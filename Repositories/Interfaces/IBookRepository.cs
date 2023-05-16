using OutputFilesProject.Models;

namespace OutputFilesProject.Repositories
{
    public interface IBookRepository
    {
        Task<Book> GetBook(string id);
    }
}