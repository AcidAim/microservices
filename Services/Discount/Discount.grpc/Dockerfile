FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["/Discount.grpc.csproj", "Discount.grpc/"]
RUN dotnet restore "Discount.grpc/Discount.grpc.csproj"
WORKDIR "/src/Discount.grpc"
COPY . .
RUN dotnet build "Discount.grpc.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Discount.grpc.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
EXPOSE 5003
ENV ASPNETCORE_URLS = "http://+:5003"
ENTRYPOINT ["dotnet", "Discount.grpc.dll"]
