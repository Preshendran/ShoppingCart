#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ShoppingCart.csproj", "."]
RUN dotnet restore "./ShoppingCart.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "ShoppingCart.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ShoppingCart.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final

RUN addgroup -g 10000 addgroup && \
	adduser -d -u 10000 addgroup -s /sbin/nologin -g addgroup

RUN chown -R addgroup:addgroup /app

USER appuser:appgroup

WORKDIR /app
COPY --chown=appuser:appgroup --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ShoppingCart.dll"]