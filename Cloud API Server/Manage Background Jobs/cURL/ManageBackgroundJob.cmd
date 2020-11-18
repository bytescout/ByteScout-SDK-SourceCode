# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

curl --location --request POST 'https://localhost/job/check' \
--header 'x-api-key: {{x-api-key}}' \
--form 'jobid=123'