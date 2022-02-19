# ASPnetW22-Michael_MacNeill
 
This folder will contain all of the Terminal content of my First assignment for WEB315

List of all commands to be used in the Terminal are listed below:

Making new page without https:
dotnet new webapp -o MichaelsPathfinderRazorPages --no-https

Changing to the Directory:
code -r MichaelsPathfinderRazorPages

List of Commands to Run for installing Features:
dotnet tool install --global dotnet-ef --version 5.*
dotnet tool install --global dotnet-aspnet-codegenerator --version 5.*
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.*
dotnet add package Microsoft.EntityFrameworkCore.SQLite --version 5.*
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.*
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.*

Creating new page:
dotnet-aspnet-codegenerator razorpage -m Feats -dc MichaelsPathfinderRazorPagesContext -udl -outdir Pages/Feats --referenceScriptLibraries -sqlite

Creating the Initial Database:
dotnet ef migrations add InitialCreate
dotnet ef database update