FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

COPY ["MainPage/MainPage.csproj", "MainPage/"]
COPY ["MainPage.Client/MainPage.Client.csproj", "MainPage.Client/"]
COPY ["MainPageLibrary/MainPageLibrary.csproj", "MainPageLibrary/"]
RUN dotnet restore MainPage/MainPage.csproj
COPY . .
WORKDIR "/src/MainPage"
RUN dotnet build "./MainPage.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./MainPage.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
ENV ASPNETCORE_URLS=http://+:5005
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MainPage.dll"]