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
    using Frapid.Configuration;
    using Frapid.Dashboard;
    using Frapid.DataAccess;
    using Frapid.DbPolicy;
    using Frapid.Framework;
    using Frapid.i18n;
    using Frapid.Messaging;
    using Frapid.Mapper.Decorators;
    using Frapid.WebsiteBuilder;
    using MixERP.Sales;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Setup/Cashiers.cshtml")]
    public partial class _Views_Setup_Cashiers_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Setup_Cashiers_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Setup\Cashiers.cshtml"
  
    ViewBag.Title = "Cashiers";
    Layout = ViewBag.SalesLayoutPath;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<script>\r\n    var scrudFactory = new Object();\r\n\r\n    scrudFactory.title = \"C" +
"ashiers\";\r\n\r\n    scrudFactory.viewAPI = \"/api/views/sales/cashier-scrud-view\";\r\n" +
"    scrudFactory.viewTableName = \"sales.cashier_scrud_view\";\r\n\r\n    scrudFactory" +
".formAPI = \"/api/forms/sales/cashiers\";\r\n    scrudFactory.formTableName = \"sales" +
".cashiers\";\r\n\r\n    scrudFactory.excludedColumns = [\"audit_user_id\", \"audit_ts\"];" +
"\r\n\r\n    scrudFactory.allowDelete = true;\r\n    scrudFactory.allowEdit = true;\r\n\r\n" +
"    scrudFactory.live = \"CashierCode\";\r\n\r\n    scrudFactory.card = {\r\n        hea" +
"der: \"associated_user\",\r\n        meta: \"cashier_code\",\r\n        description: \"co" +
"unter\"     \r\n    };\r\n\r\n    //scrudFactory.layout = [\r\n    //    {\r\n    //       " +
" tab: \"\",\r\n    //        fields: [\r\n    //            [\"\", \"\"],\r\n    //         " +
"   [\"\", \"\"],\r\n    //        ]\r\n    //    }\r\n    //];\r\n\r\n    scrudFactory.keys = " +
"[\r\n        {\r\n            property: \"CounterId\",\r\n            url: \'/api/forms/i" +
"nventory/counters/display-fields\',\r\n            data: null,\r\n            valueFi" +
"eld: \"Key\",\r\n            textField: \"Value\"\r\n        },\r\n        {\r\n            " +
"property: \"AssociatedUserId\",\r\n            url: \'/api/views/account/user-selecto" +
"r-view/display-fields\',\r\n            data: null,\r\n            valueField: \"Key\"," +
"\r\n            textField: \"Value\"\r\n        }\r\n    ];\r\n\r\n\r\n\r\n    $.get(\'/ScrudFact" +
"ory/View.html\', function (view) {\r\n        $.get(\'/ScrudFactory/Form.html\', func" +
"tion (form) {\r\n            $(\"#ScrudFactoryView\").html(view);\r\n            $(\"#S" +
"crudFactoryForm\").html(form);\r\n            $.cachedScript(\"/assets/js/scrudfacto" +
"ry-view.js\");\r\n            $.cachedScript(\"/assets/js/scrudfactory-form.js\");\r\n " +
"       });\r\n    });\r\n</script>\r\n\r\n<div");

WriteLiteral(" id=\"ScrudFactoryForm\"");

WriteLiteral("></div>\r\n<div");

WriteLiteral(" id=\"ScrudFactoryView\"");

WriteLiteral("></div>");

        }
    }
}
#pragma warning restore 1591
