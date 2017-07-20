# SA Python Demo
The solution has two projects:
SADemo - Visual Studio Iron Python project containing Python example scripts for the demo.
SAPyTools - c# dll project - wrapper contains MPHelper class 

If you need to install Iron Python dependency manually for SADemo. Use nuget package manager console:
> Install-Package IronPython -Version 2.7.7

Python search path in SADemo project points to bin\debug containing SAPyTools.dll


