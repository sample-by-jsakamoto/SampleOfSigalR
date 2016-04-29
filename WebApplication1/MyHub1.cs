using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace WebApplication1
{
    public class MyHub1 : Hub
    {
        public object ChangeState(bool newState)
        {
            this.Clients.All.StateChanged(newState);

            return new
            {
                Foo = "Bar",
                Now = DateTime.UtcNow
            };
        }
    }
}