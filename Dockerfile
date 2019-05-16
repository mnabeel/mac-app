FROM microsoft/dotnet:2.2-sdk as build
WORKDIR /app

# Copy csproj and restore as distinct layer
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM microsoft/dotnet:2.2-aspnetcore-runtime as runtime
WORKDIR /app

COPY --from=build /app/out .

ENTRYPOINT ["dotnet", "mac-app.dll"]

