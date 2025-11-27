# Create the structure using CLI

1. mkdir MyApp cd MyApp

2. Create a solution 

`dotnet new sln -n MyApp`

3. Create the app project inside src

`dotnet new console -o src/MyApp`

3. Create a Test project in tests

`dotnet new xunit -o tests/MyApp.Tests`

4. Add test and the main app to the solution

`dotnet sln add src/MyApp/MyApp.csproj`
`dotnet sln add tests/MyApp.Tests/MyApp.Tests.csproj`

5. Referebce the test app to your main app

`dotnet add tests/MyApp.Tests/MyApp.Tests.csproj reference src/MyApp/MyApp.csproj`

6. Add a simple test

7. Run the tests

dotnet test
