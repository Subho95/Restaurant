<%@ Page Title="" Language="C#" MasterPageFile="~/HomeG.master" AutoEventWireup="true" CodeFile="Add_Food.aspx.cs" Inherits="Add_Food" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:60%;">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Enter ID"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="foodid" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Food Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="foodname" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Price"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="foodprice" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" Width="126px" />
            </td>
            <td>
                <asp:Label ID="Lbl" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

