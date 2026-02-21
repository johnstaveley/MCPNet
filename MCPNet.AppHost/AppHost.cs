var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.Api>("apiservice");
//.WithHealthCheck("/health");

builder.AddProject<Projects.MCPServer>("mcpserver")
    .WithReference(apiService);
    //.WithHealthCheck("/health");

builder.Build().Run();
