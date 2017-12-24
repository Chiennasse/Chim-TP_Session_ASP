<%@ Page Title="<%$ Resources:Site, title_ivresse %>" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Ivresse.aspx.cs" Inherits="TP_Session___CHIM.Ivresse" UICulture="auto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="cp1" runat="server">
    <div>

        <asp:Image
            ID="img1"
            runat="server"
            src="images/bread.jpg" />

        <asp:Image
            ID="Image4"
            runat="server"
            src="images/scooby.jpg" />

        <asp:Image
            ID="img2"
            runat="server"
            src="images/homer.png" />

        <br />

        <asp:Image
            ID="img5"
            runat="server"
            src="images/hum.jpg" />

        <asp:Image
            ID="img6"
            runat="server"
            src="images/eddie.jpg" />


        <br /> <br />

        <asp:Image
            ID="img3"
            runat="server"
            src="images/toutoune.png" />

    </div>
</asp:Content>