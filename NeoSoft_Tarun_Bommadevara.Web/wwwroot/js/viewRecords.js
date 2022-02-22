$(document).ready(function () {
    var controllerAction = "/Employee/UpdateUserTable";

    function getData(page) {
        var emailAddress = $("#emailAddress").val();
        var panNumber = $("#panNumber").val();
        //var roleId = $("#roleSelect").val();
        //var active = $("#activeSelect").val();
        var pageSize = $("#pageSizeSelect").val();

        var data = {
            emailAddress: emailAddress,
            panNumber: panNumber,
            //roleId: roleId,
            //active: active,
            page: page,
            pageSize: pageSize
        };

        return data;
    }

    function handleError() {
        // TODO : handle error here
        console.error("Failed to update table.");
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