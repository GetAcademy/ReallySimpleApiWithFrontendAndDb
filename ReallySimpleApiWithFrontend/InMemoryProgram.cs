/*
using ReallySimpleApiWithFrontend;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseHttpsRedirection();

var contacts = new List<Contact>
{
    new Contact("Per", "per@mail.com"),
    new Contact("Pål", "paa@gmail.com"),
    new Contact("Espen", "espen@online.no"),
};

app.MapGet("/api/contact", () =>
{
    Console.WriteLine(DateTime.Now + " - Leste alle kontaktene");
    return contacts;
});
app.MapPost("/api/contact", (Contact contact) =>
{
    Console.WriteLine(DateTime.Now + $" - La til kontakten {contact.Name}");
    contacts.Add(contact);
});

app.MapGet("/image", () =>
{
    var base64 = "iVBORw0KGgoAAAANSUhEUgAAAAgAAAAICAYAAADED76LAAAAIklEQVR4nGNkYGD4z4AEmBjQAEYV" +
    "AwPDf2QZkI0BAEhKAgm1O7PRAAAAAElFTkSuQmCC";

    var bytes = Convert.FromBase64String(base64);

    return Results.File(bytes, "image/png");
});

app.MapGet("/kenneth", () =>
    Results.Content("""
                    <!DOCTYPE html>
                    <html>
                    <head>
                        <title>Kenneth spinner</title>
                        <style>
                            body {
                                margin: 0;
                                height: 100vh;
                                display: flex;
                                justify-content: center;
                                align-items: center;
                                background: black;
                                overflow: hidden;
                            }
                    
                            h1 {
                                font-size: 120px;
                                font-family: Arial, sans-serif;
                                color: white;
                                animation: spin 2s linear infinite;
                            }
                    
                            @keyframes spin {
                                from {
                                    transform: rotate(0deg);
                                }
                                to {
                                    transform: rotate(360deg);
                                }
                            }
                        </style>
                    </head>
                    <body>
                        <h1>Kenneth</h1>
                    </body>
                    </html>
                    """,
        "text/html"));
app.UseStaticFiles();
app.Run();
*/