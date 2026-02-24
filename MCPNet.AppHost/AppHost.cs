var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.Api>("apiservice");
//.WithHealthCheck("/health");

var mcp = builder.AddProject<Projects.MCPServer>("mcpserver")
    .WithReference(apiService);
    //.WithHealthCheck("/health");

builder.AddMcpInspector("mcp-inspector").WithMcpServer(mcp, path: "");

builder.Build().Run();
