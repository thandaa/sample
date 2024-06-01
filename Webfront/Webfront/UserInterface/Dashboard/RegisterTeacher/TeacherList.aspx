<%@ Page Title="" Language="C#" MasterPageFile="~/UserInterface/Dashboard/AdminMaster/AdminMaster.Master" AutoEventWireup="true" CodeBehind="TeacherList.aspx.cs" Inherits="Webfront.UserInterface.RegisterTeacher.TeacherList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderCSS" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMainContent" runat="server">
        <main>
    <div class="container-fluid px-4">
        <h1 class="mt-4">Tables</h1>
        <ol class="breadcrumb mb-4">
            <li class="breadcrumb-item"><a href="index.html">Dashboard</a></li>
            <li class="breadcrumb-item active">Teachers Lists</li>
        </ol>
        


        <div class="mb-4"></div>



        <div class="card mb-4">
            <div class="card-header">
                <i class="fas fa-table me-1"></i>
                DataTable Example
  
     <button type="button" class="btn btn-primary" style="float:right" onclick="LoadNew()">New Teacher</button>

            </div>
            <div class="card-body">
                <table class="table">
                    <thead>
                        <tr>
                            
                            <th>No</th>
                            <th>Teacher Name</th>
                            <th>Email</th>
                            <th>Phone No</th>
                            <th>Position</th>
                            <th>City</th>
                            <th>Age</th>
                            <th>Start date</th>
                            <th>Salary</th>
                            <th>Gender</th>

                          
                           
                        </tr>
                    </thead>                   
                    
                    <tbody id="teacherData"> </tbody>
                     
                    <tbody id="teacherTemplate" style="display:none">
                        <tr onclick="GoToDetailPage('[ID]')">
                            
                            <td>[No]</td>
                             <td>[TeacherName]</td>
                            <td>[Email]</td>
                            <td>[PhoneNo]</td>
                             <td>[Position]</td>
                             <td>[City]</td>
                             <td>[Age]</td>
                             <td>[StartDate]</td>
                             <td>[Salary]</td>
                            <td>[Gender]</td>
                            
                            
                            
                        </tr>
                    </tbody>


                </table>
            </div>
        </div>
    </div>
</main>   

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderJS" runat="server">
                <script src='<%=ResolveUrl("TeacherList.js") %>'></script>

</asp:Content>
