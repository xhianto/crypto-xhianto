FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Cryptografie/Cryptografie.csproj", "Cryptografie/"]
RUN dotnet restore "Cryptografie/Cryptografie.csproj"
COPY . .
WORKDIR "/src/Cryptografie"
RUN dotnet build "Cryptografie.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Cryptografie.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cryptografie.dll"]