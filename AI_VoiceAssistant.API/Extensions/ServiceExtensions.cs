using AI_VoiceAssistant.API.Endpoints;
using AI_VoiceAssistant.API.Services;

namespace AI_VoiceAssistant.API.Extensions;

public static class ServiceExtensions
{
    public static void AddApplicationServices(this IServiceCollection services)
    {
        services.AddSingleton<SpeechService>();
        services.AddSingleton<AIService>();
        services.AddSingleton<TextToSpeechService>();
    }

    public static void UseEndpoints(this WebApplication app)
    {
        SpeechEndpoints.Map(app);
        AIEndpoints.Map(app);
    }
}
