using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public partial class Contacts
    {
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Company { get; set; }
        public string Message { get; set; }
        public string Address { get; set; }
    }
}
