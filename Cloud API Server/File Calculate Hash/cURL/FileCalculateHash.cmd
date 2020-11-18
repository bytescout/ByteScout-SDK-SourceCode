# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

curl --location --request POST 'https://localhost/file/hash' \
--header 'x-api-key: {{x-api-key}}' \
--header 'Content-Type: application/json' \
--data-raw '{
    "url": "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-split/sample.pdf"
}'