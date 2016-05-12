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
    var pageIndex = $("#pageIndex").val();

    $.ajax({
        url: urlUploadFile,
        type: "POST",
        data: formData,
        cache: false,
        contentType: false,
        processData: false,
        success: function (fileId) {
            switch ($("#extractType").val()) {
                case "0":
                    ExtractText(apiKey, fileId, pageIndex);
                    break;
                case "1":
                    ExtractXML(apiKey, fileId, pageIndex);
                    break;
                case "2":
                    ExtractCSV(apiKey, fileId, pageIndex);
                    break;
                case "3":
                    ExtractInfo(apiKey, fileId);
                    break;
            }
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


function ExtractXML(apiKey, fileId, pageIndex) {
    var url = "https://bytescout.io/api/v1/pdfextractor/xmlextractor/extract?apiKey=" + apiKey;

    var options = {
        "properties": {
            "startPageIndex": pageIndex,
            "endPageIndex": pageIndex,
            "extractInvisibleText": false
        },
        "inputType": "fileId",
        "input": fileId
    };


    $.ajax({
        url: url,
        type: "POST",
        data: JSON.stringify(options),
        contentType: "application/json",
        success: function (response) {
            $("#resultBlock").show();
            $("#result").text(xmlToString(response));
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

function ExtractText(apiKey, fileId, pageIndex) {
    var url = "https://bytescout.io/api/v1/pdfextractor/textextractor/extract?apiKey=" + apiKey;

    var options = {
        "properties": {
            "startPageIndex": pageIndex,
            "endPageIndex": pageIndex,
            "rtlTextAutoDetectionEnabled": true,
            "detectLinesInsteadOfParagraphs": false
        },
        "inputType": "fileId",
        "input": fileId
    };
    
    $.ajax({
        url: url,
        type: "POST",
        data: JSON.stringify(options),
        contentType: "application/json",
        success: function (response) {
            $("#resultBlock").show();
            $("#result").text(response);
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

function ExtractCSV(apiKey, fileId, pageIndex) {
    var url = "https://bytescout.io/api/v1/pdfextractor/csvextractor/extract?apiKey=" + apiKey;

    var options = {
        "properties": {
            "startPageIndex": pageIndex,
            "endPageIndex": pageIndex,
            "columnDetectionMode": "contentGroups",
            "extractInvisibleText": false
        },
        "InputType": "FileId",
        "Input": fileId
    };
    
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

function ExtractInfo(apiKey, fileId) {
    var url = "https://bytescout.io/api/v1/pdfextractor/infoextractor/extract?apiKey=" + apiKey;

    var options = {
        "inputType": "fileId",
        "input": fileId
    };
    
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


function xmlToString(xmlData) {

    var xmlString;
    //IE
    if (window.ActiveXObject) {
        xmlString = xmlData.xml;
    }
    // code for Mozilla, Firefox, Opera, etc.
    else {
        xmlString = (new XMLSerializer()).serializeToString(xmlData);
    }
    return xmlString;
}
