using OutputFilesProject.Models;

namespace OutputFilesProject.Services
{
    public interface IFileService
    {
        Task<string> GetFileData();
    }
}