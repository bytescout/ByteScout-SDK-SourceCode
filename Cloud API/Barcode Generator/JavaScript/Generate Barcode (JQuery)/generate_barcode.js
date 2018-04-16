//*****************************************************************************************//
//                                                                                         //
// Download offline evaluation version (DLL): https://bytescout.com/download/web-installer //
//                                                                                         //
// Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   //
//                                                                                         //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               //
// http://www.bytescout.com                                                                //
//                                                                                         //
//*****************************************************************************************//


$(document).ready(function () {
    $("#resultBlock").hide();
    $("#errorBlock").hide();
});

$(document).on("click", "#submit", function () {
    var apiKey = $("#apiKey").val().trim(); //Get your API key by registering at http://www.bytescout.io/

    var url = "https://bytescout.io/v1/barcode/generate?name=barcode.png";
    url += "&type=" + $("#barcodeType").val(); // Set barcode type (symbology)
    url += "&value=" + $("#inputValue").val(); // Set barcode value

    $.ajax({
        url: url,
        type: "GET",
        headers: {
            "x-api-key": apiKey
        },
    })
    .done (function(data, textStatus, jqXHR) { 
        if (data.error == false) {
            $("#resultBlock").show();
            $("#image").attr("src", data.url);
        }
        else {
            $("#errorBlock").show();
            $("#error").html(data.message);
        }
    })
    .fail (function(jqXHR, textStatus, errorThrown) { 
        $("#errorBlock").show();
        $("#error").html("Request failed. Please check you use the correct API key.");
    });
});
