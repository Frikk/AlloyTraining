using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "StartPage",
                GroupName = SiteGroupNames.Specialized,
                GUID = "69c8efa6-d7a2-44ee-96cb-b7f834ff2669", 
                Description = "The home page for a website with an area for blocks and partial pages.")]
    [SiteStartIcon]
    public class StartPage : SitePageData
    {
        [CultureSpecific]
        [Display(Name = "Heading",
                Description = "If the heading is not set, the page falls back to showing the Name.", 
                GroupName = SystemTabNames.Content,
                Order = 10)]
        public virtual string Heading { get; set; }

        
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }

        [CultureSpecific]
        [Display(Name = "Main body",
                Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                GroupName = SystemTabNames.Content,
                Order = 20)]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(Name = "Main content area",
                Description = "The main content area",
                Order = 30,
                GroupName = SystemTabNames.Content)]
        [AllowedTypes(typeof(StandardPage), typeof(BlockData), typeof(ImageData))]
        public virtual ContentArea MainContentArea { get; set; }

        [CultureSpecific]
        [Display(Name = "Footer text",
                GroupName = SiteTabNames.SiteSettings,
                Order = 100)]
        public virtual string FooterText { get; set; }
         
    }
}