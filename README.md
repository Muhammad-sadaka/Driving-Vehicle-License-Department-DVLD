# 🚘 Driving & Vehicle License Department (DVLD) System

A comprehensive, enterprise-grade **Driving and Vehicle License Department (DVLD)** desktop application built using **C# (.NET)**, **Windows Forms**, and **SQL Server**[span_1](start_span)[span_1](end_span). The project automates the entire lifecycle of issuing driving licenses, running multi-stage candidate tests, managing license renewals, replacements, detains, and administering granular user authorization[span_2](start_span)[span_2](end_span).

---

## 🖼️ Application Screenshots

<div align="center">
  <img src="screenshots/login.png" alt="Login Screen" width="45%" />
  <img src="screenshots/main_dashboard.png" alt="Main Dashboard" width="45%" />
</div>

<br />

<div align="center">
  <img src="screenshots/applications_list.png" alt="Applications List" width="45%" />
  <img src="screenshots/driving_test.png" alt="Driving Test Screen" width="45%" />
</div>

---

## 🌟 Key Features

### 👤 Person & Driver Management
* **Person Management:** Add, update, view, and search personal profiles linked by unique National IDs with photo support[span_3](start_span)[span_3](end_span).
* **Driver Registration:** Automatically registers candidates as official drivers upon passing all tests and receiving their first issued license[span_4](start_span)[span_4](end_span).
* **Quick Search & Filter:** Instant filtering and retrieval by Person ID, National ID, or License ID[span_5](start_span)[span_5](end_span).

### 📋 License Services & Workflows
* **New Local Driving License:** Complete application process supporting 7 distinct license classes with age and active application validation[span_6](start_span)[span_6](end_span).
* **Multi-Stage Testing Pipeline:**
  * **Vision Test:** Vision check evaluation[span_7](start_span)[span_7](end_span).
  * **Written Test:** Theoretical exam scoring[span_8](start_span)[span_8](end_span).
  * **Practical Driving Test:** Practical vehicle control and road safety evaluation[span_9](start_span)[span_9](end_span).
  * *Supports re-testing logic with fee tracking for failed attempts[span_10](start_span)[span_10](end_span).*
* **License Renewals:** Renew expired driving licenses following mandatory vision checks[span_11](start_span)[span_11](end_span).
* **Replacement Services:** Issue replacements for lost or damaged licenses with status tracking[span_12](start_span)[span_12](end_span).
* **International Driving Permit:** Issue international permits for eligible Class 3 (Ordinary) license holders[span_13](start_span)[span_13](end_span).
* **Detain & Release System:** Full workflow for detaining licenses, setting fines, collecting payments, and releasing licenses[span_14](start_span)[span_14](end_span).

### 🔒 User & Admin Control
* **User Management:** Full CRUD operations for system users with active/inactive status control and role permissions[span_15](start_span)[span_15](end_span).
* **Application & Test Settings:** Admin panel to dynamically adjust application fees, test fees, and license class criteria (age limits, validity, and costs)[span_16](start_span)[span_16](end_span).
* **Activity Auditing:** Automatic tracking of created/updated operations tagged with operator identity and timestamps[span_17](start_span)[span_17](end_span).

---

## 🚘 Supported License Classes

| ID | License Class Name | Minimum Age | Validity Period |
|---|---|---|---|
| 1 | Small Motorcycle License | 18 | 5 Years |
| 2 | Heavy Motorcycle License | 21 | 5 Years |
| 3 | Ordinary Driving License (Car) | 18 | 10 Years |
| 4 | Commercial Driving License (Taxi/Limo) | 21 | 10 Years |
| 5 | Agricultural Vehicle License | 21 | 10 Years |
| 6 | Small/Medium Bus License | 21 | 10 Years |
| 7 | Heavy Truck & Vehicle License | 21 | 10 Years |

---

## 🛠️ Tech Stack & Architecture

* **Language:** C# (.NET)[span_18](start_span)[span_18](end_span)
* **User Interface:** Windows Forms (WinForms)
* **Database:** Microsoft SQL Server (T-SQL)
* **Data Access:** ADO.NET
* **Architecture:** 3-Tier Layered Architecture (Presentation Layer, Business Logic Layer, Data Access Layer)

---

## 📁 Database Setup & Structure

The application connects to a SQL Server database named **DVLD**. The database holds central tables for managing personal details, system users, applications, test appointments, driving tests, licenses, and detained licenses[span_19](start_span)[span_19](end_span).

### Core Tables:
1. **People:** Stores personal identification details (NationalNo, Name, DOB, Phone, Email, Address, ImagePath)[span_20](start_span)[span_20](end_span).
2. **Users:** Stores system credentials, status, and linked Person ID[span_21](start_span)[span_21](end_span).
3. **Applications:** Tracks application status, dates, fees, types, and applicant IDs[span_22](start_span)[span_22](end_span).
4. **LocalDrivingLicenseApplications:** Connects applications with specific license classes[span_23](start_span)[span_23](end_span).
5. **TestAppointments & Tests:** Records scheduling details and results (Pass/Fail) for Vision, Written, and Practical tests[span_24](start_span)[span_24](end_span).
6. **Licenses & Drivers:** Stores driver records, issued licenses, expiration dates, and status[span_25](start_span)[span_25](end_span).
7. **InternationalLicenses:** Tracks active and historical international driving permits[span_26](start_span)[span_26](end_span).
8. **DetainedLicenses:** Logs fine amounts, release dates, and detaining details[span_27](start_span)[span_27](end_span).

---

## 🚀 How to Run the Project

### Prerequisites
* **Visual Studio** (2019 / 2022 / 2026) with .NET Desktop Development workload.
* **Microsoft SQL Server** & **SQL Server Management Studio (SSMS)**.

### Setup Steps
1. **Clone the repository:**
   git clone https://github.com/Muhammad-sadaka/DVLD-Driving-License-Management.git

2. **Setup the Database:**
   * Open **SQL Server Management Studio (SSMS)**.
   * Open and execute the **DbScript.sql** script included in the database folder.
   * This will create the **DVLD** database along with all necessary tables, constraints, and seed data.

3. **Configure Connection String:**
   * Open **clsDataAccessSettings.cs** (or `App.config`) in Visual Studio.
   * Update the connection string to match your local SQL Server instance name and credentials.

4. **Build and Run:**
   * Set the project as the Startup Project in Visual Studio.
   * Press **F5** or click **Start** to run the application.

---

## 👨‍💻 Author

**Muhammad Sadaka**  
* GitHub: [@Muhammad-sadaka](https://github.com/Muhammad-sadaka)

