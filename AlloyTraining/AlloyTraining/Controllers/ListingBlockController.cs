using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AlloyTraining.Models.Blocks;
using AlloyTraining.Models.Pages;
using AlloyTraining.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.Filters;
using EPiServer.ServiceLocation;
using EPiServer.Web;
using EPiServer.Web.Mvc;

namespace AlloyTraining.Controllers
{
    public class ListingBlockController : BlockController<ListingBlock>
    {
        

        public override ActionResult Index(ListingBlock currentBlock)
        {
            var _loader = ServiceLocator.Current.GetInstance<IContentLoader>();

            ListingBlockViewModel viewmodel = new ListingBlockViewModel();
            viewmodel.Heading = currentBlock.Heading;

            var pages = _loader.GetChildren<PageData>(currentBlock.Parent);
            var filteredChildren = FilterForVisitor.Filter(pages).Cast<PageData>();
            viewmodel.Pages = filteredChildren;

            return PartialView(viewmodel);
        }

        
    }
}
