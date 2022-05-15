using PS.Data.Infrastructure;
using PS.Domain;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Services
{
    public class ServiceAchat : Service<Achat>,IServiceAchat //on va pas implementer 5ater deja implementer 3ana

    {
        public ServiceAchat(IUnitOfWork uow) : base(uow)
        {

        }

    }
}
