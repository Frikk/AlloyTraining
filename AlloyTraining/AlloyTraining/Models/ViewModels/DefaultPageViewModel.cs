using AlloyTraining.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;
using AlloyTraining.Business.ExtensionMethods;

namespace AlloyTraining.Models.ViewModels
{
    public class DefaultPageViewModel<T> : IPageViewModel<T> where T : SitePageData
    {
        public DefaultPageViewModel(T currentPage)
        {
            CurrentPage = currentPage;
            Section = currentPage.ContentLink.GetSection();
        }

        public T CurrentPage { get; set; }
        public IContent Section { get; set; }
    }
}