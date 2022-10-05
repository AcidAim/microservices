FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Services/Basket/Basket.api/Basket.api.csproj", "Services/Basket/Basket.api/"]
RUN dotnet restore "Services/Basket/Basket.api/Basket.api.csproj"
COPY . .
WORKDIR "/src/Services/Basket/Basket.api"
RUN dotnet build "Basket.api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Basket.api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
EXPOSE 5001
ENV ASPNETCORE_URLS="http://+:5001"
ENTRYPOINT ["dotnet", "Basket.api.dll"]
