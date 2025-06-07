# 🛍️ E-Commerce Web Application – ASP.NET MVC

This repository contains a university final year project: a full-stack e-commerce web application built using ASP.NET MVC and SQL Server. The application supports product browsing, cart management, checkout with PDF invoice generation, voucher assignment, role-based authentication, and comprehensive admin/customer dashboards with reporting.

---

## 📋 Features

### Customer Features
- Browse products by category and subcategory
- Add products to cart and checkout
- Download sales invoices as PDF
- Apply vouchers valid for specific periods
- Customer dashboard to manage profile, view orders, vouchers, and product reviews

### Authentication & Authorization
- Role-based login system (Customer/Admin)
- Account and role data stored securely in SQL Server
- Authorization managed through database-driven roles

### Admin Features
- Admin dashboard to manage customers, products, categories, vouchers, and reviews
- Full CRUD operations on all entities
- Reporting modules for sales, customers, and stock levels

---

## 🧩 Important Note on Project Resources

While the full project source code is not completely available due to accidental data loss, this repository provides all essential components to understand, rebuild, or extend the application, including:

- **Model-View-Controller (MVC) Code**: Complete backend (C# Controllers and Models) and frontend (Razor Views) code that outlines the application's logic and UI structure.
- **SQL Server Database Backup (.bak file)**: Contains database schema, relationships, and sample data necessary for running or analyzing the system.
- **Project Documentation**: Comprehensive reports describing features, design decisions, and workflows.

---

## 🚀 How to Use These Resources

1. **Restore the Database**  
   - Use the provided `.bak` file to restore the database in SQL Server or SQL Server Express.
   - Update the connection string in `Web.config` to connect your application to this restored database.

2. **Explore the MVC Code**  
   - Review the Controllers, Models, and Views to understand the implementation of e-commerce workflows such as product listing, cart management, checkout, voucher handling, authentication, and reporting.

3. **Run and Test the Application**  
   - Build and run the project in Visual Studio to verify existing features.

4. **Extend or Rebuild**  
   - Use the provided code and database as a starting point to add missing features, improve UI/UX, or integrate additional services such as payment gateways or enhanced analytics.

5. **Learn Best Practices**  
   - Study the project to gain hands-on experience with ASP.NET MVC architecture, role-based security, and e-commerce system design.

---

## 🛠️ Tech Stack

- Backend: ASP.NET MVC (C#)  
- Frontend: HTML, CSS, Bootstrap, JavaScript, jQuery  
- Database: Microsoft SQL Server  
- PDF Generation: iTextSharp (or equivalent)  
- Development Environment: Visual Studio  



### Prerequisites

- Visual Studio 2019 or later  
- SQL Server / SQL Server Express / LocalDB  
- .NET Framework 4.7.2 or higher  
