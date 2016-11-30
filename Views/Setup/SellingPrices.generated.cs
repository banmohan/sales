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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Setup/SellingPrices.cshtml")]
    public partial class _Views_Setup_SellingPrices_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Setup_SellingPrices_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Setup\SellingPrices.cshtml"
  
    ViewBag.Title = "Selling Prices";
    Layout = ViewBag.SalesLayoutPath;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<script>\r\n    var scrudFactory = new Object();\r\n\r\n    scrudFactory.title = \"S" +
"elling Prices\";\r\n\r\n    scrudFactory.viewAPI = \"/api/views/sales/item-selling-pri" +
"ce-scrud_view\";\r\n    scrudFactory.viewTableName = \"sales.item_selling_price_scru" +
"d_view\";\r\n\r\n    scrudFactory.formAPI = \"/api/forms/sales/item-selling-prices\";\r\n" +
"    scrudFactory.formTableName = \"sales.item_selling_prices\";\r\n\r\n    scrudFactor" +
"y.excludedColumns = [\"audit_user_id\", \"audit_ts\"];\r\n\r\n    scrudFactory.allowDele" +
"te = true;\r\n    scrudFactory.allowEdit = true;\r\n\r\n\r\n    scrudFactory.card = {\r\n " +
"       header: \"item\",\r\n        meta: \"unit\",\r\n        description: \"price\"\r\n   " +
"     };\r\n\r\n    //scrudFactory.layout = [\r\n    //    {\r\n    //        tab: \"\",\r\n " +
"   //        fields: [\r\n    //            [\"\", \"\"],\r\n    //            [\"\", \"\"]," +
"\r\n    //        ]\r\n    //    }\r\n    //];\r\n\r\n    scrudFactory.keys = [\r\n        {" +
"\r\n            property: \"ItemId\",\r\n            url: \'/api/views/inventory/items/" +
"display-fields\',\r\n            data: null,\r\n            valueField: \"Key\",\r\n     " +
"       textField: \"Value\"\r\n        },\r\n        {\r\n            property: \"UnitId\"" +
",\r\n            url: \'/api/views/inventory/units/display-fields\',\r\n            da" +
"ta: null,\r\n            valueField: \"Key\",\r\n            textField: \"Value\"\r\n     " +
"   },\r\n        {\r\n            property: \"CustomerTypeId\",\r\n            url: \'/ap" +
"i/views/inventory/customer-types/display-fields\',\r\n            data: null,\r\n    " +
"        valueField: \"Key\",\r\n            textField: \"Value\"\r\n        },\r\n        " +
"{\r\n            property: \"PriceTypeId\",\r\n            url: \'/api/views/sales/pric" +
"e-types/display-fields\',\r\n            data: null,\r\n            valueField: \"Key\"" +
",\r\n            textField: \"Value\"\r\n        }\r\n    ];\r\n\r\n\r\n\r\n    $.get(\'/ScrudFac" +
"tory/View.html\', function (view) {\r\n        $.get(\'/ScrudFactory/Form.html\', fun" +
"ction (form) {\r\n            $(\"#ScrudFactoryView\").html(view);\r\n            $(\"#" +
"ScrudFactoryForm\").html(form);\r\n            $.cachedScript(\"/assets/js/scrudfact" +
"ory-view.js\");\r\n            $.cachedScript(\"/assets/js/scrudfactory-form.js\");\r\n" +
"        });\r\n    });\r\n</script>\r\n\r\n<div");

WriteLiteral(" id=\"ScrudFactoryForm\"");

WriteLiteral("></div>\r\n<div");

WriteLiteral(" id=\"ScrudFactoryView\"");

WriteLiteral("></div>");

        }
    }
}
#pragma warning restore 1591
