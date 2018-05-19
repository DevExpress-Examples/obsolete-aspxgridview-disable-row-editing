using DevExpress.Web.ASPxGridView.Rendering;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page {
    protected void ASPxGridView1_HtmlRowCreated(object sender, DevExpress.Web.ASPxGridView.ASPxGridViewTableRowEventArgs e) {
        if (e.VisibleIndex >= 0 && (bool)e.GetValue("Discontinued"))
            foreach (GridViewTableDataCell cell in e.Row.Cells) {
                cell.Attributes.Add("onclick", "event.cancelBubble = true");
                cell.Attributes.Add("style", "background-color:red");
            }
    }
    protected void ASPxGridView1_BatchUpdate(object sender, DevExpress.Web.Data.ASPxDataBatchUpdateEventArgs e) {
        throw new NotImplementedException();
    }
}