using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleThree
{
    public interface IContactList
    {
        void AddContact(Contact contact);
        List<Contact> SearchContacts(string searchTerm);
        Task WriteToFileAsync(string filePath);
        object FileLock { get; }
    }
}
