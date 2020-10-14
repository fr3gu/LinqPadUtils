using System;
using System.Net;
using System.Security.Principal;
using Hilda.Shared.Contracts.BLL.Infrastructure;

namespace LinqPadUtils
{
    public class LinqPadClientContext : IClientContext
    {
        public string UserName { get; set; }
        public string SessionId { get; set; }
        public IPrincipal SecurityPrincipal { get; }
        public IPAddress IpAddress { get; }

        public LinqPadClientContext()
        {
            UserName = "LinqPad query";
            SessionId = Guid.NewGuid().ToString();
            SecurityPrincipal = new GenericPrincipal(new GenericIdentity("LinqPadUser"), null);
            IpAddress = IPAddress.Parse("127.0.0.1");
        }
    }
}