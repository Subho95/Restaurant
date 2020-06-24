<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    &nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="USER ID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtuserid" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="DELETE" />
&nbsp;<asp:Label ID="Label2" runat="server" Font-Bold="True"></asp:Label>
    
    </div>
    </form>
</body>
</html>
