# How to customize a message dialog displayed when runtime errors occur


<p>This example demonstrates how to display a custom message in a custom manner instead of the default user warning dialog box.<br /> Сreate a class that implements the <a href="http://help.devexpress.com/#CoreLibraries/clsDevExpressXtraSpreadsheetServicesIMessageBoxServicetopic"><u>IMessageBox</u></a> service and register that class in place of the default service by using the <a href="http://help.devexpress.com/#WindowsForms/DevExpressXtraSpreadsheetSpreadsheetControl_ReplaceService[T]topic"><u>SpreadsheetControl.ReplaceService</u></a> method.<br /> The IMessageBox service provides the <u><a href="http://help.devexpress.com/#CoreLibraries/DevExpressXtraSpreadsheetServicesIMessageBoxService_ShowOkCancelMessagetopic">ShowOkCancelMessage</a>,</u> <u><a href="http://help.devexpress.com/#CoreLibraries/DevExpressXtraSpreadsheetServicesIMessageBoxService_ShowWarningMessagetopic">ShowWarningMessage</a>,</u> <a href="http://help.devexpress.com/#CoreLibraries/DevExpressXtraSpreadsheetServicesIMessageBoxService_ShowYesNoMessagetopic">ShowYesNoMessage</a>,  <a href="http://help.devexpress.com/#CoreLibraries/DevExpressXtraSpreadsheetServicesIMessageBoxService_ShowMessagetopic">ShowMessage</a>, <a href="http://help.devexpress.com/#CoreLibraries/DevExpressXtraSpreadsheetServicesIMessageBoxService_ShowDataValidationDialogtopic">ShowDataValidationDialog</a> methods which are called in specific situations when the SpreadsheetControl needs user attention.</p>

<br/>


