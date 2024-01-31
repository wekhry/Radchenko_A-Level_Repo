using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleThree
{
    public class ContactList : IContactList
    {
        private List<Contact> contacts = new List<Contact>();
        private readonly object fileLock = new object();
        public event EventHandler<ContactAddedEventArgs> ContactAdded;
        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
            OnContactAdded(new ContactAddedEventArgs(contact));
        }

        protected virtual void OnContactAdded(ContactAddedEventArgs e)
        {
            ContactAdded?.Invoke(this, e);
        }

        public List<Contact> SearchContacts(string searchTerm)
        {
            List<Contact> searchResults = contacts.FindAll(contact =>
            contact.Name.Contains(searchTerm) ||
            contact.Surname.Contains(searchTerm) ||
            contact.Phone.Contains(searchTerm)
            );
            return searchResults;
        }
        public void DisplayAllContacts()
        {
            foreach (var contact in contacts)
            {
                Console.WriteLine($"Name: {contact.Name}, Surname: {contact.Surname}, Phone: {contact.Phone}");
            }
        }
        public object FileLock => fileLock;
        public async Task WriteToFileAsync(string filePath)
        {
            lock (fileLock)
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var contact in contacts)
                    {
                        writer.WriteLine($"{contact.Name},{contact.Surname},{contact.Phone}");
                    }
                }
            }
        }
    }
    public class ContactAddedEventArgs : EventArgs
    {
        public Contact AddedContact { get; }

        public ContactAddedEventArgs(Contact contact)
        {
            AddedContact = contact;
        }
    }
}
