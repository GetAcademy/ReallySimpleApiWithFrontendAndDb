using ReallySimpleApiWithFrontend;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseHttpsRedirection();

app.MapGet("/api/contact", async () =>
{
    Console.WriteLine(DateTime.Now + " - Leste alle kontaktene");
    return await ContactsRepository.GetAsync();
});
app.MapPost("/api/contact", async (Contact contact) =>
{
    Console.WriteLine(DateTime.Now + $" - La til kontakten {contact.Name}");
    await ContactsRepository.AddAsync(contact);
});

app.UseStaticFiles();
app.Run();
