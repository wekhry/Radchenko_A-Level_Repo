using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace ModuleThree
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IContactList, ContactList>()
                .BuildServiceProvider();

            var app = new ContactListApp(serviceProvider.GetService<IContactList>());
            app.Start();

            string directoryPath = "C:\\Users\\radch\\OneDrive\\Документы\\A-Level\\GitHubRepo\\ModuleThree\\ModuleThree\\bin\\Debug\\net8.0";
            string fileName = "contacts.txt";
            string filePath = Path.Combine(directoryPath, fileName);

            await app.ContactList.WriteToFileAsync(filePath);

            var fileWatcher = new FileSystemWatcher(Path.GetDirectoryName(filePath));
            fileWatcher.Filter = Path.GetFileName(filePath);
            fileWatcher.Changed += async (sender, e) =>
            {
                while (IsFileLocked(new FileInfo(filePath)))
                {
                    await Task.Delay(100);
                }
                var contacts = File.ReadAllLines(filePath);
                foreach (var contactData in contacts)
                {
                    var contactDetails = contactData.Split(',');
                    Console.WriteLine($"Name: {contactDetails[0]}, Surname: {contactDetails[1]}, Phone:{contactDetails[2]}");
                }
            };
            fileWatcher.EnableRaisingEvents = true;

            Console.ReadLine();
        }

        private static bool IsFileLocked(FileInfo file)
        {
            FileStream stream = null;
            try
            {
                stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None);
            }
            catch (IOException)
            {
                return true;
            }
            finally
            {
                stream?.Close();
            }
            return false;
        }
    }
}