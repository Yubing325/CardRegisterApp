# Feature

* Front-end & Back-end Fully Seperated.
* CRUD operation with nice looking notifications.
* Front-end framework: Angular 7 ; Back-end: Asp.NET Core 2.2 Web API
* MVC pattern in both ends.
* Form input type & length validation in both front-end and server-side.
* Cors supported.

# Front-end Structure:
```
● src
+---● app
|   +--● payment-details
|   |  |--payment-details.component.ts|.html|.css
|   |  +--● payment-detail
|   |  |  |--payment-detail.component.ts|.html|.css
|   |  |
|   |  +--● payment-detail-list
|   |  |  |--payment-detail-list.component.ts|.html|.css
|   |  |
|   |  +--● shared
|   |     |--payment-detail.service.ts
|   |     |--payment-detail.model.ts
|   |
|   |--app.module.ts
|
|--index.html (cdn path for bootstrap & fa icons)
```
# Back-end Structure
```
● CardRegisterApp.API
+---● Controllers
|   +--● PaymentDetailController.cs
+---● DAL //Data Access Layer
|   +--● PaymentDetailContext.cs
+---● Models
|   +--● PaymentDetail.cs
+---● Migrations //EF core migration files
+---● package.json
+---● appsettings.json
+---● Program.cs
+---● Startup.cs
```

# Demo

![add](/demo_add.jpg)
![delete](/demo_delete.jpg)
![database](/demo_database.jpg)

