using System.Web.Mvc;
using AlloyTraining.Models.Pages;
using AlloyTraining.Models.ViewModels;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;

namespace AlloyTraining.Controllers
{
    [TemplateDescriptor(Inherited = true, Tags = new[] { SiteTags.Wide }, AvailableWithoutTag = true)]
    public class AllPagesWidePartialController : PartialContentController<SitePageData>
    {
        public override ActionResult Index(SitePageData currentPage)
        {
            var viewmodel = new DefaultPageViewModel<SitePageData>(currentPage);

            return PartialView(SiteTags.Wide, viewmodel);
        }
    }
}