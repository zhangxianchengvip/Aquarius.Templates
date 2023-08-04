#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["NuGet.Config", "."]
COPY ["src/EShopOnAbp.HttpApi.Host/EShopOnAbp.HttpApi.Host.csproj", "src/EShopOnAbp.HttpApi.Host/"]
COPY ["src/EShopOnAbp.Application/EShopOnAbp.Application.csproj", "src/EShopOnAbp.Application/"]
COPY ["src/EShopOnAbp.Domain/EShopOnAbp.Domain.csproj", "src/EShopOnAbp.Domain/"]
COPY ["src/EShopOnAbp.Domain.Shared/EShopOnAbp.Domain.Shared.csproj", "src/EShopOnAbp.Domain.Shared/"]
COPY ["src/EShopOnAbp.Application.Contracts/EShopOnAbp.Application.Contracts.csproj", "src/EShopOnAbp.Application.Contracts/"]
COPY ["src/EShopOnAbp.EntityFrameworkCore/EShopOnAbp.EntityFrameworkCore.csproj", "src/EShopOnAbp.EntityFrameworkCore/"]
COPY ["src/EShopOnAbp.HttpApi/EShopOnAbp.HttpApi.csproj", "src/EShopOnAbp.HttpApi/"]
RUN dotnet restore "src/EShopOnAbp.HttpApi.Host/EShopOnAbp.HttpApi.Host.csproj"
COPY . .
WORKDIR "/src/src/EShopOnAbp.HttpApi.Host"
RUN dotnet build "EShopOnAbp.HttpApi.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EShopOnAbp.HttpApi.Host.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EShopOnAbp.HttpApi.Host.dll"]