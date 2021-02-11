using System;
using System.Collections.Generic;

#nullable disable

namespace EFDatabaseFirst.Models
{
    public partial class Client
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
    }
}
