﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Facade.ExternalAPI.Mail
{
    public interface IMailSender
    {
        void SendMail(string source, string destination, string from, string to, string message);
    }
}