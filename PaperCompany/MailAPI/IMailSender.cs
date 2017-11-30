using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Integration.Api
{
    public interface IMailSender
    {
        void SendMail(string source, string destination, string from, string to, string message);
    }
}
