using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFLogin.Models.Entities
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        
    }
}