using OutputFilesProject.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OutputFilesProject.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly IConfiguration _config;
        public BookRepository(IConfiguration config)
        {
            _config = config;
        }
        public async Task<Book> GetBook(string id)
        {
            Book bookDeserialized = new Book();
            using var httpClient = new HttpClient();
            
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
        
                RequestUri = new Uri($"https://openlibrary.org/isbn/{id}.json"),
            };
            
            using var response = await httpClient.SendAsync(request);
            
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                bookDeserialized = JsonConvert.DeserializeObject<Book>(content);
            }
            else
            {
                return null;
            }
            return bookDeserialized;
        }
    }
}