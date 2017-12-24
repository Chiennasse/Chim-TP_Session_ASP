<%@ Page Title="<%$ Resources:Site, connexion %>" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TP_Session___CHIM.Login" UICulture="auto "%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="cp1" runat="server">

    <div class="zoneLogin">
        <br />
        
        <asp:Label
            AssociatedControlID = "tb_nom"
            ID = "lb_nom"
            runat ="server"
            Text="<%$ Resources:Site, name %>"
            Cssclass="label"/>

        <asp:TextBox
             ID = "tb_nom"
             runat = "server"
             CssClass="tb"/>

        <br />

        <asp:Label
            ID = "lb_mail"
            runat = "server"
            Text = "<%$ Resources:Site, mail %>"
            AssociatedControlID = "tb_mail"
            Cssclass="label"/>

        <asp:TextBox
            ID = "tb_mail"
            runat = "server"
            Cssclass="tb"/>

        <br /> <br />

        <asp:Button
            ID="bt_login"
            runat="server"
            Text="<%$ Resources:Site, connexion %>"
            OnClick="bt_login_Click" 
            Cssclass="bouton"/>
        
    </div>

</asp:Content>