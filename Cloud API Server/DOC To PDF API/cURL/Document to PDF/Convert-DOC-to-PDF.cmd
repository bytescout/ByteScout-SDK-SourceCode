# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

curl --location --request POST 'https://localhost/pdf/convert/from/doc' \
--header 'x-api-key: {{x-api-key}}' \
--form 'encrypt=true' \
--form 'url=https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/doc-to-pdf/sample.docx' \
--form 'name=result.pdf'