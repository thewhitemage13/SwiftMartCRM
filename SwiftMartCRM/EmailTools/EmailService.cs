using FluentEmail.Core;
using FluentEmail.Razor;
using FluentEmail.Smtp;
using System.Net.Mail;
using System.Text;
using System.Windows;

namespace SwiftMart.EmailTools
{

    /// <summary>
    /// Provides email sending functionality for the SwiftMart application.
    /// </summary>
    /// <remarks>
    /// This class uses the FluentEmail library to send emails asynchronously.
    /// The email is sent via a Gmail SMTP server, and the body is rendered using Razor templates.
    /// </remarks>
    public class EmailService
    {

        /// <summary>
        /// Sends a welcome email to a user after registration.
        /// </summary>
        /// <param name="emailSend">The recipient's email address.</param>
        /// <param name="name">The name of the recipient.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        /// <exception cref="Exception">Thrown if an error occurs during the email sending process.</exception>
        /// <remarks>
        /// This method constructs an email template, configures the email client using Gmail's SMTP settings,
        /// and sends a welcome message to the user. If the email fails to send, an exception is thrown.
        /// </remarks>
        public async Task Sender(string emailSend, string name)
        {
            try
            {
                var sender = new SmtpSender(() => new SmtpClient("smtp.gmail.com")
                {
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Port = 587,
                    Credentials = new System.Net.NetworkCredential("lmecomcompany@gmail.com", "mgspnfykrzjhwmmu") 
                });

                Email.DefaultSender = sender;

                StringBuilder template = new StringBuilder();
                template.AppendLine($"Dear {name},");
                template.AppendLine("<p>Thank you for registering at SwiftMart. We hope you have a great shopping experience with us.</p>");
                template.AppendLine("- The SwiftMart Team");

                Email.DefaultRenderer = new RazorRenderer();

                var email = await Email
                    .From("lmecomcompany@gmail.com") 
                    .To(emailSend, name)
                    .Subject("Welcome to SwiftMart!")
                    .UsingTemplate(template.ToString(), new { FirstName = name })
                    .SendAsync();

                if (!email.Successful)
                {
                    var errorMessages = string.Join("\n", email.ErrorMessages);
                    throw new Exception($"Email sending failed: {errorMessages}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in EmailService: {ex.Message}", ex);
            }
        }
    }
}
