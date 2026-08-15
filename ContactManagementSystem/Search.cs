using System;
using System.Collections.Generic;
using System.Text;

namespace Contact_Management_System
{
    internal class Search
    {
        public static Contact? LinearSearchByPhoneNumber(ContactList contactList, string phoneNumber)
        {
            Contactnode? current = contactList.GetHead();

            while (current != null)
            {
                if (current.Data.PhoneNumber == phoneNumber)
                {
                    return current.Data;
                }

                current = current.Next;
            }

            return null;
        }
        public static List<Contact> LinearSearchByName(ContactList contactList, string name)
        {
            List<Contact> results = new List<Contact>();
            Contactnode? current = contactList.GetHead();

            while (current != null)
            {
                if (current.Data.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    results.Add(current.Data);
                }

                current = current.Next;
            }

            return results;
        }
        public static void SearchAndDisplayByPhoneNumber(ContactList contactList, string phoneNumber)
        {
            Contact? found = LinearSearchByPhoneNumber(contactList, phoneNumber);

            if (found == null)
            {
                Console.WriteLine("No contact found with phone number: " + phoneNumber);
                return;
            }

            Console.WriteLine("Name: " + found.Name);
            Console.WriteLine("Phone: " + found.PhoneNumber);
            Console.WriteLine("Email: " + found.Email);
        }

        public static void SearchAndDisplayByName(ContactList contactList, string name)
        {
            List<Contact> results = LinearSearchByName(contactList, name);

            if (results.Count == 0)
            {
                Console.WriteLine("No contact found with name: " + name);
                return;
            }

            foreach (Contact contact in results)
            {
                Console.WriteLine("Name: " + contact.Name);
                Console.WriteLine("Phone: " + contact.PhoneNumber);
                Console.WriteLine("Email: " + contact.Email);
                Console.WriteLine();
            }
        }
    }
}