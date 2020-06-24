<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admn_aftr_lgin.aspx.cs" Inherits="restaurant.admn_aftr_lgin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        welcome !!!!<br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="view order" Width="187px" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="view customer details" />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" Text="view table booking info" Width="189px" />
        <br />
        <br />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="view datewise table booking" Width="188px" />
        <br />
        <br />
        <asp:Button ID="Button5" runat="server" Text="view menu" Width="188px" />
        <br />
        <br />
        <asp:Button ID="Button6" runat="server" Text="change password" Width="188px" />
        <br />
        <br />
        no. of table&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
    
    </div>
    </form>
</body>
</html>
