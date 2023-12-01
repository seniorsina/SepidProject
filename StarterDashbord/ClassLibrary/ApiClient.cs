using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterDashbord.ClassLibrary;
internal class ApiClient
{
    private readonly HttpClient client;
    private readonly string baseUrl;

    public ApiClient(string baseUrl)
    {
        this.baseUrl = baseUrl;
        client = new HttpClient();
    }


    public async Task<T> GetAsync<T>(string endpoint)
    {
        var response = await client.GetAsync(baseUrl + endpoint);
        response.EnsureSuccessStatusCode();

        var json = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<T>(json);
    }
    public async Task<HttpResponseMessage> PostAsync<T>(string endpoint, T data)
    {
        var json = JsonConvert.SerializeObject(data);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await client.PostAsync(baseUrl + endpoint, content);
        response.EnsureSuccessStatusCode();

        return response;
    }

    public async Task<HttpResponseMessage> PutAsync<T>(string endpoint, T data)
    {
        var json = JsonConvert.SerializeObject(data);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await client.PutAsync(baseUrl + endpoint, content);
        response.EnsureSuccessStatusCode();

        return response;
    }

    public async Task<HttpResponseMessage> DeleteAsync(string endpoint)
    {
        var response = await client.DeleteAsync(baseUrl + endpoint);
        response.EnsureSuccessStatusCode();

        return response;
    }
}
