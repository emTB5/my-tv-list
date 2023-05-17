<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Gallery.aspx.cs" Inherits="masterPageLesson.Gallery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="js/Gallery.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>Welcome to the Gallery where you can see posters of shows the photos switch automatically but if you want to stop and look at a specific one press stop and to continue the automatic switiching press start</p>
    <input type="button" value="start" onclick="Timer()" />
    <input type="button" value="stop" onclick="Stop()" />
  
    <br />
    <br />
    <img name="pic" src="gallery/1.jpg" width="30%" alt="pic" onload="Timer()" />

</asp:Content>
