$(document).ready(function () {
    if ($("#radioBtnValue").val() == '1') {
        $("#flexRadioDefault1").attr('checked', true);
    }
    else {
        $("#flexRadioDefault2").attr('checked', true);
    }
    if ($("#checkBoxValue").val() == 'True') {
        $("#flexCheckDefault").attr('checked', true);
    }
    else {
        $("#flexCheckDefault").attr('checked', false);
    }
    //console.log($("#dob").val());
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
