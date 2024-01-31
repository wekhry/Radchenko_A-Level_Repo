using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleThree
{
    public class ContactListApp
    {
        private readonly IContactList contactList;
        public ContactListApp(IContactList contactList)
        {
            this.contactList = contactList;
        }
        public ContactList ContactList { get; } = new ContactList();
        public void Start()
        {
            Contact newContact = new Contact { Name = "John", Surname = "Doe", Phone = "1234567890" };
            ContactList.AddContact(newContact);
            Contact newContact2 = new Contact { Name = "Bruce", Surname = "Wayne", Phone = "0987654321" };
            ContactList.AddContact(newContact2);
        }
    }
}
