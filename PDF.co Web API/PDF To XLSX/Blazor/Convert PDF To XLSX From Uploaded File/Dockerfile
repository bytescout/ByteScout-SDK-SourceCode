#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Convert PDF To XLSX From Uploaded File.csproj", "."]
RUN dotnet restore "./Convert PDF To XLSX From Uploaded File.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Convert PDF To XLSX From Uploaded File.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Convert PDF To XLSX From Uploaded File.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Convert PDF To XLSX From Uploaded File.dll"]