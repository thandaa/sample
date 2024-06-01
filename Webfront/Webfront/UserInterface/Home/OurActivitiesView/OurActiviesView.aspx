<%@ Page Title="" Language="C#" MasterPageFile="~/UserInterface/Home/HomePageMaster/HomeMaster.Master" AutoEventWireup="true" CodeBehind="OurActiviesView.aspx.cs" Inherits="Webfront.UserInterface.OurActivitiesView.OurActiviesView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderSS" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMainContent" runat="server">
        <div id="speciality">
            <div class="head">
                <h1>Our Speciality</h1>
            </div>
            <div class="surgery">
                <div class="surgeryCard">
                    <img src="s1.png" alt="">
                    <p>Succesfully Knee Surgery</p>
                    <p>Lorem ipsum dolor sit amet consectetur adipisicing.</p>
                </div>
                <div class="surgeryCard">
                    <img src="s2.png" alt="">
                    <p>Succesfully Knee Surgery</p>
                    <p>Lorem ipsum dolor sit amet consectetur adipisicing.</p>

                </div>
                <div class="surgeryCard">
                    <img src="s3.png" alt="">
                    <p>Succesfully Knee Surgery</p>
                    <p>Lorem ipsum dolor sit amet consectetur adipisicing.</p>

                </div>
            </div>
        </div>

        <div id="patient">
            <div class="head">
                <h1>Our Patient's Review</h1>
            </div>
            <div class="patients">
                <div class="patientCard">
                    <img src="p1.png" alt="">
                    <img src="p2.png" alt="">

                </div>
                <div class="patientCard">
                    <img src="p3.jpg" alt="">
                    <img src="p4.jpg" alt="">
                     

                      
                </div>
                <div class="patientCard">
                    <img src="p5.jpg" alt="">  
                    <img src="p6.jpg" alt="">                   
                   
                </div>
            </div>
        </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderJS" runat="server">
</asp:Content>
