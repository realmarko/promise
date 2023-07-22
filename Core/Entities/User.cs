using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Passwrod { get; set; }
        public string FirstName{get;set;}
        public string LastName { get; set; }
        
    }
}