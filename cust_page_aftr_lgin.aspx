<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cust_page_aftr_lgin.aspx.cs" Inherits="restaurant.admnpage_aftr_lgin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="hello"></asp:Label>
&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="name"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="online order" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="table booking" />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" Height="26px" Text="view order" Width="85px" />
        <br />
        <br />
        <asp:Button ID="Button4" runat="server" Text="view booking" />
        <br />
        <br />
        <asp:Button ID="Button5" runat="server" Text="update info" />
    
    </div>
    </form>
</body>
</html>
