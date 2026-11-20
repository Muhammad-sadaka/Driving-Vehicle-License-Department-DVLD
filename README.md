# 🚘 Driving & Vehicle License Department (DVLD)

A desktop system that manages the full lifecycle of driving licenses: applicants, applications, a three-stage testing pipeline, license issuing, renewals, replacements, international permits, and detained licenses.

Built with **C#**, **Windows Forms**, **ADO.NET**, and **SQL Server**, using a **3-tier architecture**.

![Language](https://img.shields.io/badge/language-C%23-blue)
![UI](https://img.shields.io/badge/UI-Windows%20Forms-purple)
![Database](https://img.shields.io/badge/database-SQL%20Server-red)
![Architecture](https://img.shields.io/badge/architecture-3--Tier-green)

---

## 🖼️ Screenshots

<div align="center">
  <img src="screenshots/login.png" alt="Login" width="45%" />
  <img src="screenshots/main_dashboard.png" alt="Main dashboard" width="45%" />
</div>
<br />
<div align="center">
  <img src="screenshots/applications_list.png" alt="Applications list" width="45%" />
  <img src="screenshots/driving_test.png" alt="Driving test" width="45%" />
</div>

---

## ✨ Features

**People and drivers**
- Add, edit, view, search, and delete people, identified by a unique National ID, with photo support
- A person becomes an official driver automatically when their first license is issued, and all later licenses link to the same driver record
- Search by Person ID, National ID, or License ID

**License services**
- **New local license** for 7 license classes, with age and duplicate-class validation
- **Three-stage testing:** Vision → Written → Practical, taken strictly in order
- **Retake tests** for failed attempts, linked to the original application
- **Renewal** of expired licenses after a new vision test
- **Replacement** of lost or damaged licenses
- **International driving permit** for holders of a valid, non-detained Class 3 license
- **Detain and release** licenses with fines, reasons, and release dates

**Administration**
- User management: add (linked to a person), edit, delete, activate/deactivate, and permissions
- Editable test fees, application fees, and license class settings (minimum age, validity, fees)
- Every operation records the user who performed it and the date

---

## 🔄 License Workflow

```
Application ──► Vision test ──► Written test ──► Practical test ──► License issued ──► Driver record
     │               │                │                 │
     └─ fees paid    └─ fail: schedule a retake (pay again)
```

A new application is rejected when:
- the applicant is below the minimum age for the class
- the applicant already holds a license of the same class
- the applicant already has an active application of the same type

---

## 📏 Business Rules

| Rule | Detail |
|------|--------|
| Test order | Vision, then Written, then Practical. A failed test blocks the next one |
| Test appointments | Each test needs a paid appointment; two appointments for the same test are not allowed |
| Retakes | Only allowed after a failure, with a new fee and a new linked application |
| Renewal | Requires the expired license and a passed vision test |
| Replacement | Not allowed for a detained license |
| International permit | Class 3 only, license must be valid and not detained; issuing a new one cancels the active one and keeps history |
| Detained license | Released only after the fine is paid |
| Auditing | Every change is tagged with the user and timestamp |

---

## 🚘 License Classes

| ID | Class | Min. age | Validity | Fee |
|---:|-------|:--------:|:--------:|----:|
| 1 | Small Motorcycle | 18 | 5 years | $15 |
| 2 | Heavy Motorcycle | 21 | 5 years | $30 |
| 3 | Ordinary (Car) | 18 | 10 years | $20 |
| 4 | Commercial (Taxi/Limo) | 21 | 10 years | $200 |
| 5 | Agricultural Vehicles | 21 | 10 years | $50 |
| 6 | Small/Medium Bus | 21 | 10 years | $250 |
| 7 | Heavy Truck & Vehicles | 21 | 10 years | $300 |

Fees are added to the application fee. All values can be edited from the settings screens.

---

## 🧱 Architecture

```
┌─────────────────────────┐
│  Presentation Layer     │  Windows Forms (screens, user controls)
├─────────────────────────┤
│  Business Logic Layer   │  Validation, rules, workflows
├─────────────────────────┤
│  Data Access Layer      │  ADO.NET + T-SQL
└────────────┬────────────┘
             ▼
        SQL Server (DVLD)
```

Each layer talks only to the one below it, so UI code never touches the database directly.

---

## 🗄️ Database

The database is named **DVLD**.

| Table | Purpose |
|-------|---------|
| `People` | Personal data (National No, name, birth date, contact, image path) |
| `Users` | Login credentials, active status, linked person |
| `Applications` | Application type, status, fee, applicant, dates |
| `LocalDrivingLicenseApplications` | Links an application to a license class |
| `TestAppointments` / `Tests` | Scheduling and pass/fail results for each test |
| `Drivers` / `Licenses` | Driver records and issued licenses |
| `InternationalLicenses` | Active and historical international permits |
| `DetainedLicenses` | Fines, reasons, and release information |

---

## 🚀 Getting Started

### Requirements
- Visual Studio 2019 or newer with the **.NET desktop development** workload
- Microsoft SQL Server and SQL Server Management Studio (SSMS)

### Setup

1. **Clone**
   ```bash
   git clone https://github.com/Muhammad-sadaka/DVLD-Driving-License-Management.git
   ```
2. **Create the database**
   Open SSMS and run `DbScript.sql` from the database folder. It creates the `DVLD` database, tables, constraints, and seed data.
3. **Configure the connection string**
   Edit the connection string in `clsDataAccessSettings.cs` (or `App.config`) to match your SQL Server instance.
4. **Run**
   Set the project as the startup project and press **F5**.

### Default login
```
Username: <your-admin-username>
Password: <your-admin-password>
```
> Change these credentials after the first login.

---

## 🗺️ Roadmap

- [ ] Unit tests for the business layer
- [ ] Reports and exports (PDF / Excel)
- [ ] Role-based permission presets
- [ ] Database transactions for multi-step operations
- [ ] Localization (Arabic / English)

---

## 🤝 Contributing

1. Fork the repository
2. Create a branch: `git checkout -b feature/your-feature`
3. Commit your changes: `git commit -m "Add your feature"`
4. Push and open a Pull Request

## 🙏 Acknowledgments

Built as part of the training course by **Programming Advices** (Dr. Mohammed Abu-Hadhoud).

## 📄 License

Released under the [MIT License](LICENSE).

## 👤 Author

**Muhammad Sadaka**
- GitHub: [@Muhammad-sadaka](https://github.com/Muhammad-sadaka)