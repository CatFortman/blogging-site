using BloggingSite.Models;
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
        [DataType(DataType.Text)]
        public string Title { get; set; }
        public virtual List<Topic> Topics { get; set; }
        [DataType(DataType.Text)]
        public string Text { get; set; }
    }
}
