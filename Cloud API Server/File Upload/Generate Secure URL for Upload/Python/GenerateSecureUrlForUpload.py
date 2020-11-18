import requests

# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

url = "https://localhost/file/upload/get-presigned-url?name=test.pdf&encrypt=true"

payload = {}
files = {}
headers = {
		'x-api-key': '{{x-api-key}}'
}

response = requests.request("GET", url, headers=headers, data = payload, files = files)

print(response.text.encode('utf8'))
