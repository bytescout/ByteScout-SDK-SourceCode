# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

curl --location --request POST 'https://localhost/pdf/edit/replace-text' \
--header 'Content-Type: application/json' \
--header 'x-api-key: {{x-api-key}}' \
--data-raw '{
  "url": "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-split/sample.pdf",
  "searchStrings": [
    "conspicuous feature",
    "Martian"
  ],
  "replaceStrings": [
    "Replaced1",
    "Replaced2"
  ],
  "caseSensitive": true,
  "pages": "",
  "password":"",
  "name": "finalFile"
  
}'