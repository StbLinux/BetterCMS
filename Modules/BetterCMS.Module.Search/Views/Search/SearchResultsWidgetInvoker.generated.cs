﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BetterCms.Module.Search.Views.Search
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\Search\SearchResultsWidgetInvoker.cshtml"
    using Autofac;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Search\SearchResultsWidgetInvoker.cshtml"
    using BetterCms.Module.Search.Content.Resources;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Search\SearchResultsWidgetInvoker.cshtml"
    using BetterCms.Module.Search.Services;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Search\SearchResultsWidgetInvoker.cshtml"
    using BetterModules.Core.Dependencies;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Search/SearchResultsWidgetInvoker.cshtml")]
    public partial class SearchResultsWidgetInvoker : System.Web.Mvc.WebViewPage<BetterCms.Module.Root.ViewModels.Cms.RenderWidgetViewModel>
    {
        public SearchResultsWidgetInvoker()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 8 "..\..\Views\Search\SearchResultsWidgetInvoker.cshtml"
  
    bool hasImplementation;
    using (var container = ContextScopeProvider.CreateChildContainer())
    {
        hasImplementation = container.IsRegistered<ISearchService>();
    }

    if (!hasImplementation)
    {

            
            #line default
            #line hidden
WriteLiteral("        <h3");

WriteLiteral(" style=\"color: red;\"");

WriteLiteral(">");

            
            #line 17 "..\..\Views\Search\SearchResultsWidgetInvoker.cshtml"
                           Write(SearchGlobalization.Search_Module_Has_No_Service_Implementations);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n");

            
            #line 18 "..\..\Views\Search\SearchResultsWidgetInvoker.cshtml"
    }
    else
    {
        Html.RenderAction("Results", "Search", new { Area = "bcms-search", WidgetModel = Model });
    }

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
