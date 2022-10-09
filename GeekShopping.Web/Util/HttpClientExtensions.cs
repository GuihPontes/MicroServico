using System.Net.Http.Headers;
using System.Text.Json;

namespace GeekShopping.Web.Util
{
    public static class HttpClientExtensions
    {
        private static MediaTypeHeaderValue contentType = new MediaTypeHeaderValue("application/jason");
        public static async Task<T> ReadContentAs<T>(this HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode) throw new ApplicationException($"Algo aconteceu de errado na comunicação : {response.ReasonPhrase}");

            
                var dataAsString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return JsonSerializer.Deserialize<T>(dataAsString,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
        }

        public static Task<HttpResponseMessage> PostAsJason<T>(this HttpClient response, string url, T data)
        {
            var dataAsString = JsonSerializer.Serialize(data);
            var content = new StringContent(dataAsString);
            content.Headers.ContentType = contentType;
            return response.PostAsync(url, content);
        } 
        public static Task<HttpResponseMessage> PutAsJason<T>(this HttpClient response, string url, T data)
        {
            var dataAsString = JsonSerializer.Serialize(data);
            var content = new StringContent(dataAsString);
            content.Headers.ContentType = contentType;
            return response.PutAsync(url, content);
        }
        

    }
}
