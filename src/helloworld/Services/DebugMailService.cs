using System.Diagnostics;

namespace helloworld.Services
{
    public  class DebugMailService : IMailService
    {
        public bool SendMail(string from, string to, string subject, string body)
        {
            Debug.WriteLine($"Sending mail from: {from} to: {to}, subject: {subject}");
            return true;
        }
    }
}