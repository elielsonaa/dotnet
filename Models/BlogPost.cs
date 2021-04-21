using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogApi.Models
{
    public class BlogPost
    {   
        [Key]
        public long PostId { get; set; }
        public string Title { get; set; }
        public string Content {get;set;}
        public string Author {get;set;}
        public DateTime Date { get; set; }
        public ICollection<Comment> Commments {get; set;}
    }
}