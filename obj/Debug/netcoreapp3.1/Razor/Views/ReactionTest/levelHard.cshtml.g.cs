#pragma checksum "C:\Users\Ola\Documents\dokumenty studia\magisterka\Biometria\Biometria projekt\ReactionTestApp-main\Views\ReactionTest\levelHard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc058c66f710165f6985fd37dcef36482eeaa9fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ReactionTest_levelHard), @"mvc.1.0.view", @"/Views/ReactionTest/levelHard.cshtml")]
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
#line 1 "C:\Users\Ola\Documents\dokumenty studia\magisterka\Biometria\Biometria projekt\ReactionTestApp-main\Views\_ViewImports.cshtml"
using ReactionTimeApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ola\Documents\dokumenty studia\magisterka\Biometria\Biometria projekt\ReactionTestApp-main\Views\_ViewImports.cshtml"
using ReactionTimeApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc058c66f710165f6985fd37dcef36482eeaa9fc", @"/Views/ReactionTest/levelHard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b6d516f41215a621a28bd2ba0da767fa5ba0ff8", @"/Views/_ViewImports.cshtml")]
    public class Views_ReactionTest_levelHard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Ola\Documents\dokumenty studia\magisterka\Biometria\Biometria projekt\ReactionTestApp-main\Views\ReactionTest\levelHard.cshtml"
  
    ViewData["Title"] = "levelHard";


#line default
#line hidden
#nullable disable
            WriteLiteral("<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc058c66f710165f6985fd37dcef36482eeaa9fc3695", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <title>Reaction time test 3</title>

    <style>

        :root {
            --bound: 100px;
        }

        body {
            background-color: rgba(202, 28, 28, 0.5);
            text-align: center;
            color: #000000;
            opacity: 1;
            font-family: Arial;
        }

        .p {
            text-align: center;
            color: #000000;
            opacity: 1;
            font-family: Arial;
            font-weight: bold;
        }

        .s {
            background-color: rgb(0, 255, 13);
            font-family: Arial;
            font-weight: bold;
        }

        #box {
            width: var(--bound);
            height: var(--bound);
            background-color: red;
            opacity: 1;
            display: none;
            position: relative;
        }
    </style>

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc058c66f710165f6985fd37dcef36482eeaa9fc5564", async() => {
                WriteLiteral(@"
    <div id=""text"">
        <h1>Reaction Game</h1>
        <h2>Click as fast as you can :)</h2>
        <h2>Speed level hard</h2>
        <h4>Before you start, please enter your age and the device you are using. </h4>
        <h5> Click ""Save Game"" to save your best result.</h5>
    </div>
    <div>
        <input id=""userAge"" type=""number"" placeholder=""Type your age"">
        <input id=""userDevice"" type=""text"" placeholder=""What is your device?"">
    </div>
    <div>
        <button class=""s"" onclick=""gameStart()"" type=""button"">Start Game</button>
        <button class=""s"" id=""SaveGame"" type=""button"">SaveGame</button>
    </div>
    <p class=""p"">Reaction time: <span id=""time"">0</span>s</p>
    <div id=""box""></div>
    <script type=""text/javascript"">
        var createdTime;
        var clickedTime;
        var reactionTime;
        var testName = ""Hard"";
        var list = [];

        function randomcolor() {
            var max = 200;
            var min = 50;
            var gr");
                WriteLiteral(@"een = Math.floor(Math.random() * (max - min + 1)) + min;
            var color = ""rgba(255,"" + green + "",100,1.0)"";
            return color;
        }

        function makebox() {

            var time = Math.random();
            time = time * 1000; //speed

            setTimeout(function () {
                if (Math.random() >= 0.5) {
                    document.getElementById('box').style.borderRadius = ""75px"";
                    document.getElementById('box').style.border = ""5px solid black"";
                } else {
                    document.getElementById('box').style.borderRadius = ""0px"";
                    document.getElementById('box').style.border = ""5px solid black"";
                }

                var min = 0;
                var max = document.documentElement.clientHeight - 500;
                var top = Math.floor(Math.random() * (max - min + 1)) + min;

                min = 0;
                max = document.documentElement.clientWidth - 400;

            ");
                WriteLiteral(@"    if (document.documentElement.clientWidth > document.documentElement.clientHeight) {
                    var dynamicBound = document.documentElement.clientWidth / 8;
                    console.log(""width:"" + dynamicBound);
                } else {
                    var dynamicBound = document.documentElement.clientHeight / 8;
                    console.log(""height:"" + dynamicBound);
                }

                dynamicBound = dynamicBound + ""px"";
                document.documentElement.style.setProperty(""--bound"", dynamicBound);

                var left = Math.floor(Math.random() * (max - min + 1)) + min;


                document.getElementById('box').style.top = top + ""px"";
                document.getElementById('box').style.left = left + ""px"";

                document.getElementById('box').style.backgroundColor = randomcolor();
                document.getElementById('box').style.display = ""block"";
                createdTime = Date.now();
            }, time);


  ");
                WriteLiteral(@"      }

        function gameStart() {
             var a = 0;
             document.getElementById(""userAge"").style.display = 'none';
             document.getElementById(""userDevice"").style.display = 'none';
             document.getElementById(""text"").style.display = 'none';
            document.getElementById('box').onclick = function(){
                this.style.display=""none"";
                clickedTime = Date.now();
                reactionTime = (clickedTime - createdTime) / 1000;
                document.getElementById('time').innerHTML = reactionTime;
                list[a] = reactionTime;
                a++;
                makebox();
            }
            makebox();
        }

        document.getElementById(""SaveGame"").onclick = function () {

            var min = 10000;
            for (var i = 0; i < list.length; i++) {

                if (min >= list[i]) {
                    min = list[i];
                }
            }
            var userAge = documen");
                WriteLiteral("t.getElementById(\"userAge\").value;\r\n            var userDevice = document.getElementById(\"userDevice\").value;\r\n            console.log(userAge);\r\n            reactionSpan = min * 1000;\r\n             $.ajax({\r\n                url: \'");
#nullable restore
#line 159 "C:\Users\Ola\Documents\dokumenty studia\magisterka\Biometria\Biometria projekt\ReactionTestApp-main\Views\ReactionTest\levelHard.cshtml"
                 Write(Url.Action("AddRecordToReactionTest", "ReactionTest"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                type: 'POST',
                data: {
                    ""span"": reactionSpan,
                    ""testName"": testName,
                    ""userAge"": userAge,
                    ""userDevice"": userDevice
                },
                success: function (response) {
                    var Data = JSON.parse(response);
                    alert(""Your best reaction time has been saved!"");
                },
                failure: function () {
                    var Data = JSON.parse(response);
                    alert(response);
                },
                error: function () {
                    var Data = JSON.parse(response);
                    alert(response);
                }

            });
        };
    </script>
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
            WriteLiteral("\r\n</html>\r\n");
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
