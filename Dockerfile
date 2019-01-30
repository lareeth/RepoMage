FROM microsoft/dotnet:2.2-sdk-alpine as build
MAINTAINER gareth.luckett@gmail.com

# Opt-out of the telemetry feature 
ENV DOTNET_CLI_TELEMETRY_OPTOUT 1

# Set work directory for apps
WORKDIR /opt/app/

ADD RepoMage ./

RUN dotnet publish -c Release

FROM microsoft/dotnet:2.2-runtime-alpine

# Opt-out of the telemetry feature 
ENV DOTNET_CLI_TELEMETRY_OPTOUT 1

# Set work directory for apps
WORKDIR /opt/app/

COPY --from=build /opt/app/bin/Release/netcoreapp2.2/publish /opt/app

ENTRYPOINT exec dotnet /opt/app/RepoMage.dll