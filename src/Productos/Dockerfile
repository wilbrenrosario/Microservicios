FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

COPY ["Productos.csproj", "Productos/"]
RUN dotnet restore "Productos/Productos.csproj"

COPY . ./Productos
WORKDIR "/src/Productos"
RUN dotnet build "Productos.csproj" -c Release -o /app/publish

FROM build AS publish
RUN dotnet publish "Productos.csproj" -c Release -o /app/publish

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app
EXPOSE 8080
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Productos.dll"]