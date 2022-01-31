# Podman .NET 6 Proof of Concept

This is a proof of concept of a .NET 6 Web API created with the `dotnet new webapi` command running in a podman container.

## Installations

- [Podman](https://podman.io/getting-started/installation)
- [.NET 6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)

## Docs

- [Getting Started With Podman](https://podman.io/getting-started/)
- [Podman Documentation](https://docs.podman.io/en/latest/)
- [.NET 6 Documentation](https://docs.microsoft.com/en-us/dotnet/fundamentals/)

## Run

1. <b>Start the Podman managed VM (Fedora CoreOS) with the following commands:</b>

`podman machine init`
`podman machine start`

2. <b>Run the following command to build an image of this app:</b>

`podman build -t podman-dotnet-poc .`

Verify it was created successfully with the following command:

`podman images`

3. <b>Run the following command to create, but not start, a container with the image from the previous step:</b>

`podman create -p 8080:80 localhost/podman-dotnet-poc:latest`

Verify it was created successfully with the following command:

`podman ps --all`

4. <b>Start the container with the following command:</b>

`podman start [container ID from previous command]`

Verify the container is running with the following command:

`podman ps`

Note: You can combine steps 3 and 4 into one command:

`podman run -d -p 8080:80 localhost/podman-dotnet-poc:latest`

5. <b>Hit http://localhost:8080/</b>

#### Without Podman

1. Run `dotnet run` in this folder
2. Make an HTTP Get request to `https://localhost:[port in output]/time`