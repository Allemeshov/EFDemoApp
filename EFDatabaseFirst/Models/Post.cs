using System;
using System.Collections.Generic;

#nullable disable

namespace EFDatabaseFirst.Models
{
    public partial class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Wieght { get; set; }
    }
}
