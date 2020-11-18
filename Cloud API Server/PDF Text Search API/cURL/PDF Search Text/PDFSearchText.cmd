# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

curl --location --request POST 'https://localhost/pdf/find' \
--header 'x-api-key: {{x-api-key}}' \
--form 'url=https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-to-text/sample.pdf' \
--form 'searchString=Invoice Date \d+/\d+/\d+' \
--form 'pages=' \
--form 'password=' \
--form 'regexSearch=true'