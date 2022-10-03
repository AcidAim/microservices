FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["/Catalog.api.csproj", "Catalog.api/"]
RUN dotnet restore "Catalog.api/Catalog.api.csproj"

WORKDIR "/src/Catalog.api"
COPY . .
RUN dotnet build "Catalog.api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Catalog.api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
EXPOSE 5000
ENV ASPNETCORE_URLS="http://+:5000"
ENTRYPOINT ["dotnet", "Catalog.api.dll"]
