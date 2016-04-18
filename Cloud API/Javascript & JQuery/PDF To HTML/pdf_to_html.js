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
            convertToHtml(apiKey, fileId);
        },
        error: function (response) {
            $("#errorBlock").show();
            $("#statusCode").html(response.status);
            $("#errors").html("");
            $.each(response.responseJSON.Errors, function() {
                $("#errors").append($("<li></li>").html(this));
            });
        }
    });
});


function convertToHtml(apiKey, fileId) {
    var url = "https://bytescout.io/api/v1/pdftohtml/htmlextractor/extract?apiKey=" + apiKey;

    var options = {
        "properties": {
            "extractInvisibleText": false,
            "trimSpaces": true,
            "outputImageFormat": "png",
            "outputPageWidth": 1200
        },
        "inputType": "fileId",
        "input": fileId,
        "outputType": "link"
    };
    
    $.ajax({
        url: url,
        type: "POST",
        data: JSON.stringify(options),
        contentType: "application/json",
        success: function (link) {
            $("#resultBlock").show();
            $("#result").attr("href", link).html(link);
        },
        error: function (response) {
            $("#errorBlock").show();
            $("#statusCode").html(response.status);
            $("#errors").html("");
            $.each(response.responseJSON.Errors, function() {
                $("#errors").append($("<li></li>").html(this));
            });
        }
    });
}
