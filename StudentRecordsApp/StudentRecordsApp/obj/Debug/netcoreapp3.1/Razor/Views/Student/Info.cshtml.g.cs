#pragma checksum "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acb704745d7320ba4fa0f096d3e49b86ba924011"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Info), @"mvc.1.0.view", @"/Views/Student/Info.cshtml")]
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
#line 1 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\_ViewImports.cshtml"
using StudentRecordsApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\_ViewImports.cshtml"
using StudentRecordsApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acb704745d7320ba4fa0f096d3e49b86ba924011", @"/Views/Student/Info.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af852e96bdcc0aefcdb8389cabbdf36487512e73", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Info : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentRecordsApp.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Student</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
       Write(Html.DisplayNameFor(model => model.StudentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
       Write(Html.DisplayFor(model => model.StudentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
       Write(Html.DisplayNameFor(model => model.MiddleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
       Write(Html.DisplayFor(model => model.MiddleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd>

        <center>
            <div>
                <h5>Grades</h5>
                <dl class=""row"">


                    <!--PRELIM-->
                    <div class=""table TablePrelim"">

                        <table class="" w-75 Prelim"">
                            <thead class=""thead-dark"">
                                <tr>
                                    <th colspan=""2"">Preliminary</th>
                                    <th></th>
                                    <th></th>
                                    <th></th>
                                </tr>
                            </thead>
                            <thead class=""thead-light"">
                                <tr>
                                    <th> </th>
                                    <th>1</th>
                                    <th>2</th>
                                    <th>3</th>
                                    <th style=""font-weight:bold;"">Average</th>
    ");
            WriteLiteral("                            </tr>\r\n                            </thead>\r\n");
#nullable restore
#line 77 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                             foreach (var item in Model.Grades)
                            {
                                double totalPrelimQuiz = item.Prelim_Quiz1 + item.Prelim_Quiz2 + item.Prelim_Quiz3;
                                double averagePrelimQuiz = totalPrelimQuiz / 3;
                                double roundedAveQuiz = Math.Round((double)averagePrelimQuiz, 2);

                                double totalPrelimAssign = item.Prelim_Assign1 + item.Prelim_Assign2 + item.Prelim_Assign3;
                                double averagePrelimAssign = totalPrelimAssign / 3;
                                double roundedAveAssign = Math.Round((double)averagePrelimAssign, 2);

                                double prelimTotal = averagePrelimQuiz + averagePrelimAssign;
                                double PrelimGradeAve = Math.Round((double)prelimTotal / 2, 2);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tbody>\r\n                                    <tr>\r\n                                        <td style=\"font-weight:bold;\">Quizzes</td>\r\n                                        <td>");
#nullable restore
#line 92 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Prelim_Quiz1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 93 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Prelim_Quiz2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 94 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Prelim_Quiz3));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 95 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                                       Write(Html.DisplayFor(modelItem => roundedAveQuiz));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n                                    <tr>\r\n                                        <td style=\"font-weight:bold;\">Assignments</td>\r\n                                        <td>");
#nullable restore
#line 99 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Prelim_Assign1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 100 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Prelim_Assign2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 101 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Prelim_Assign3));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 102 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                                       Write(Html.DisplayFor(modelItem => roundedAveAssign));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                    </tr>
                                    <tr class=""bg-secondary text-light"">
                                        <td style=""font-weight:bold;"" colspan=""4"">Prelim Grade</td>
                                        <td style=""font-weight:bold;"">");
#nullable restore
#line 106 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                                                                 Write(Html.DisplayFor(modelItem => PrelimGradeAve));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n                                </tbody>\r\n");
#nullable restore
#line 109 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </table>
                    </div>
                    <!---->
                    <!--MIDTERMS-->
                    <div class=""table TableMidterm"">

                        <table class="" w-75 Midterm"">
                            <thead class=""thead-dark"">
                                <tr>
                                    <th colspan=""2"">Midterm</th>
                                    <th></th>
                                    <th></th>
                                    <th></th>
                                </tr>
                            </thead>
                            <thead class=""thead-light"">
                                <tr>
                                    <th> </th>
                                    <th>1</th>
                                    <th>2</th>
                                    <th>3</th>
                                    <th style=""font-weight:bold;"">Average</th>
                                </tr>
 ");
            WriteLiteral("                           </thead>\r\n");
#nullable restore
#line 134 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                             foreach (var item in Model.Grades)
                            {
                                double totalMidtermQuiz = item.Midterm_Quiz1 + item.Midterm_Quiz2 + item.Midterm_Quiz3;
                                double averageMidtermQuiz = totalMidtermQuiz / 3;
                                double roundedAveQuiz = Math.Round((double)averageMidtermQuiz, 2);

                                double totalMidtermAssign = item.Midterm_Assign1 + item.Midterm_Assign2 + item.Midterm_Assign3;
                                double averageMidtermAssign = totalMidtermAssign / 3;
                                double roundedAveAssign = Math.Round((double)averageMidtermAssign, 2);

                                double MidtermTotal = averageMidtermQuiz + averageMidtermAssign;
                                double MidtermGradeAve = Math.Round((double)MidtermTotal / 2, 2);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tbody>\r\n                                    <tr>\r\n                                        <td style=\"font-weight:bold;\">Quizzes</td>\r\n                                        <td>");
#nullable restore
#line 149 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Midterm_Quiz1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 150 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Midterm_Quiz2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 151 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Midterm_Quiz3));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 152 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                                       Write(Html.DisplayFor(modelItem => roundedAveQuiz));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n                                    <tr>\r\n                                        <td style=\"font-weight:bold;\">Assignments</td>\r\n                                        <td>");
#nullable restore
#line 156 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Midterm_Assign1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 157 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Midterm_Assign2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 158 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Midterm_Assign3));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 159 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                                       Write(Html.DisplayFor(modelItem => roundedAveAssign));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                    </tr>
                                    <tr class=""bg-secondary text-light"">
                                        <td style=""font-weight:bold;"" colspan=""4"">Midterm Grade</td>
                                        <td style=""font-weight:bold;"">");
#nullable restore
#line 163 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                                                                 Write(Html.DisplayFor(modelItem => MidtermGradeAve));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n                                </tbody>\r\n");
#nullable restore
#line 166 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </table>
                    </div>


                    <!--PREfinals-->

                    <div class=""table TablePrefinal"">

                        <table class="" w-75 Prefinal"">
                            <thead class=""thead-dark"">
                                <tr>
                                    <th colspan=""2"">Prefinals</th>
                                    <th></th>
                                    <th></th>
                                    <th></th>
                                </tr>
                            </thead>
                            <thead class=""thead-light"">
                                <tr>
                                    <th> </th>
                                    <th>1</th>
                                    <th>2</th>
                                    <th>3</th>
                                    <th style=""font-weight:bold;"">Average</th>
                                </tr>
                   ");
            WriteLiteral("         </thead>\r\n");
#nullable restore
#line 193 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                             foreach (var item in Model.Grades)
                            {
                                double totalPrefinalQuiz = item.Prefinal_Quiz1 + item.Prefinal_Quiz2 + item.Prefinal_Quiz3;
                                double averagePrefinalQuiz = totalPrefinalQuiz / 3;
                                double roundedAveQuiz = Math.Round((double)averagePrefinalQuiz, 2);

                                double totalPrefinalAssign = item.Prefinal_Assign1 + item.Prefinal_Assign2 + item.Prefinal_Assign3;
                                double averagePrefinalAssign = totalPrefinalAssign / 3;
                                double roundedAveAssign = Math.Round((double)averagePrefinalAssign, 2);

                                double PrefinalTotal = averagePrefinalQuiz + averagePrefinalAssign;
                                double PrefinalGradeAve = Math.Round((double)PrefinalTotal / 2, 2);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tbody>\r\n                                    <tr>\r\n                                        <td style=\"font-weight:bold;\">Quizzes</td>\r\n                                        <td>");
#nullable restore
#line 208 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Prefinal_Quiz1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 209 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Prefinal_Quiz2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 210 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Prefinal_Quiz3));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 211 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                                       Write(Html.DisplayFor(modelItem => roundedAveQuiz));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n                                    <tr>\r\n                                        <td style=\"font-weight:bold;\">Assignments</td>\r\n                                        <td>");
#nullable restore
#line 215 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Prefinal_Assign1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 216 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Prefinal_Assign2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 217 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Prefinal_Assign3));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 218 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                                       Write(Html.DisplayFor(modelItem => roundedAveAssign));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                    </tr>
                                    <tr class=""bg-secondary text-light"">
                                        <td style=""font-weight:bold;"" colspan=""4"">Prefinals Grade</td>
                                        <td style=""font-weight:bold;"">");
#nullable restore
#line 222 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                                                                 Write(Html.DisplayFor(modelItem => PrefinalGradeAve));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n                                </tbody>\r\n");
#nullable restore
#line 225 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </table>
                    </div>

                    <!--FINALS-->

                    <div class=""table TableFinal"">

                        <table class="" w-75 Final"">
                            <thead class=""thead-dark"">
                                <tr>
                                    <th colspan=""2"">Finals</th>
                                    <th></th>
                                    <th></th>
                                    <th></th>
                                </tr>
                            </thead>
                            <thead class=""thead-light"">
                                <tr>
                                    <th> </th>
                                    <th>1</th>
                                    <th>2</th>
                                    <th>3</th>
                                    <th style=""font-weight:bold;"">Average</th>
                                </tr>
                            </the");
            WriteLiteral("ad>\r\n");
#nullable restore
#line 251 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                             foreach (var item in Model.Grades)
                            {
                                double totalFinalQuiz = item.Final_Quiz1 + item.Final_Quiz2 + item.Final_Quiz3;
                                double averageFinalQuiz = totalFinalQuiz / 3;
                                double roundedAveQuiz = Math.Round((double)averageFinalQuiz, 2);

                                double totalFinalAssign = item.Final_Assign1 + item.Final_Assign2 + item.Final_Assign3;
                                double averageFinalAssign = totalFinalAssign / 3;
                                double roundedAveAssign = Math.Round((double)averageFinalAssign, 2);

                                double FinalTotal = averageFinalQuiz + averageFinalAssign;
                                double FinalGradeAve = Math.Round((double)FinalTotal / 2, 2);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tbody>\r\n                                    <tr>\r\n                                        <td style=\"font-weight:bold;\">Quizzes</td>\r\n                                        <td>");
#nullable restore
#line 266 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Final_Quiz1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 267 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Final_Quiz2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 268 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Final_Quiz3));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 269 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                                       Write(Html.DisplayFor(modelItem => roundedAveQuiz));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n                                    <tr>\r\n                                        <td style=\"font-weight:bold;\">Assignments</td>\r\n                                        <td>");
#nullable restore
#line 273 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Final_Assign1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 274 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Final_Assign2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 275 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Final_Assign3));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 276 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                                       Write(Html.DisplayFor(modelItem => roundedAveAssign));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                    </tr>
                                    <tr class=""bg-secondary text-light"">
                                        <td style=""font-weight:bold;"" colspan=""4"">Finals Grade</td>
                                        <td style=""font-weight:bold;"">");
#nullable restore
#line 280 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                                                                 Write(Html.DisplayFor(modelItem => FinalGradeAve));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n                                </tbody>\r\n");
#nullable restore
#line 283 "C:\Users\Lenovo Ideapad A320\Source\Repos\adet-midterm-q2-Pancake\StudentRecordsApp\StudentRecordsApp\Views\Student\Info.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </table>\r\n                    </div>\r\n                </dl>\r\n            </div>\r\n        </center>\r\n\r\n    </dl>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentRecordsApp.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
