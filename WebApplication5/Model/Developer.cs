using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Model
{
    public class Developer
    {
        public int DeveloperId { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Skills { get; set; }
        public bool Gender { get; set; }
        public int Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public virtual string Department {get; set;}        
    }
}
