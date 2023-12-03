namespace BankAssistant.Web;

public class ChatApiClient(HttpClient httpClient, ILogger<ChatApiClient> chatApiClient)
{
    
    public async Task<ChatResponse?> GetChatResponse(string chat)
    {
        chatApiClient.LogInformation("Calling backend");
        var response = await httpClient.PostAsJsonAsync("/chat", new ChatRequest(new[] { chat }));
        chatApiClient.LogInformation("Backend response code {Code}", response.StatusCode);
        return await response.Content.ReadFromJsonAsync<ChatResponse>();
    }
}

public record ChatRequest(string[] Chat);
public record ChatResponse(string Response);

