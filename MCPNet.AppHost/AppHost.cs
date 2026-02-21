var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Api>("api");

builder.AddProject<Projects.MCPServer>("mcpserver");

builder.Build().Run();
