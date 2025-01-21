//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
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
    url += "&async=True"; // Set async

    // Show loader
    $("#loader").show();

    $.ajax({
        url: url,
        type: "GET"
    })
        .done(function (data, textStatus, jqXHR) {

            if (data.error) {
                $("#errorBlock").show();
                $("#error").html(data.message);
                $("#loader").hide();
            }
            else {
                checkIfJobIsCompleted(data.jobId, data.url);
            }
        })
        .fail(function (jqXHR, textStatus, errorThrown) {
            $("#errorBlock").show();
            $("#error").html("Request failed. Please check you use the correct API key.");
            $("#loader").hide();
        });
});

function checkIfJobIsCompleted(jobId, resultFileUrl) {
    $.ajax({
        url: 'https://localhost/job/check?jobid=' + jobId,
        type: 'GET',
        success: function (jobResult) {

            $("#status").html(jobResult.status + ' &nbsp;&nbsp;&nbsp; <img src="ajax-loader.gif" />');

            if (jobResult.status == "working") {
                // Check again after 3 seconds
                setTimeout(function(){
                    checkIfJobIsCompleted(jobId, resultFileUrl);
                }, 3000);
            }
            else if (jobResult.status == "success") {
                $("#resultBlock").show();
                $("#image").attr("src", resultFileUrl);
            }

            $("#loader").hide();
        },
        error: function(){
            $("#errorBlock").show();
            $("#error").html("Request failed. Please check you use the correct API key.");
            $("#loader").hide();
        }
    });
}
