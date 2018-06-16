FROM microsoft/aspnetcore:2.0-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0-nanoserver-1709 AS build
WORKDIR /src
COPY FacundoMasgrau/FacundoMasgrau.csproj FacundoMasgrau/
RUN dotnet restore FacundoMasgrau/FacundoMasgrau.csproj
COPY . .
WORKDIR /src/FacundoMasgrau
RUN dotnet build FacundoMasgrau.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish FacundoMasgrau.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "FacundoMasgrau.dll"]
