#pragma checksum "E:\Code C# Tasklar\eNno\eNno\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76afef5a24f0cfa2576e44bf041aee7bd243b10d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "E:\Code C# Tasklar\eNno\eNno\Views\_ViewImports.cshtml"
using eNno;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Code C# Tasklar\eNno\eNno\Views\_ViewImports.cshtml"
using eNno.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76afef5a24f0cfa2576e44bf041aee7bd243b10d", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7415060a96a4e28a5e50b64b1d6bc9c28ecce594", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76afef5a24f0cfa2576e44bf041aee7bd243b10d5016", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Document</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "76afef5a24f0cfa2576e44bf041aee7bd243b10d5488", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <link rel=""preconnect"" href=""https://fonts.googleapis.com"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
    <link href=""https://fonts.googleapis.com/css2?family=Poppins:wght@100&family=Quicksand:wght@300&family=Raleway:ital,wght@0,400;1,600&family=Signika:wght@300&display=swap"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.15.4/css/all.css"" integrity=""sha384-DyZ88mC6Up2uqS4h/KRgHuoeGwBcD4Ng9SiP4dIRy0EXTlnuz47vAwmeGwVChigm"" crossorigin=""anonymous"">
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76afef5a24f0cfa2576e44bf041aee7bd243b10d8148", async() => {
                WriteLiteral(@"
    <nav class=""navbar navbar-expand-lg"">
        <div class=""container"">
            <a class=""navbar-brand"" href=""#"">eNno</a>
            <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                <ul class=""navbar-nav ms-auto"">
                    <li class=""nav-item"">
                        <a class=""nav-link active"" aria-current=""page"" href=""#"">Home</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link active"" aria-current=""page"" href=""#"">About</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link active"" aria-current=""page"" href=""#"">Services</a>
    ");
                WriteLiteral(@"                </li>
                    <li class=""nav-item"">
                        <a class=""nav-link active"" aria-current=""page"" href=""#"">Portfolio</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link active"" aria-current=""page"" href=""#"">Team</a>
                    </li>
                    <li class=""nav-item dropdown"">
                        <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown"" role=""button"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                            Dropdown
                        </a>
                        <ul class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">
                            <li><a class=""dropdown-item"" href=""#"">Action</a></li>
                            <li><a class=""dropdown-item"" href=""#"">Another action</a></li>
                            <li><hr class=""dropdown-divider""></li>
                            <li><a class=""dropdown-item"" href=""#"">Something ");
                WriteLiteral(@"else here</a></li>
                        </ul>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link active"" aria-current=""page"" href=""#"">Contact</a>
                    </li>
                </ul>
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76afef5a24f0cfa2576e44bf041aee7bd243b10d10913", async() => {
                    WriteLiteral("\r\n                    <button class=\"btn btn-outline-success\" type=\"submit\">Get Started</button>\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </div>
        </div>
    </nav>

    <header>

        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-6"">
                    <div class=""title"">
                        <h2>Elegant and creative solutions</h2>
                    </div>
                    <div class=""desc"">
                        <p>Lorem ipsum dolor, sit amet consectetur adipisicing elit. Suscipit minus autem nemo officia aspernatur provident beatae quia aperiam nam odio.</p>
                    </div>
                    <div class=""headerbtn"">
                        <a href=""#"">Get Started</a>
                    </div>
                </div>
                <div class=""col-lg-6"">
                    <div class=""image"">
                        <img class=""img-fluid"" src=""https://bootstrapmade.com/demo/templates/eNno/assets/img/hero-img.png""");
                BeginWriteAttribute("alt", " alt=\"", 4431, "\"", 4437, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </header>\r\n    ");
#nullable restore
#line 84 "E:\Code C# Tasklar\eNno\eNno\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <footer>
        <div class=""container"" style=""width: 660px;"">
            <div class=""row head text-center"">
                <div class=""col-lg-12"">
                    <div class=""title"">
                        <h1>eNno</h1>
                    </div>

                    <div class=""desc"">
                        <p>
                            Et aut eum quis fuga eos sunt ipsa nihil. Labore corporis magni eligendi fuga maxime saepe
                            commodi placeat.
                        </p>
                    </div>


                </div>
            </div>

            <div class=""mail"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76afef5a24f0cfa2576e44bf041aee7bd243b10d14478", async() => {
                    WriteLiteral(@"
                    <div class=""input-group mb-3"">
                        <input type=""text"" class=""form-control"" placeholder=""Enter Your Email""
                               aria-label=""Recipient's username"" aria-describedby=""button-addon2"">
                        <button class=""btn btn-outline-secondary"" type=""button"" id=""button-addon2"">Subscribe</button>
                    </div>
                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </div>

            <div class=""socialFooter d-flex justify-content-center"">
                <ul class=""d-flex"">
                    <li>
                        <a href=""#"">
                            <i class=""fab fa-twitter""></i>
                        </a>
                    </li>
                    <li>
                        <a href=""#"">
                            <i class=""fab fa-facebook-f""></i>
                        </a>
                    </li>
                    <li>
                        <a href=""#"">
                            <i class=""fab fa-instagram""></i>
                        </a>
                    </li>
                    <li>
                        <a href=""#"">
                            <i class=""fab fa-skype""></i>
                        </a>
                    </li>
                    <li>
                        <a href=""#"">
                            <i class=""fab fa-linkedin-in""></i>
                        </a>
        ");
                WriteLiteral(@"            </li>
                </ul>
            </div>
        </div>

        <div class=""container copyRightDesigned"">
            <div class=""row d-flex align-items-center"">
                <div class=""col-lg-6"">
                    <div class=""copyRight"">
                        <span>© Copyright <strong>eNno</strong>. All Rights Reserved</span>
                    </div>
                </div>
                <div class=""col-lg-6 d-flex justify-content-end"">
                    <div class=""designed "">
                        <span>Designed by <a href=""#"">BootstrapMade</a></span>
                    </div>
                </div>
            </div>
        </div>

    </footer>



    <!-- JavaScript Bundle with Popper -->
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p"" crossorigin=""anonymous""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
