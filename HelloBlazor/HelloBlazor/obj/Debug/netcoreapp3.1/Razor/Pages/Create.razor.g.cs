#pragma checksum "C:\Users\Thomas\Documents\Computer Science\C#\Blazor\Blazor-Docker-Linux\HelloBlazor\HelloBlazor\Pages\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7973c3e6156d96609c5a558c9471b20981ffbd8a"
// <auto-generated/>
#pragma warning disable 1591
namespace HelloBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Thomas\Documents\Computer Science\C#\Blazor\Blazor-Docker-Linux\HelloBlazor\HelloBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Thomas\Documents\Computer Science\C#\Blazor\Blazor-Docker-Linux\HelloBlazor\HelloBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Thomas\Documents\Computer Science\C#\Blazor\Blazor-Docker-Linux\HelloBlazor\HelloBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Thomas\Documents\Computer Science\C#\Blazor\Blazor-Docker-Linux\HelloBlazor\HelloBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Thomas\Documents\Computer Science\C#\Blazor\Blazor-Docker-Linux\HelloBlazor\HelloBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Thomas\Documents\Computer Science\C#\Blazor\Blazor-Docker-Linux\HelloBlazor\HelloBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Thomas\Documents\Computer Science\C#\Blazor\Blazor-Docker-Linux\HelloBlazor\HelloBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Thomas\Documents\Computer Science\C#\Blazor\Blazor-Docker-Linux\HelloBlazor\HelloBlazor\_Imports.razor"
using HelloBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Thomas\Documents\Computer Science\C#\Blazor\Blazor-Docker-Linux\HelloBlazor\HelloBlazor\_Imports.razor"
using HelloBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Thomas\Documents\Computer Science\C#\Blazor\Blazor-Docker-Linux\HelloBlazor\HelloBlazor\Pages\Create.razor"
using System.Runtime.InteropServices;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/create")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Create Text File</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<label>Filename:</label>\r\n");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "class", "form-control");
            __builder.AddAttribute(4, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "C:\Users\Thomas\Documents\Computer Science\C#\Blazor\Blazor-Docker-Linux\HelloBlazor\HelloBlazor\Pages\Create.razor"
              fileName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => fileName = __value, fileName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n<br>\r\n");
            __builder.AddMarkupContent(7, "<label>Text:</label>\r\n");
            __builder.OpenElement(8, "textarea");
            __builder.AddAttribute(9, "rows", "5");
            __builder.AddAttribute(10, "class", "form-control");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\Thomas\Documents\Computer Science\C#\Blazor\Blazor-Docker-Linux\HelloBlazor\HelloBlazor\Pages\Create.razor"
                 text

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => text = __value, text));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n<br>\r\n");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "class", "btn btn-primary");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\Thomas\Documents\Computer Science\C#\Blazor\Blazor-Docker-Linux\HelloBlazor\HelloBlazor\Pages\Create.razor"
                                          SubmitFile

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, "Submit File");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\Thomas\Documents\Computer Science\C#\Blazor\Blazor-Docker-Linux\HelloBlazor\HelloBlazor\Pages\Create.razor"
       
    private int currentCount = 72;
    private string fileName = "";
    private string text = "";
    private FileHelper fileHelper = new FileHelper();

    private void SubmitFile()
    {
        Console.WriteLine($"Text: {text}");
        Console.WriteLine("Submit File clicked");
        fileHelper.CreateFile(fileName, text);
    }

    public class FileHelper
    {
        private bool IsWindows() => RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
        private bool IsMacOS() => RuntimeInformation.IsOSPlatform(OSPlatform.OSX);
        private bool IsLinux() => RuntimeInformation.IsOSPlatform(OSPlatform.Linux);

        public string GetOperatingSystem()
        {
            string os = "";

            if (IsWindows())
            {
                os = "Windows";
            }
            else if (IsMacOS())
            {
                os = "Mac";
            }
            else if (IsLinux())
            {
                os = "Linux";
            }
            else
            {
                os = "Unknown";
            }

            return os;
        }


        public void CreateFile(string fileName, string textToWrite)
        {
            try
            {
                var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                // WriteAllText creates a file, writes the specified string to the file,
                // and then closes the file.    You do NOT need to call Flush() or Close().

                string filePath = "";
                string os = GetOperatingSystem();

                if (os == "Windows")
                {
                    filePath = $@"{path}\Computer Science\Blazor Generated Files\{fileName}";
                }
                else if (os == "Linux")
                {
                    filePath = $@"{path}\{fileName}";
                }

                System.IO.File.WriteAllText(filePath, textToWrite);
                Console.WriteLine("Successfully wrote to file!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591