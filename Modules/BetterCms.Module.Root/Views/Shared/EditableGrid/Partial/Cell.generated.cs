﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
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
    
    #line 1 "..\..\Views\Shared\EditableGrid\Partial\Cell.cshtml"
    using BetterCms.Module.Root.Mvc.Grids;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/EditableGrid/Partial/Cell.cshtml")]
    public partial class _Views_Shared_EditableGrid_Partial_Cell_cshtml : System.Web.Mvc.WebViewPage<EditableGridColumn>
    {
        public _Views_Shared_EditableGrid_Partial_Cell_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<td ");

            
            #line 4 "..\..\Views\Shared\EditableGrid\Partial\Cell.cshtml"
Write(Html.Raw(Model.Attributes));

            
            #line default
            #line hidden
WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"bcms-input-box\"");

WriteLiteral(">\r\n        <a");

WriteLiteral(" class=\"bcms-tables-link\"");

WriteLiteral(" data-bind=\"\r\n           text: ");

            
            #line 7 "..\..\Views\Shared\EditableGrid\Partial\Cell.cshtml"
             Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral(" ()\r\n");

WriteLiteral("           ");

            
            #line 8 "..\..\Views\Shared\EditableGrid\Partial\Cell.cshtml"
       Write(!string.IsNullOrEmpty(Model.FocusIdentifier) ? string.Format(", click: onItemSelect.bind($data, {0})", Model.FocusIdentifier) : string.Empty);

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("           ");

            
            #line 9 "..\..\Views\Shared\EditableGrid\Partial\Cell.cshtml"
       Write(Model.CanBeEdited ? string.Format(", visible: !isActive() || ({0}.editingIsDisabled && {0}.editingIsDisabled())", Model.ValueBind) : string.Empty);

            
            #line default
            #line hidden
WriteLiteral(" \"");

WriteLiteral("></a>\r\n");

            
            #line 10 "..\..\Views\Shared\EditableGrid\Partial\Cell.cshtml"
        
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\Shared\EditableGrid\Partial\Cell.cshtml"
         if (Model.CanBeEdited)
        {

            
            #line default
            #line hidden
WriteLiteral("            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"bcms-editor-field-box\"");

WriteLiteral(" data-bind=\"\r\n                css: { \'bcms-input-validation-error\': !isNew() && ");

            
            #line 13 "..\..\Views\Shared\EditableGrid\Partial\Cell.cshtml"
                                                              Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral(".hasError && ");

            
            #line 13 "..\..\Views\Shared\EditableGrid\Partial\Cell.cshtml"
                                                                                             Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral(".hasError() },\r\n                value: ");

            
            #line 14 "..\..\Views\Shared\EditableGrid\Partial\Cell.cshtml"
                  Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral(", \r\n                valueUpdate: \'afterkeydown\', \r\n                enterPress: on" +
"Save, \r\n                escPress: onCancelEdit, \r\n                afterRender: i" +
"nitInput($element, ");

            
            #line 18 "..\..\Views\Shared\EditableGrid\Partial\Cell.cshtml"
                                            Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral(")\r\n");

WriteLiteral("                ");

            
            #line 19 "..\..\Views\Shared\EditableGrid\Partial\Cell.cshtml"
            Write(!string.IsNullOrWhiteSpace(Model.CustomBinding) ? string.Format(", {0}", Model.CustomBinding) : string.Empty);

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 20 "..\..\Views\Shared\EditableGrid\Partial\Cell.cshtml"
            Write(!string.IsNullOrEmpty(Model.FocusIdentifier) ? string.Format(", hasfocus: {0}", Model.FocusIdentifier) : string.Empty);

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 21 "..\..\Views\Shared\EditableGrid\Partial\Cell.cshtml"
            Write(string.Format(", visible: isActive() && (!{0}.editingIsDisabled || !{0}.editingIsDisabled())", Model.ValueBind));

            
            #line default
            #line hidden
WriteLiteral("\r\n                   \"");

WriteLiteral(" />\r\n");

WriteLiteral("            <!-- ko if: !isNew() &&  ");

            
            #line 23 "..\..\Views\Shared\EditableGrid\Partial\Cell.cshtml"
                                 Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral(".hasError && ");

            
            #line 23 "..\..\Views\Shared\EditableGrid\Partial\Cell.cshtml"
                                                                Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral(".hasError() -->\r\n");

WriteLiteral("            <span");

WriteLiteral(" class=\"bcms-field-validation-error\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" data-bind=\"html: ");

            
            #line 25 "..\..\Views\Shared\EditableGrid\Partial\Cell.cshtml"
                                   Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral(".validationMessage()\"");

WriteLiteral("></span>\r\n            </span>\r\n");

WriteLiteral("            <!-- /ko -->\r\n");

            
            #line 28 "..\..\Views\Shared\EditableGrid\Partial\Cell.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</td>");

        }
    }
}
#pragma warning restore 1591
