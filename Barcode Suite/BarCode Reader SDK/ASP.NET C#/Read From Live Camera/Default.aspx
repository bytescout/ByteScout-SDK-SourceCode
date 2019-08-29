<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1. Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <script src="http://ajax.microsoft.com/ajax/jquery/jquery-1.4.2.js" type="text/javascript"></script>  
    <script type="text/javascript" src="webcam.js"></script>
      <!-- this javascript plugin uses the webcam.swf file to capture image and send the image to server for further processing -->
    <script type="text/javascript">
        var canvas, context, timer;
        var constraints = window.constraints = {
            audio: false,
            video: { facingMode: "environment" } // change to "user" for front camera, see https://developer.mozilla.org/en-US/docs/Web/API/MediaTrackConstraints/facingMode
        };
        //  (HTML5 based camera only) this portion of code will be used when browser supports navigator.getUserMedia  *********     */
        window.addEventListener("DOMContentLoaded", function () {
            canvas = document.getElementById("canvasU"),
            context = canvas.getContext("2d"),
            video = document.getElementById("video"),
            videoObj = { "video": true },
            errBack = function (error) {
                console.log("Video capture error: ", error.code);
            };

            // check if we can use HTML5 based camera (through mediaDevices.getUserMedia() function)
            if (navigator.mediaDevices.getUserMedia) { // Standard browser
                // display HTML5 camera
                document.getElementById("userMedia").style.display = '';
                // adding click event to take photo from webcam
                document.getElementById("snap").addEventListener("click", function () {
                    context.drawImage(video, 0, 0, 640, 480);
                });

                navigator.mediaDevices
                    .getUserMedia(constraints)
                    .then(handleSuccess)
                    .catch(handleError);
            }
            // check if we can use HTML5 based camera (through .getUserMedia() function in Webkit based browser)
            else if (navigator.webkitGetUserMedia) { // WebKit-prefixed for Google Chrome
                // display HTML5 camera
                document.getElementById("userMedia").style.display = '';
                // adding click event to take photo from webcam
                document.getElementById("snap").addEventListener("click", function () {
                    context.drawImage(video, 0, 0, 640, 480);
                });
                navigator.webkitGetUserMedia(videoObj, function (stream) {
                    video.src = window.webkitURL.createObjectURL(stream);
                    video.play();
                }, errBack);
            }
            // check if we can use HTML5 based camera (through .getUserMedia() function in Firefox based browser)
            else if (navigator.mozGetUserMedia) { // moz-prefixed for Firefox 
                // display HTML5 camera
                document.getElementById("userMedia").style.display = '';
                // adding click event to take photo from webcam
                document.getElementById("snap").addEventListener("click", function () {
                    context.drawImage(video, 0, 0, 640, 480);
                });
                navigator.mozGetUserMedia(videoObj, function (stream) {
                    video.mozSrcObject = window.webkitURL.createObjectURL(stream);
                    video.play();
                }, errBack);
            }
            else
            // if we can not use any of HTML5 based camera ways then we use Flash based camera
            {
                // display Flash camera
                document.getElementById("flashDiv").style.display = '';
                document.getElementById("flashOut").innerHTML = (webcam.get_html(640, 480));
            }

        }, false);

        // (all type of camera) set the default selection of barcode type
        var selection = "All barcodes (slow)";

        // (all type of camera) gets the selection text of "barcode type to scan" combobox
        function selectType(type) {
            selection = type.options[type.selectedIndex].text;
        }

        function handleSuccess(stream) {
            var video = document.querySelector('video');
            var videoTracks = stream.getVideoTracks();
            console.log('Got stream with constraints:', constraints);
            console.log(`Using video device: ${videoTracks[0].label}`);
            window.stream = stream; // make variable available to browser console
            video.srcObject = stream;
        }

        function handleError(error) {
            if (error.name === 'ConstraintNotSatisfiedError') {
                var v = constraints.video;
                errorMsg(`The resolution ${v.width.exact}x${v.height.exact} px is not supported by your device.`);
            } else if (error.name === 'PermissionDeniedError') {
                errorMsg('Permissions have not been granted to use your camera and ' +
                    'microphone, you need to allow the page access to your devices in ' +
                    'order for the demo to work.');
            }
            errorMsg(`getUserMedia error: ${error.name}`, error);
        }

        function errorMsg(msg, error) {
            var errorElement = document.querySelector('#errorMsg');
            errorElement.innerHTML += `<p>${msg}</p>`;
            if (typeof error !== 'undefined') {
                console.error(error);
            }
        }

        // (HTML5 based camera only)
        // uploads the image to the server 
        function UploadToCloud() {        
            document.getElementById('report').innerHTML = "scanning the current frame......";
            context.drawImage(video, 0, 0, 640, 480);
            $("#upload").attr('disabled', 'disabled');
            $("#upload").attr("value", "Uploading...");
            var img = canvas.toDataURL('image/jpeg', 0.9).split(',')[1];
            // send AJAX request to the server with image data 
            $.ajax({
                url: "HTML5Camera.aspx/Upload",
                type: "POST",
                data: "{ 'image': '" + img + "' , 'type': '" + selection + "'}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                // on success output the result returned by the server side (See HTML5Camera.aspx)
                success: function (data, status) {
                    $("#upload").removeAttr('disabled');
                    $("#upload").attr("value", "Upload");
                    if (data.d.length != 0) {
                        var htmlSelect = document.getElementById('OutListBoxHTML5');
			    
			//var selectBoxOption = document.createElement("option");
	                //selectBoxOption.text = data.d;
        	        //selectBoxOption.id = "child";
                	//htmlSelect.insertBefore(selectBoxOption, htmlSelect.childNodes[0]);
	                htmlSelect.value = data.d + "\r\n" + htmlSelect.value;			    			    
                    }
                },
                // on error just show the message that no barcodes were found
                error: function (data) {
                    document.getElementById('report').innerHTML = "no barcode found, scanning.....";
                    $("#upload").removeAttr('disabled');
                    $("#upload").attr("value", "Upload");
                },
                async: false
            });
            timer = setTimeout(UploadToCloud, 3000);  // will capture new image to detect barcode after 3000 mili second
        }

        // (flash based camera only) stop the capturing 
        function stopCall() {
            document.getElementById('report').innerHTML = "STOPPED Scanning."
            clearTimeout(timer);
        }

        // (flash based camera only) sets the handler for callback completition to output the result
        Webcam.on('onComplete', 'my_completion_handler');
        
        // (flash based camera only) this function will start flash to capture image and send the image to the server for further processing (for IE)
        function take_snapshot() {
            // set api to be called by flash camera
            webcam.set_api_url('FlashCamera.aspx?type=' + selection);
            webcam.set_quality(100);
            // enable the shutter sound
            webcam.set_shutter_sound(true);
            document.getElementById('upload_results').innerHTML = '<h4>Scanning...</h4>';
            // capture image from the webcam
            webcam.snap();
            // set timout to capter new image (interval between captures)
            timer = setTimeout(take_snapshot, 3000);
        }

        // (flash based camera only) this one will work after recieving barcode from server
        // this function writes the output result back to the front page (from server side)
        function my_completion_handler(msg) {
            var str = msg;
            // encode into html compatible string
            var result = str.match(/<d>(.*?)<\/d>/g).map(function (val) {
                return val.replace(/<\/?d>/g, '');
            });
            // add new result into the listbox 
            var htmlSelect = document.getElementById('OutListBoxFlash');
            //var selectBoxOption = document.createElement("option");
            //selectBoxOption.text = result;
            //selectBoxOption.id = "child";
            //htmlSelect.insertBefore(selectBoxOption, htmlSelect.childNodes[0]);		
	    htmlSelect.value = result + "\r\n" + htmlSelect.value;	
		
            // reset webcam and flash to capture new image. this reset process flickers a little
            webcam.reset();         
        }

        // (flash based camera only) stop the scan and set the message on the page
        function stopScanning() {
            document.getElementById('upload_results').innerHTML = "STOPPED Scanning."
            clearTimeout(timer);
        }
    </script>
    <style>
    span
    {
        font-size:20px;
    }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <!-- HTML5 camera based capturing section -->
    <!-- this div block will be shown when browser supports get user media-->
        <div id="userMedia"  style="display:none; height: 575px; width: 1182px">  
        <table>
        <tr align="left" valign="top">
        <td valign="top" colspan="2">
        <h3 style=" color:Green; ">(HTML5 based camera) This works in Chrome, Firefox, Safari and other modern browsers with HTML5 support. If HTML5 camera is not enabled then Flash based camera should appear instead. To enable web-cam access answer ALLOW when asked if you want to give access to webcam </h3>
	<strong>IMPORTANT: html5 webcam access (Chrome, Firefox, Safari on desktop and iOS) requires SSL connection! Otherwise, web camera will not initialize at all as it requies SSL connection only. </strong>
        </td>
        </tr>
          <tr align="left" valign="top">
                <td valign="top">
                    <h2 id="choiceU"> <b>Barcode Type To Scan (to start barcode scan - click START below)</b></h2> 
                    <br />
          <select id="comboBoxBarCodeTypeHTML5" onchange="selectType(this)">
            <option value="1">All Barcodes (slow)</option>
            <option value="2">All Linear Barcodes (Code39, Code 128, EAN 13, UPCA, UPCE, etc.)</option>
            <option value="3">All 2D Barcodes (QR Code, Aztec, DataMatrix, PDF417, etc.)</option>
            <option value="4">Code 39c</option>
            <option value="5">Code 128</option>
            <option value="6">EAN 13</option>
            <option value="7">UPCA</option>
            <option value="8">GS1-128</option>
            <option value="9">GS1DataBarExpanded</option>
            <option value="10">GS1DataBarExpandedStacked </option>
            <option value="11">GS1DataBarLimited</option>
            <option value="12">GS1DataBarOmnidirectional</option>
            <option value="13">GS1DataBarStacked</option>
            <option value="14">I2of5</option>
            <option value="15">Intelligent Mail</option>
            <option value="16">Patch Code</option>
            <option value="17">PDF 417</option>
            <option value="18">QR Code</option>
            <option value="19">DataMatrix</option>
            <option value="20">Aztec</option>
            <option value="21">MaxiCode</option>
         </select>        
        <br />
        <span style=" font-size:20px; ">Output barcode values read appears below: </span>
        <br />
            <!-- decoding results appears in this listbox -->
            <textarea style="width:500px; height:100px;" size="8" id="OutListBoxHTML5"> 
            </textarea>
        <br />
            <input id="snap"  style="color:black; font-weight:bold; font-size:x-large;" type="button" onclick="UploadToCloud();" value="START READING BARCODES..." />
            <input id="pause" style="color:black;" type="button" onclick="stopCall();" value="STOP" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <h4 id="report" >
         </td>
         <td valign="top">   
            <span>Webcam preview shows below:</span>
            <video id="video" width="640" height="480" autoplay playsinline muted></video> 
         <!-- canvas with the output -->
       <canvas id="canvasU" width="640" height="480" style="display:none" ></canvas>     
                   
         </td>
         </tr>
         </table>
    </div>

    <!-- Flash (SWF) camera based capturing section -->
    <!-- this div block will be shown when browser does not support user media so the only way is to capture with flash (swf) camera -->
         <div id="flashDiv" style=" display:none; ">  
            <table>
            <tr align="left" valign="top">
            <td colspan="2"><h3 style=" color:Green; " >(FLASH based camera) This works in Internet Explorer 9+, Chrome, Firefox and other browsers with flash support. To enable web-cam access answer ALLOW when asked if you want to give access to webcam </h3></td>
            </tr>
            <tr align="left" valign="top">
                <td valign="top">
                    <h4 id="choice"> <b>Barcode Type To Scan (to start barcode scan - click START below)</b></h4> 
                    <br />
                     <select id="comboBoxBarCodeTypeFlash" onchange="selectType(this)">
            <option value="1">All Barcodes (slow)</option>
            <option value="2">All Linear Barcodes (Code39, Code 128, EAN 13, UPCA, UPCE, etc.)</option>
            <option value="3">All 2D Barcodes (QR Code, Aztec, DataMatrix, PDF417, etc.)</option>
            <option value="4">Code 39</option>
            <option value="5">Code 128</option>
            <option value="6">EAN 13</option>
            <option value="7">UPCA</option>
            <option value="8">GS1-128</option>
            <option value="9">GS1DataBarExpanded</option>
            <option value="10">GS1DataBarExpandedStacked </option>
            <option value="11">GS1DataBarLimited</option>
            <option value="12">GS1DataBarOmnidirectional</option>
            <option value="13">GS1DataBarStacked</option>
            <option value="14">I2of5</option>
            <option value="15">Intelligent Mail</option>
            <option value="16">Patch Code</option>
            <option value="17">PDF 417</option>
            <option value="18">QR Code</option>
            <option value="19">DataMatrix</option>
            <option value="20">Aztec</option>
            <option value="21">MaxiCode</option>
   </select>
            <br />
            <span style=" font-size:20px; ">Output barcode values read appears below: </span>
        <br />

            <!-- decoding results appears in this listbox -->
          <textarea style="width:500px; height:100px;" size="8" id="OutListBoxFlash"> </textarea>
    <br />
		<input type="button"  style="color:black; font-weight:bold; font-size:x-large;" value="START READING BARCODES.." onclick="take_snapshot()"/> &nbsp;&nbsp;&nbsp;
        <br />
        <input type="button" style="color:black; font-weight:bold; font-size:x-large;" value="STOP" onclick="stopScanning()"/>
        <br />                   
    </div>
    <div id="upload_results" style="background-color:#eee;"></div>
    </td>
    <td>    
    <div id="flashOut"> </div>
    </td>
   </tr>
    </table>
            
    </form>
   
</body>
</html>
