using OutputFilesProject.Models;

namespace OutputFilesProject.Repositories
{
    public interface IAuthorRepository
    {
        Task<string> GetAuthors(List<AuthorBook> authors);
    }
}