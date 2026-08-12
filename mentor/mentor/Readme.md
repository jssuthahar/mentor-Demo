# Mentor Application – ASP.NET Core

## 1. Project Overview

The **Mentor Application** is a web-based platform where users can create an account, manage their profile, become mentors, define their availability, discover mentors, and book appointments.

The application will be developed using:

* **ASP.NET Core**
* **C#**
* **SQL Server**
* **Entity Framework Core**
* **ASP.NET Core Identity**
* **HTML / CSS / Bootstrap**
* **Google / Facebook Authentication**
* **Email Service**

---

## 2. Technology Stack

| Layer                | Technology               |
| -------------------- | ------------------------ |
| Programming Language | C#                       |
| Backend              | ASP.NET Core             |
| Frontend             | ASP.NET Core MVC / Razor |
| Database             | SQL Server               |
| ORM                  | Entity Framework Core    |
| Authentication       | ASP.NET Core Identity    |
| Social Login         | Google / Facebook OAuth  |
| UI                   | HTML, CSS, Bootstrap     |
| Email                | SMTP / Email Service     |
| API Testing          | Swagger                  |
| IDE                  | Visual Studio            |

---

# 3. Application Flow

```text
                    ┌──────────────────┐
                    │      Welcome     │
                    └────────┬─────────┘
                             │
              ┌──────────────┴──────────────┐
              │                             │
       Create Account                    Login
              │                             │
       ┌──────┴──────┐             ┌────────┴────────┐
       │             │             │                 │
    Register    Google/Facebook  Email/Password   Google/Facebook
       │             │             │                 │
       └──────┬──────┘             └────────┬────────┘
              │                             │
              └──────────────┬──────────────┘
                             │
                        Home Screen
                             │
       ┌─────────────────────┼─────────────────────┐
       │                     │                     │
   My Profile           Find Mentor          Appointments
       │                     │                     │
   Edit Profile         Mentor List          My Bookings
       │                     │
 Enable Mentor          Mentor Details
       │                     │
 Availability          Book Appointment
                             │
                       Email Confirmation
```

---

# 4. Main Features

## 4.1 User Registration

Users can create a new account.

### Registration Fields

* First Name
* Last Name
* Email
* Phone Number
* Password
* Confirm Password

### Registration Flow

```text
Enter Registration Details
          ↓
Validate Details
          ↓
Create User Account
          ↓
Save User in SQL Server
          ↓
Redirect to Login
```

---

# 5. Social Login

Users can also log in using:

* Google
* Facebook

```text
Login
 │
 ├── Email + Password
 │
 ├── Google
 │
 └── Facebook
```

Social authentication will be implemented using OAuth authentication supported by ASP.NET Core.

---

# 6. Login

Users can log in using:

```text
Email
Password
```

After successful authentication:

```text
Login
  ↓
Validate User
  ↓
Create Authentication Session
  ↓
Home Screen
```

---

# 7. Home Screen

After login, users will see the main dashboard.

### Home Screen Features

* Welcome message
* Search Mentor
* Popular Skills
* Mentor List
* Recommended Mentors
* My Appointments
* My Profile

Example:

```text
--------------------------------------------------
                    MentorApp
--------------------------------------------------

Welcome, John!

Search Mentor
[ Search by name or skill................ ] [Search]

Popular Skills

[C#] [ASP.NET Core] [Azure] [SQL] [Python]

Recommended Mentors

--------------------------------------------------
John Smith
Senior .NET Developer

C# | .NET | Azure

[View Profile]
--------------------------------------------------

David Kumar
Azure Architect

Azure | Cloud | .NET

[View Profile]
--------------------------------------------------
```

---

# 8. User Profile

Every registered user will have a profile.

### Profile Information

```text
First Name
Last Name
Email
Phone
Profile Image
Bio
Location
```

Users can edit their profile.

```text
Home
 ↓
My Profile
 ↓
Edit Profile
 ↓
Save
```

---

# 9. Enable Mentor

A normal user can become a mentor.

Initially:

```text
IsMentor = false
```

When the user selects **Enable Mentor**:

```text
User
 ↓
Enable Mentor
 ↓
IsMentor = true
 ↓
Create Mentor Profile
 ↓
Set Mentor Information
 ↓
Set Availability
```

---

# 10. Mentor Profile

Mentors will have additional information.

### Mentor Information

```text
Professional Title
Experience
About
Skills
Availability
```

Example:

```text
John Smith

Senior .NET Developer

Experience:
10 Years

Skills:
C#
ASP.NET Core
SQL Server
Azure

About:
Experienced .NET developer and mentor.

Availability:
Monday    09:00 AM - 11:00 AM
Tuesday   02:00 PM - 05:00 PM
Thursday  10:00 AM - 01:00 PM
```

---

# 11. Mentor Availability

Mentors can define when they are available for appointments.

### Example

```text
Monday
09:00 AM - 11:00 AM

Tuesday
02:00 PM - 05:00 PM

Wednesday
10:00 AM - 01:00 PM
```

### Availability Fields

```text
Day
Start Time
End Time
Is Active
```

---

# 12. Mentor List

Users can view all available mentors.

### Mentor List

```text
--------------------------------------------------
Find a Mentor
--------------------------------------------------

Search:
[ C# Development                    ] [Search]

--------------------------------------------------

John Smith
Senior .NET Developer
10 Years Experience

C# | .NET | Azure | SQL Server

[View Profile]
--------------------------------------------------

David Kumar
Azure Architect
12 Years Experience

Azure | Cloud | DevOps

[View Profile]
--------------------------------------------------
```

---

# 13. Search Mentor

Users should be able to search mentors by:

* Name
* Skill
* Technology
* Professional Title

Example:

```text
Search: C#

       ↓

John Smith
David Kumar
Michael Thomas
```

---

# 14. Mentor Details

When the user selects **View Profile**, the mentor details page will display:

```text
Profile Image

John Smith

Senior .NET Developer

10 Years Experience

About
--------------------------------
Experienced .NET developer...

Skills
--------------------------------
C#
ASP.NET Core
SQL Server
Azure

Availability
--------------------------------
Monday    09:00 AM - 11:00 AM
Tuesday   02:00 PM - 05:00 PM

              [Book Appointment]
```

---

# 15. Book Appointment

Users can book an appointment with an available mentor.

### Booking Flow

```text
Select Mentor
      ↓
Select Date
      ↓
Select Available Time
      ↓
Enter Message
      ↓
Confirm Booking
      ↓
Create Appointment
      ↓
Send Email
```

### Booking Screen

```text
Mentor
John Smith

Date
[ 20-Aug-2026 ]

Available Time

[10:00 AM]
[11:00 AM]
[02:00 PM]
[04:00 PM]

Message

[ I would like to discuss .NET architecture ]

             [Book Appointment]
```

---

# 16. Appointment Status

Appointments can have the following statuses:

```text
Pending
Confirmed
Rejected
Cancelled
Completed
```

Example:

```text
User books appointment
        ↓
     Pending
        ↓
Mentor confirms
        ↓
     Confirmed
        ↓
Appointment completed
        ↓
    Completed
```

---

# 17. My Appointments

Users can see their appointments.

### Upcoming Appointments

```text
--------------------------------------------------
My Appointments
--------------------------------------------------

Mentor: John Smith
Date: 20-Aug-2026
Time: 10:00 AM - 11:00 AM
Status: Confirmed

[View]
[Cancel]
--------------------------------------------------

Mentor: David Kumar
Date: 22-Aug-2026
Time: 02:00 PM - 03:00 PM
Status: Pending

[View]
[Cancel]
--------------------------------------------------
```

---

# 18. Mentor Appointments

Mentors can view appointments booked with them.

```text
--------------------------------------------------
Mentor Appointments
--------------------------------------------------

Student: Suthahar
Date: 20-Aug-2026
Time: 10:00 AM - 11:00 AM

Message:
I want to discuss ASP.NET Core.

Status: Pending

[Confirm] [Reject]
--------------------------------------------------
```

---

# 19. Email Notification

The application will send emails when important appointment events occur.

### New Appointment

```text
User
 ↓
Book Appointment
 ↓
Save Appointment
 ↓
Send Email
 ├── User
 └── Mentor
```

### User Email

```text
Subject:
Mentor Appointment Confirmation

Hello,

Your appointment with John Smith has been booked.

Date: 20-Aug-2026
Time: 10:00 AM - 11:00 AM

Thank you.
Mentor Application
```

### Mentor Email

```text
Subject:
New Mentor Appointment

Hello John,

You have received a new appointment request.

Student: Suthahar
Date: 20-Aug-2026
Time: 10:00 AM - 11:00 AM

Please check your dashboard.
```

---

# 20. Database Design

The application will use **SQL Server**.

Main tables:

```text
Users
Roles
UserRoles
MentorProfiles
Skills
MentorSkills
MentorAvailabilities
Appointments
ExternalLogins
EmailLogs
```

---

# 21. Users Table

ASP.NET Core Identity will be used for authentication.

Conceptually:

```text
Users
--------------------------------
Id
FirstName
LastName
Email
PhoneNumber
ProfileImage
Bio
Location
IsMentor
CreatedDate
UpdatedDate
```

---

# 22. MentorProfiles Table

```text
MentorProfiles
--------------------------------
Id
UserId
ProfessionalTitle
ExperienceYears
About
IsAvailable
CreatedDate
UpdatedDate
```

Relationship:

```text
User
  │
  └────── MentorProfile
```

---

# 23. Skills Table

```text
Skills
----------------
Id
Name
```

Example:

```text
1   C#
2   ASP.NET Core
3   SQL Server
4   Azure
5   Python
6   Angular
7   React
```

---

# 24. MentorSkills Table

A mentor can have multiple skills.

```text
MentorSkills
----------------
MentorId
SkillId
```

Example:

```text
John Smith
    │
    ├── C#
    ├── ASP.NET Core
    ├── SQL Server
    └── Azure
```

---

# 25. MentorAvailabilities Table

```text
MentorAvailabilities
--------------------------------
Id
MentorId
DayOfWeek
StartTime
EndTime
IsActive
```

Example:

```text
Id    MentorId    Day       Start     End
------------------------------------------------
1     10          Monday    09:00     11:00
2     10          Monday    14:00     17:00
3     10          Tuesday   10:00     13:00
```

---

# 26. Appointments Table

```text
Appointments
--------------------------------
Id
UserId
MentorId
AppointmentDate
StartTime
EndTime
Message
Status
CreatedDate
UpdatedDate
```

Relationship:

```text
User
  │
  └──── Appointment
              │
              └──── Mentor
```

---

# 27. Important Business Rules

### Rule 1 – Default User

Every new account starts as a normal user.

```text
IsMentor = false
```

### Rule 2 – Enable Mentor

A user must explicitly enable mentor mode.

```text
IsMentor = true
```

### Rule 3 – Mentor Availability

A mentor should configure availability before users can book appointments.

```text
IsMentor = true
        +
Availability exists
        ↓
Mentor can be booked
```

### Rule 4 – No Self Booking

A mentor cannot book an appointment with themselves.

### Rule 5 – No Double Booking

A mentor cannot have two appointments for the same date and time.

### Rule 6 – Only Available Slots

Users should only see available appointment slots.

### Rule 7 – Cancellation

When an appointment is cancelled, the time slot becomes available again.

---

# 28. Project Structure

```text
MentorApp
│
├── MentorApp.Web
│   │
│   ├── Controllers
│   │   ├── AccountController.cs
│   │   ├── HomeController.cs
│   │   ├── ProfileController.cs
│   │   ├── MentorController.cs
│   │   └── AppointmentController.cs
│   │
│   ├── Views
│   │   ├── Account
│   │   │   ├── Login.cshtml
│   │   │   └── Register.cshtml
│   │   │
│   │   ├── Home
│   │   │   └── Index.cshtml
│   │   │
│   │   ├── Profile
│   │   │   └── Edit.cshtml
│   │   │
│   │   ├── Mentor
│   │   │   ├── Index.cshtml
│   │   │   └── Details.cshtml
│   │   │
│   │   └── Appointment
│   │       ├── Book.cshtml
│   │       └── MyAppointments.cshtml
│   │
│   ├── wwwroot
│   │
│   └── Program.cs
│
├── MentorApp.Core
│   │
│   ├── Entities
│   ├── DTOs
│   ├── Interfaces
│   └── Enums
│
├── MentorApp.Infrastructure
│   │
│   ├── Data
│   ├── Repositories
│   ├── Services
│   └── Email
│
└── MentorApp.sln
```

---

# 29. Development Phases

## Phase 1 – Project Setup

* Create ASP.NET Core project
* Configure SQL Server
* Configure Entity Framework Core
* Configure Identity
* Create database
* Create migrations

## Phase 2 – Authentication

* Register
* Login
* Logout
* Forgot Password
* Google Login
* Facebook Login

## Phase 3 – Profile

* View Profile
* Edit Profile
* Profile Image
* User Information

## Phase 4 – Mentor

* Enable Mentor
* Mentor Profile
* Skills
* Availability

## Phase 5 – Mentor Discovery

* Mentor List
* Search
* Filter
* Mentor Details

## Phase 6 – Appointment

* Book Appointment
* Available Time Slots
* My Appointments
* Mentor Appointments
* Confirm
* Reject
* Cancel

## Phase 7 – Email

* Appointment Confirmation
* New Appointment Notification
* Cancellation Notification

---

# 30. MVP Scope

The first version should contain only the core functionality:

```text
Register
   ↓
Login
   ↓
Home
   ↓
Profile
   ↓
Enable Mentor
   ↓
Set Availability
   ↓
Mentor List
   ↓
Mentor Details
   ↓
Book Appointment
   ↓
Email Confirmation
```

After the MVP is working, additional features can be added:

```text
Reviews
Ratings
Chat
Notifications
Payment
Admin Dashboard
Reports
Advanced Search
Calendar Integration
Video Meeting
```

---

# 31. Final Application Flow

```text
                    MENTOR APPLICATION
                           │
                           ▼
                    ┌───────────────┐
                    │   Register    │
                    └───────┬───────┘
                            │
                    ┌───────▼───────┐
                    │     Login     │
                    └───────┬───────┘
                            │
                    ┌───────▼───────┐
                    │     Home      │
                    └───────┬───────┘
                            │
             ┌──────────────┼──────────────┐
             │              │              │
             ▼              ▼              ▼
          Profile       Find Mentor    Appointments
             │              │
             ▼              ▼
       Enable Mentor    Mentor List
             │              │
             ▼              ▼
       Availability    Mentor Details
                            │
                            ▼
                    Book Appointment
                            │
                            ▼
                    Save Appointment
                            │
                            ▼
                      Send Email
                            │
                            ▼
                    Appointment Done
```
