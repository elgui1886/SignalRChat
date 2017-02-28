using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRChat
{
    public class ChatHub : Hub
    {
        //Metodo che viene invocato dal proxy Hub del client
        public void Send(string name, string message)
        {
            //call the broadcastMessage to update the client
            //metodo client che viene invocato dal server hub
            Clients.All.broadcastMessage(name, message);
        }
    }
}