using SharicApi.Controllers;
using SharicApi.Models;
using SharicApi.Repository;
using SharicCommon.Data.Models;

namespace SharicApi.Middlewares
{
    public class CheckPermisionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly BaseCrudRepository<Driver> driversRepository;
        private readonly List<AvailablePath> availablePaths;

        public CheckPermisionMiddleware(RequestDelegate next, BaseCrudRepository<Driver> driversRepository, List<AvailablePath> availablePaths)
        {
            _next = next;
            this.driversRepository = driversRepository;
            this.availablePaths = availablePaths;
        }

        public async Task Invoke(HttpContext context)
        {
            if (CheckPathAllow(context.Request.Path.Value, context.Request.Method)) await _next(context);
            else
            {
                var token = context.Request.Cookies["token"];
                if (token != null && (await TokenIsValid(token))) await _next(context);
                else context.Response.StatusCode = 401;
            }
        }

        private async Task<bool> TokenIsValid(string token)
        {
            var user = await driversRepository.ReadFirst(u => u.Token == token);
            return user != null;
        }

        private bool CheckPathAllow(string path, string method)
        {
            foreach (var availablePath in availablePaths)
            {
                if (availablePath.Path.Contains("..."))
                {
                    if (path.Contains(availablePath.Path[..^3]) && method == availablePath.Method.ToString().ToUpper()) return true;
                }
                else if (path.Contains(availablePath.Path) && method == availablePath.Method.ToString().ToUpper()) return true;
            }

            return false;
        }
    }
}