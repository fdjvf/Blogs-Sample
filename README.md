# Blogs App

<details open="open">
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#azure-sql-database-creation">Azure SQL Database Creation (Optional) </a></li>
        <li><a href="#code-setup">Code Setup</a></li>
      </ul>
    </li>
    <li>
      <a href="#usage">Usage</a>
     <ul>
        <li>
          <a href="#web-app">Web App</a>
          <ul>
          <li><a href="#credentials">Credentials</a></li>
          <li><a href="#writer-demo">Writer Demo</a></li>
          <li><a href="#editor-demo">Editor Demo </a></li>
          <li><a href="#anonymous-demo">Anonymous Demo</a></li>          
          </ul>       
       </li> 
        <li>
          <a href="#rest-api">REST API</a>
          <ul>
          <li><a href="#credentials">Credentials</a></li>
          <li><a href="#api-demo">API Demo (Postman)</a></li>  
          </ul>       
       </li>  
    </li>
    <li><a href="#acknowledgements">Acknowledgements</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project
**Development Time**: 28 Hours
### Built With

* [Bootstrap](https://getbootstrap.com)
* [ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-5.0)
* [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
* [Azure SQL Server](https://azure.microsoft.com/en-us/services/sql-database/campaign)



<!-- GETTING STARTED -->
## Getting Started

To debug a local copy of the project, follow these simple example steps.

### Prerequisites
* [Postman](https://www.postman.com/downloads/)
* [Visual Studio 2019 16.10.2](https://visualstudio.microsoft.com/downloads/) 
    * Make sure to mark the following workloads during installation:
        *  **ASP.NET and Web Development**
        *  **Azure Development**
        *  **.Net Cross Platform Development**

![image](https://user-images.githubusercontent.com/11657124/122759328-6c8f7880-d25f-11eb-91b0-8a223abd4e86.png)

![image](https://user-images.githubusercontent.com/11657124/122759402-8204a280-d25f-11eb-9112-4acbbb3aa562.png)

* [SQL Server Management Studio](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15)
* [SQL Server Developer Edition](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (Optional, a SQL Cloud instance can be used)
* Azure Account (If you don't have one, [Click Here](https://azure.microsoft.com/en-us/free/))(Optional, a local SQL instance can be used)

### Azure SQL Database Creation
1. This an optional step, you can just create a database called **Blogs** in your local SQL Server Dev Edition, after having it installer in the previous step.
2. Go to [Create Azure SQL Database](https://portal.azure.com/#create/Microsoft.SQLDatabase) to start the database creation
![image](https://user-images.githubusercontent.com/11657124/122762450-f0972f80-d262-11eb-9bf4-62627a22dbef.png)

3. Under the **Server** option, click **Create New** and typed the information required. Be sure to save the **login** and **password**, since you will use those later on.
![image](https://user-images.githubusercontent.com/11657124/122763903-7cf62200-d264-11eb-8c18-ce55f5251378.png)

4. Once that's done , review and create the database
![image](https://user-images.githubusercontent.com/11657124/122764123-c34b8100-d264-11eb-8e69-e29b920a9e2e.png)
![image](https://user-images.githubusercontent.com/11657124/122764175-cf374300-d264-11eb-8272-f204841fda7a.png)

5. When deployment is finished, click on **Go to resource** and you will see your new Sql database
![image](https://user-images.githubusercontent.com/11657124/122764718-600e1e80-d265-11eb-9381-490d77c17448.png)
![image](https://user-images.githubusercontent.com/11657124/122764947-9ea3d900-d265-11eb-82b0-b36664467279.png)

6. Click on **Show database connection strings**
![image](https://user-images.githubusercontent.com/11657124/122765018-ad8a8b80-d265-11eb-95ed-2acc1ce18583.png)

7. Copy the connection string from the ADO.NET Tab and add it your password and user. This will be the connection string that you will use in the App.
8. Now go back to overview and click on **Set Server Firewall**
![image](https://user-images.githubusercontent.com/11657124/122765463-2558b600-d266-11eb-825c-7106c654bf3e.png)

9. This step is important , otherwise your application won't be able to communicate the database. Mark as yes the option "**Allow Azure services and resources to access this server**" and click on **Add Client API** to a add new IP rule name that includes your current public API (so that so can connect from your local computer). Then click on Save

![image](https://user-images.githubusercontent.com/11657124/122765744-6cdf4200-d266-11eb-8d69-8632631d0398.png)

10. That's it. You are ready to go.

### Code Setup
1. Clone repository to your computer by going to the [repo link](https://gitlab.com/fdjvf/BlogsApp/-/tree/master) and clicking on **Download Source Code**
![image](https://user-images.githubusercontent.com/11657124/122815353-f6106c00-d29a-11eb-875f-0049bc24efd8.png)

2. Unzip the code and open with Visual Studio the file called BlogsApp.sln

![image](https://user-images.githubusercontent.com/11657124/122768094-e24c1200-d268-11eb-857d-0c99f252363e.png)

3. On Visual Studio, click on **Build Solution**
![image](https://user-images.githubusercontent.com/11657124/122768370-263f1700-d269-11eb-90d4-38151570c3ac.png)

4. Now go to **Blogs.API->appsettings.json** and change the connection string value with the one from the previous step. Remember the database should be called Blogs
![image](https://user-images.githubusercontent.com/11657124/122769022-cd23b300-d269-11eb-9d66-bceb7c4fff23.png)

5. Do the previous step also for **Blogs.Web->appsettings.json**
6. Now Change the target project to **Blogs.Web**
![image](https://user-images.githubusercontent.com/11657124/122768523-4bcc2080-d269-11eb-8d99-741dc4314707.png)

7. Now go to **Tools->NuGet Package Manager->Package Manager Console**. Make sure default project is **Blogs.Web**
![image](https://user-images.githubusercontent.com/11657124/122768721-7ddd8280-d269-11eb-8ee1-37f0961f076a.png)

8. Type the command **Update-Database** .This will run the EF-Core Migrations and create all the neccessary tables and seed data.
![image](https://user-images.githubusercontent.com/11657124/122769255-08be7d00-d26a-11eb-94c0-b46f7f4ada7a.png)

9. Now just run the app by clicking the **Play Button**
![image](https://user-images.githubusercontent.com/11657124/122769936-9c904900-d26a-11eb-8e45-c6fd33494bef.png)

10. Voilà !
![image](https://user-images.githubusercontent.com/11657124/122770094-b9c51780-d26a-11eb-8688-effa53676df2.png)


<!-- USAGE EXAMPLES -->
## Usage

### Web App

Simple blog App to create and submit posts.

To test the website use: <https://zemogablogs.azurewebsites.net>

#### Credentials
Use these to login:
1. Writer 1
    * Username: writer
    * Password: 1234
2. Editor 1
    * Username: editor
    * Password: 1234
3. Writer 2
    * Username: writer2
    * Password: 1234

#### Writer Demo
![Writer User Blog](https://user-images.githubusercontent.com/11657124/122775210-82a53500-d26f-11eb-8661-d22063181bf2.gif)

#### Editor Demo
![Edito User Demo](https://user-images.githubusercontent.com/11657124/122775220-85078f00-d26f-11eb-9d26-1c8bbf88e030.gif)

#### Anonymous Demo
![Anonymous User Blog](https://user-images.githubusercontent.com/11657124/122775239-8933ac80-d26f-11eb-976c-73ba5680f8fd.gif)

### REST API

REST API to manage the posts as an Editor user. The API exposes two endpoints:
* GetPendingPosts : Returns a list of the posts that are pending for approval
* UpdatePostStatus : Receives the post identifier and a PostStatus (Approve or Reject) in order to update the Post.

The API used API Key Auth to validate who the user is and if it is an Editor or a Writer. Currently only **Editors** are able to use the API

#### Credentials

To use the API with **Postman** , create a new request and add a new Header with Key called **AuthToken** and in the value use the following tokens:
![image](https://user-images.githubusercontent.com/11657124/122782334-41645380-d276-11eb-84f6-9bd1473f46a2.png)

Auth Tokens for REST API:
1. Editor 1
    * AuthToken: skzUF6rtAW
2. Writer 1
    * AuthToken: wrZTLJRCob

#### API Demo

To test the API use this URL : <https://zemogablogsapi.azurewebsites.net>

##### Auth Demo/GetPendingPosts

Sample URL: <https://zemogablogsapi.azurewebsites.net/Posts/GetPendingPosts>

![Auth Sample-GetPendingPosts](https://user-images.githubusercontent.com/11657124/122783629-57264880-d277-11eb-967e-ff45ac4b7d10.gif)

##### UpdatePostStatus

Sample URL: <https://zemogablogsapi.azurewebsites.net/Posts/UpdatePostStatus/{PostGuid}?postStatus={newStatus}>

Parameters:
* {PostGuid}: Id of the Post to update. It can be obtained from the previous endpoint result.
* {newStatus}: The new status of the post. Available values are **Approved** or **Rejected**
    
![Update Pending Post](https://user-images.githubusercontent.com/11657124/122784217-e4699d00-d277-11eb-9eb7-3fdaf8f7bd9a.gif)




<!-- ACKNOWLEDGEMENTS -->
## Acknowledgements
* [Best README Template](https://github.com/othneildrew/Best-README-Template)
