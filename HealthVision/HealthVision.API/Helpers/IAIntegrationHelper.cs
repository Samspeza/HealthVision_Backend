using System.IO;
using System.Threading.Tasks;

public static class IAIntegrationHelper
{
    public static async Task<string> EnviarImagemAsync(string imagePath)
    {
        using var client = new HttpClient();
        using var form = new MultipartFormDataContent();
        using var stream = File.OpenRead(imagePath);
        form.Add(new StreamContent(stream), "file", Path.GetFileName(imagePath));
        var response = await client.PostAsync("http://localhost:8000/analisar-imagem", form);
        var json = await response.Content.ReadAsStringAsync();
        var data = JsonDocument.Parse(json);
        return data.RootElement.GetProperty("resultado").GetString();
    }
}
