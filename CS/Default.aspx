<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v15.2, Version=15.2.20.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <dx:ASPxGridView ID="Grid" runat="server" KeyFieldName="ID" OnHeaderFilterFillItems="Grid_HeaderFilterFillItems">
                <Settings ShowHeaderFilterButton="true" ShowFilterBar="Visible" />
                <Columns>
                    <dx:GridViewDataColumn FieldName="ID" />
                    <dx:GridViewDataColumn FieldName="Cities">
                        <SettingsHeaderFilter Mode="CheckedList" />
                    </dx:GridViewDataColumn>
                </Columns>
            </dx:ASPxGridView>
        </div>
    </form>
</body>
</html>
