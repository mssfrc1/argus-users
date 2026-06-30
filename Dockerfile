FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /app

COPY Argus.Users.sln .
COPY src/Argus.Users/Argus.Users.csproj src/Argus.Users/
COPY tests/Argus.Users.Tests/Argus.Users.Tests.csproj tests/Argus.Users.Tests/
RUN dotnet restore

COPY src/ src/
COPY tests/ tests/
RUN dotnet build --no-restore -c Release

FROM build AS test
ENTRYPOINT ["dotnet", "test", "--no-build", "-c", "Release", "--logger", "console;verbosity=normal"]
