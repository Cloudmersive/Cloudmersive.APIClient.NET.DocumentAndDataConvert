Remove-Item –path ./client –recurse
& java -jar swagger-codegen-cli.jar generate -i https://api.cloudmersive.com/swagger/api/convert -l csharp -o client -c packageconfig.json
#(Get-Content ./client/src/api/ConvertDocumentApi.js).replace('var returnType = Object;', "var returnType = 'Blob';") | Set-Content ./client/src/api/ConvertDocumentApi.js
#(Get-Content ./client/src/api/ConvertWebApi.js).replace('var returnType = Object;', "var returnType = 'Blob';") | Set-Content ./client/src/api/ConvertWebApi.js
#& npm build ./client

# Cleanup



(Get-Content ./client/src/Cloudmersive.APIClient.NETCore.DocumentAndDataConvert/Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.csproj).replace('<Authors>Swagger</Authors>', "<Authors>Cloudmersive</Authors>") | Set-Content ./client/src/Cloudmersive.APIClient.NETCore.DocumentAndDataConvert/Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.csproj
(Get-Content ./client/src/Cloudmersive.APIClient.NETCore.DocumentAndDataConvert/Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.csproj).replace('<Company>Swagger</Company>', "<Company>Cloudmersive</Company>") | Set-Content ./client/src/Cloudmersive.APIClient.NETCore.DocumentAndDataConvert/Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.csproj
(Get-Content ./client/src/Cloudmersive.APIClient.NETCore.DocumentAndDataConvert/Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.csproj).replace('<AssemblyTitle>Swagger Library</AssemblyTitle>', "<AssemblyTitle>Cloudmersive Convert API Client</AssemblyTitle>") | Set-Content ./client/src/Cloudmersive.APIClient.NETCore.DocumentAndDataConvert/Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.csproj
(Get-Content ./client/src/Cloudmersive.APIClient.NETCore.DocumentAndDataConvert/Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.csproj).replace('<Description>A library generated from a Swagger doc</Description>', "<Description>Convert files and data effortlessly. Convert DOCX to PDF. Convert CSV to JSON. And much more.</Description>") | Set-Content ./client/src/Cloudmersive.APIClient.NETCore.DocumentAndDataConvert/Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.csproj
(Get-Content ./client/src/Cloudmersive.APIClient.NETCore.DocumentAndDataConvert/Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.csproj).replace('<TargetFramework>net45</TargetFramework>', "<TargetFramework>netcoreapp2.1</TargetFramework>") | Set-Content ./client/src/Cloudmersive.APIClient.NETCore.DocumentAndDataConvert/Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.csproj

& dotnet build ./client/src/Cloudmersive.APIClient.NETCore.DocumentAndDataConvert/Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.csproj -c Release
& dotnet pack ./client/src/Cloudmersive.APIClient.NETCore.DocumentAndDataConvert/Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.csproj -c Release