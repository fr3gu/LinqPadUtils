using System;
using Hilda.Shared.Contracts.BLL.Infrastructure;

namespace LinqPadUtils
{
    public class LinqPadClientContext : IClientContext
    {
        public string UserName { get; set; }
        public string SessionId { get; set; }
        public ICustomPrincipal SecurityPrincipal { get; set; }

        public LinqPadClientContext()
        {
            UserName = "LinqPad query";
            SessionId = Guid.NewGuid().ToString();
            SecurityPrincipal = null;
        }
    }
}