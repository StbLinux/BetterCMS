﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BetterCms.Module.Blog.Views.Author.Partial
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
    
    #line 1 "..\..\Views\Author\Partial\ImageCell.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Author/Partial/ImageCell.cshtml")]
    public partial class ImageCell : System.Web.Mvc.WebViewPage<BetterCms.Module.Root.Mvc.Grids.EditableGridColumn>
    {
        public ImageCell()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("<td ");

            
            #line 5 "..\..\Views\Author\Partial\ImageCell.cshtml"
Write(Html.Raw(Model.Attributes));

            
            #line default
            #line hidden
WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"bcms-author-picture\"");

WriteLiteral(">\r\n        <!-- ko if: image().url() && isActive() -->\r\n        <a");

WriteLiteral(" class=\"bcms-remove-image\"");

WriteLiteral(" data-bind=\"click: image().remove.bind(image())\"");

WriteLiteral(">");

            
            #line 8 "..\..\Views\Author\Partial\ImageCell.cshtml"
                                                                                Write(RootGlobalization.Button_Remove);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n        <!-- /ko -->\r\n        <!-- ko if: image().url() -->\r\n        <a");

WriteLiteral(" data-bind=\"click: image().preview.bind(image())\"");

WriteLiteral("><img");

WriteLiteral(" data-bind=\"attr: {src: image().thumbnailUrl(), alt: image().tooltip() }\"");

WriteLiteral(" /></a>\r\n        <!-- /ko -->\r\n    </div>\r\n\r\n    <!-- ko if: isActive() -->\r\n    " +
"<div");

WriteLiteral(" class=\"bcms-blog-browse-images\"");

WriteLiteral(" data-bind=\"click: image().select.bind(image())\"");

WriteLiteral(">");

            
            #line 16 "..\..\Views\Author\Partial\ImageCell.cshtml"
                                                                                    Write(RootGlobalization.Button_Browse);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n    <!-- /ko -->\r\n</td>");

        }
    }
}
#pragma warning restore 1591
