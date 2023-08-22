#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["NuGet.Config", "."]
COPY ["src/Aquarius.HttpApi.Host/Aquarius.HttpApi.Host.csproj", "src/Aquarius.HttpApi.Host/"]
COPY ["src/Aquarius.Application/Aquarius.Application.csproj", "src/Aquarius.Application/"]
COPY ["src/Aquarius.Domain/Aquarius.Domain.csproj", "src/Aquarius.Domain/"]
COPY ["src/Aquarius.Domain.Shared/Aquarius.Domain.Shared.csproj", "src/Aquarius.Domain.Shared/"]
COPY ["src/Aquarius.Application.Contracts/Aquarius.Application.Contracts.csproj", "src/Aquarius.Application.Contracts/"]
COPY ["src/Aquarius.EntityFrameworkCore/Aquarius.EntityFrameworkCore.csproj", "src/Aquarius.EntityFrameworkCore/"]
COPY ["src/Aquarius.HttpApi/Aquarius.HttpApi.csproj", "src/Aquarius.HttpApi/"]
RUN dotnet restore "src/Aquarius.HttpApi.Host/Aquarius.HttpApi.Host.csproj"
COPY . .
WORKDIR "/src/src/Aquarius.HttpApi.Host"
RUN dotnet build "Aquarius.HttpApi.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Aquarius.HttpApi.Host.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Aquarius.HttpApi.Host.dll"]