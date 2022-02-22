$(document).ready(function () {
    var controllerAction = "/Employee/UpdateUserTable";
    $("form").on("submit", function (e) {
        e.preventDefault();

        var data = $("form").serialize();
        var url ="/Employee/GenerateCsvReports";

        $.ajax({
            data: data,
            url: url,
            type: "POST",
            success: function (response) {
                if (response.success) {
                    text = 'CSV report Generated sucessfully.';
                    alerts(text);
                    // showToast("Foxtrot report is sucessfull.");
                }
                else {
                    alerts("Failed to generate  csv reports");
                }
            },
            error: function () {
                alerts("Failed to generate csv reports");
            }
        })
    });

    function getData(page) {
        var emailAddress = $("#emailAddress").val();
        var panNumber = $("#panNumber").val();
        var pageSize = $("#pageSizeSelect").val();

        var data = {
            emailAddress: emailAddress,
            panNumber: panNumber,
            page: page,
            pageSize: pageSize
        };

        return data;
    }

    function handleError() {
        // TODO : handle error here
        console.error("Failed to update table.");
    }
    function alerts(message) {
        $(".modal-body").text(message)
        $("#alertModelTitle").text('Alert');
        $('#alertDiv').modal('show');
    }
    function updateTable(pageFunc) {
        var page = pageFunc();

        if (page != null) {
            var data = getData(page);
            snvUpdateTable(data, controllerAction, handleError);
        }
    }

    $("#search-button, #pageSizeSelect").click(function () {
        updateTable(function () { return 1; });
    });

    $("#page-up-control").click(function () {
        updateTable(snvPageUp);
    });

    $("#page-down-control").click(function () {
        updateTable(snvPageDown);
    });

    $("#page-first-control").click(function () {
        updateTable(snvPageFirst);
    });

    $("#page-last-control").click(function () {
        updateTable(snvPageLast);
    });
})