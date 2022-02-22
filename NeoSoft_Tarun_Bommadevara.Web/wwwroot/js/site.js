// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var blockUI = function () {
    $.blockUI({
        message: '<h2 class="loader">Please wait...</h2>',
        css: {
            border: 'none',
            padding: '15px',
            backgroundColor: '#000',
            '-webkit-border-radius': '10px',
            '-moz-border-radius': '10px',
            opacity: .5,
            color: 'rgb(178, 178, 178)',

        }
    });
};

function snvPageUp() {
    var page = $("#snv-table-body").data("pagenum") + 1;

    if (!snvValidatePageNum(page)) {
        return;
    }

    return page;
}

function snvPageDown() {
    var page = $("#snv-table-body").data("pagenum") - 1;

    if (!snvValidatePageNum(page)) {
        return;
    }

    return page;
}

function snvPageFirst() {
    var currentPage = $("#snv-table-body").data("pagenum");

    if (currentPage === 1) {
        return;
    }

    var firstPage = 1;
    return firstPage;
}

function snvPageLast() {
    var lastPage = $("#snv-table-body").data("totalpages");
    var currentPage = $("#snv-table-body").data("pagenum");

    if (lastPage === currentPage || lastPage === 0) {
        return;
    }

    return lastPage;
}

function snvValidatePageNum(pageNum) {
    var total = $("#snv-table-body").data("totalpages");
    return pageNum > 0 && pageNum <= total;
}

function snvUpdatePageDisplay() {
    // Get current/total page values now that the table is updated
    var currentPage = $("#snv-table-body").data("pagenum");
    var pageCount = $("#snv-table-body").data("totalpages");

    // Force page count of at least 1
    pageCount = pageCount == 0 ? 1 : pageCount;

    // Update display text
    var displayText = "Page: " + currentPage + "/" + pageCount;
    $("#page-num-display").html(displayText);
}

function snvUpdateTable(data, controllerAction, error) {
    $.ajax({
        url:  controllerAction,
        data: data,
        type: "GET",
        success: function (response) {
            $("#snv-table-body").replaceWith(response);
            snvUpdatePageDisplay();
        },
        error: error
    });
}
