# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

curl --location --request GET 'https://localhost/file/upload/get-presigned-url?name=test.pdf&encrypt=true' \
--header 'x-api-key: {{x-api-key}}'