using CommandLine;
using System;

namespace Notimpo
{
    class Program
    {
        static void Main(string[] args)
        {
            //var firstName = Environment.GetEnvironmentVariable("INPUT_FIRST_NAME");
            //var lastName = Environment.GetEnvironmentVariable("INPUT_LAST_NAME");

            //Console.WriteLine(firstName + " SPACE " + lastName);

           

            Parser.Default.ParseArguments<Options>(args)
                   .WithParsed<Options>(o =>
                   {                

                       if (o.NotifyType.Trim().ToLower() == "email" && !string.IsNullOrEmpty(o.MailgunApiKey) && !string.IsNullOrEmpty(o.To) && !string.IsNullOrEmpty(o.From) && !string.IsNullOrEmpty(o.Subject) && !string.IsNullOrEmpty(o.Message))
                       {
                           Console.WriteLine($"Sending mail with subject: {o.Subject}");

                           MailService.SendMail();

                           Console.WriteLine("Email Message send from Notimpo :)");

                       }
                       else if (o.NotifyType.Trim().ToLower() == "sms" && !string.IsNullOrEmpty(o.MailgunApiKey) && !string.IsNullOrEmpty(o.To) && !string.IsNullOrEmpty(o.From) && !string.IsNullOrEmpty(o.Subject) && !string.IsNullOrEmpty(o.Message))
                       {
                           Console.WriteLine($"Sending SMS with subject: {o.Subject}");

                           SMSService.SendSMS();

                           Console.WriteLine("SMS Message send from Notimpo :)");

                       }
                       else
                       {
       
                           Console.WriteLine("Oops error! while sending notification :( , Kindly check if workflow file is correct or you have access to Mail or SMS providers");
                       }
                   });
          
        }
    }
}
