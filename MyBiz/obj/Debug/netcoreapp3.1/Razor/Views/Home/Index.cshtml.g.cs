#pragma checksum "C:\Users\admin\Desktop\MyBiz\MyBiz\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "017a188eb3f57f29061f3df91ff5b05ad8d287aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\admin\Desktop\MyBiz\MyBiz\Views\_ViewImports.cshtml"
using MyBiz;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\admin\Desktop\MyBiz\MyBiz\Views\_ViewImports.cshtml"
using MyBiz.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"017a188eb3f57f29061f3df91ff5b05ad8d287aa", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"578ca992f97debacb0961a0402f6a3bd1f89b583", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Team>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\admin\Desktop\MyBiz\MyBiz\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "MyBiz Bootstrap Template";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Swiper -->
<div class=""swiper introSwiper"">
    <div class=""swiper-wrapper"">
        <div class=""swiper-slide"" style=""background: url(assets/img/slide-1.jpg);"">
            <div class=""slider-container"">
                <h1>Sequi ea ut et est quaerat</h1>
                <p>
                    Ut velit est quam dolor ad a aliquid qui aliquid. Sequi ea ut et est quaerat sequi nihil ut
                    aliquam.
                    Occaecati alias dolorem mollitia ut. Similique ea voluptatem. Esse doloremque accusamus
                    repellendus
                    deleniti vel. Minus et tempore modi architecto.
                </p>
                <button type=""button"">Read More</button>
            </div>
        </div>
        <div class=""swiper-slide"" style=""background: url(assets/img/slide-2.jpg);"">
            <div class=""slider-container"">
                <h1>Sequi ea ut et est quaerat</h1>
                <p>
                    Ut velit est quam dolor ad a aliquid qui ");
            WriteLiteral(@"aliquid. Sequi ea ut et est quaerat sequi nihil ut
                    aliquam.
                    Occaecati alias dolorem mollitia ut. Similique ea voluptatem. Esse doloremque accusamus
                    repellendus
                    deleniti vel. Minus et tempore modi architecto.
                </p>
                <button type=""button"">Read More</button>
            </div>
        </div>
        <div class=""swiper-slide"" style=""background: url(assets/img/slide-3.jpg);"">
            <div class=""slider-container"">
                <h1>Sequi ea ut et est quaerat</h1>
                <p>
                    Ut velit est quam dolor ad a aliquid qui aliquid. Sequi ea ut et est quaerat sequi nihil ut
                    aliquam.
                    Occaecati alias dolorem mollitia ut. Similique ea voluptatem. Esse doloremque accusamus
                    repellendus
                    deleniti vel. Minus et tempore modi architecto.
                </p>
                <button type=""button");
            WriteLiteral(@""">Read More</button>
            </div>
        </div>
    </div>
    <div class=""swiper-button-next pagination-arrow""></div>
    <div class=""swiper-button-prev pagination-arrow""></div>
    <div class=""swiper-pagination""></div>
</div>

<section class=""services"">
    <div class=""container"">
        <h1>SERVICES</h1>
        <p>Sit sint consectetur velit quisquam cupiditate impedit suscipit alias</p>
        <div class=""services-container"">
            <div class=""services-item-container"">
                <div class=""services-item"">
                    <div class=""left"">
                        <i class=""fa-solid fa-briefcase""></i>
                    </div>
                    <div class=""right"">
                        <h3>Lorem, ipsum.</h3>
                        <p>
                            Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint
                            occaecati cupiditate non provident
                        </p>
                  ");
            WriteLiteral(@"  </div>
                </div>
            </div>
            <div class=""services-item-container"">
                <div class=""services-item"">
                    <div class=""left"">
                        <i class=""fa-solid fa-chart-simple""></i>
                    </div>
                    <div class=""right"">
                        <h3>Lorem, ipsum.</h3>
                        <p>
                            Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint
                            occaecati cupiditate non provident
                        </p>
                    </div>
                </div>
            </div>
            <div class=""services-item-container"">
                <div class=""services-item"">
                    <div class=""left"">
                        <i class=""fa-solid fa-cookie-bite""></i>
                    </div>
                    <div class=""right"">
                        <h3>Lorem, ipsum.</h3>
                        <p>");
            WriteLiteral(@"
                            Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint
                            occaecati cupiditate non provident
                        </p>
                    </div>
                </div>
            </div>
            <div class=""services-item-container"">
                <div class=""services-item"">
                    <div class=""left"">
                        <i class=""fa-solid fa-rectangle-list""></i>
                    </div>
                    <div class=""right"">
                        <h3>Lorem, ipsum.</h3>
                        <p>
                            Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint
                            occaecati cupiditate non provident
                        </p>
                    </div>
                </div>
            </div>
            <div class=""services-item-container"">
                <div class=""services-item"">
                    <div ");
            WriteLiteral(@"class=""left"">
                        <i class=""fa-solid fa-sun""></i>
                    </div>
                    <div class=""right"">
                        <h3>Lorem, ipsum.</h3>
                        <p>
                            Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint
                            occaecati cupiditate non provident
                        </p>
                    </div>
                </div>
            </div>
            <div class=""services-item-container"">
                <div class=""services-item"">
                    <div class=""left"">
                        <i class=""fa-solid fa-calendar-days""></i>
                    </div>
                    <div class=""right"">
                        <h3>Lorem, ipsum.</h3>
                        <p>
                            Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint
                            occaecati cupiditate non provident
       ");
            WriteLiteral(@"                 </p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>


<section class=""team"">
    <div class=""container"">
        <h1>TEAM</h1>
        <p>Sit sint consectetur velit quisquam cupiditate impedit suscipit alias</p>
        <div class=""team-container"">
");
#nullable restore
#line 154 "C:\Users\admin\Desktop\MyBiz\MyBiz\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"team-item-container\">\r\n                    <div class=\"team-item\">\r\n                        <div class=\"left\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "017a188eb3f57f29061f3df91ff5b05ad8d287aa11697", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6799, "~/upload/", 6799, 9, true);
#nullable restore
#line 159 "C:\Users\admin\Desktop\MyBiz\MyBiz\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 6808, item.ImageSrc, 6808, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"right\">\r\n                            <h3 class=\"fullName\">");
#nullable restore
#line 162 "C:\Users\admin\Desktop\MyBiz\MyBiz\Views\Home\Index.cshtml"
                                            Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <div class=\"position\">");
#nullable restore
#line 163 "C:\Users\admin\Desktop\MyBiz\MyBiz\Views\Home\Index.cshtml"
                                             Write(item.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <div class=\"description\">\r\n                                ");
#nullable restore
#line 165 "C:\Users\admin\Desktop\MyBiz\MyBiz\Views\Home\Index.cshtml"
                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"social-media\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 7284, "\"", 7306, 1);
#nullable restore
#line 168 "C:\Users\admin\Desktop\MyBiz\MyBiz\Views\Home\Index.cshtml"
WriteAttributeValue("", 7291, item.Instagram, 7291, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <i class=\"fa-brands fa-instagram\"></i>\r\n                                </a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 7458, "\"", 7479, 1);
#nullable restore
#line 171 "C:\Users\admin\Desktop\MyBiz\MyBiz\Views\Home\Index.cshtml"
WriteAttributeValue("", 7465, item.Linkedin, 7465, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <i class=\"fa-brands fa-linkedin\"></i>\r\n                                </a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 7630, "\"", 7651, 1);
#nullable restore
#line 174 "C:\Users\admin\Desktop\MyBiz\MyBiz\Views\Home\Index.cshtml"
WriteAttributeValue("", 7637, item.Facebook, 7637, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <i class=\"fa-brands fa-facebook\"></i>\r\n                                </a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 7802, "\"", 7822, 1);
#nullable restore
#line 177 "C:\Users\admin\Desktop\MyBiz\MyBiz\Views\Home\Index.cshtml"
WriteAttributeValue("", 7809, item.Twitter, 7809, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <i class=\"fa-brands fa-twitter\"></i>\r\n                                </a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 184 "C:\Users\admin\Desktop\MyBiz\MyBiz\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
</section>


<section class=""contact"">
    <div class=""container"">
        <h1>CONTACT</h1>
        <p>Sit sint consectetur velit quisquam cupiditate impedit suscipit alias</p>

    </div>
    <div class=""map"">
        <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3039.748317523108!2d49.813257115705156!3d40.37010466639721!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x40307dc397d94dc3%3A0x617bc46b47244c00!2sAzerbaijan%20Technical%20University!5e0!3m2!1sen!2s!4v1656570795483!5m2!1sen!2s""
                style=""border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 8665, "\"", 8683, 0);
            EndWriteAttribute();
            WriteLiteral(@" loading=""lazy""
                referrerpolicy=""no-referrer-when-downgrade""></iframe>
    </div>
    <div class=""contact-cards"">
        <div class=""container"">

            <div class=""card-container"">
                <div class=""cardd"">
                    <div class=""left"">
                        <i class=""fa-solid fa-location-pin""></i>
                    </div>
                    <div class=""right"">
                        <h3>Location:</h3>
                        <p>A108 Adam Street</p>
                        <p>New York, NY 535022</p>
                    </div>
                </div>
                <div class=""cardd"">
                    <div class=""left"">
                        <i class=""fa-solid fa-envelope""></i>
                    </div>
                    <div class=""right"">
                        <h3>Email:</h3>
                        <p>info@example.com</p>
                        <p>info2@example.com</p>
                    </div>
                </div>
     ");
            WriteLiteral(@"           <div class=""cardd"">
                    <div class=""left"">
                        <i class=""fa-solid fa-phone""></i>
                    </div>
                    <div class=""right"">
                        <h3>Call:</h3>
                        <p>+1 5589 55488 51</p>
                        <p>+1 5589 55488 52</p>
                    </div>
                </div>
            </div>

            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "017a188eb3f57f29061f3df91ff5b05ad8d287aa18953", async() => {
                WriteLiteral(@"
                <div class=""input-group"">
                    <input type=""text"" placeholder=""Your Name"">
                    <input type=""text"" placeholder=""Your Email"">
                </div>
                <input type=""text"" placeholder=""Subject"">
                <textarea");
                BeginWriteAttribute("name", " name=\"", 10446, "\"", 10453, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 10454, "\"", 10459, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Message\"></textarea>\r\n                <div class=\"center-btn\">\r\n                    <button type=\"submit\">Send Message</button>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Team>> Html { get; private set; }
    }
}
#pragma warning restore 1591
