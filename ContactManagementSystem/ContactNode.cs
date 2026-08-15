using System;
using System.Collections.Generic;
using System.Text;

namespace Contact_Management_System
{
    internal class Contactnode
    {
        public Contact Data { get; set; } = new Contact();
        public Contactnode? Next { get; set; } 
    }
}
