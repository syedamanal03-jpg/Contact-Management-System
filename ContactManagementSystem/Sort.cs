using System;
using System.Collections.Generic;
using System.Text;

namespace Contact_Management_System
{
    internal class Sort
    {
        public static void BubbleSortByName(ContactList contactList)
        {
            if (contactList.IsEmpty())
            {
                return;
            }

            bool swapped;

            do
            {
                swapped = false;
                Contactnode? current = contactList.GetHead();

                while (current != null && current.Next != null)
                {
                    if (string.Compare(current.Data.Name, current.Next.Data.Name, StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        Contact temp = current.Data;
                        current.Data = current.Next.Data;
                        current.Next.Data = temp;

                        swapped = true;
                    }

                    current = current.Next;
                }
            }
            while (swapped);
        }
    }
}