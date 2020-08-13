## How to display PDF in browser and select area using PDF in Javascript and PDF.js v2.x and ByteScout Robotic Process Automation ByteScout Robotic Process Automation is set of integrated APIs for quick replaccement of manual data processing with robotic process automations.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Robotic%20Process%20Automation%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Robotic%20Process%20Automation%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore Documentation](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Explore Source Code Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://app.pdf.co/signup?utm_source=github-readme)
[Security](https://pdf.co/security)
[Explore Web API Documentation](https://apidocs.pdf.co?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=gEjuZ0zgtHo](https://www.youtube.com/watch?v=gEjuZ0zgtHo)




<!-- code block begin -->

##### **code.js:**
    
```
// PDF file to display:
var url = 'https://cdn.mozilla.net/pdfjs/tracemonkey.pdf';
// Note: if absolute URL from the remote server is provided, 
// you should configure the CORS header on your server.

// Loaded via <script> tag, create shortcut to access PDF.js exports.
var pdfjsLib = window['pdfjs-dist/build/pdf'];

// The workerSrc property should be specified
pdfjsLib.GlobalWorkerOptions.workerSrc = 'https://cdnjs.cloudflare.com/ajax/libs/pdf.js/2.0.426/pdf.worker.js';

var pdfDoc = null,
  pageNum = 1,
  pageRendering = false,
  pageNumPending = null,
  scale = 1,
  canvas = document.getElementById('the-canvas'),
  ctx = canvas.getContext('2d');

/**
 * Get page info from document, resize canvas accordingly, and render page.
 * @param num Page number.
 */
function renderPage(num) {
  pageRendering = true;
  // Using promise to fetch the page
  pdfDoc.getPage(num).then(function (page) {
    var viewport = page.getViewport(scale);
    canvas.height = viewport.height;
    canvas.width = viewport.width;

    // Render PDF page into canvas context
    var renderContext = {
      canvasContext: ctx,
      viewport: viewport
    };
    var renderTask = page.render(renderContext);

    // Wait for rendering to finish
    renderTask.promise.then(function () {
      pageRendering = false;
      if (pageNumPending !== null) {
        // New page rendering is pending
        renderPage(pageNumPending);
        pageNumPending = null;
      }
    });
  });

  // Update page counters
  document.getElementById('page_num').textContent = num;
}

/**
 * If another page rendering in progress, waits until the rendering is
 * finised. Otherwise, executes rendering immediately.
 */
function queueRenderPage(num) {
  if (pageRendering) {
    pageNumPending = num;
  } else {
    renderPage(num);
  }
}

/**
 * Displays previous page.
 */
function onPrevPage() {
  if (pageNum <= 1) {
    return;
  }
  pageNum--;
  queueRenderPage(pageNum);
}
document.getElementById('prev').addEventListener('click', onPrevPage);

/**
 * Displays next page.
 */
function onNextPage() {
  if (pageNum >= pdfDoc.numPages) {
    return;
  }
  pageNum++;
  queueRenderPage(pageNum);
}
document.getElementById('next').addEventListener('click', onNextPage);

/**
 * Asynchronously downloads PDF.
 */
pdfjsLib.getDocument(url).then(function (pdfDoc_) {
  pdfDoc = pdfDoc_;
  document.getElementById('page_count').textContent = pdfDoc.numPages;

  // Initial/first page rendering
  renderPage(pageNum);
});


// Area selector
var startX,
  startY,
  selectedBoxes = [],
  $selectionMarquee = $('#selectionMarquee'),
  clearSelectedAreasBtn = $('#clearSelectedAreasBtn'),
  wrapper = $("#canvas-wrap"),
  wrapperObj = wrapper[0],
  $allCords = $('#all-cords'),
  positionBox = function ($box, coordinates) {
    $box.css(
      'top', coordinates.top + wrapperObj.offsetTop
    ).css(
      'left', coordinates.left + wrapperObj.offsetLeft
    ).css(
      'height', coordinates.bottom - coordinates.top
    ).css(
      'width', coordinates.right - coordinates.left
    ).css(
      'border', 'solid grey 1px'
    );
  },

  compareNumbers = function (a, b) {
    return a - b;
  },
  getBoxCoordinates = function (startX, startY, endX, endY) {
    var x = [startX, endX].sort(compareNumbers),
      y = [startY, endY].sort(compareNumbers);

    return {
      top: y[0],
      left: x[0],
      right: x[1],
      bottom: y[1]
    };
  },
  trackMouse = function (event) {
    var position = getBoxCoordinates(startX, startY, event.pageX - wrapperObj.offsetLeft, event.pageY - wrapperObj.offsetTop);
    console.log(position);
    positionBox($selectionMarquee, position);
  },
  displayCoordinates = function () {
    var msg = 'Areas:\n';

    if (!selectedBoxes.length) {
      $allCords.html('');
      return;
    }
    selectedBoxes.forEach(function (box) {
      msg += '<li>(' + box.left + ', ' + box.top + ') - (' + (box.right) + ', ' + (box.bottom) + ')</li>';
    });

    $allCords.html(msg);
  },
  endMoving = function (event) {
    var position,
      $selectedBox;

    $selectionMarquee.hide();

    position = getBoxCoordinates(startX, startY, event.pageX - wrapperObj.offsetLeft, event.pageY - wrapperObj.offsetTop);

    if (position.left !== position.right && position.top !== position.bottom) {
      $selectedBox = $('<div class="selected-box selected-box-item"></div>');
      $selectedBox.hide();
      wrapper.append($selectedBox);

      positionBox($selectedBox, position, wrapper[0]);

      $selectedBox.show();

      selectedBoxes.push(position);
      displayCoordinates();

      wrapper.off('mousemove', trackMouse);
      $selectionMarquee.off('mousemove', trackMouse);
      $selectionMarquee.off('mouseup', endMoving);
    }
  };

wrapper.on('mousedown', function (event) {
  event.preventDefault();
  startX = event.pageX - wrapperObj.offsetLeft;
  startY = event.pageY - wrapperObj.offsetTop;
  positionBox($selectionMarquee, getBoxCoordinates(startX, startY, startX, startY), this);
  $selectionMarquee.show();

  wrapper.on('mousemove', trackMouse);
  $selectionMarquee.on('mousemove', trackMouse);
  $selectionMarquee.on('mouseup', endMoving);
}).on('mouseup', endMoving);

clearSelectedAreasBtn.on('click', function (event) {
  selectedBoxes = [];
  $('.selected-box-item').remove();
  displayCoordinates();
});
```

<!-- code block end -->