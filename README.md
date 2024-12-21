![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white)
![MicrosoftSQLServer](https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white)

# Medical Center Management System

## Overview
The Medical Center Management System is a comprehensive application designed to manage operations within a medical center. It provides functionality for handling patient data, appointments, and administrative tasks. The project is implemented in C# and leverages a database for persistent storage.

## Features
- 📈 Patient record management
- ⏳ Appointment scheduling
- 📊 Administrative control panel
- 🔐 Database integration for data persistence

## Folder Structure
```
Medical Center/
|-- .vs/                  # Visual Studio configuration files
|-- DataBase/             # Database files
|-- Medical_Centre/       # Main project source code
|-- packages/             # External dependencies
|-- Medical_Centre.sln    # Visual Studio solution file
```

## Requirements
- **Visual Studio 2022** (or later)
- **.NET Framework** (version used in the project)
- **SQL Server** (for the database)

## Setup Instructions
1. 🔧 Clone or download the project.
2. 🔍 Open `Medical_Centre.sln` in Visual Studio.
3. 🔧 Restore NuGet packages:
   - Go to `Tools > NuGet Package Manager > Manage NuGet Packages for Solution`.
   - Restore the required packages.
4. 📊 Set up the database:
   - Navigate to the `DataBase` folder.
   - Import the provided database file into your SQL Server instance.
   - Update the connection string in the application configuration file.
5. 🔄 Build and run the project in Visual Studio.

## Usage
1. ▶️ Launch the application.
2. 🔰 Use the intuitive interface to manage patient records and appointments.
3. 🌐 Access the administrative panel for advanced features.

## License
This project is licensed under the [MIT License](LICENSE).

## Contributing
🙌 Contributions are welcome! Please fork the repository and submit a pull request.

## Contact
For questions or support, please contact the project maintainer.
