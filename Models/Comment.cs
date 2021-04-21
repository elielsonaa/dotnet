using System;
using System.ComponentModel.DataAnnotations;

namespace BlogApi.Models
{
    public class Comment
    {
       [Key]        
       public long CommentId { get; set; }
        public long PostId { get; set; }
        public DateTime Date { get; set;}
        public string UserAvatar {get; set;}
        public string UserName {get; set;}
        public string Content { get; set; }
        
    }
}