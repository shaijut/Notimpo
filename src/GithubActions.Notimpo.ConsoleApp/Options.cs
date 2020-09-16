using CommandLine;


namespace Notimpo
{
    /// <summary>
    /// This represents the parameters entity for the console app.
    /// </summary>
    public class Options
    {
        /// <summary>
        /// Gets or sets the mailgun api key.
        /// </summary>
        [Option("mailgun-api-key", Required = true, HelpText = "Mailgun Api Key")]
        public virtual string MailgunApiKey { get; set; }

        /// <summary>
        /// Gets or sets the message to email ID.
        /// </summary>
        [Option("to", Required = true, Default = "", HelpText = "To Email ID")]
        public virtual string To { get; set; }

        /// <summary>
        /// Gets or sets the from email ID.
        /// </summary>
        [Option("from", Required = true, HelpText = "From Email ID")]
        public virtual string From { get; set; }

        /// <summary>
        /// Gets or sets the email subject.
        /// </summary>
        [Option("subject", Required = true, Default = "", HelpText = "Email Subject")]
        public virtual string Subject { get; set; }

        /// <summary>
        /// Gets or sets the email message.
        /// </summary>
        [Option("message", Required = true, Default = "", HelpText = "Email Message")]
        public virtual string Message { get; set; }

        /// <summary>
        /// Gets or sets the email message.
        /// </summary>
        [Option("notify-type", Required = true, Default = "", HelpText = "Email or SMS Message Type")]
        public virtual string NotifyType { get; set; }

    }
}
