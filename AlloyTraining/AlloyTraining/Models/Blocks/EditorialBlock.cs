using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace AlloyTraining.Models.Blocks
{
    [ContentType(DisplayName = "Editorial", GUID = "f2740d06-8e6e-4110-805c-5574b138481e",
        Description = "Use this for rich editorial text that will be reused in multiple places.")]
    [SiteBlockIcon]
    public class EditorialBlock : BlockData
    {

        [CultureSpecific]
        [Display(Name = "Main body", 
            Description = "The main body will be shown in the main content area of the pag,e using the XHMTL-editor u can insert for example text images and tables.", 
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual XhtmlString MainBody { get; set; }

    }
}