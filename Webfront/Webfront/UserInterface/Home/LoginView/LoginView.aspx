<%@ Page Title="" Language="C#" MasterPageFile="~/UserInterface/Home/HomePageMaster/HomeMaster.Master" AutoEventWireup="true" CodeBehind="LoginView.aspx.cs" Inherits="Webfront.UserInterface.LoginView.LoginView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderSS" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMainContent" runat="server">

        <div id="contact">
            <div class="head">
                <h1>Contact <span>Us</span></h1>
            </div>
            <div class="contact">
                <h1>Connect With Us</h1>
                <input type="text" placeholder="Enter Email" id="email">
                <input type="password" placeholder="Enter Password" id="pass">
                <button id="connectBtn">Connect</button>

            </div>
        </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderJS" runat="server">
</asp:Content>
