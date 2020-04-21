## How to display PDF in browser and select area using PDF in Javascript and PDF.js v1.x using Multiple ByteScout SDK

### This tutorial will show how to display PDF in browser and select area using PDF in Javascript and PDF.js v1.x

Every ByteScout tool contains example Javascript and PDF.js v1.x source codes that you can find here or in the folder with installed ByteScout product. Multiple ByteScout SDK is Bundle of SDK components can be used to implement multistep workflow. For example, multiple SDKs can be used to implement 2-3 steps code like a search for keywords inside documents and highlights of results found or app that splits pdf based on visually detected lines inside documents and you can use it to display PDF in browser and select area using PDF with Javascript and PDF.js v1.x.

Javascript and PDF.js v1.x code samples for Javascript and PDF.js v1.x developers help to speed up coding of your application when using Multiple ByteScout SDK. Follow the instructions from the scratch to work and copy the Javascript and PDF.js v1.x code. Enjoy writing a code with ready-to-use sample codes in Javascript and PDF.js v1.x.

Download free trial version of Multiple ByteScout SDK from our website with this and other source code samples for Javascript and PDF.js v1.x.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=Multiple%20ByteScout%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=Multiple%20ByteScout%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=NEwNs2b9YN8](https://www.youtube.com/watch?v=NEwNs2b9YN8)




<!-- code block begin -->

##### ****code.js:**
    
```
// PDF file to display:
var url = 'https://cdn.mozilla.net/pdfjs/tracemonkey.pdf';
// Note: if absolute URL from the remote server is provided, 
// you should configure the CORS header on your server.

// The workerSrc property should be specified
PDFJS.workerSrc = 'https://cdnjs.cloudflare.com/ajax/libs/pdf.js/1.10.97/pdf.worker.js';

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

    // Wait until the end of the rendering
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
 * If another page rendering in progress, wait until it finished; 
 * otherwise, execute the rendering immediately.
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
  displayCoordinates();
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
  displayCoordinates();
  queueRenderPage(pageNum);
}
document.getElementById('next').addEventListener('click', onNextPage);

/**
 * Download PDF asynchronously.
 */
PDFJS.getDocument(url).then(function (pdfDoc_) {
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

clearSelectedAreasBtn.on('click', function(event){
  selectedBoxes = [];
  $('.selected-box-item').remove();
  displayCoordinates();
});
```

<!-- code block end -->