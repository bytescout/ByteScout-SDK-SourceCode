$(document).ready(function () {
    $("#resultBlock").hide();
    $("#errorBlock").hide();
});

$(document).on("click", "#submit", function () {
    $("#resultBlock").hide();
    $("#errorBlock").hide();

    var apiKey = $("#apiKey").val().trim(); //Get your API key by registering at http://www.bytescout.com/

    var url = "https://bytescout.io/api/v1/htmltopdf/convert?apiKey=" + apiKey;

    var options = {
        "properties": {
            "orientation": "Landscape",
            "margin": {
                "top": $("#marginTop").val(),
                "bottom": $("#marginBottom").val(),
                "left": $("#marginLeft").val(),
                "right": $("#marginRight").val()
            }
        },
        "inputType": $("#inputLink").val() ? "link" : "value",
        "input": $("#inputLink").val() || $("#inputValue").val(),
        "outputType": "link"
    };

    $.ajax({
        url: url,
        type: "POST",
        data: JSON.stringify(options),
        contentType: "application/json",
        success: function (response) {
            $("#resultBlock").show();
            $("#result").attr("href", response).html(response);
        },
        error: function (response) {
            $("#errorBlock").show();
            $("#statusCode").html(response.status);
            $("#errors").html("");
            $.each(response.responseJSON.Errors, function () {
                $("#errors").append($("<li></li>").html(this));
            });
        },
    });
});
