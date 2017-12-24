<%@ Page Title="<%$ Resources:Site, Title_Home %>" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Acceuil.aspx.cs" Inherits="TP_Session___CHIM.Acceuil" UICulture="auto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="cp1" runat="server">
    <div class="tableauPhoto">
        <br />
        <asp:Label
            ID="lb_titre_acceuil"
            runat="server"
            Text="<%$ Resources:Site, lb_titre_acceuil %>"/>

        <br /> <br />

        <div class="tableauPhoto">
            <asp:Image
                ID="img_langue"
                runat="server"
                src="<%$ Resources:Site, imgLink1 %>"
                CssClass="imgAcceuil"/>
            <asp:Image
                ID="img_original"
                runat="server"
                src="images/godzila.jpg"
                CssClass="imgAcceuil"/>

            <br />

            <asp:Image
                ID="img_retouch"
                runat="server"
                src="images/photoshop.png"
                CssClass="imgAcceuil"/>

            <asp:Image
                ID="img_biere"
                runat="server"
                src="images/4 bières.jpg"
                CssClass="imgAcceuil"/>

        </div>
    </div>
</asp:Content>
