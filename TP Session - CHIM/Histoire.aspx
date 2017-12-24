<%@ Page Title="<%$ Resources:Site, title_histoire %>" Language="C#" MasterPageFile="~/MasterSecondaire.Master" AutoEventWireup="true" CodeBehind="Histoire.aspx.cs" Inherits="TP_Session___CHIM.Histoire" UICulture="auto" %>


<asp:Content ID="Content2" ContentPlaceHolderID="Content7" runat="server">

    <div class="titreH">
        <br />
        <asp:Label
            ID="titre_histoire"
            Text="<%$ Resources:Site, H_histoire %>"
            runat="server"/>
    </div>

    

    <div class="txt">
        <asp:Label
            ID="txt1"
            runat="server"
            Text="<%$ Resources:Site, txt1 %>" />
     
        <br /> <br />

        <asp:Label
            ID="txt2"
            runat="server"
            Text="<%$ Resources:Site, txt2 %>" />

        <br /> <br />

        <asp:Label
            ID="txt3"
            runat="server"
            Text="<%$ Resources:Site, txt3 %>" />

        <br /> <br />

        <asp:Label
            ID="txt4"
            runat="server"
            Text="<%$ Resources:Site, txt4 %>" />

        <br /> <br />

        <asp:Label
            ID="txt5"
            runat="server"
            Text="<%$ Resources:Site, txt5 %>" />

        <br /> <br />

        <asp:Label
            ID="txt6"
            runat="server"
            Text="<%$ Resources:Site, txt6 %>" />
    </div>

</asp:Content>
