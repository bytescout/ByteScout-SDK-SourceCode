curl --location --request POST 'https://api.pdf.co/v1/pdf/edit/replace-text' \
--header 'x-api-key: {{x-api-key}}' \
--form 'url=https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-to-text/sample.pdf' \
--form 'name=finalFile' \
--form 'caseSensitive=true' \
--form 'searchString=onspicuous feature' \
--form 'replaceString=Replaced1'