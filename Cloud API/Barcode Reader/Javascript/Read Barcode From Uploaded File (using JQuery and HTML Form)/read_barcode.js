$(document).ready(function () {
    $("#resultBlock").hide();
    $("#errorBlock").hide();
});

$(document).on("click", "#submit", function () {
    $("#resultBlock").hide();
    $("#errorBlock").hide();

    var apiKey = $("#apiKey").val().trim(); //Get your API key by registering at http://www.bytescout.com/

    var urlUploadFile = "https://bytescout.io/api/v1/file/upload?apiKey=" + apiKey;

    var formData = new FormData($("#form")[0]);

    $.ajax({
        url: urlUploadFile,
        type: "POST",
        data: formData,
        cache: false,
        contentType: false,
        processData: false,
        success: function (fileId) {
            ReadBarcodes(apiKey, fileId);
        },
        error: function (response) {
            $("#errorBlock").show();
            $("#statusCode").html(response.status);
            $("#errors").html("");
            $.each(response.responseJSON.Errors, function () {
                $("#errors").append($("<li></li>").html(this));
            });
        }
    });
});

function ReadBarcodes(apiKey, fileId) {
    var url = "https://bytescout.io/api/v1/barcodereader/read?apiKey=" + apiKey;

    var options = {
        "properties": {
            "startPageIndex": 0,
            "endPageIndex": 0,
            "barcodeTypesToFind": {},
        },
        "input": fileId,
        "inputType": "fileId"
    };

    var barcodeTypesToFind = {};
    $.each($("#barcodeTypesToFind").val(), function () {
        barcodeTypesToFind[this] = true;
    });
    options["properties"]["barcodeTypesToFind"] = barcodeTypesToFind;

    $.ajax({
        url: url,
        type: "POST",
        data: JSON.stringify(options),
        contentType: "application/json",
        success: function (response) {
            $("#resultBlock").show();
            $("#result").html(response);
        },
        error: function (response) {
            $("#errorBlock").show();
            $("#statusCode").html(response.status);
            $("#errors").html("");
            $.each(response.responseJSON.Errors, function () {
                $("#errors").append($("<li></li>").html(this));
            });
        }
    });
}
