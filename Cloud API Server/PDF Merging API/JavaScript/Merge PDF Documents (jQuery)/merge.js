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
    $("#result").attr("href", '').html('');
});

$(document).on("click", "#submit", function () {
    $("#resultBlock").hide();
    $("#errorBlock").hide();
    $("#inlineOutput").text(''); // inline output div
    $("#status").text(''); // status div

    var formData = new FormData();
    formData.append('name', 'result.pdf');
    
    // Append files in input request
    formData.append('file[]', $("#form input[type=file]")[0].files[0]);
    formData.append('file[]', $("#form input[type=file]")[1].files[0]);

    $("#status").html('Processing... &nbsp;&nbsp;&nbsp; <img src="ajax-loader.gif" />');

    $.ajax({
        url: 'https://localhost/pdf/merge',
        type: 'POST',
        
        data: formData,
        contentType: false, // NEEDED, DON'T OMIT THIS (requires jQuery 1.6+)
        processData: false, // NEEDED, DON'T OMIT THIS
        success: function (result) {
            $("#status").text('Success!');

            $("#resultBlock").show();
            $("#inlineOutput").html('<iframe style="width:100%; height:500px;" src="'+ result.url +'" />');
        },
        error: function () {
            $("#status").text('error');
        }
    });
 });
