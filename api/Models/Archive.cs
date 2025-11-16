using Microsoft.AspNetCore.Http;

namespace api.Models
{
    public class Archive
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FilePath {  get;  set;}   
        public string Description { get; set; }
    }
}