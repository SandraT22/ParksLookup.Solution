# State and National Parks Lookup API

#### By  Sandra Tena

#### A simple API that allows the user to lookup state and national parks.   

---


## Technologies Used

* _C#_
* _.NET_
* _HTML_
* _CSS_
* _SQL Workbench_
* _Entity Framework_
*_Swashbuckle.AspNetCore_
---
## A simple API the allows the user to enter a park name, disignation or state in order to lookup a list of state or national parks that match their search. 

---
## Documentation

#### API Endpoints:
* Get/Parks
* Post/Parks
* Get/Parks/{id}
* Put/Parks/{id}
* Delete/Parks/{id}
#### Further Exploration: 
* Swagger: "is a language-agnostic specification for describing REST APIs. It allows both computers and humans to understand the capabilities of a REST API without direct access to the source code."
_Resource: https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-6.0&viewFallbackFrom=aspnetcore-50_
* Swagger impplemented by running $ dotnet new webapi --framework net5.0 in the terminal. 
* Swagger runs automatically after following the steps below (editing appsettings.json, running $ dotnet restore, and running $ dotnet run).

## Setup and Installation Requirements
**This Setup assumes you have GitBash and MySQL Workbench pre-installed.   
If needed, please navigate to these links:  
https://git-scm.com/download/  
Download Git and follow the setup wizard.  
https://dev.mysql.com/downloads/workbench/  
Download MySQL Workbench, follow the setup wizard & create a localhost server on port 3306**


*Note: Keep track of your username and password, this will be used in the connection link under,*  
"**SQL Workbench Configuration**" > "2. Insert the following code:"

<details>
<summary><strong>Initial Setup</strong></summary>
<ol>
<li>Copy the git repository url: https://github.com/SandraT22/ParksLookup.Solution
<li>Open a terminal and navigate to your Desktop with <strong>cd</strong> command
<li>Run,   
<strong>$ git clone https://github.com/SandraT22/ParksLookup.Solution.git</strong>
<li>In the terminal, navigate into the root directory of the cloned project folder "ParksLookuo.Solution".
<li>Navigate to the projects root directory, "ParksLookup".
<li>Move onto "SQL Workbench Configuration" instructions below to build the necessary database.
<br>
</details>

<details>
<summary><strong>SQL Workbench Configuration</strong></summary>
<ol>
<li>Create an appsetting.json file in the "ParksLookup" directory  
   <pre>ParksLookup.Solution
   └── ParksLookup
    └── appsetting.json</pre>
<li> Insert the following code: <br>

<pre>{
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=parks_lookup;uid=[YOUR UID HERE];pwd=[YOUR PASSWORD HERE];"
  }
}
}</pre>
<small>*Note: you must include your password in the code block section labeled "YOUR-PASSWORD-HERE".</small><br>
<small>**Note: you must include your username in the code block section labeled "YOUR-USERNAME-HERE".</small><br>
<small>***Note: if you plan to push this cloned project to a public-facing repository, remember to add the appsettings.json file to your .gitignore before doing so.</small>

<li>In root directory of project folder "ParksLookup", run  
<strong>$ dotnet ef migrations add restoreDatabase</strong>
<li>Then run <strong>$ dotnet ef database update</strong>

<ol> 
  <li>Open SQL Workbench.
  <li>Navigate to "parks_lookup" schema.
  <li>Click the drop down, select "Tables" drop down.
  <li>Verify the tables, you should see <strong>park</strong>.
  
</details>

<details>
<summary><strong>To Run</strong></summary>
Navigate to:  
   <pre>ParksLookup.Solution
   └── <strong>ParksLookup</strong></pre>

Run ```$ dotnet restore``` in the terminal.<br>
Run ```$ dotnet run``` in the terminal.
</details>
<br>

This program was built using *`Microsoft .NET SDK 5.0.401`*, and may not be compatible with other versions. Your milage may vary.

---
## Known Bugs

* No known bugs. 

## License
MIT


Copyright (c) 2022 Sandra Tena 

## Contact Information
_If you have any questions or concerns, please feel free to reach out to me [via email at: YOUR EMAIL HERE](mailto:YOUR EMAIL HERE) or request to make a contribution. Thank you!_ 



>#### _**A Big Thanks To:**_ 
>#### **Garrett Hays @ https://github.com/GarrettHays**    
>#### **Zachary Waggoner @ https://github.com/CyndaZ42**  
>#### _**for amazing README formatting and instructions!**_ 