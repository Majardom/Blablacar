#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Blablacar/Blablacar.csproj", "Blablacar/"]
COPY ["Blablacar.Domain.Core/Blablacar.Domain.Core.csproj", "Blablacar.Domain.Core/"]
COPY ["Blablacar.Infrastructure.Business/Blablacar.Infrastructure.Business.csproj", "Blablacar.Infrastructure.Business/"]
COPY ["Blablacar.Domain.Interfaces/Blablacar.Domain.Interfaces.csproj", "Blablacar.Domain.Interfaces/"]
COPY ["Blablacar.Infrastructure.Data/Blablacar.Infrastructure.Data.csproj", "Blablacar.Infrastructure.Data/"]
COPY ["Blablacar.Services.Interfaces/Blablacar.Services.Interfaces.csproj", "Blablacar.Services.Interfaces/"]
RUN dotnet restore "Blablacar/Blablacar.csproj"
COPY . .
WORKDIR "/src/Blablacar"
RUN dotnet build "Blablacar.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Blablacar.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Blablacar.dll"]
