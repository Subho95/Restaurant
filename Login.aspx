<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width:60%;">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Maroon" Text="USER ID"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>
                    <asp:TextBox ID="txtuserid" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Maroon" Text="PASSWORD"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>
                    <asp:TextBox ID="txtpass" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="LOGIN" />
                </td>
            </tr>
        </table>
    
    
    </div>
    </form>
</body>
</html>
