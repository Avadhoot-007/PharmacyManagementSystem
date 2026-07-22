# Pharmacy Management System

A desktop pharmacy management application built with C# WinForms and MS Access. Developed as a college project.

## Features

- **Authentication** — Login screen with dashboard access
- **Inventory Management** — Track products and stock (Inventory, Product)
- **Customer Management** — Manage customer records (Customer, Cust)
- **Employee Management** — Manage staff records (Employee, Emp)
- **Supplier Management** — Manage supplier records (Supplier, Sup)
- **Physician & Prescription** — Record physicians and prescriptions
- **Sales & Payments** — Record sales transactions and payments (Sales, Payment, Sal)
- **Billing** — Generate bills and receipts (BillGeneration, Recipt)
- **Reporting** — Crystal Reports-based reports for Customers, Employees, Inventory, Products, Sales, Suppliers (`.rpt` files)

## Tech Stack

- **Language:** C#
- **Framework:** .NET WinForms
- **Database:** MS Access (`PharmaDb.accdb`)
- **Reporting:** Crystal Reports

## Project Structure

PharmacyManagementSystem/
├── Login.cs / Login.Designer.cs / Login.resx
├── Dashboard.cs / Dashboard.Designer.cs / Dashboard.resx
├── Customer.cs, Cust.cs, Cust.rpt
├── Employee.cs, Emp.cs, Emp.rpt
├── Supplier.cs, Sup.cs, Sup.rpt
├── Product.cs, Prod.cs, Prod.rpt
├── Sales.cs, Sal.cs, Sal.rpt
├── Inventory.cs
├── Physician.cs
├── Prescription.cs
├── Payment.cs
├── BillGeneration.cs
├── Recipt.cs
├── ReportGeneration.cs
├── Company.cs
├── PharmaDb.accdb # MS Access database
├── PharmaDbDataSet.xsd/.xsc/.xss
├── PharmacyManagementSystem.csproj
├── PharmacyManagementSystem.sln
├── App.config
├── Properties/
└── Resources/

## Installation

1. Clone the repository:
```bash
   git clone https://github.com/Avadhoot-007/PharmacyManagementSystem.git
```
2. Open `PharmacyManagementSystem.sln` in Visual Studio.
3. Ensure `PharmaDb.accdb` is in the project directory and the connection string in `App.config` points to it.
4. Restore NuGet packages (Crystal Reports runtime required for `.rpt` viewing).
5. Build and run the project (F5).

## Requirements

- Windows OS
- Visual Studio 2017+ (or compatible)
- .NET Framework
- Microsoft Access Database Engine (for `.accdb` access)
- SAP Crystal Reports runtime

## License

Open source — college project, educational use.
