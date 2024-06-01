var recordID = GetURLData('id');
getPosition();
getCity();
if (recordID) 
    getTeacher();



function getCity() {
    $.ajax({
        url: "https://localhost:44312/WebService/WebServiceCity.asmx/getAllCity",
        data: [],
        dataType: 'json',
        type: "POST",
        contentType: "application/json; charset=utf-8",
        success: function (data) {
            var cityList = data.d;
            console.log(JSON.stringify(cityList), "list")
            $.each(cityList, function (index, item) {
                $('#city').append($('<option>', {
                    value: item.CitydID,
                    text: item.CityName
                }));
            });
        },
        error: function (xhr, msg) {
            /*  LogJSError('Web Service Fail: ' + msg + '\n' + xhr.responseText);*/
            alert('Web Service Fail: ' + msg + '\n' + xhr.responseText)

        }
    })

}
function getPosition() {
    $.ajax({
        url: "https://localhost:44312/WebService/WebServicePosition.asmx/getAllPosition",
        data: [],
        dataType: 'json',
        type: "POST",
        contentType: "application/json; charset=utf-8",
        success: function (data) {
            var positionList = data.d;
            console.log(JSON.stringify(positionList), "list")
            $.each(positionList, function (index, item) {
                $('#position_option').append($('<option>', {
                    value: item.PositionID,
                    text: item.PositionName
                }));
            });
        },
        error: function (xhr, msg) {
            /*  LogJSError('Web Service Fail: ' + msg + '\n' + xhr.responseText);*/
            alert('Web Service Fail: ' + msg + '\n' + xhr.responseText)

        }
    })

}
function getTeacher() {
    var param = { id: recordID };

    $.ajax({
        url: "https://localhost:44312/WebService/WebServiceTeacher.asmx/getTeacher",
        data: JSON.stringify(param),
        dataType: 'json',
        type: "POST",
        contentType: "application/json; charset=utf-8",
        success: function (data) {
            var teacher = data.d;
            $('#tb_name').val(teacher.TeacherName);
            $('#tb_email').val(teacher.Email);
            $('#tb_phone').val(teacher.PhoneNo);
            $('#position').val(teacher.Position);
            $('#tb_city').val(teacher.City);
            $('#tb_age').val(teacher.Age);
            $('#startDateBox').val(JsonDateToFormat(teacher.StartDate, "yyyy-MM-DD"));
            $('#tb_salary').val(teacher.Salary);

            if (teacher.Gender === "Male") {
                $('#rdo_male').prop('checked', true);
            } else {
                $('#rdo_female').prop('checked', true);
            }

            $('#myanmar').prop('checked', teacher.Myanmar);
            $('#english').prop('checked', teacher.English);
            $('#mathematics').prop('checked', teacher.Mathematics);
            $('#chemistry').prop('checked', teacher.Chemistry);
            $('#physics').prop('checked', teacher.Physics);
            $('#biology').prop('checked', teacher.Biology);
        },
        error: function (xhr, status, error) {
            console.error("AJAX Error:", status, error);
            alert("Failed to fetch teacher data. Please try again later.");
        }
    });
}



function onSave() {
    var param = {
        id: recordID,
        name: $('#tb_name').val(),
        email: $('#tb_email').val(),
        phoneno: $('#tb_phone').val(),
        position: $('#position_option').val(),
        city: $('#city').val(),
        age: $('#tb_age').val(),
        startdate: $('#startDateBox'), // Assuming startDateBox directly returns the date value
        salary: $('#tb_salary').val(),
        gender: $('input[name="gender"]:checked').val(),
        myanmar: $('#myanmar').prop('checked'),
        english: $('#english').prop('checked'),
        mathematics: $('#mathematics').prop('checked'),
        chemistry: $('#chemistry').prop('checked'),
        physics: $('#physics').prop('checked'),
        biology: $('#biology').prop('checked'),
    };

    $.ajax({
        url: "https://localhost:44312/WebService/WebServiceTeacher.asmx/saveTeacher",
        data: JSON.stringify(param),
        dataType: 'json',
        type: "POST",
        contentType: "application/json; charset=utf-8",
        success: function (data) {
            console.log("success")
           

            // Update recordID if necessary
            //if (!recordID) {
            //    recordID = data.d; // Assuming the server returns the new record ID
            //}

            //clearData();
            //$('#deleteBtn').show();
        },
        error: function (xhr, msg) {
            alert('Web Service Fail: ' + msg + '\n' + xhr.responseText);
            console.log('Web Service Fail: ' + msg + '\n' + xhr.responseText)
        }
    });
}
