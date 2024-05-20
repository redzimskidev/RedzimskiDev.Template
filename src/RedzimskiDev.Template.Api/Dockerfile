FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/RedzimskiDev.Template.Api/RedzimskiDev.Template.Api.csproj", "src/RedzimskiDev.Template.Api/"]
RUN dotnet restore "src/RedzimskiDev.Template.Api/RedzimskiDev.Template.Api.csproj"
COPY . .
WORKDIR "/src/src/RedzimskiDev.Template.Api"
RUN dotnet build "RedzimskiDev.Template.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "RedzimskiDev.Template.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RedzimskiDev.Template.Api.dll"]
