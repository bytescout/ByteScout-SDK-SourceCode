# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

$headers = New-Object "System.Collections.Generic.Dictionary[[String],[String]]"
$headers.Add("x-api-key", "{{x-api-key}}")

$multipartContent = [System.Net.Http.MultipartFormDataContent]::new()
$stringHeader = [System.Net.Http.Headers.ContentDispositionHeaderValue]::new("form-data")
$stringHeader.Name = "url"
$StringContent = [System.Net.Http.StringContent]::new("https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-split/sample.pdf")
$StringContent.Headers.ContentDisposition = $stringHeader
$multipartContent.Add($stringContent)

$stringHeader = [System.Net.Http.Headers.ContentDispositionHeaderValue]::new("form-data")
$stringHeader.Name = "name"
$StringContent = [System.Net.Http.StringContent]::new("result.pdf")
$StringContent.Headers.ContentDisposition = $stringHeader
$multipartContent.Add($stringContent)

$stringHeader = [System.Net.Http.Headers.ContentDispositionHeaderValue]::new("form-data")
$stringHeader.Name = "pages"
$StringContent = [System.Net.Http.StringContent]::new("1-2")
$StringContent.Headers.ContentDisposition = $stringHeader
$multipartContent.Add($stringContent)

$body = $multipartContent

$response = Invoke-RestMethod 'https://localhost/pdf/edit/delete-pages' -Method 'POST' -Headers $headers -Body $body
$response | ConvertTo-Json