import requests

url = "https://api.pdf.co/v1/job/check"

payload = {'jobid': '123'}
files = [

]
headers = {
		'x-api-key': '{{x-api-key}}'
}

response = requests.request("POST", url, headers=headers, data = payload, files = files)

print(response.text.encode('utf8'))
