Imports DevExpress.Data.Filtering
Imports DevExpress.Web
Imports System
Imports System.Collections.Generic
Imports System.Linq

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected separator As Char = ","c
    Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
        Grid.DataSource = Data.GetData()
        Grid.DataBind()
    End Sub
   Protected Sub Grid_HeaderFilterFillItems(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewHeaderFilterEventArgs)
        If e.Column.FieldName <> "Cities" Then
            Return
        End If
        Dim result = e.Values.Select(Function(q) q.Value.Split(separator)).SelectMany(Function(q) q).Distinct().ToList()
        e.Values.Clear()
        For Each item In result
            Dim cop As CriteriaOperator = New FunctionOperator(FunctionOperatorType.Contains, New OperandProperty("Cities"), item)
            e.Values.Add(New FilterValue(item, item, cop.ToString()))
        Next item
   End Sub
End Class
