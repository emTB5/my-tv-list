<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="masterPageLesson.register1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <script src="js/Register_JavaScript.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <h2>register page</h2>
                <input type="reset" value="delete" />
                <input type="submit" value="send" onclick="return checkRegister()"   />
                <div id="nameDiv"></div>
                <label>name:</label>
                <br />
                <input type="text" name="name" id="name" oninput="checkName()" />
                <br />
                <div id="password1Div"></div>
                <label>password:</label>
                <br />
                <input type="password" name="password1" id="password1" oninput="checkPassword1()" />
                <div id="password2Div"></div>
                <label>confirm password:</label>
                <br />
                <input type="password" name="password2" id="password2" oninput="checkPassword2()" />
                <div id="mailDiv"></div>
                <label>mail:</label>
                <br />
                <input type="text" name="mail" id="mail" oninput="checkMail()" />
                <br />
                <div id="radioDiv"></div>
                <p>Choose your gender:</p>
                <br />
                <input type="radio" name="gender" value="male" id="male">
                <label>male</label><br>
                <input type="radio" name="gender" value="female" id="female">
                <label>female</label><br>
                <input type="radio" name="gender" value="other" id="other">
                <label>other</label>
                <div id="checkBoxDiv"></div>
                <p>choose genre/s (one or more) :</p>
                <input type="checkbox" name="genre1" value="action"id="action">
                <label>action</label><br>
                <input type="checkbox" name="genre2" value="horror"id="horror">
                <label>horror</label><br>
                <input type="checkbox" name="genre3" value="comedy"id="comedy">
                <label>comedy</label><br>
                <input type="checkbox" name="genre4" value="romance"id="romance">
                <label>romance</label><br>
                <input type="checkbox" name="genre5" value="drama"id="drama">
                <label>drama</label><br>
                <input type="checkbox" name="genre6" value="fantasy"id="fantasy">
                <label>fantasy</label><br>
                <div id="birthdayDiv"></div>
                <label>Birthday:</label>
                <input type="date" name="birthday" id="birthday">
</asp:Content>
