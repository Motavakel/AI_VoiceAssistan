using System;
using System.Text.Json;
using System.Text;
using System.Threading.Tasks;

namespace AI_VoiceAssistant.API.Services;


//ارسال متن به سرور 

class AIService
{
    private readonly HttpClient _httpClient;

    public AIService()
    {
        _httpClient = new HttpClient();
        _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {Environment.GetEnvironmentVariable("DEEPSEEK_API_KEY")}");
    }

    public async Task<string> GetAIResponse(string inputText)
    {
        var request = new { question = inputText };
        var json = JsonSerializer.Serialize(request);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync("https://api.deepseek.com/ask", content);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync();
    }
}
