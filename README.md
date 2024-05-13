Welcom to Agri.Energy.Connect.Web
in order to run this Project you must follow the following steps
1. change or add the conection string for your database inside the appsettings.json
   "DbConnectionString": "data source=.\\SQLExpress;initial catalog={DATABASE-NAME};integrated security=True;MultipleActiveResultSets=True;App=EntityFramework;TrustServerCertificate=True",
   "AuthDbConnectionString": "data source=.\\SQLExpress;initial catalog={DATABASE-NAME};integrated security=True;MultipleActiveResultSets=True;App=EntityFramework;TrustServerCertificate=True"
2. YOU CAN RUN
3. Update-Database -context AgricoEnergyDbContext to run all Migration related to the app
4. Update-Database -context AuthDbContext       to run all Migration related to the authentication this will added a users name:Employee@AgriEnergy.com with password:Superadmin@123 this will allow you to add Farmers with their role of farmer
5. you can see all users while using the employee account
6. enjoy your application
