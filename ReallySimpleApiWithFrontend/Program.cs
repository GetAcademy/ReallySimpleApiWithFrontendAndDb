using Dapper;
using Microsoft.Data.SqlClient;
using ReallySimpleApiWithFrontend;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseHttpsRedirection();

var connStr =
    @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Contacts;Integrated Security=True";

app.MapGet("/api/contact", async () =>
{
    Console.WriteLine(DateTime.Now + " - Leste alle kontaktene");
    var conn = new SqlConnection(connStr);
    var sql = "SELECT * FROM Contacts";
    var contacts = await conn.QueryAsync<Contact>(sql);
    return contacts;
    //return await ContactsRepository.GetAsync();
});
app.MapPost("/api/contact", async (Contact contact) =>
{
    Console.WriteLine(DateTime.Now + $" - La til kontakten {contact.Name}");
    var conn = new SqlConnection(connStr);
    var sql = "INSERT INTO Contacts VALUES (@Name, @Email)";
    await conn.ExecuteAsync(sql, contact);
    //await ContactsRepository.AddAsync(contact);
});

app.UseStaticFiles();
app.Run();
