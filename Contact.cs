using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList
{
    internal class Contact
    {
        public string Name {  get; set; }
        public string Phone{  get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Contact(string name, string phone, string email, string address) 
        { 
            this.Name = name;
            this.Phone = phone; 
            this.Email = email;
            this.Address = address;
        }
    }
}
