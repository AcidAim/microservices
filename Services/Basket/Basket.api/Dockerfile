FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Services/Basket/Basket.api/Basket.api.csproj", "Basket.api/"]
RUN dotnet restore "Basket.api/Basket.api.csproj"
WORKDIR "/src/Basket.api"
COPY . .

RUN dotnet build "Basket.api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Basket.api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Basket.api.dll"]
