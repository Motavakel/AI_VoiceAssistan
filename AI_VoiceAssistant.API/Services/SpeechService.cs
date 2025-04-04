using System;
using Python.Runtime;

namespace AI_VoiceAssistant.API.Services;

public class SpeechService
{
    public string SpeechToText(string audioFilePath)
    {
        using (Py.GIL()) 
        {
            dynamic whisper = Py.Import("whisper");
            dynamic model = whisper.load_model("base");
            dynamic result = model.transcribe(audioFilePath, language: "fa");
            string text = result["text"];
            return text;
        }
    }
}
