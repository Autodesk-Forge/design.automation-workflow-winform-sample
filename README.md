# Design Automation API - WinForm sample
===========================
(Formely AutoCAD I/O)

[![.net](https://img.shields.io/badge/.net-4.5-green.svg)](http://www.microsoft.com/en-us/download/details.aspx?id=30653)
[![odata](https://img.shields.io/badge/odata-4.0-yellow.svg)](http://www.odata.org/documentation/)
[![Design Automation](https://img.shields.io/badge/Design%20Automation-v2-green.svg)](http://developer.autodesk.com/)
[![visual studio](https://img.shields.io/badge/visual%20studio-2015%2F2017-yellowgreen.svg)](https://www.visualstudio.com/)
[![License](http://img.shields.io/:license-mit-red.svg)](http://opensource.org/licenses/MIT)

## Description
A C# WinForm application for performing workflow tasks of Design Automation on create custom activities, create AppPackage, submit workitem requests and view downloaded results.

## Thumbnail
![thumbnail](/thumbnail.png) 

## Setup

### Dependencies 
* Download and install [Visual Studio](https://visualstudio.microsoft.com/downloads/). In the latest test, Visual Studio version is 2017.
* Ensure you have already [AWS account and S3 storage](https://aws.amazon.com/s3/). 
* Get the auxiliary library project [design.automation-.net-library](https://github.com/Autodesk-Forge/design.automation-.net-library)

### Prerequisites
1. **Forge Account**: Learn how to create a Forge Account, activate subscription and create an app at [this tutorial](http://learnforge.autodesk.io/#/account/). Make sure to select the service **Design Automation**.
2. Make a note with the credentials (client id and client secret) of the app. 
3. as mentioned in **Dependencies**, ensure to build the auxiliary library project and get the binary dll.

## Running locally  

1. Open the project. Restore the packages of the project by [NuGet](https://www.nuget.org/. The simplest way is
  * VS2012: Projects tab >> Enable NuGet Package Restore. Then right click the project>>"Manage NuGet Packages for Solution" >> "Restore" (top right of dialog)
  * VS2013/VS2015/2017:  right click the project>>"Manage NuGet Packages for Solution" >> "Restore" (top right of dialog)
2. Add other missing references and the library of[design.automation-.net-library](https://github.com/Autodesk-Forge/design.automation-.net-library)
3. In the project settings, provide the following details:
 * Path to a local folder in your system that contains AutoCAD drawings. Put some test drawings in this folder.
 * Design Automation Client Id which is from #1 of **Prerequisites**
 * Design Automation Client Secret which is from #1 of **Prerequisites**
 * Bucket name in your AWS S3 Storage which is from #2 of **Prerequisites**
  ![Picture](./assets/1.png)
4. Open “App.Config” file and fill in AWS credentials. This will allow the sample project to access S3 storage in your AWS profile.
  ![Picture](./assets/2.png)
5. Build the sample project
6. Run AutoCADIODemo.exe. the main window to appear. The path to the sample drawings that was provided in the project settings can also be provided by accessing “Settings” button as shown in the below screenshot.
  ![Picture](./assets/3.png)

## Demonstrations

### Demo 1: Using Shared Design Automation Activity
-----------------------------------------------------------------------------------------------------------------------------
 * Design Automation provides a Shared activity which is named “PlotToPDF”. This activity is available by default. Choose this activity from the list of activities as shown in the below screenshot.Select any drawing from the list of drawings that appear at the left. 

  ![Picture](./assets/4.png)

  The chosen drawing will be uploaded to the S3 storage and a WorkItem will be created based on the selected activity.
The WorkItem will be submitted to AutoCAD IO for processing and the result will get displayed in the right pane.
 
 ![Picture](./assets/5.png)
 
### Demo 2: Creating and using a custom AutoCAD IO Activity 
-----------------------------------------------------------------------------------------------------------------------------
   To create a custom activity, click on the Activities button as shown in below screenshot and provide the details.
 
  ![Thumbnail](./assets/6.png)
 
Important Note : The script should be implemented such that the result file is named as “result.*”. 
The result file name can be any name of your choice, AutoCAD IO does not have a restriction on that. 
But just to make the sample code generic and have it identify the result file automatically from the script, 
the sample project looks for anything that sounds like result.pdf, Result.dwf, RESULT.DWG etc. So for custom activities 
to work, please ensure that the script saves the result with an appropriate file name as result.dwg, result.pdf, result.dwf etc.
After the custom activity is created, close the Activities dialog.
The custom activity should now appear in the list of Activities alongside the shared activity as shown in the below screenshot. 

  ![Picture](./assets/7.png)
 
Select the custom activity and choose any drawing from the list of drawings just as we did for using a Shared activity.
The result of the custom activity will be displayed in the right pane if it is a pdf. For any other outputs such as dwg, dwf, 
the result file is downloaded to a local path and the path is displayed in the right pane.

### Demo 3: Creating and using a custom Design Automation Activity that is linked to an App Package 
-----------------------------------------------------------------------------------------------------------------------------

Create a custom crx or .Net plugin (that does not reference acmgd.dll)
Package it in AutoCAD Bundle format
Click on “App Packages” button and provide the details as shown in below screenshot
 
  ![Picture](./assets/8.png)
 
To create a custom activity that links with the custom app package, click on the Activities button as 
shown in below screenshot and provide the details.
 
  ![Picture](./assets/9.png)

After the custom activity is created, close the Activities dialog.
The custom activity should now appear in the list of Activities alongside the shared activity as shown in the below screenshot. 
 
  ![Picture](./assets/10.png)
 
Select the custom activity and choose any drawing from the list of drawings just as we did for using a Shared activity.
The result of the custom activity will be downloaded to a local path and the path is displayed as shown in the below screenshot. 
 
  ![Picture](./assets/11.png)
 
Verify that the custom command has done its task by opening the downloaded result.

## Known Issues
* as of writing, Design Automation of Forge is released with version 2. Odata is used with .NET project. In futher version, OData might not be used. 


## Further Reading 
* [Design Automation API help](https://forge.autodesk.com/en/docs/design-automation/v2/developers_guide/overview/)
* [ Intro to Design Automation API Video](https://www.youtube.com/watch?v=GWsJM344CJE&t=107s)
* [Create and use a SAS with Blob storage](https://docs.microsoft.com/en-us/azure/storage/blobs/storage-dotnet-shared-access-signature-part-2) 

## License

These samples are licensed under the terms of the [MIT License](http://opensource.org/licenses/MIT). Please see the [LICENSE](LICENSE) file for full details.

## Written by 

Balaji Ramamoorthy 
updated by Xiaodong Liang
  