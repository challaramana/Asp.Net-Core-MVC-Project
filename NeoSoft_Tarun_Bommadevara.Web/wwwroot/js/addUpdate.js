$(document).ready(function () {
    if ($("#stateHidden").val() != "") {
        getCountryData($("#stateHidden").val());
    }
    if ($("#cityHidden").val() != "") {
        getStateData($("#cityHidden").val());
    }
    if ($("#radioBtnValue").val() == '1') {
        $("#flexRadioDefault1").attr('checked', true);
    }
    else if ($("#radioBtnValue").val() == '0') { 
        $("#flexRadioDefault2").attr('checked', true);
    }
    if ($("#checkBoxValue").val() == 'True') {
        $("#flexCheckDefault").attr('checked', true);
    }
    else {
        $("#flexCheckDefault").attr('checked', false);
    }
   
    $(".report-datepicker").datepicker();
    $("#dob").datepicker("option", "dateFormat", "mm/dd/yy");
    $("#doj").datepicker("option", "dateFormat", "mm/dd/yy");
    $("#dob").datepicker("option", "maxDate", new Date());
    $("#doj").datepicker("option", "maxDate", new Date());
    if ($("#dob").val() == "01/01/2001") {
        $("#dob").val('')
    }    
});
function addCheckboxValue() {
    if ($("#flexCheckDefault").is(":checked")) {
        $("#checkBoxValue").val(true);
    }
    else {
        $("#checkBoxValue").val(false);
    }
}
function addRadioValue() {
    if ($("#flexRadioDefault1").is(":checked")) {
        $("#radioBtnValue").val('1');
    }
    else {
        $("#radioBtnValue").val('0');
    }
}
function listofFilesUploaded() {
    $("#fileName").empty();
    var fp = $("#uploadBox");
    var lg = fp[0].files.length;
    var items = fp[0].files;
    var fragment = "";
    if (lg > 0) {
        for (var i = 0; i < lg; i++) {
            var fileName = items[i].name; // get file name
            var fileSize = items[i].size; // get file size 
            var fileType = items[i].type; // get file type
            fragment += "<li>" + fileName + " (<b>" + fileSize + "</b> bytes) - Type :" + fileType + "</li>";
        }
        $("#fileName").show();
    } 
    $("#fileName").append(fragment);

}
function getCountryData(i) {
    var url = "/Employee/GetStateDropdownData";
    let value = i != "" ? i : $("#countryId").val();
    $.ajax({
        data: { id: value },
        url: url,
        type: "POST",
        success: function (responseData) {
            if (responseData != null && responseData.length != 0) {
                $("#stateId").empty();
                $("#stateId").append('<option value=' + "" + '>' + "--Please Select--" + '</option>')
                $.each(responseData, function (index, row) {
                    $("#stateId").append('<option value=' + row.row_Id + '>' + row.stateName + '</option>')
                });
                $("#stateId").val(i);
               /* $("#cityId").val("");*/
            }
            else {
                $("#stateId").empty();
                $("#stateId").append("'<option value='" + "" + "'>" + "--Please Select--" + "</option>")
            }
        },
        error: function () {
            console.log("Failed to update state List.");
        }
    })
};
function getStateData(i) {
    let value = i != "" ? i : $("#stateId").val();
    var url = "/Employee/GetCityDropdownData";
    $.ajax({
        data: { id: value },
        url: url,
        type: "POST",
        success: function (responseData) {
            if (responseData != null && responseData.length != 0) {
                $("#cityId").empty();
                $("#cityId").append('<option value=' + "" + '>' + "--Please Select--" + '</option>')
                $.each(responseData, function (index, row) {
                    $("#cityId").append('<option value=' + row.row_Id + '>' + row.cityName + '</option>')
                });
                $("#cityId").val(i);
            }
            else {
                $("#cityId").empty();
                $("#cityId").append("'<option value='" + "" + "'>" + "--Please Select--" + "</option>")
            }
        },
        error: function () {
            console.log("Failed to update city List.");
        }
    })
};

