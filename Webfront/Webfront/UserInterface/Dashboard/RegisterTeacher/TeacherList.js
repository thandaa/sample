var template = $('#teacherTemplate').html();

GetAllTeacher();

function GetAllTeacher() {
    $.ajax({
        url: "https://localhost:44312/WebService/WebServiceTeacher.asmx/getAllTeacher",
        type: "POST",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            var teacherList = data.d; // Ensure the response is correctly parsed
            var allDataTemplate = '';


            console.log(JSON.stringify(teacherList), "list")
            $.each(teacherList, function (index, teacher) {
                var teacherRecord = template.replace('[No]', index + 1)
                    .replace('[ID]', teacher.TeacherID)
                    .replace('[TeacherName]', teacher.TeacherName)
                    .replace('[Email]', teacher.Email)
                    .replace('[PhoneNo]', teacher.PhoneNo)
                    .replace('[Position]', teacher.Position)
                    .replace('[City]', teacher.City)
                    .replace('[Age]', teacher.Age)
                    .replace('[StartDate]', JsonDateToFormat(teacher.StartDate, 'DD/MM/yyyy'))
                    .replace('[Salary]', formatSalaryWithCommas(teacher.Salary))
                    .replace('[Gender]', teacher.Gender);

                allDataTemplate += teacherRecord;
            });

            $('#teacherData').html('');

            $('#teacherData').html(allDataTemplate);
        },
        error: function (xhr, msg) {
            alert('Web Service Fail: ' + msg + '\n' + xhr.responseText);
        }
    });
}

function formatSalaryWithCommas(salary) {
    return Number(salary).toLocaleString();
}

function GoToDetailPage(id) {
    GotoPage('teacherdetail?id=' + id);
}


function LoadNew() {
    GotoPage('teacherdetail');
}


