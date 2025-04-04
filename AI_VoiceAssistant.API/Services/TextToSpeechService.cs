using System.Speech.Synthesis;

namespace AI_VoiceAssistant.API.Services;

// تبدیل متن به صوت
class TextToSpeechService
{
    public async Task SpeakTextAsync(string text)
    {
        using var synth = new SpeechSynthesizer();
        await Task.Run(() => synth.Speak(text));
    }
}


