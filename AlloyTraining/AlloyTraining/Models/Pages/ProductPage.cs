using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "Product", 
                GUID = "cfb53af0-1422-4d65-8fd0-3c60be13c2a7",
                Description = "Use this for products that alloy sells",
                GroupName = SiteGroupNames.Specialized)]
    [SiteCommerceIcon]
    public class ProductPage : StandardPage
    {

        [Display(GroupName = SystemTabNames.Content, 
                Order = 320)]
        [UIHint(UIHint.Textarea)]
        [Required]
        public virtual string UniqueSellingPoints  { get; set; }
         
    }
}