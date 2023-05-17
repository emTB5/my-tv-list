<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="masterPageLesson.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="js/login_JavaScript.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>login page</h2>
    <hr />
    <input type="reset" value="delete" />
    <input type="submit" value="send" onclick="return checkLogin()" />
    <br />
    <label>name:</label>
    <br />
    <br />
    <div id="vName"></div>
    <input type="text" name="name" id="name" oninput="checkName()" />
    
    <br />
    
    <div id="vPassword"></div>
    <label>password:</label>
    <br />
    <input type="password" name="password" id="password" oninput="checkPassword()" />
    <br />
</asp:Content>
