using System;
using System.Diagnostics;
using System.Web;
using The_World.ViewModel;


namespace The_World.Services
{
    public class DebugMailService : IMailService
    {
        public bool SendMail(string to, string from, string subject, string body)
        {
            Debug.WriteLine($"Sending mail: To: {to}, Subject: {subject}");
            return true;
        }
        
           
    }
}
