using System;

namespace The_World.Services
{
    public interface IMailService
    {
        bool SendMail(string to, string from, string subject, string body);
    }

}