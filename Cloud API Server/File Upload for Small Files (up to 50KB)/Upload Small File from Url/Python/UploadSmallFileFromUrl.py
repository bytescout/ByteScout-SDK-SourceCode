import requests

# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

url = "https://localhost/file/upload/url"

payload = {'name': 'sample.pdf',
'url': 'https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-split/sample.pdf'}
files = [

]
headers = {
		'x-api-key': '{{x-api-key}}'
}

response = requests.request("POST", url, headers=headers, data = payload, files = files)

print(response.text.encode('utf8'))
