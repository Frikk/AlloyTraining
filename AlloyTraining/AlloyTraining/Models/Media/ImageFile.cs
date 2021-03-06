﻿using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace AlloyTraining.Models.Media
{
    [ContentType(DisplayName = "Image File",
        Description = "Use this to upload image files.")]
    [MediaDescriptor(ExtensionString = "png,jpg,jpeg,gif")]
    public class ImageFile : ImageData
    {
        [CultureSpecific]
        [Editable(true)]
        public virtual string Description { get; set; }

        [CultureSpecific]
        [Editable(true)]
        public virtual string AlternativeText { get; set; }
    }
}