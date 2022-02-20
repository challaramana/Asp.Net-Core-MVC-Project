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
    console.log($("#radioBtnValue").val());
    if ($("#dob").val() == "0001-01-01") {
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




















//$(document).ready(function () {
//    $("form").on("submit", function (e) {
//        e.preventDefault();

//        var data = $("form").serialize();
//        var url = snvBaseUrl + "/Admin/UpdateLogLevel";

//        $.ajax({
//            data: data,
//            url: url,
//            type: "POST",
//            success: function (response) {
//                if (response.success) {
//                    showToast("Logging level successfully updated.");
//                }
//                else {
//                    showToast("Failed to update logging level.");
//                }
//            },
//            error: function () {
//                showToast("Failed to update logging level.");
//            }
//        })
//    });
//});




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
console.log($("#stateHidden").val());
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

