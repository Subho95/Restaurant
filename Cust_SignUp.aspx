<%@ Page Title="" Language="C#" MasterPageFile="~/HomeG.master" AutoEventWireup="true" CodeFile="Cust_SignUp.aspx.cs" Inherits="Cust_SignUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

    .auto-style3 {
        width: 225px;
    }
        .auto-style2 {
            height: 26px;
        }
    .auto-style5 {
        height: 26px;
        width: 225px;
    }
    .auto-style4 {
        height: 23px;
        width: 225px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                <asp:Label ID="Lbl" runat="server"></asp:Label>
            </td>
            <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtname" ErrorMessage=" Plzzz" BorderStyle="Dotted" ForeColor="Lime"></asp:RequiredFieldValidator>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:TextBox ID="txtmail" runat="server" TextMode="Email"></asp:TextBox>
            </td>
            <td class="auto-style5">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" BorderColor="#990033" BorderStyle="Dotted" ForeColor="#000066" ToolTip="enter email">Make it easy</asp:RegularExpressionValidator>
            </td>
            <td class="auto-style2">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtmail" ErrorMessage="Plzz  Enter Email" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label3" runat="server" Text="Mobile"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="txtmob" runat="server" TextMode="Number"></asp:TextBox>
            </td>
            <td class="auto-style4">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" BorderStyle="Dashed" ControlToValidate="txtmob" ErrorMessage="not clever decision" ForeColor="#3333CC" ValidationExpression="[789][0-9]{9}"></asp:RegularExpressionValidator>
            </td>
            <td class="auto-style1">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" BorderColor="#FF0066" BorderStyle="Solid" ControlToValidate="txtmob" ErrorMessage="Must"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Address"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtadd" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtadd" ErrorMessage="We will not bomb ur house" BorderColor="#660033" BorderStyle="Dashed" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;&nbsp; &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label5" runat="server" Text="Password"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:TextBox ID="txtpass" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td class="auto-style5">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtpass" ErrorMessage="No one is watching" BorderStyle="Dashed" ForeColor="#FF6600"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label8" runat="server" Text="Re-Enter Password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="repass" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:CompareValidator ID="CompareValidator1" runat="server" BorderColor="#CC9900" BorderStyle="Dashed" ControlToCompare="txtpass" ControlToValidate="repass" ErrorMessage="Not Matched" ForeColor="Red"></asp:CompareValidator>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Preference"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="prf" runat="server">
                    <asp:ListItem>Veg</asp:ListItem>
                    <asp:ListItem>Non-Veg</asp:ListItem>
                    <asp:ListItem>Both</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Sign Up" Width="65px" OnClick="Button1_Click" />
            </td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>

