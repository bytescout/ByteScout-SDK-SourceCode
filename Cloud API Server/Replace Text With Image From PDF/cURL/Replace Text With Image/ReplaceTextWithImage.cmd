# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

curl --location --request POST 'https://localhost/pdf/edit/replace-text-with-image' \
--header 'x-api-key: {{x-api-key}}' \
--form 'url=https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-split/sample.pdf' \
--form 'caseSensitive=true' \
--form 'searchString=Hypothesis' \
--form 'replaceImage=https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/image-to-pdf/image1.png' \
--form 'pages=0'