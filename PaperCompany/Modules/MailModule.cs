using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;
using System.Text;
using System.Threading.Tasks;
using PaperCompany.Integration.MailApi;
using PaperCompany.Integration.Gmail;

namespace PaperCompany.Modules
{
    public class MailModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<GmailSender>().As<IMailSender>();
            base.Load(builder);
        }
    }
}
