# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

$headers = New-Object "System.Collections.Generic.Dictionary[[String],[String]]"
$headers.Add("x-api-key", "{{x-api-key}}")

$multipartContent = [System.Net.Http.MultipartFormDataContent]::new()
$body = $multipartContent

$response = Invoke-RestMethod 'https://localhost/file/upload/get-presigned-url?name=test.pdf&encrypt=true' -Method 'GET' -Headers $headers -Body $body
$response | ConvertTo-Json