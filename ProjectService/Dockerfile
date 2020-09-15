FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-stretch-slim AS base
WORKDIR /app
EXPOSE 80
FROM mcr.microsoft.com/dotnet/core/sdk:2.1-stretch AS build
WORKDIR /src
COPY ["ProjectService.csproj", "ProjectService/"]
RUN dotnet restore "ProjectService/ProjectService.csproj"
WORKDIR "/src/ProjectService"
COPY . .
RUN dotnet build "ProjectService.csproj" -c Release -o /app/build
FROM build AS publish
RUN dotnet publish "ProjectService.csproj" -c Release -o /app/publish
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProjectService.dll"]
