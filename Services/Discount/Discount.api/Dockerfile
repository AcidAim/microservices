FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["/Discount.api.csproj", "Discount.api/"]
RUN dotnet restore "Discount.api/Discount.api.csproj"
WORKDIR "/src/Discount.api"
COPY . .
RUN dotnet build "Discount.api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Discount.api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
EXPOSE 5002
ENV ASPNETCORE_URLS="http://+:5002"
ENTRYPOINT ["dotnet", "Discount.api.dll"]
