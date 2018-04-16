using DevExpress.Data.Filtering;
using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Linq;

public partial class _Default : System.Web.UI.Page {
    protected char separator = ',';
    protected void Page_Init(object sender, EventArgs e) {
        Grid.DataSource = Data.GetData();
        Grid.DataBind();
    }
   protected void Grid_HeaderFilterFillItems(object sender, DevExpress.Web.ASPxGridViewHeaderFilterEventArgs e) {
        if (e.Column.FieldName != "Cities")
            return;
        var result = e.Values
                        .Select(q => q.Value.Split(separator))
                        .SelectMany(q => q)
                        .Distinct()
                        .ToList();
        e.Values.Clear();
        foreach (var item in result) {
            CriteriaOperator cop = new FunctionOperator(FunctionOperatorType.Contains, new OperandProperty("Cities"), item);
            e.Values.Add(new FilterValue(item, item, cop.ToString()));
        }
    }
}
