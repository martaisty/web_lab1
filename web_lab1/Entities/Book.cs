using System.Collections.Generic;

namespace web_lab1.Entities
{
    public class Book
    { 
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<Sage> Sages { get; set; }
    }
}