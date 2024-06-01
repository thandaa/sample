<%@ Page Title="" Language="C#" MasterPageFile="~/UserInterface/Home/HomePageMaster/HomeMaster.Master" AutoEventWireup="true" CodeBehind="HomeView1.aspx.cs" Inherits="Webfront.UserInterface.HomeView.HomeView1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderSS" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderMainContent" runat="server">

        <div class="main">
           <div class="mainText">
            <h1>The Hospital that <br>Care for you</h1>
            <h3>Best Team's</h3>
            <!-- <p> Lorem ipsum dolor sit amet consectetur adipisicing elit</p> -->
            <button>Show More</button>
           </div>
           <img src='<%=ResolveUrl("../../../images/mains.png")%>' alt="">
        </div></asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderJS" runat="server">
</asp:Content>
