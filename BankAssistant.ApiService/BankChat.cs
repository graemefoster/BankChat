using Microsoft.AspNetCore.Mvc;

namespace BankAssistant.ApiService;

public class BankChat
{
    public ChatResponse Chat(ChatRequest chatRequest)
    {
        var chat = string.Join(Environment.NewLine, chatRequest.Chat);
        return new ChatResponse(chat);
    }
}

public record ChatResponse(string Response);

public record ChatRequest(string[] Chat);