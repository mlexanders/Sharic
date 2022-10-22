using System.Net.Http;

namespace SharicApi.Middlewares
{
    public class AvailablePath
    {
        public string Path { get; set; }
        public HttpMethod Method { get; set; }

        public AvailablePath(string path, HttpMethod method)
        {
            Path = path;
            Method = method;
        }
    }
}