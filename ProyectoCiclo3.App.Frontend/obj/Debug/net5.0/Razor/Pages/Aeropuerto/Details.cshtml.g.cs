#pragma checksum "D:\Mision_Tic_ciclo_3\ejercicio_base_ciclo3_MT-main\mision_tic\ProyectoCiclo3.App.Frontend\Pages\Aeropuerto\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c8c2c97f0c5acc2e957b76f72b4f3d7774705cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProyectoCiclo3.App.Frontend.Pages.Aeropuerto.Pages_Aeropuerto_Details), @"mvc.1.0.razor-page", @"/Pages/Aeropuerto/Details.cshtml")]
namespace ProyectoCiclo3.App.Frontend.Pages.Aeropuerto
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
#line 1 "D:\Mision_Tic_ciclo_3\ejercicio_base_ciclo3_MT-main\mision_tic\ProyectoCiclo3.App.Frontend\Pages\_ViewImports.cshtml"
using ProyectoCiclo3.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c8c2c97f0c5acc2e957b76f72b4f3d7774705cf", @"/Pages/Aeropuerto/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0cfd9bc5bff4f4085d3be4adaa6cbe2c60ca0c2", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Aeropuerto_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Mision_Tic_ciclo_3\ejercicio_base_ciclo3_MT-main\mision_tic\ProyectoCiclo3.App.Frontend\Pages\Aeropuerto\Details.cshtml"
  
    var aeropuerto = Model.Aeropuerto;

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n<ul class=\"list-group list-group-flush\">\r\n  <li class=\"list-group-item\"> <b>Id: </b>");
#nullable restore
#line 8 "D:\Mision_Tic_ciclo_3\ejercicio_base_ciclo3_MT-main\mision_tic\ProyectoCiclo3.App.Frontend\Pages\Aeropuerto\Details.cshtml"
                                     Write(aeropuerto.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\"> <b>Nombre: </b>");
#nullable restore
#line 9 "D:\Mision_Tic_ciclo_3\ejercicio_base_ciclo3_MT-main\mision_tic\ProyectoCiclo3.App.Frontend\Pages\Aeropuerto\Details.cshtml"
                                         Write(aeropuerto.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\"> <b>Ciudad: </b>");
#nullable restore
#line 10 "D:\Mision_Tic_ciclo_3\ejercicio_base_ciclo3_MT-main\mision_tic\ProyectoCiclo3.App.Frontend\Pages\Aeropuerto\Details.cshtml"
                                         Write(aeropuerto.ciudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\"><b>Pais: </b>");
#nullable restore
#line 11 "D:\Mision_Tic_ciclo_3\ejercicio_base_ciclo3_MT-main\mision_tic\ProyectoCiclo3.App.Frontend\Pages\Aeropuerto\Details.cshtml"
                                      Write(aeropuerto.pais);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\"><b>Coordenadas X: </b>");
#nullable restore
#line 12 "D:\Mision_Tic_ciclo_3\ejercicio_base_ciclo3_MT-main\mision_tic\ProyectoCiclo3.App.Frontend\Pages\Aeropuerto\Details.cshtml"
                                               Write(aeropuerto.coord_x);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\"><b>Coordenadas Y: </b>");
#nullable restore
#line 13 "D:\Mision_Tic_ciclo_3\ejercicio_base_ciclo3_MT-main\mision_tic\ProyectoCiclo3.App.Frontend\Pages\Aeropuerto\Details.cshtml"
                                               Write(aeropuerto.coord_y);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ul>\t");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProyectoCiclo3.App.Frontend.Pages.DetailsAeropuertoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoCiclo3.App.Frontend.Pages.DetailsAeropuertoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoCiclo3.App.Frontend.Pages.DetailsAeropuertoModel>)PageContext?.ViewData;
        public ProyectoCiclo3.App.Frontend.Pages.DetailsAeropuertoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
