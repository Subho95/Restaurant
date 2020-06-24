<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AfterLogin.aspx.cs" Inherits="AfterLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="WELCOME    "></asp:Label>
    
        <br />
        <br />
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/UpdateProfile.aspx" OnClick="LinkButton1_Click">UPDATE PROFILE</asp:LinkButton>
        <br />
    
    </div>
    </form>
</body>
</html>
