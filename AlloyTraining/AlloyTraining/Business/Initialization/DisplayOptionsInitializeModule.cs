using System;
using System.Linq;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.Web;

namespace AlloyTraining.Business.Initialization
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class DisplayOptionsInitializeModule : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            //Add initialization logic, this method is called once after CMS has been initialized
            var options = context.Locate.Advanced.GetInstance<DisplayOptions>();

            options.Add(id: SiteTags.Full, name: "Full", tag: SiteTags.Full);
            options.Add(id: SiteTags.Wide, name: "Wide", tag: SiteTags.Wide);
            options.Add(id: SiteTags.Narrow, name: "Narrow", tag: SiteTags.Narrow);

        }

        public void Uninitialize(InitializationEngine context)
        {
            //Add uninitialization logic
        }
    }
}