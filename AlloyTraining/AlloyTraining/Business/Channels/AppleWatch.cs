using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Web;

namespace AlloyTraining.Business.Channels
{
    public class AppleWatch : DisplayChannel
    {
        public override bool IsActive(HttpContextBase context)
        {
           return context.Request.UserAgent.Contains("AppleWatch");
        }

        public override string ChannelName { get { return "AppleWatch"; } }

        
    }
}