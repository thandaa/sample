<%@ Page Title="" Language="C#" MasterPageFile="~/UserInterface/Dashboard/AdminMaster/AdminMaster.Master" AutoEventWireup="true" CodeBehind="TeacherDetail.aspx.cs" Inherits="Webfront.UserInterface.RegisterTeacher.RegisterTeacher" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderCSS" runat="server">

<style>
        .btn_action {
            margin-right: 10px; /* Adjust the margin value as needed */
            margin: 3px;
        }
        .input-field {
    margin-bottom: 20px;
        }

.checkbox-group {
    margin-top: 20px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMainContent" runat="server">
         <main>
        <div class="container-fluid px-4">
            <h1 class="mt-4">Teachers</h1>
            <ol class="breadcrumb mb-4">
                <li class="breadcrumb-item"><a href="staff">Teachers List</a></li>
                <li class="breadcrumb-item active">Teacher form</li>
            </ol>
            <p class="text-muted">Please fill in the details below</p>
            <form class="row">
       
                <div class="col-4 mb-3 input-field">
                    <label for="tb_name" class="form-label">Teacher Name</label>
                    <input type="text" class="form-control" id="tb_name" >
                </div>
                <div class="col-4 mb-3 input-field">
                    <label for="tb_email" class="form-label">Email</label>
                    <input type="text" class="form-control" id="tb_email">
                </div>
                <div class="col-4 mb-3 input-field">
                    <label for="tb_phone" class="form-label">Phone Number</label>
                    <input type="text" class="form-control" id="tb_phone">
                </div>        
                <div class="col-4 mb-3 input-field">
                    <label for="position_option" class="form-label">Position</label>
                    <%--<input type="text" id="position" class="form-control" required>--%>
                    <div class="dropdown">
                    <select class="form-control" id="position_option">
                    </select>
                    </div>

                </div>
                <div class="col-4 mb-3 input-field">
                    <label for="tb_city" class="form-label">City</label>
                    <div class="dropdown">
                    <select class="form-control" id="city">
                    </select>
                        </div>
                </div>
        
                <div class="col-4 mb-3 input-field">
                    <label for="tb_age" class="form-label">Age</label>
                    <input type="number" class="form-control" id="tb_age">
                </div>
        
                <div class="col-4 mb-3 input-field">
                    <label for="startDateBox" class="form-label">Start Date</label>
                    <input type="date" class="form-control" id="startDateBox">
                </div>
        
                <div class="col-4 mb-3 input-field">
                    <label for="tb_salary" class="form-label">Salary</label>
                    <input type="number" class="form-control" id="tb_salary">
                </div>
        
                 <div class="col-4 mb-3 input-field">
                  <label class="form-label">Gender</label>
                  <div>
                    <div class="col-4 form-check form-check-inline">
                      <input class="form-check-input" type="radio" name="gender" id="rdo_male" value="Male" checked="true">
                      <label class="form-check-label" for="rdo_male">Male</label>
                    </div>
                    <div class="col-4 form-check form-check-inline">
                      <input class="form-check-input" type="radio" name="gender" id="rdo_female" value="Female">
                      <label class="form-check-label" for="rdo_female">Female</label>
                    </div>
                  </div>
                </div>




                <div class="col-4 mb-3 form-check">
                    <input type="checkbox" class="form-check-input" id="myanmar">
                    <label class="form-check-label" for="myanmar">Myanmar</label>
                </div>
                <div class="col-4 mb-3 form-check">
                    <input type="checkbox" class="form-check-input" id="english">
                    <label class="form-check-label" for="english">English</label>
                </div>
                <div class="col-4 mb-3 form-check">
                    <input type="checkbox" class="form-check-input" id="math">
                    <label class="form-check-label" for="math">Mathematics</label>
                </div>
                <div class="col-4 mb-3 form-check">
                    <input type="checkbox" class="form-check-input" id="chemistry">
                    <label class="form-check-label" for="chemistry">Chemistry</label>
                </div>
                <div class="col-4 mb-3 form-check">
                    <input type="checkbox" class="form-check-input" id="physics">
                    <label class="form-check-label" for="physics">Physics</label>
                </div>
                   <div class="col-4 mb-3 form-check">
                    <input type="checkbox" class="form-check-input" id="biology">
                    <label class="form-check-label" for="biology">Biology</label>
                </div>
        


               <div class="mb-3" style="display: flex; justify-content: flex-end;">
                    <button type="button" class="btn btn-primary btn_action" id="saveBtn" onclick="onSave();">Save Me</button>
                   <%--<button class="btn btn-primary" onclick="onSave()">Submit</button>--%>

                    <button type="button" class="btn btn-danger btn_action" id="deleteBtn" onclick="deleteConfirmation();">Delete</button>
                    <button type="button" class="btn btn-info btn_action" id="clearBtn" onclick="clearData();">Clear</button>
                </div>
             

              
                </form>
        </div>

    </main>



</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderJS" runat="server">
            <script src='<%=ResolveUrl("TeacherDetail.js") %>'></script>

</asp:Content>
