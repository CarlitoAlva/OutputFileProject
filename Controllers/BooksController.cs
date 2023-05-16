using System.Text;
using Microsoft.AspNetCore.Mvc;
using OutputFilesProject.Services;

namespace OutputFilesProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;
        private readonly ILogger<BooksController> _logger;

        public BooksController(ILogger<BooksController> logger, IBookService bookService)
        {
            _logger = logger;
            _bookService = bookService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            string csvData = await _bookService.GetBooks();

            byte[] byteArray = Encoding.UTF8.GetBytes(csvData);

            return File(byteArray, "text/csv", "data.csv");
        }
    }

}

