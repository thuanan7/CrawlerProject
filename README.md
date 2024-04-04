## Prerequisites
### Required:
1. Visual Studio 2022
2. .Net 8 runtime
### Not Required:
- MSSQL (or MySql but i've not tried it yet) from https://github.com/tyh7121/DANMCNPM/tree/feature/firstCrawler
---
## Steps to run the code: 
1. Clone source code (or download then extract)
2. Open file **WebApplication1.sln**
3. In **CrawlerProject_API**:
![image](https://github.com/thuanan7/CrawlerProject/assets/47140156/fb8fcf02-e01b-42a9-92e7-25af98e6145f)
   - **(If you have your own Db)**: Open **appsettings.json** then edit **"ConnectionStrings":"CrawlerProjectDb"** with the configuration of your Db.
     (Expample: "Server={ServerName};Database={Database};User ID=sa;Password={YourPassword};Trusted_Connection=false;TrustServerCertificate=True;MultipleActiveResultSets=True;")
   - **(If you don't have Db)**: Open **appsettings.Production.json**, copy all then replace **appsettings.json** with the copy (this is my sample database).

4. Right-click Solution -> Configure Startup Projects -> check Multiple startup projects -> change both project's Action to "start" (Make sure Api start first).
5. Run project using https.
