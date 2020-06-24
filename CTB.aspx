<%@ Page Title="" Language="C#" MasterPageFile="~/HomeG.master" AutoEventWireup="true" CodeFile="CTB.aspx.cs" Inherits="CTB" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style1 {
        height: 23px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:60%;">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="No. of Table"></asp:Label>
            </td>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
            <td>&nbsp;&nbsp;<asp:TextBox ID="txttb" runat="server" TextMode="Number"></asp:TextBox>
               </td>
            <td>
                <asp:Label ID="Lbl" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Date</td>
            <td>&nbsp;</td>
            <td>
                <asp:TextBox ID="txtd" runat="server" TextMode="Date"></asp:TextBox>
            </td>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Session</td>
            <td class="auto-style1">
                &nbsp;</td>
            <td class="auto-style1">
                <asp:DropDownList ID="Ss" runat="server">
                    <asp:ListItem>Lunch</asp:ListItem>
                    <asp:ListItem>Dinner</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style1">
                &nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="avail2" runat="server" OnClick="avail2_Click" Text="Check Avail" />
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="BookTable" Width="97px" />
            </td>
            <td>
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Checkout" />
            </td>
        </tr>
    </table>
</asp:Content>

