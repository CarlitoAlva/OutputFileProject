namespace OutputFilesProject.Services
{
    public class FileService : IFileService
    {
        private const string filePath = "ISBN_Input_File.txt";

        public async Task<string> GetFileData()
        {
            string content = "";
            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, true))
            using (var reader = new StreamReader(stream))
            {
                while (!reader.EndOfStream)
                {
                    content += await reader.ReadLineAsync() + ",";
                }
            }
            return content.Remove(content.Length - 1, 1);
        }
    }
}