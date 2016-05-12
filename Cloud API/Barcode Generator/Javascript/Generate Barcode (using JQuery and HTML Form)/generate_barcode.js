$(document).ready(function () {
    $("#resultBlock").hide();
    $("#errorBlock").hide();
});

$(document).on("click", "#submit", function () {
    var apiKey = $("#apiKey").val().trim(); //Get your API key by registering at http://www.bytescout.io/

    var url = "https://bytescout.io/api/v1/barcode/generate?apiKey=" + apiKey;
    var value = $("#inputValue").val();

    var options = {
        "properties": {
            "symbology": $("#barcodeType").val(),
            "foreColor": "Red",
            "margins": {
                "top": 0,
                "bottom": 0,
                "left": 0,
                "right": 0
            },
            "resolutionX": 50,
            "resolutionY": 50,
            "size": {
                "height": 100,
                "width": 100
            }
        },
        "input": value,
        "inputType": "value",
        "outputType": "link"
    };

    $.ajax({
        url: url,
        type: "POST",
        data: JSON.stringify(options),
        contentType: "application/json",
        success: function (link) {
            $("#resultBlock").show();
            $("#image").attr("src", link);
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
