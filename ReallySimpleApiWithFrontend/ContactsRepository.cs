using System.Text.Json;

namespace ReallySimpleApiWithFrontend
{
    public class ContactsRepository
    {
        const string Filename = "contacts.json";

        public static Contact[] Get()
        {
            if (!File.Exists(Filename)) return [];
            var json = File.ReadAllText(Filename);
            var contacts = JsonSerializer.Deserialize<Contact[]>(json);
            return contacts;
        }

        public static void Add(Contact contact)
        {
            var contactsArray = Get();
            var contacts = new List<Contact>(contactsArray);
            contacts.Add(contact);
            Save(contacts);
        }

        private static void Save(List<Contact> contacts)
        {
            var json = JsonSerializer.Serialize(contacts);
            File.WriteAllText(Filename, json);
        }

        public static async Task<Contact[]> GetAsync()
        {
            if (!File.Exists(Filename)) return [];
            var json = await File.ReadAllTextAsync(Filename);
            var contacts = JsonSerializer.Deserialize<Contact[]>(json);
            return contacts;
        }

        public static async Task AddAsync(Contact contact)
        {
            var contactsArray = await GetAsync();
            var contacts = new List<Contact>(contactsArray);
            contacts.Add(contact);
            await SaveAsync(contacts);
        }

        private static async Task SaveAsync(List<Contact> contacts)
        {
            var json = JsonSerializer.Serialize(contacts, new JsonSerializerOptions() { WriteIndented = true });
            await File.WriteAllTextAsync(Filename, json);
        }
    }
}
