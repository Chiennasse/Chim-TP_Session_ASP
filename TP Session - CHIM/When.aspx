<%@ Page Title="<%$ Resources:Site, title_quand %>" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="When.aspx.cs" Inherits="TP_Session___CHIM.When" UICulture="auto" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cp1" runat="server">

    <asp:Label
        ID="lb_instru_Cal"
        runat="server"
        Text="<%$ Resources:Site, lb_intruc %>"
        CssClass="lbCalInstru">
    </asp:Label>

    <div class="calendrier">
        <asp:Calendar
            ID="cal"
            runat="server">
        </asp:Calendar>

        <br /><br />

        <asp:Button
            ID="bt_date"
            runat="server"
            Text="<%$ Resources:Site, bt_date %>"
            PostBack="true"
            OnClick="bt_date_Click"/>
    </div>

    <br /><br /><br /><br />

    <asp:Label
        ID="lb_date_choisie"
        runat="server"
        Text="<%$ Resources:Site, lb_date_choisie %>"
        CssClass="lbDate">
    </asp:Label>

</asp:Content>
