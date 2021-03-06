#pragma checksum "C:\Projects\GitHub\WebApiChartsInvestV2\src\WebApiChartsInvestV2.Web\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7408c749ce7e8d53d4d0740df81c18cc7cdb131d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Projects\GitHub\WebApiChartsInvestV2\src\WebApiChartsInvestV2.Web\Views\_ViewImports.cshtml"
using WebApiChartsInvestV2.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\GitHub\WebApiChartsInvestV2\src\WebApiChartsInvestV2.Web\Views\_ViewImports.cshtml"
using WebApiChartsInvestV2.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7408c749ce7e8d53d4d0740df81c18cc7cdb131d", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db38d11c3ce9e97857d126fdf6cc9879db34029b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Projects\GitHub\WebApiChartsInvestV2\src\WebApiChartsInvestV2.Web\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

    var type = ViewBag.Type;
    var qty = ViewBag.Qty;

    var typeSerializado = Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(type));
    var qtySerializado = Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(qty));


#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""subheader"">
    <h1 class=""subheader-title"">
        <i class='subheader-icon fal fa-chart-area'></i> Analytics <span class='fw-300'>Dashboard</span>
    </h1>
    <div class=""subheader-block d-lg-flex align-items-center border-faded border-right-0 border-top-0 border-bottom-0 ml-3 pl-3"">
        <div class=""d-inline-flex flex-column justify-content-center mr-3"">
            <div class=""position-absolute pos-top pos-right d-none d-sm-block""><span class=""js-get-date""></span></div>
        </div>
        <span class=""sparklines hidden-lg-down"" sparkType=""bar"" sparkBarColor=""#fe6bb0"" sparkHeight=""32px"" sparkBarWidth=""5px"" values=""1,4,3,6,5,3,9,6,5,9,7""></span>
    </div>
</div>

<div class=""row"">
    <div class=""col-3 col-sm-3 col-m-3 col-lg-3 col-xl-3"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""card-title text-center fs-xl"">Performance</div>
                <div class=""card-title text-center"">
                    <h1 class=""tex");
            WriteLiteral(@"t-info"">4,56%</h1>
                    <span class=""text-dark fs-xs"">Rentabilidade do Portfolio Atual</span>

                </div>

                <table class=""table table-sm w-100"">
                    <tbody>
                        <tr>
                            <td>Patrimonio</td>
                            <td class=""text-right"">2,500.00</td>
                        </tr>
                        <tr>
                            <td>Custo da aquisi????o</td>
                            <td class=""text-right"">3,500.00</td>
                        </tr>
                        <tr>
                            <td>Proventos acumulados</td>
                            <td class=""text-right"">3,500.00</td>
                        </tr>
                        <tr>
                            <td>Lucro com opera????es</td>
                            <td class=""text-right"">3,500.00</td>
                        </tr>
                        <tr>
                            <td class=""te");
            WriteLiteral(@"xt-dark font-weight-bold"">Lucro</td>
                            <td class=""text-right text-info""><h3>100.00</h3></td>
                        </tr>
                    </tbody>
                </table>
                <div class=""text-right"">
                    <a href=""#"" class=""btn btn-sm btn-info bg-info-100 bg-info-gradient back"" data-toggle=""modal"" data-target=""#default-example-modal-center"">New Order</a>
                </div>
                <!-- Modal -->
                <div class=""modal fade"" id=""default-example-modal-center"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
                    <div class=""modal-dialog modal-lg"" role=""document"">
                        <div class=""modal-content"">
                            <div class=""modal-header bg-info-100 bg-info-gradient"">
                                <h4 class=""modal-title"">
                                    New Order
                                </h4>
                                <button type=""button"" class=""close""");
            WriteLiteral(@" data-dismiss=""modal"" aria-label=""Close"">
                                    <span aria-hidden=""true""><i class=""fal fa-times""></i></span>
                                </button>
                            </div>
                            <div class=""modal-body"">
                                <div class=""panel-content"">
                                    <div class=""btn-group btn-group-toggle"" data-toggle=""buttons"">
                                        <label class=""btn btn-success active"">
                                            <span class=""fal fa-money-bill mr-1""></span>
                                            <input type=""radio"" name=""options"" id=""option1"" checked=""checked""> Buy
                                        </label>
                                        <label class=""btn btn-danger"">
                                            <span class=""fal fa-envelope-open-dollar mr-1""></span>
                                            <input type=""radio"" name=""options"" id");
            WriteLiteral(@"=""option3""> Sell
                                        </label>
                                    </div>
                                    <hr />
                                    <div class=""row"">
                                        <div class=""form-group col-md-12"">
                                            <label class=""form-label"" for=""example-select"">Portfolio</label>
                                            <select class=""form-control"" id=""example-select"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7408c749ce7e8d53d4d0740df81c18cc7cdb131d8562", async() => {
                WriteLiteral("1");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7408c749ce7e8d53d4d0740df81c18cc7cdb131d9563", async() => {
                WriteLiteral("2");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7408c749ce7e8d53d4d0740df81c18cc7cdb131d10564", async() => {
                WriteLiteral("3");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7408c749ce7e8d53d4d0740df81c18cc7cdb131d11566", async() => {
                WriteLiteral("4");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7408c749ce7e8d53d4d0740df81c18cc7cdb131d12568", async() => {
                WriteLiteral("5");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </select>
                                        </div>
                                        <div class=""form-group col-md-12"">
                                            <div class=""input-group flex-nowrap"">
                                                <input id=""addon-wrapping-right"" type=""text"" class=""form-control"" placeholder=""Stock"" aria-label=""Username"" aria-describedby=""addon-wrapping-right"">
                                                <div class=""input-group-append"">
                                                    <span class=""input-group-text""><i class=""fal fa-search fs-xl""></i></span>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""form-group col-md-3"">
                                            <label>Date</label>
                                            <div class=""i");
            WriteLiteral(@"nput-group"">
                                                <input type=""text"" class=""form-control "" id=""datepicker-4-4"">
                                                <div class=""input-group-append"">
                                                    <span class=""input-group-text fs-xl"">
                                                        <i class=""fal fa-calendar-plus""></i>
                                                    </span>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""form-group col-md-3"">
                                            <label>Quantity</label>
                                            <input type=""text"" class=""form-control "" placeholder=""1,000.0000""");
            BeginWriteAttribute("id", " id=\"", 7095, "\"", 7100, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>
                                        <div class=""form-group col-md-3"">
                                            <label>Unit Price</label>
                                            <input type=""text"" class=""form-control "" placeholder=""1,000.00""");
            BeginWriteAttribute("id", " id=\"", 7405, "\"", 7410, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>
                                        <div class=""form-group col-md-3"">
                                            <label>Comission</label>
                                            <input type=""text"" class=""form-control "" placeholder=""1,000.00""");
            BeginWriteAttribute("id", " id=\"", 7714, "\"", 7719, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>
                                    </div>
                                    <div class=""row text-right"">
                                        <div class=""form-group col-md-12"">
                                            <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                                            <button type=""button"" class=""btn btn-primary"">Save</button>
                                        </div>
                                    </div>

                                </div>
                            </div>
");
            WriteLiteral(@"                        </div>
                    </div>
                </div>
            </div>
        </div>

        <hr />
        <div class=""card"">
            <div class=""card-body"">
                <div class=""card-title text-center fs-xl"">Historico de Aportes</div>
                <div class=""card-body"">
                    <div id=""barChart"" style=""width:100%; height:300px;""></div>
                </div>
                <div class=""card-footer text-center"">
                    <h1 class=""text-info"">$2,212.00</h1>
                    <span class=""text-dark fs-xs"">Total</span>
                </div>
            </div>
        </div>

        <hr />
        <div class=""card"">
            <div class=""card-body"">
                <div class=""card-title text-center fs-xl""> Display as Pie Chart</div>
                <div class=""card-body"">
                    <div id=""pieChart"" style=""width:100%; height:300px;""></div>
                    <div class=""text-right"">
              ");
            WriteLiteral(@"          <button id=""pieChartUnload"" onclick=""pieChartUnload();"" class=""btn btn-sm btn-dark ml-auto"">Unload Data</button>
                    </div>
                </div>
            </div>
        </div>

    </div>
    <div class=""col-9 col-sm-9 col-m-9 col-lg-9 col-xl-9"">
        <div class=""card"">
            <div class=""card-header"">
                <ul class=""nav nav-pills"" role=""tablist"">
                    <li class=""nav-item""><a class=""nav-link bg-info-100 bg-info-gradient back active"" data-toggle=""tab"" href=""#js_pill_border_icon-1""><i class=""fal fa-home mr-1""></i>Home</a></li>&nbsp;&nbsp;
                    <li class=""nav-item""><a class=""nav-link bg-info-100 bg-info-gradient back"" data-toggle=""tab"" href=""#js_pill_border_icon-2""><i class=""fal fa-user mr-1""></i>Profile</a></li>&nbsp;&nbsp;
                    <li class=""nav-item""><a class=""nav-link bg-info-100 bg-info-gradient back"" data-toggle=""tab"" href=""#js_pill_border_icon-3""><i class=""fal fa-clock mr-1""></i>Time</a></li>&nbsp;&nb");
            WriteLiteral(@"sp;
                    <li class=""nav-item""><a class=""nav-link bg-info-100 bg-info-gradient back"" data-toggle=""tab"" href=""#js_pill_border_icon-4""><i class=""fal fa-chart-pie mr-1""></i>Chart</a></li>
                </ul>
            </div>
            <div class=""card-body"">
                <div class=""tab-content py-3"">
                    <div class=""tab-pane fade show active"" id=""js_pill_border_icon-1"" role=""tabpanel"">
                        Raw denim you probably haven't heard of them jean shorts Austin. Nesciunt tofu stumptown aliqua, retro synth master cleanse. Mustache cliche tempor, williamsburg carles vegan helvetica. Reprehenderit butcher retro keffiyeh dreamcatcher synth. Cosby sweater eu banh mi, qui irure terry richardson ex squid. Aliquip placeat salvia cillum iphone.
                    </div>
                    <div class=""tab-pane fade"" id=""js_pill_border_icon-2"" role=""tabpanel"">
                        Food truck fixie locavore, accusamus mcsweeney's marfa nulla single-origin cof");
            WriteLiteral(@"fee squid. Exercitation +1 labore velit, blog sartorial PBR leggings next level wes anderson artisan four loko farm-to-table craft beer twee. Qui photo booth letterpress, commodo enim craft beer mlkshk aliquip jean shorts ullamco ad vinyl cillum PBR. Homo nostrud organic.
                    </div>
                    <div class=""tab-pane fade"" id=""js_pill_border_icon-3"" role=""tabpanel"">
                        Etsy mixtape wayfarers, ethical wes anderson tofu before they sold out mcsweeney's organic lomo retro fanny pack lo-fi farm-to-table readymade. Messenger bag gentrify pitchfork tattooed craft beer, iphone skateboard locavore carles etsy salvia banksy hoodie helvetica. DIY synth PBR banksy irony. Leggings gentrify squid 8-bit cred pitchfork.
                    </div>
                    <div class=""tab-pane fade"" id=""js_pill_border_icon-4"" role=""tabpanel"">
                        Teste Emilio
                    </div>
                </div>
            </div>
        </div>
    </div>

</");
            WriteLiteral("div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"    <!--Date Picker-->
    <script>
        $('#datepicker-4-4').datepicker(
            {
                orientation: ""bottom right"",
                todayHighlight: true,
                templates: controls
            });
    </script>

    <!--Teste Bar Chart - Using C3.JS-->
    <script>
        var colors = [color.info._300];

        var colorsmix = [color.info._500, color.warning._500, color.success._500, color.danger._500, color.fusion._300]

        var barChart = c3.generate(
            {
                bindto: ""#barChart"",
                data:
                {
                    x: 'x',
                    columns: [
                        ['x', 'Jan', 'Feb', 'Mar', 'Apr', 'May'],
                        ['M??s', 100.00, 500.00, 300.00, 350.00, 380.00]
                    ],
                    type: 'bar'
                },
                color:
                {
                    pattern: colors
                },
                bar:
                {
");
                WriteLiteral(@"                    width:
                    {
                        ratio: 0.8 // this makes bar width 50% of length between ticks
                    }
                    // or
                    //width: 100 // this makes bar width 100px
                },
                axis: {
                    x: {
                        type: 'category'
                    }
                }
            });

    </script>

    <!--Teste Pie Chart-->
    <script>
         var TypeItem = ");
#nullable restore
#line 264 "C:\Projects\GitHub\WebApiChartsInvestV2\src\WebApiChartsInvestV2.Web\Views\Dashboard\Index.cshtml"
                   Write(typeSerializado);

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n            QtyItem = ");
#nullable restore
#line 265 "C:\Projects\GitHub\WebApiChartsInvestV2\src\WebApiChartsInvestV2.Web\Views\Dashboard\Index.cshtml"
                 Write(qtySerializado);

#line default
#line hidden
#nullable disable
                WriteLiteral(@";


        var colors = [color.success._500, color.danger._500, color.info._500, color.primary._500, color.warning._500];

        var pieChart = c3.generate(
            {
                bindto: ""#pieChart"",
                data:
                {
                    // iris data from R
                    columns: [
                        ['emilio', 30],
                        ['clarfy', 120],
                        [""setosa"", 0.2, 0.2, 0.2, 0.2, 0.2, 0.4, 0.3, 0.2, 0.2, 0.1, 0.2, 0.2, 0.1, 0.1, 0.2, 0.4, 0.4, 0.3, 0.3, 0.3, 0.2, 0.4, 0.2, 0.5, 0.2, 0.2, 0.4, 0.2, 0.2, 0.2, 0.2, 0.4, 0.1, 0.2, 0.2, 0.2, 0.2, 0.1, 0.2, 0.2, 0.3, 0.3, 0.2, 0.6, 0.4, 0.3, 0.2, 0.2, 0.2, 0.2],
                        [""versicolor"", 1.4, 1.5, 1.5, 1.3, 1.5, 1.3, 1.6, 1.0, 1.3, 1.4, 1.0, 1.5, 1.0, 1.4, 1.3, 1.4, 1.5, 1.0, 1.5, 1.1, 1.8, 1.3, 1.5, 1.2, 1.3, 1.4, 1.4, 1.7, 1.5, 1.0, 1.1, 1.0, 1.2, 1.6, 1.5, 1.6, 1.5, 1.3, 1.3, 1.3, 1.2, 1.4, 1.2, 1.0, 1.3, 1.2, 1.3, 1.3, 1.1, 1.3],
                        [""vir");
                WriteLiteral(@"ginica"", 2.5, 1.9, 2.1, 1.8, 2.2, 2.1, 1.7, 1.8, 1.8, 2.5, 2.0, 1.9, 2.1, 2.0, 2.4, 2.3, 1.8, 2.2, 2.3, 1.5, 2.3, 2.0, 2.0, 1.8, 2.1, 1.8, 1.8, 1.8, 2.1, 1.6, 1.9, 2.0, 2.2, 1.5, 1.4, 2.3, 2.4, 1.8, 1.8, 2.1, 2.4, 2.3, 1.9, 2.3, 2.5, 2.3, 1.9, 2.0, 2.3, 1.8],
                    ],
                    type: 'pie' //,
                    /*onclick: function (d, i) { console.log(""onclick"", d, i); },
                    onmouseover: function (d, i) { console.log(""onmouseover"", d, i); },
                    onmouseout: function (d, i) { console.log(""onmouseout"", d, i); }*/
                },
                color:
                {
                    pattern: colors
                }
            });

        //var pieChartUnload = function () {
        //    $(""#pieChartUnload"").attr(""disabled"", true);
        //    $(""#pieChartUnload"").text(""unloading datasets..."")
        //    setTimeout(function () {
        //        pieChart.unload(
        //            {
        //                ids: ");
                WriteLiteral(@"'virtigo'
        //            });
        //        pieChart.unload(
        //            {
        //                ids: 'clarfy'
        //            });
        //    }, 1000);
        //    setTimeout(function () {
        //        $(""#pieChartUnload"").text(""unload complete"")
        //    }, 2000);
        //};
    </script>



    <!-- ChartPie Funciona o retorno mas n~ao redeniza o chart-->
    <script>
        toastr.options = {
            ""closeButton"": true,
            ""debug"": true,
            ""newestOnTop"": true,
            ""progressBar"": true,
            ""positionClass"": ""toast-top-right"",
            ""preventDuplicates"": true,
            ""onclick"": null,
            ""showDuration"": 300,
            ""hideDuration"": 100,
            ""timeOut"": 5000,
            ""extendedTimeOut"": 1000,
            ""showEasing"": ""swing"",
            ""hideEasing"": ""linear"",
            ""showMethod"": ""fadeIn"",
            ""hideMethod"": ""fadeOut""
        }


        $(do");
                WriteLiteral(@"cument).ready(function () {
            $.ajax({
                type: ""GET"",
                url: ""/Dashboard/GetData"",
                data: {},
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
                success: function (response) {
                    successFunc(response);
                },
                error: function (jqXHR, textStatus, errorThrown) {
                    toastr[""error""](""Error in ploted chart."");
                }
            });

            //teste
            function successFunc(jsondata) {
                toastr[""success""](""Success in ploted chart. Emilio Message"");
                var data = {};
                var TypePesquisa = [];

                jsondata.forEach(function (e) {
                    TypePesquisa.push(e.Type);
                    data[e.Type] = e.Qty;
                })


                var pieChart = c3.generate(
                    {
                        bindto: ""#cont");
                WriteLiteral(@"ainer1"",
                        data:
                        {
                            // iris data from R
                            columns: [
                                //jsondata.forEach(function (e) {
                                //    [e.Type, e.Qty];,
                                //})

                                [""Test"", 10],
                                [""Test2"", 50],
                                [""Test3"", 40],

                            ],
                            type: 'pie'
                        },
                        color:
                        {
                            pattern: colors
                        }
                    });

            }


        });
    </script>


    <!--Este esta funcionando-->
    <script>
        var TypeItem = ");
#nullable restore
#line 396 "C:\Projects\GitHub\WebApiChartsInvestV2\src\WebApiChartsInvestV2.Web\Views\Dashboard\Index.cshtml"
                  Write(typeSerializado);

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n         QtyItem = ");
#nullable restore
#line 397 "C:\Projects\GitHub\WebApiChartsInvestV2\src\WebApiChartsInvestV2.Web\Views\Dashboard\Index.cshtml"
              Write(qtySerializado);

#line default
#line hidden
#nullable disable
                WriteLiteral(@";

        $(document).ready(function () {
                var config = {
                    type: 'pie',
                    data:
                    {
                        labels: TypeItem,
                        datasets: [{
                                data: QtyItem,
                                backgroundColor: [
                                    color.primary._200,
                                    color.primary._400,
                                    color.success._50
                                ],
                                label: 'My dataset' // for legend
                            }]

                    },
                    options:
                    {
                        responsive: true,
                        legend:
                        {
                            display: true,
                            position: 'bottom',
                        }
                    }
                };
                new Chart($(""#pi");
                WriteLiteral(@"eChart2 > canvas"").get(0).getContext(""2d""), config);
        });
    </script>

    <script>
        var pieChart3 = function () {
            var config = {
                type: 'pie',
                data:
                {
                    datasets: [
                        {
                            data: [
                                11,
                                16,
                                7,
                                3,
                                14
                            ],
                            backgroundColor: [
                                color.primary._200,
                                color.primary._400,
                                color.success._50,
                                color.success._300,
                                color.success._500
                            ],
                            label: 'My dataset' // for legend
                        }],
                    labels: [
          ");
                WriteLiteral(@"              ""USA"",
                        ""Germany"",
                        ""Austalia"",
                        ""Canada"",
                        ""France""
                    ]
                },
                options:
                {
                    responsive: true,
                    legend:
                    {
                        display: true,
                        position: 'bottom',
                    }
                }
            };
            new Chart($(""#pieChart3 > canvas"").get(0).getContext(""2d""), config);
        }

        $(document).ready(function () {
            pieChart3();
        });
    </script>

");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
