using AI_VoiceAssistant.API.Services;

namespace AI_VoiceAssistant.API.Endpoints;

public static class SpeechEndpoints
{
    public static void Map(WebApplication app)
    {
        app.MapPost("/speech-to-text",  (SpeechService service) =>
        service.SpeechToText(""));
    }
}
