// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorComponent.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\SMS\source\repos\BlazorComponent\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SMS\source\repos\BlazorComponent\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SMS\source\repos\BlazorComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\SMS\source\repos\BlazorComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\SMS\source\repos\BlazorComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\SMS\source\repos\BlazorComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\SMS\source\repos\BlazorComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\SMS\source\repos\BlazorComponent\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\SMS\source\repos\BlazorComponent\_Imports.razor"
using BlazorComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\SMS\source\repos\BlazorComponent\_Imports.razor"
using BlazorComponent.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/vote")]
    public partial class Vote : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\SMS\source\repos\BlazorComponent\Pages\Vote.razor"
        private String voteCount = "";
            private int voteValue;
            public String name;
            private Boolean btnFlag = false;
            private String message;

            private void VoteCount()
            {
                btnFlag = true;

                if (voteValue > 5)
                {

                    voteCount = "Invalid - Number should not be greater than 5";
                    message = "";
                }
                else if (voteValue < 1)
                {
                    voteCount = "Invalid - Number should not be less than 1";
                    message = "";
                }
                else
                {
                    if (btnFlag)
                    {
                        voteCount = voteValue.ToString();
                        message = "Thank you for your vote!";

                    }
                }
            } 

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591