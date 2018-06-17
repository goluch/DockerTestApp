# DockerTestApp
#mono version
#build:
docker build -t my-mono-app -f Dockerfile.mono .
#run:
docker run my-mono-app

#microsoft/dotnet version:
#build:
docker build -t my-dotnet-app -f Dockerfile.dotnet .
#run:
docker run my-dotnet-app
