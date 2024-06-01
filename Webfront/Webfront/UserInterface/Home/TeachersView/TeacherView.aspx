<%@ Page Title="" Language="C#" MasterPageFile="~/UserInterface/Home/HomePageMaster/HomeMaster.Master" AutoEventWireup="true" CodeBehind="TeacherView.aspx.cs" Inherits="Webfront.UserInterface.TeachersView.TeacherView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderSS" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMainContent" runat="server">
     <div id="doctors">
            <div class="head">
                <h1>Our Teachers</h1>
            </div>
            <div class="teachers">
                <div class="card">
                    <img src='<%=ResolveUrl("../../../images/dt1.jpg")%>' alt="">
                    <p>Dr Alexa</p>
                    <p>Surgeon</p>

                </div>
                <div class="card">
                    <img src='<%=ResolveUrl("../../../images/dt2.jpg")%>' alt="">
                    
                    <p>Dr Alexa</p>
                    <p>Surgeon</p>

                </div>
                <div class="card">
                    <img src='<%=ResolveUrl("../../../images/dt3.jpg")%>' alt="">
                    
                    <p>Dr Alexa</p>
                    <p>Surgeon</p>

                </div>
            </div>
        </div>
    </asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderJS" runat="server">
</asp:Content>
