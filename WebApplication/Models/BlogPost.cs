using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class BlogPost
    {
        [Key]
        public int BlogID { get; set; }
        public string Title { get; set; }
        public TopicNames Topics { get; set; }
        public string Text { get; set; }
    }
}
