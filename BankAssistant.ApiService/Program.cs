using BankAssistant.ApiService;

var builder = WebApplication.CreateBuilder(args);

// Add service defaults & Aspire components.
builder.AddServiceDefaults();

// Add services to the container.
builder.Services.AddProblemDetails();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseExceptionHandler();

app.MapPost("/chat", (ChatRequest request) => new BankChat().Chat(request));
app.MapGet("/chat", () => new ChatResponse("Hello!"));

app.MapDefaultEndpoints();

app.Run();

