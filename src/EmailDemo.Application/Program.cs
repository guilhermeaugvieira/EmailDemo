// See https://aka.ms/new-console-template for more information
using FluentEmail.Core;
using FluentEmail.Smtp;
using System.Net;
using System.Net.Mail;

Console.WriteLine("Hello, World!");

var sender = new SmtpSender(() => new SmtpClient("smtp.mailtrap.io", 2525)
{
    Credentials = new NetworkCredential("1ccd533fe6bf6f", "09935031c06ac7"),
    EnableSsl = true
});

Email.DefaultSender = sender;

var email = await Email
    .From("from@example.com")
    .To("to@example.com")
    .Subject("Hello World")
    .Body("Test Body")
    .SendAsync();