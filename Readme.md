<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128613506/20.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5052)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/MessageBoxServiceExample/Form1.cs) (VB: [Form1.vb](./VB/MessageBoxServiceExample/Form1.vb))
* [MyMessageBoxService.cs](./CS/MessageBoxServiceExample/MyMessageBoxService.cs) (VB: [MyMessageBoxService.vb](./VB/MessageBoxServiceExample/MyMessageBoxService.vb))
<!-- default file list end -->
# How to customize a message dialog displayed when runtime errors occur


<p>This example demonstrates how to display a custom message in a custom manner instead of the default user warning dialog box.<br /> Сreate a class that implements the <a href="http://help.devexpress.com/#CoreLibraries/clsDevExpressXtraSpreadsheetServicesIMessageBoxServicetopic"><u>IMessageBox</u></a> service and register that class in place of the default service by using the <a href="http://help.devexpress.com/#WindowsForms/DevExpressXtraSpreadsheetSpreadsheetControl_ReplaceService[T]topic"><u>SpreadsheetControl.ReplaceService</u></a> method.<br /> The IMessageBox service provides the <u><a href="http://help.devexpress.com/#CoreLibraries/DevExpressXtraSpreadsheetServicesIMessageBoxService_ShowOkCancelMessagetopic">ShowOkCancelMessage</a>,</u> <u><a href="http://help.devexpress.com/#CoreLibraries/DevExpressXtraSpreadsheetServicesIMessageBoxService_ShowWarningMessagetopic">ShowWarningMessage</a>,</u> <a href="http://help.devexpress.com/#CoreLibraries/DevExpressXtraSpreadsheetServicesIMessageBoxService_ShowYesNoMessagetopic">ShowYesNoMessage</a>,  <a href="http://help.devexpress.com/#CoreLibraries/DevExpressXtraSpreadsheetServicesIMessageBoxService_ShowMessagetopic">ShowMessage</a>, <a href="http://help.devexpress.com/#CoreLibraries/DevExpressXtraSpreadsheetServicesIMessageBoxService_ShowDataValidationDialogtopic">ShowDataValidationDialog</a> methods which are called in specific situations when the SpreadsheetControl needs user attention.</p>

<br/>


