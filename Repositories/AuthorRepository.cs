using Newtonsoft.Json;
using OutputFilesProject.Models;

namespace OutputFilesProject.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly IConfiguration _config;
        public AuthorRepository(IConfiguration config)
        {
            _config = config;
        }
        public async Task<string> GetAuthors(List<AuthorBook> authors)
        {
            string authorNames = "";
            foreach(var author in authors)
            {
                using var httpClient = new HttpClient();
                
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
            
                    RequestUri = new Uri($"https://openlibrary.org{author.key}.json"),
                };
                
                using var response = await httpClient.SendAsync(request);
                
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Author authorDeserialized = JsonConvert.DeserializeObject<Author>(content);
                    authorNames += authorDeserialized.name + ",";
                }
                else
                {
                    throw new Exception($"Request Authors failed with status code {response.StatusCode}");
                }
            }
            return authorNames.Remove(authorNames.Length - 1, 1);
        }
    }
}