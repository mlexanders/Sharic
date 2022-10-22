#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["SharicApi/SharicApi.csproj", "SharicApi/"]
RUN dotnet restore "SharicApi/SharicApi.csproj"
COPY . .
WORKDIR "/src/SharicApi"
RUN dotnet build "SharicApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SharicApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SharicApi.dll"]