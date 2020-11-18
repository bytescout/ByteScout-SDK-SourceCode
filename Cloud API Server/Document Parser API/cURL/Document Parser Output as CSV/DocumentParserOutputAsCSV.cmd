# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

curl --location --request POST 'https://localhost/pdf/documentparser' \
--header 'Content-Type: application/json' \
--header 'x-api-key: {{x-api-key}}' \
--data-raw '{
    "url": "https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/document-parser/sample-invoice.pdf",
    "templateId": "1",
    "outputFormat": "CSV",
    "generateCsvHeaders": true,

    "async": false,
    "encrypt": "false",
    "inline": "true",
    "password": "",
    "storeResult": false

}'