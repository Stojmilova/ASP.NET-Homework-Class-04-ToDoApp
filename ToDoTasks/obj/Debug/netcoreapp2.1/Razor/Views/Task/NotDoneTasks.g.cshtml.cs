#pragma checksum "C:\Users\Stojmilova\Desktop\ASP.NET MVC\Homework - Class 4\ToDoApp\ToDoTasks\Views\Task\NotDoneTasks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5b5725e0c38221d8210f9f9c398c13919eca011"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_NotDoneTasks), @"mvc.1.0.view", @"/Views/Task/NotDoneTasks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Task/NotDoneTasks.cshtml", typeof(AspNetCore.Views_Task_NotDoneTasks))]
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
#line 1 "C:\Users\Stojmilova\Desktop\ASP.NET MVC\Homework - Class 4\ToDoApp\ToDoTasks\Views\_ViewImports.cshtml"
using ToDoTasks.Models.DomainModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5b5725e0c38221d8210f9f9c398c13919eca011", @"/Views/Task/NotDoneTasks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64cda02f794e1cf490298f810faf5e417324ad8f", @"/Views/_ViewImports.cshtml")]
    public class Views_Task_NotDoneTasks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Stojmilova\Desktop\ASP.NET MVC\Homework - Class 4\ToDoApp\ToDoTasks\Views\Task\NotDoneTasks.cshtml"
  
    ViewBag.Title = "Not Done Tasks";

#line default
#line hidden
            BeginContext(59, 6, true);
            WriteLiteral("\r\n<h3>");
            EndContext();
            BeginContext(66, 13, false);
#line 6 "C:\Users\Stojmilova\Desktop\ASP.NET MVC\Homework - Class 4\ToDoApp\ToDoTasks\Views\Task\NotDoneTasks.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(79, 58, true);
            WriteLiteral("</h3>\r\n<table>\r\n    <thead>\r\n\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 12 "C:\Users\Stojmilova\Desktop\ASP.NET MVC\Homework - Class 4\ToDoApp\ToDoTasks\Views\Task\NotDoneTasks.cshtml"
         foreach (var task in Model.CreatedTasks)
        {
            if (task.Status == TypeStatus.NotDone)
            {

#line default
#line hidden
            BeginContext(266, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(339, 10, false);
#line 18 "C:\Users\Stojmilova\Desktop\ASP.NET MVC\Homework - Class 4\ToDoApp\ToDoTasks\Views\Task\NotDoneTasks.cshtml"
                   Write(task.Title);

#line default
#line hidden
            EndContext();
            BeginContext(349, 4, true);
            WriteLiteral(" => ");
            EndContext();
            BeginContext(354, 13, false);
#line 18 "C:\Users\Stojmilova\Desktop\ASP.NET MVC\Homework - Class 4\ToDoApp\ToDoTasks\Views\Task\NotDoneTasks.cshtml"
                                  Write(task.TaskType);

#line default
#line hidden
            EndContext();
            BeginContext(367, 4, true);
            WriteLiteral(" => ");
            EndContext();
            BeginContext(372, 13, false);
#line 18 "C:\Users\Stojmilova\Desktop\ASP.NET MVC\Homework - Class 4\ToDoApp\ToDoTasks\Views\Task\NotDoneTasks.cshtml"
                                                    Write(task.Priority);

#line default
#line hidden
            EndContext();
            BeginContext(385, 80, true);
            WriteLiteral("\r\n                        <div> Sub Tasks:</div>\r\n                        <ul>\r\n");
            EndContext();
#line 21 "C:\Users\Stojmilova\Desktop\ASP.NET MVC\Homework - Class 4\ToDoApp\ToDoTasks\Views\Task\NotDoneTasks.cshtml"
                             foreach (var subTask in task.SubTasks)
                            {

#line default
#line hidden
            BeginContext(565, 43, true);
            WriteLiteral("                                <li>Title: ");
            EndContext();
            BeginContext(609, 13, false);
#line 23 "C:\Users\Stojmilova\Desktop\ASP.NET MVC\Homework - Class 4\ToDoApp\ToDoTasks\Views\Task\NotDoneTasks.cshtml"
                                      Write(subTask.Title);

#line default
#line hidden
            EndContext();
            BeginContext(622, 17, true);
            WriteLiteral(" => Description: ");
            EndContext();
            BeginContext(640, 19, false);
#line 23 "C:\Users\Stojmilova\Desktop\ASP.NET MVC\Homework - Class 4\ToDoApp\ToDoTasks\Views\Task\NotDoneTasks.cshtml"
                                                                     Write(subTask.Description);

#line default
#line hidden
            EndContext();
            BeginContext(659, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 24 "C:\Users\Stojmilova\Desktop\ASP.NET MVC\Homework - Class 4\ToDoApp\ToDoTasks\Views\Task\NotDoneTasks.cshtml"
                            }

#line default
#line hidden
            BeginContext(697, 85, true);
            WriteLiteral("                        </ul>\r\n                    </td>    \r\n                </tr>\r\n");
            EndContext();
#line 28 "C:\Users\Stojmilova\Desktop\ASP.NET MVC\Homework - Class 4\ToDoApp\ToDoTasks\Views\Task\NotDoneTasks.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(808, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
