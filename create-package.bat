call build.bat
if %errorlevel% neq 0 exit /b %errorlevel%

.nuget\nuget pack "System.Diagnostics.Abstractions\System.Diagnostics.Abstractions.csproj" -Properties Configuration=Release
if %errorlevel% neq 0 exit /b %errorlevel%