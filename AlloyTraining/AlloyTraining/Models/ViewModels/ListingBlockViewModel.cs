﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;

namespace AlloyTraining.Models.ViewModels
{
    public class ListingBlockViewModel
    {

        public string Heading { get; set; }

        public IEnumerable<PageData> Pages { get; set; }

    }
}