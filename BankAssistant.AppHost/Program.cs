var builder = DistributedApplication.CreateBuilder(args);

var apiservice = builder.AddProject<Projects.BankAssistant_ApiService>("apiservice");

builder.AddProject<Projects.BankAssistant_Web>("webfrontend")
    .WithReference(apiservice);

builder.Build().Run();
