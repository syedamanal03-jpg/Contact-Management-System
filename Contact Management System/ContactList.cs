using System;
using System.Collections.Generic;
using System.Text;

namespace Contact_Management_System
{
    internal class ContactList
    {
        private Contactnode? Head;


        public void AddContact(Contact contact)
        {
            Contactnode newNode = new Contactnode();
            newNode.Data = contact;

            if (Head == null)
            {
                Head = newNode;
                return;
            }

            Contactnode current = Head;

            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;
        }

        public void DisplayContacts()
        {
            if (Head == null)
            {
                Console.WriteLine("No contacts found.");
                return;
            }

            Contactnode? current = Head;

            while (current != null)
            {
                Console.WriteLine("Name: " + current.Data.Name);
                Console.WriteLine("Phone: " + current.Data.PhoneNumber);
                Console.WriteLine("Email: " + current.Data.Email);
                Console.WriteLine();

                current = current.Next;
            }
        }

        public bool DeleteContact(string phoneNumber)
        {
            if (Head == null)
            {
                return false;
            }

            if (Head.Data.PhoneNumber == phoneNumber)
            {
                Head = Head.Next;
                return true;
            }

            Contactnode? current = Head;

            while (current.Next != null)
            {
                if (current.Next.Data.PhoneNumber == phoneNumber)
                {
                    current.Next = current.Next.Next;
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        public bool UpdateContact(string oldPhoneNumber, string newName, string newPhoneNumber, string newEmail)
        {
            if (Head == null)
            {
                return false;
            }

            Contactnode? current = Head;

            while (current != null)
            {
                if (current.Data.PhoneNumber == oldPhoneNumber)
                {
                    current.Data.Name = newName;
                    current.Data.PhoneNumber = newPhoneNumber;
                    current.Data.Email = newEmail;

                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        public bool IsEmpty()
        {
            return Head == null;
        }
    }


}