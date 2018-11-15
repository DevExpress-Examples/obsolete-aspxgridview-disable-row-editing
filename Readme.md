<!-- default file list -->
*Files to look at*:

* **[Default.aspx](./CS/Default.aspx)**
* [Default.aspx.cs](./CS/Default.aspx.cs)
<!-- default file list end -->
# [OBSOLETE, version v13.2 only] ASPxGridView - How to disable editing for rows that match some condition in Batch Edit Mode


<p>This example demonstrates how to disable editing for rows whose discontinued value is true. In this example, ASPxGridView is created with <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewASPxGridViewEditingSettings_Modetopic">ASPxGridView.SettingsEditing.Mode</a> = "Batch" and the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewASPxGridView_HtmlRowCreatedtopic">ASPxGridView.HtmlRowCreated</a> event is handled. For each cell in a row whose discontinued value is true, an attribute that cancels a click is added. Please note that in this case the row still can be edited by pressing the enter or tab key in the previous row. This example is for the 13.2 version and older. For the newer versions, see the <a href="https://www.devexpress.com/Support/Center/p/T115144">ASPxGridView - Batch Editing - How to cancel editing or disable the editor conditionally</a> example</p>

<br/>


