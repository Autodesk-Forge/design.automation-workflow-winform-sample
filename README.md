workflow-winform-autocad.io
===========================

A C# WinForm application for performing AutoCAD IO workflow tasks.

--------------------------------------------------------------------
Important note :
This is a learning/prototyping utility to quickly create custom activities, create AppPackage, 
submit workitem requests and view downloaded results.

This sample accepts the AutoCAD IO client id and client secret in its settings and this is not 
the recommended method to be followed in your production code.
Client Id and Client secret should be kept confidential and should not shared or distributed
along with your application.

This sample takes the client id and client secret as inputs since as it is not a tool for distribution 
and is only intended for helping developers quickly try out AutoCAD IO and learn the steps involved.
----------------------------------------------------------------------

1) As this sample includes a reference to "library-dotnet-autocad.io", please build
that sample following the instruction provided in that sample. Here is the link :
https://github.com/Developer-Autodesk/library-dotnet-autocad.io

2) After you have built the library project, 
Open the AutoCADIODemo sample project in Visual Studio 2012

3) Add reference to AutoCADIOUtil library

4) In the project settings, provide the following details:
-	Path to a local folder in your system that contains AutoCAD drawings.
-	AutoCAD IO Client Id
-	AutoCAD IO Client Secret
-	Bucket name in your AWS S3 Storage

![Picture](https://github.com/Developer-Autodesk/workflow-winform-autocad.io/blob/master/assets/1.png)

5) Open “App.Config” file and provide AWS credentials. This will allow the sample project to access S3 storage in your 
AWS profile.

![Picture](https://github.com/Developer-Autodesk/workflow-winform-autocad.io/blob/master/assets/2.png)

6) Build the sample project

7) Run AutoCADIODemo.exe for the main window to appear

The path to the sample drawings that was provided in the project settings can also be provided by accessing 
“Settings” button as shown in the below screenshot.

![Picture](https://github.com/Developer-Autodesk/workflow-winform-autocad.io/blob/master/assets/3.png)
 
Demo 1: Using Shared AutoCAD IO Activity
-----------------------------------------------------------------------------------------------------------------------------
AutoCAD IO provides a Shared activity which is named “PlotToPDF”. This activity is available by default. 
Choose this activity from the list of activities as shown in the below screenshot.
Select any drawing from the list of drawings that appear at the left. 

![Picture](https://github.com/Developer-Autodesk/workflow-winform-autocad.io/blob/master/assets/4.png)

The chosen drawing will be uploaded to the S3 storage and a WorkItem will be created based on the selected activity. 
The WorkItem will be submitted to AutoCAD IO for processing and the result will get displayed in the right pane.
 
 ![Picture](https://github.com/Developer-Autodesk/workflow-winform-autocad.io/blob/master/assets/5.png)
 
Demo 2: Creating and using a custom AutoCAD IO Activity 
-----------------------------------------------------------------------------------------------------------------------------
To create a custom activity, click on the Activities button as shown in below screenshot and provide the details.
 
![Picture](https://github.com/Developer-Autodesk/workflow-winform-autocad.io/blob/master/assets/6.png)
 
Important Note : The script should be implemented such that the result file is named as “result.*”. 
The result file name can be any name of your choice, AutoCAD IO does not have a restriction on that. 
But just to make the sample code generic and have it identify the result file automatically from the script, 
the sample project looks for anything that sounds like result.pdf, Result.dwf, RESULT.DWG etc. So for custom activities 
to work, please ensure that the script saves the result with an appropriate file name as result.dwg, result.pdf, result.dwf etc.
After the custom activity is created, close the Activities dialog.
The custom activity should now appear in the list of Activities alongside the shared activity as shown in the below screenshot. 

![Picture](https://github.com/Developer-Autodesk/workflow-winform-autocad.io/blob/master/assets/7.png)
 
Select the custom activity and choose any drawing from the list of drawings just as we did for using a Shared activity.
The result of the custom activity will be displayed in the right pane if it is a pdf. For any other outputs such as dwg, dwf, 
the result file is downloaded to a local path and the path is displayed in the right pane.

Demo 3: Creating and using a custom AutoCAD IO Activity that is linked to an App Package 
-----------------------------------------------------------------------------------------------------------------------------

Create a custom crx or .Net plugin (that does not reference acmgd.dll)
Package it in AutoCAD Bundle format
Click on “App Packages” button and provide the details as shown in below screenshot
 
![Picture](https://github.com/Developer-Autodesk/workflow-winform-autocad.io/blob/master/assets/8.png)
 
To create a custom activity that links with the custom app package, click on the Activities button as 
shown in below screenshot and provide the details.
 
![Picture](https://github.com/Developer-Autodesk/workflow-winform-autocad.io/blob/master/assets/9.png)

After the custom activity is created, close the Activities dialog.
The custom activity should now appear in the list of Activities alongside the shared activity as shown in the below screenshot. 
 
![Picture](https://github.com/Developer-Autodesk/workflow-winform-autocad.io/blob/master/assets/10.png)
 
Select the custom activity and choose any drawing from the list of drawings just as we did for using a Shared activity.
The result of the custom activity will be downloaded to a local path and the path is displayed as shown in the below screenshot. 
 
![Picture](https://github.com/Developer-Autodesk/workflow-winform-autocad.io/blob/master/assets/11.png)
 
Verify that the custom command has done its task by opening the downloaded result.
