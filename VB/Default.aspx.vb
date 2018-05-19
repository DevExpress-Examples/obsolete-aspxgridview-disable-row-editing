Imports Microsoft.VisualBasic
Imports DevExpress.Web.ASPxGridView.Rendering
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub ASPxGridView1_HtmlRowCreated(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewTableRowEventArgs)
		If e.VisibleIndex >= 0 AndAlso CBool(e.GetValue("Discontinued")) Then
			For Each cell As GridViewTableDataCell In e.Row.Cells
				cell.Attributes.Add("onclick", "event.cancelBubble = true")
				cell.Attributes.Add("style", "background-color:red")
			Next cell
		End If
	End Sub
	Protected Sub ASPxGridView1_BatchUpdate(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataBatchUpdateEventArgs)
		Throw New NotImplementedException()
	End Sub
End Class