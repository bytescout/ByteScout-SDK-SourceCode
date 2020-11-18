# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

curl --location --request POST 'https://localhost/file/delete?file=https://pdf-temp-files.s3.amazonaws.com/b5c1e67d98ab438292ff1fea0c7cdc9d/sample.pdf' \
--header 'x-api-key: {{x-api-key}}'