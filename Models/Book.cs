namespace OutputFilesProject.Models
{
    public class AuthorBook
    {
        public string key { get; set; }
    }

    public class Created
    {
        public string type { get; set; }
        public DateTime value { get; set; }
    }

    public class Identifiers
    {
        public List<string> librarything { get; set; }
        public List<string> wikidata { get; set; }
        public List<string> goodreads { get; set; }
    }

    public class Language
    {
        public string key { get; set; }
    }

    public class LastModified
    {
        public string type { get; set; }
        public DateTime value { get; set; }
    }

    public class Notes
    {
        public string type { get; set; }
        public string value { get; set; }
    }

    public class Book
    {
        public List<string> publishers { get; set; }
        public int number_of_pages { get; set; }
        public string subtitle { get; set; }
        public List<string> isbn_10 { get; set; }
        public List<int> covers { get; set; }
        public List<string> lc_classifications { get; set; }
        public int latest_revision { get; set; }
        public string key { get; set; }
        public List<AuthorBook> authors { get; set; }
        public string ocaid { get; set; }
        public List<string> publish_places { get; set; }
        public List<string> contributions { get; set; }
        public List<string> subjects { get; set; }
        public List<Language> languages { get; set; }
        public string pagination { get; set; }
        public List<string> source_records { get; set; }
        public string title { get; set; }
        public List<string> dewey_decimal_class { get; set; }
        public Notes notes { get; set; }
        public Identifiers identifiers { get; set; }
        public Created created { get; set; }
        public string edition_name { get; set; }
        public List<string> lccn { get; set; }
        public List<string> local_id { get; set; }
        public string publish_date { get; set; }
        public string publish_country { get; set; }
        public LastModified last_modified { get; set; }
        public string by_statement { get; set; }
        public List<Work> works { get; set; }
        public Type type { get; set; }
        public int revision { get; set; }
    }

    public class Type
    {
        public string key { get; set; }
    }

    public class Work
    {
        public string key { get; set; }
    }
}