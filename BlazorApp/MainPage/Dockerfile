FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

COPY MainPage.csproj .
RUN dotnet restore
COPY . .
RUN dotnet publish -c $BUILD_CONFIGURATION -o /app/publish

FROM nginx:1.24.0-alpine
WORKDIR /app
EXPOSE ${BLAZOR_PORT}
COPY nginx.conf /etc/nginx/nginx.conf
COPY --from=build /app/publish/wwwroot /usr/share/nginx/html


# FROM node:alpine AS nodetailwind
# WORKDIR /src
# COPY . .
# WORKDIR /src/MainPage
# RUN npm run tailwind

# FROM restore AS build
# ARG BUILD_CONFIGURATION=Release
# WORKDIR /src
# COPY --from=nodetailwind /src .
# COPY . .
# WORKDIR /src
# RUN dotnet build -c $BUILD_CONFIGURATION -o /app/build

# FROM build AS publish
# ARG BUILD_CONFIGURATION=Release
# RUN dotnet publish -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
# WORKDIR /app
# EXPOSE 8080
# EXPOSE 8081
# COPY --from=publish /app/publish .
# ENTRYPOINT [ "dotnet", "MainPage.dll" ]