<%@ Page Title="" Language="C#" MasterPageFile="~/HomeG.master" AutoEventWireup="true" CodeFile="A_T_B.aspx.cs" Inherits="A_T_B" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:60%;">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>THANK&nbsp;&nbsp;&nbsp;&nbsp; YOU&nbsp;&nbsp;&nbsp;&nbsp; FOR&nbsp;&nbsp;&nbsp; YOUR&nbsp;&nbsp;&nbsp;&nbsp; BOOKING!!!!!</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>WE WILL BE WAITING FOR U!!!</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>Booking_Id:</td>
            <td>
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="View" Width="88px" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Customer_After_Login.aspx">Your Home</asp:LinkButton>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>

