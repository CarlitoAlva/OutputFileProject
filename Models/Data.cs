using System.ComponentModel.DataAnnotations;

namespace OutputFilesProject.Models
{
    public class Data
    {
        public int RowNumber { get; set; }
        public string? DataRetrievalType { get; set; }
        public string? Isbn { get; set; }
        public string? Title { get; set; } 
        public string? Subtitle { get; set; }
        public string? Authors { get; set; }
        public int NumberOfPages { get; set; }
        public string? PublishDate { get; set; }
    }
}