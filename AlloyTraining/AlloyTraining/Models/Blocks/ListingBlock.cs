using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace AlloyTraining.Models.Blocks
{
    [ContentType(DisplayName = "Listing", 
        GUID = "74d9e7b2-c630-4463-9b1e-2b03cf6f8d69",
        Description = "Block for listing pages")]
    [SiteBlockIcon]
    public class ListingBlock : BlockData
    {
        [Display(Name = "Heading", Order = 10)]
        public virtual string Heading { get; set; }
        [Display(Name = "Parent", Order = 20)]
        public virtual PageReference Parent { get; set; }
        
    }
}