FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

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
ENTRYPOINT ["dotnet", "Discount.grpc.dll"]
