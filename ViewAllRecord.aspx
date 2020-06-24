<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewAllRecord.aspx.cs" Inherits="ViewAllRecord" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="VIEW ALL RECORD" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        </asp:GridView>
        <br />
    <div>
    
    </div>
    </form>
</body>
</html>
