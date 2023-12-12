using homework_2.homework_2;
using homework_2;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace homework_2
{
    public class Cash : Payment
    {
        private float cashTendered;

        public Cash(float amount, float cashTendered)
            : base(amount)
        {
            this.cashTendered = cashTendered;
        }

        public float CashTendered
        {
            get { return cashTendered; }
            private set { cashTendered = value; }
        }
    }
}
38 changes: 38 additions & 0 deletions38
Check.cs
@@ -0,0 + 1,38 @@
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2
{
    public class Check : Payment
    {
        private string name;
        private string bankID;

        public Check(float amount, string name, string bankID)
            : base(amount)
        {
            this.name = name;
            this.bankID = bankID;
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public string BankID
        {
            get { return bankID; }
            private set { bankID = value; }
        }

        public void Authorized()
        {
            Console.WriteLine("Check Authorization...");
        }
    }
}
47 changes: 47 additions & 0 deletions47
Credit.cs
@@ -0,0 + 1,47 @@
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2
{
    public class Credit : Payment
    {
        private string name;
        private string type;
        private DateTime expDate;

        public Credit(float amount, string name, string type, DateTime expDate)
            : base(amount)
        {
            this.name = name;
            this.type = type;
            this.expDate = expDate;
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public string Type
        {
            get { return type; }
            private set { type = value; }
        }

        public DateTime ExpDate
        {
            get { return expDate; }
            private set { expDate = value; }
        }

        public void Authorized()
        {
            Console.WriteLine("Credit Authorization...");
        }
    }

}
35 changes: 35 additions & 0 deletions35
Customer.cs
@@ -0,0 + 1,35 @@
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2
{

    class Customer
    {



        private string name;

        private string adress;


        public Customer(string aname, string aadress)
        {


            name = aname;

            adress = aadress;






        }

    }
 53 changes: 53 additions & 0 deletions53
Item.cs
@@ -0,0 +1,53 @@
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2
    {


        public class Item
        {
            private double shippingWeight;
            private string description;

            public Item(double shippingWeight, string description)
            {
                this.shippingWeight = shippingWeight;
                this.description = description;
            }

            public double ShippingWeight
            {
                get { return shippingWeight; }
                private set { shippingWeight = value; }
            }

            public string Description
            {
                get { return description; }
                private set { description = value; }
            }

            public double GetPriceForQuantity()
            {
                Console.WriteLine("Calculating Price for Quantity...");
                return 0.0;
            }

            public double GetTax()
            {
                Console.WriteLine("Calculating Tax for Item...");
                return 0.0;
            }

            public bool InStock()
            {
                Console.WriteLine("Checking Stock for Item...");
                return false;
            }
        }

    }
 39 changes: 39 additions & 0 deletions39
Order.cs
@@ -0,0 +1,39 @@
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Order
    {
        private DateTime date;
        private string status;

        public Order(DateTime date, string status)
        {
            this.date = date;
            this.status = status;
        }

        public void CalcSubTotal()
        {

            Console.WriteLine("Calculating SubTotal...");
        }

        public void CalcTax()
        {

            Console.WriteLine("Calculating Tax...");
        }

        public void CalcTotal()
        {

            Console.WriteLine("Calculating Total...");
        }

        public void CalcTotalWeight()
        {

            Console.WriteLine("Calculating Total Weight...");
        }
 50 changes: 50 additions & 0 deletions50
OrderDetail.cs
@@ -0,0 +1,50 @@
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2
    {
        public class OrderDetail
        {
            private int quality;
            private string taxStatus;

            public OrderDetail(int quality, string taxStatus)
            {
                this.quality = quality;
                this.taxStatus = taxStatus;
            }

            public int Quality
            {
                get { return quality; }
                private set { quality = value; }
            }

            public string TaxStatus
            {
                get { return taxStatus; }
                private set { taxStatus = value; }
            }

            public void CalcSubTotal()
            {

                Console.WriteLine("Calculating SubTotal for OrderDetail...");
            }

            public void CalcWeight()
            {

                Console.WriteLine("Calculating Weight for OrderDetail...");
            }

            public void CalcTax()
            {

                Console.WriteLine("Calculating Tax for OrderDetail...");
            }
        }
    }
 23 changes: 23 additions & 0 deletions23
Payment.cs
@@ -0,0 +1,23 @@
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2
    {
        public class Payment
        {
            private float amount;

            public Payment(float amount)
            {
                this.amount = amount;
            }

            public float Amount
            {
                get { return amount; }
                private set { amount = value; }
            }

 45 changes: 45 additions & 0 deletions45
Program.cs
@@ -0,0 +1,45 @@
﻿using System;






public class homework2
        {




            public static void Main(String[] args)
            {















            }















        }
 11 changes: 11 additions & 0 deletions11
homework 2.csproj
@@ -0,0 +1,11 @@
<Project Sdk = "Microsoft.NET.Sdk" >

  < PropertyGroup >
    < OutputType > Exe </ OutputType >
    < TargetFramework > net6.0</TargetFramework>
    <RootNamespace>homework_2</RootNamespace>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>
 25 changes: 25 additions & 0 deletions25
homework 2.sln
@@ -0,0 +1,25 @@

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio Version 17
VisualStudioVersion = 17.4.33122.133
MinimumVisualStudioVersion = 10.0.40219.1
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "homework 2", "homework 2.csproj", "{76480E6B-D08E-4E05-99BF-43588B01735E}"
EndProject
Global

    GlobalSection(SolutionConfigurationPlatforms) = preSolution

        Debug|Any CPU = Debug | Any CPU

        Release|Any CPU = Release | Any CPU
    EndGlobalSection

    GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{76480E6B-D08E-4E05-99BF-43588B01735E
    }.Debug|Any CPU.ActiveCfg = Debug|Any CPU

        { 76480E6B - D08E - 4E05 - 99BF - 43588B01735E}.Debug|Any CPU.Build.0 = Debug|Any CPU

        { 76480E6B - D08E - 4E05 - 99BF - 43588B01735E}.Release|Any CPU.ActiveCfg = Release|Any CPU

        { 76480E6B - D08E - 4E05 - 99BF - 43588B01735E}.Release|Any CPU.Build.0 = Release|Any CPU

    EndGlobalSection
    GlobalSection(SolutionProperties) = preSolution

        HideSolutionNode = FALSE

    EndGlobalSection
    GlobalSection(ExtensibilityGlobals) = postSolution

        SolutionGuid = { 266A5D86 - 57C6 - 4FD4 - A2D9 - 868483DBF039}
    EndGlobalSection
EndGlobal
 23 changes: 23 additions & 0 deletions23
obj/Debug/net6.0/homework 2.AssemblyInfo.cs
@@ -0,0 +1,23 @@
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Reflection;

[assembly: System.Reflection.AssemblyCompanyAttribute("homework 2")]
[assembly: System.Reflection.AssemblyConfigurationAttribute("Debug")]
[assembly: System.Reflection.AssemblyFileVersionAttribute("1.0.0.0")]
[assembly: System.Reflection.AssemblyInformationalVersionAttribute("1.0.0")]
[assembly: System.Reflection.AssemblyProductAttribute("homework 2")]
[assembly: System.Reflection.AssemblyTitleAttribute("homework 2")]
[assembly: System.Reflection.AssemblyVersionAttribute("1.0.0.0")]

// Generated by the MSBuild WriteCodeFragment class.

 1 change: 1 addition & 0 deletions1
obj/Debug/net6.0/homework 2.AssemblyInfoInputs.cache
@@ -0,0 +1 @@
848a4d165effb484d79f7946cd1c3c6be211f5e4
 11 changes: 11 additions & 0 deletions11
obj/Debug/net6.0/homework 2.GeneratedMSBuildEditorConfig.editorconfig
@@ -0,0 +1,11 @@
is_global = true
build_property.TargetFramework = net6.0
build_property.TargetPlatformMinVersion = 
build_property.UsingMicrosoftNETSdkWeb = 
build_property.ProjectTypeGuids = 
build_property.InvariantGlobalization = 
build_property.PlatformNeutralAssembly = 
build_property.EnforceExtendedAnalyzerRules = 
build_property._SupportedPlatformList = Linux,macOS,Windows
build_property.RootNamespace = homework_2
build_property.ProjectDir = S:\uni\c++\c++ visual studio\homework 2\
 8 changes: 8 additions & 0 deletions8
obj/Debug/net6.0/homework 2.GlobalUsings.g.cs
@@ -0,0 +1,8 @@
// <auto-generated/>
global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;
 Binary file addedBIN +223 Bytes
obj/Debug/net6.0/homework 2.assets.cache
Binary file not shown.
 Binary file addedBIN +89.1 KB
obj/Debug/net6.0/homework 2.csproj.AssemblyReference.cache
Binary file not shown.
 67 changes: 67 additions & 0 deletions67
obj/homework 2.csproj.nuget.dgspec.json
@@ -0,0 +1,67 @@
{
        "format": 1,
  "restore": {
            "S:\\uni\\c++\\c++ visual studio\\homework 2\\homework 2.csproj": { }
        },
  "projects": {
            "S:\\uni\\c++\\c++ visual studio\\homework 2\\homework 2.csproj": {
                "version": "1.0.0",
      "restore": {
                    "projectUniqueName": "S:\\uni\\c++\\c++ visual studio\\homework 2\\homework 2.csproj",
        "projectName": "homework 2",
        "projectPath": "S:\\uni\\c++\\c++ visual studio\\homework 2\\homework 2.csproj",
        "packagesPath": "C:\\Users\\user\\.nuget\\packages\\",
        "outputPath": "S:\\uni\\c++\\c++ visual studio\\homework 2\\obj\\",
        "projectStyle": "PackageReference",
        "fallbackFolders": [
          "C:\\Program Files (x86)\\Microsoft Visual Studio\\Shared\\NuGetPackages"
        ],
        "configFilePaths": [
          "C:\\Users\\user\\AppData\\Roaming\\NuGet\\NuGet.Config",
          "C:\\Program Files (x86)\\NuGet\\Config\\Microsoft.VisualStudio.FallbackLocation.config",
          "C:\\Program Files (x86)\\NuGet\\Config\\Microsoft.VisualStudio.Offline.config"
        ],
        "originalTargetFrameworks": [
          "net6.0"
        ],
        "sources": {
                        "C:\\Program Files (x86)\\Microsoft SDKs\\NuGetPackages\\": { },
          "https://api.nuget.org/v3/index.json": { }
                    },
        "frameworks": {
                        "net6.0": {
                            "targetAlias": "net6.0",
            "projectReferences": { }
                        }
                    },
        "warningProperties": {
                        "warnAsError": [
                          "NU1605"
          ]
        }
                },
      "frameworks": {
                    "net6.0": {
                        "targetAlias": "net6.0",
          "imports": [
            "net461",
            "net462",
            "net47",
            "net471",
            "net472",
            "net48",
            "net481"
                      ],
          "assetTargetFallback": true,
          "warn": true,
          "frameworkReferences": {
                            "Microsoft.NETCore.App": {
                                "privateAssets": "all"
                            }
                        },
          "runtimeIdentifierGraphPath": "C:\\Program Files\\dotnet\\sdk\\7.0.100\\RuntimeIdentifierGraph.json"
                    }
                }
            }
        }
    }
 16 changes: 16 additions & 0 deletions16
obj/homework 2.csproj.nuget.g.props
@@ -0,0 +1,16 @@
<? xml version="1.0" encoding="utf-8" standalone="no"?>
<Project ToolsVersion = "14.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup Condition = " '$(ExcludeRestorePackageImports)' != 'true' " >
    < RestoreSuccess Condition=" '$(RestoreSuccess)' == '' ">True</RestoreSuccess>
    <RestoreTool Condition = " '$(RestoreTool)' == '' " > NuGet </ RestoreTool >
    < ProjectAssetsFile Condition=" '$(ProjectAssetsFile)' == '' ">$(MSBuildThisFileDirectory) project.assets.json</ProjectAssetsFile>
    <NuGetPackageRoot Condition = " '$(NuGetPackageRoot)' == '' " >$(UserProfile)\.nuget\packages\</NuGetPackageRoot>
    <NuGetPackageFolders Condition = " '$(NuGetPackageFolders)' == '' " > C:\Users\user\.nuget\packages\; C:\Program Files(x86)\Microsoft Visual Studio\Shared\NuGetPackages</NuGetPackageFolders>
    <NuGetProjectStyle Condition = " '$(NuGetProjectStyle)' == '' " > PackageReference </ NuGetProjectStyle >
    < NuGetToolVersion Condition=" '$(NuGetToolVersion)' == '' ">6.4.0</NuGetToolVersion>
  </PropertyGroup>
  <ItemGroup Condition = " '$(ExcludeRestorePackageImports)' != 'true' " >
    < SourceRoot Include="C:\Users\user\.nuget\packages\" />
    <SourceRoot Include = "C:\Program Files (x86)\Microsoft Visual Studio\Shared\NuGetPackages\" />
  </ ItemGroup >
</ Project >
 2 changes: 2 additions & 0 deletions2
obj/homework 2.csproj.nuget.g.targets
@@ -0,0 +1,2 @@
<? xml version="1.0" encoding="utf-8" standalone="no"?>
<Project ToolsVersion = "14.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" />
 73 changes: 73 additions & 0 deletions73
obj/project.assets.json
@@ -0,0 +1,73 @@
{
  "version": 3,
  "targets": {
    "net6.0": {}
  },
  "libraries": { },
  "projectFileDependencyGroups": {
    "net6.0": []
  },
  "packageFolders": {
    "C:\\Users\\user\\.nuget\\packages\\": { },
    "C:\\Program Files (x86)\\Microsoft Visual Studio\\Shared\\NuGetPackages": { }
},
  "project": {
    "version": "1.0.0",
    "restore": {
        "projectUniqueName": "S:\\uni\\c++\\c++ visual studio\\homework 2\\homework 2.csproj",
      "projectName": "homework 2",
      "projectPath": "S:\\uni\\c++\\c++ visual studio\\homework 2\\homework 2.csproj",
      "packagesPath": "C:\\Users\\user\\.nuget\\packages\\",
      "outputPath": "S:\\uni\\c++\\c++ visual studio\\homework 2\\obj\\",
      "projectStyle": "PackageReference",
      "fallbackFolders": [
        "C:\\Program Files (x86)\\Microsoft Visual Studio\\Shared\\NuGetPackages"
      ],
      "configFilePaths": [
        "C:\\Users\\user\\AppData\\Roaming\\NuGet\\NuGet.Config",
        "C:\\Program Files (x86)\\NuGet\\Config\\Microsoft.VisualStudio.FallbackLocation.config",
        "C:\\Program Files (x86)\\NuGet\\Config\\Microsoft.VisualStudio.Offline.config"
      ],
      "originalTargetFrameworks": [
        "net6.0"
      ],
      "sources": {
            "C:\\Program Files (x86)\\Microsoft SDKs\\NuGetPackages\\": { },
        "https://api.nuget.org/v3/index.json": { }
        },
      "frameworks": {
            "net6.0": {
                "targetAlias": "net6.0",
          "projectReferences": { }
            }
        },
      "warningProperties": {
            "warnAsError": [
              "NU1605"
        ]
      }
    },
    "frameworks": {
        "net6.0": {
            "targetAlias": "net6.0",
        "imports": [
          "net461",
          "net462",
          "net47",
          "net471",
          "net472",
          "net48",
          "net481"
          ],
        "assetTargetFallback": true,
        "warn": true,
        "frameworkReferences": {
                "Microsoft.NETCore.App": {
                    "privateAssets": "all"
                }
            },
        "runtimeIdentifierGraphPath": "C:\\Program Files\\dotnet\\sdk\\7.0.100\\RuntimeIdentifierGraph.json"
        }
    }
}
}
 8 changes: 8 additions & 0 deletions8
obj/project.nuget.cache
@@ -0,0 +1,8 @@
{
  "version": 2,
  "dgSpecHash": "DOSaXUZVKgj0QXdqHrpKzwBbKwSKRSTlyCBH2VhtYSBSRpWhbFEUCppkMUcwzZxuYCXkaD9KVpzj1fOJ+aMMig==",
  "success": true,
  "projectFilePath": "S:\\uni\\c++\\c++ visual studio\\homework 2\\homework 2.csproj",
  "expectedPackageFiles": [],
  "logs": []
}