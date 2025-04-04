using AI_VoiceAssistant.API.Models;
using AI_VoiceAssistant.API.Services;

namespace AI_VoiceAssistant.API.Endpoints;

public static class AIEndpoints
{
    public static void Map(WebApplication app)
    {
        app.MapPost("/ask", async (AIRequest request, AIService service) => {
            var response = await service.GetAIResponse(request.Question);
            return Results.Ok(new AIResponse { Answer = response });
        });
    }
}