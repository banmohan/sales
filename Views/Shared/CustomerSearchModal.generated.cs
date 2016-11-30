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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/CustomerSearchModal.cshtml")]
    public partial class _Views_Shared_CustomerSearchModal_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared_CustomerSearchModal_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"ui customer search fullscreen modal padded segment\"");

WriteLiteral(">\r\n    <iframe");

WriteLiteral(" src=\"/dashboard/sales/setup/customers/search\"");

WriteLiteral(@"></iframe>
</div>

<script>
    $(""#SearchCustomerAction"").click(function () {
        $("".customer.search.modal"").modal(""show"");
    });

    function onCustomerSearchSelect(customerId, customerCode) {
        if (customerId) {
            $("".customer.search.modal"").modal(""hide"");

            $(""#CustomerInputText"").attr(""data-customer-id"", customerId).val(customerCode);

            //$(""#CustomerSelect"").dropdown(""clear"");
            //$(""#CustomerSelect"").html(""<option value='"" + customerId + ""'>"" + customerName + ""</option>"");
            //setTimeout(function () {
            //    $(""#CustomerSelect"").dropdown(""set selected"", customerId);
            //}, 100);
        };
    };
</script>");

        }
    }
}
#pragma warning restore 1591
