//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


// Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
// If it's not then please replace this with with your hosting url.

$(document).ready(function () {
    $("#resultBlock").hide();
    $("#errorBlock").hide();
});

$(document).on("click", "#submit", function () {
    var url = "https://localhost/barcode/generate?name=barcode.png";
    url += "&type=" + $("#barcodeType").val(); // Set barcode type (symbology)
    url += "&value=" + $("#inputValue").val(); // Set barcode value

    $.ajax({
        url: url,
        type: "GET"
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
