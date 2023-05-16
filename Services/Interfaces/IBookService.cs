using OutputFilesProject.Models;

namespace OutputFilesProject.Services
{
    public interface IBookService
    {
        Task<string> GetBooks();
    }
}