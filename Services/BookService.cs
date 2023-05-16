using System.Collections;
using OutputFilesProject.Models;
using OutputFilesProject.Repositories;

namespace OutputFilesProject.Services
{
    public class BookService : IBookService
    {
        private const string filePath = "ISBN_Input_File.txt";
        private readonly IBookRepository _bookRepository;
        private readonly IFileService _fileService;
        private readonly IAuthorRepository _authorRepository;
        public BookService(
            IBookRepository bookRepository, 
            IAuthorRepository authorRepository, 
            IFileService fileService)
        {
            _bookRepository = bookRepository;
            _authorRepository = authorRepository;
            _fileService = fileService;
        }
        public async Task<string> GetBooks()
        {
            int rowNumber = 1;
            string dataFile = await _fileService.GetFileData();
            string[] books = dataFile.Split(',');
            List<Data> listBooks = new List<Data>();

            foreach(string bookId in books)
            {
                 var book = await _bookRepository.GetBook(bookId);
                 var authors = await _authorRepository.GetAuthors(book.authors);
                 Data data = new Data()
                 {
                    RowNumber = rowNumber,
                    DataRetrievalType = book == null ? DataRetrievalType.Cache.ToString() : DataRetrievalType.Server.ToString(),
                    Isbn = bookId,
                    Title = book.title == null ? "Whitout Title" : book.title,
                    Subtitle = book.subtitle == null ? "Whitout Subtitle" : book.subtitle,
                    Authors = book.authors == null ? "Without author" : authors,
                    NumberOfPages = book.number_of_pages == null ? 0 : book.number_of_pages,
                    PublishDate = book.publish_date == null ? "Whitout publish date" : book.publish_date,
                 };
                 listBooks.Add(data);
                 rowNumber++;
            }
            string csv = Utilities.File.ConvertToCsv(listBooks);
            return csv;
        }
    }
}