﻿namespace TemplateMethod
{
    /// <summary>
    /// Abstract Class
    /// </summary>
    public abstract class MailParser
    {
        public virtual void FindServer()
        {
            Console.WriteLine("Finding server...");
        }

        public abstract void AuthenticateToServer();
        public string ParseHtmlMailBody(string identifier)
        {
            Console.WriteLine("Parsing HTML mail body...");
            return $"This is the body of the email with the id: {identifier}";
        }

        /// <summary>
        /// Template method
        /// </summary>
        /// <param name="identifier"></param>
        /// <returns></returns>
        public string ParseMailBody(string identifier)
        {
            Console.WriteLine("Parsing mail body (in template method)...");
            FindServer();
            AuthenticateToServer();
            return ParseHtmlMailBody(identifier);
        }
    }

    public class ExchangeMailParser : MailParser
    {
        public override void AuthenticateToServer()
        {
            Console.WriteLine("Connecting to Exchange server...");
        }
    }

    public class ApacheMailParser : MailParser
    {
        public override void AuthenticateToServer()
        {
            Console.WriteLine("Connecting to Apache server...");
        }
    }

    public class EudoraMailParser : MailParser
    {
        public override void FindServer()
        {
            Console.WriteLine("Finding Eudora server via custom algorithm...");
        }

        public override void AuthenticateToServer()
        {
            Console.WriteLine("Connecting to Eudora server...");
        }
    }
}
