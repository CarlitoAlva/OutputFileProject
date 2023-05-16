namespace OutputFilesProject.Models
{
    public class Bio
    {
        public string type { get; set; }
        public string value { get; set; }
    }

    public class AuthorCreated
    {
        public string type { get; set; }
        public DateTime value { get; set; }
    }

    public class AuthorLastModified
    {
        public string type { get; set; }
        public DateTime value { get; set; }
    }

    public class RemoteIds
    {
        public string viaf { get; set; }
        public string wikidata { get; set; }
        public string isni { get; set; }
    }

    public class Author
    {
        public List<string> alternate_names { get; set; }
        public List<string> source_records { get; set; }
        public string key { get; set; }
        public string death_date { get; set; }
        public string personal_name { get; set; }
        public string birth_date { get; set; }
        public Bio bio { get; set; }
        public string name { get; set; }
        public RemoteIds remote_ids { get; set; }
        public TypeAuthor type { get; set; }
        public int latest_revision { get; set; }
        public int revision { get; set; }
        public AuthorCreated created { get; set; }
        public AuthorLastModified last_modified { get; set; }
    }

    public class TypeAuthor
    {
        public string key { get; set; }
    }
}