FROM mcr.microsoft.com/dotnet/core/sdk:3.1-alpine as build
MAINTAINER gareth.luckett@gmail.com

# Opt-out of the telemetry feature 
ENV DOTNET_CLI_TELEMETRY_OPTOUT 1

# Set work directory for apps
WORKDIR /opt/app/

ADD . ./

RUN dotnet test && \
	dotnet publish -c Release

FROM mcr.microsoft.com/dotnet/core/runtime:3.1-alpine

# Opt-out of the telemetry feature 
ENV DOTNET_CLI_TELEMETRY_OPTOUT 1

# Set work directory for apps
WORKDIR /opt/app/

COPY --from=build /opt/app/RepoMage/bin/Release/netcoreapp3.0/publish /opt/app

ENTRYPOINT exec dotnet /opt/app/RepoMage.dll