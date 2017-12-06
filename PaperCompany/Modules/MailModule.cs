using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;
using System.Text;
using System.Threading.Tasks;
using Company.Integration.MailApi;
using Company.Integration.Gmail;

namespace Company.Modules
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
