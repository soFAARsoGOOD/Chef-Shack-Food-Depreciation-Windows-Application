# 🚀 Chef Shack Food Depreciation Windows Application

A professional **VB.NET Windows Forms application** designed to compute and track asset financial lifecycles. This application determines the depreciation of inventory items over a **5-year life expectancy** using both **Straight-Line** and **Double-Declining Balance** financial accounting methods.

---

## 📋 Table of Contents
- [About the Project](#-about-the-project)
- [Key Features](#-key-features)
- [Built With](#-built-with)
- [Getting Started](#-getting-started)
  - [Prerequisites](#prerequisites)
  - [Data File Configuration](#data-file-configuration)
  - [Installation & Setup](#installation--setup)
- [Usage](#-usage)
- [Application Forms Archetype](#-application-forms-archetype)
- [Data Structure Schema](#-data-structure-schema)
- [License](#-license)

---

## 🔍 About the Project

Managing kitchen and food production equipment requires accurate asset accounting. The **Chef Shack Inventory Application** automates this by reading structured text files of active inventory and generating precise financial amortization schedules.

### Amortization Methods Supported
1. **Straight-Line Depreciation:** Allocates an even amount of depreciation expense each year over the asset's useful life.
2. **Double-Declining Balance:** An accelerated depreciation method that calculates higher expenses in the earlier years of ownership.

---

## ✨ Key Features

* **File-Driven Design:** Automatically ingests local text-based inventory streams upon initialization.
* **Form-Based Validation:** Enforces explicit data matching (`Option Strict On`) with comprehensive user error alerts.
* **Dual Amortization Engines:** Generates clear comparative breakdowns side-by-side.
* **Multi-Form View System:** Features an inventory display matrix dialog alongside the core calculator form.
* **Dynamic Form Interaction:** Updates tracking indices instantly while hiding inactive interface nodes to keep views uncluttered.

---

## 🛠️ Built With

| Technology | Purpose | Documentation |
| :--- | :--- | :--- |
| **VB.NET** | Backend Programming Logic | [://microsoft.com](https://://microsoft.com/en-us/dotnet/visual-basic/) |
| **Windows Forms** | UI Desktop Framework | [://microsoft.com/winforms](https://://microsoft.com/en-us/dotnet/desktop/winforms/) |
| **.NET Framework** | Runtime Engine & Object Library | [/dotnet](https://microsoft.com) |

---

## 🚀 Getting Started

Follow these steps to set up and run a local instance of the application.

### Prerequisites
* **Visual Studio** (2022 or newer recommended) with the **.NET Desktop Development** workload installed.
* Windows Operating System environment.

### Data File Configuration
The application looks for a flat database file located exactly at `d:\inventory.txt`. 

1. Create a text file named `inventory.txt`.
2. Populate it using a sequential 4-line repeating pattern (Item Name, ID, Price, Quantity).
3. Place this file inside your `D:` directory drive root (or update `strLocationAndNameOfFile` within the source code to point to your local file layout).

### Installation & Setup

1. **Clone the Repository**
   ```bash
   git clone https://github.com
   cd chef-shack-depreciation
   ```
2. **Open the Project:** Launch Visual Studio, select **Open a project or solution**, and select your `.sln` or `.vbproj` file.
3. **Run:** Press `F5` or click the **Start** button in Visual Studio to compile and launch the UI window.

---

## 💡 Usage

1. **Select an Item:** Click an **Inventory Item ID** from the loaded listbox window.
2. **Choose a Method:** Check either the **Straight Line** or **Double Declining** radio button.
3. **Calculate:** Click **Calculate Depreciation** to view the year-by-year present values, annual depreciation, and cumulative reductions.
4. **Inventory View:** Use the `Display` menu tab toolbar (`mnuDisplay`) to slide away the calculator screen and open the separate `frmDisplayInventory` overview modal interface.

---

## 🖥️ Application Forms Archetype

The system is split cleanly between two specialized workspace frames:
* **`frmDepreciation` (Main Form):** Features calculations, selection grids, calculations loops, string array readers, and reset features.
* **`frmDisplayInventory` (Display Form):** Serves as a standalone lookup modal windows table where users can read full details from the text stream cleanly.

---

## 📊 Data Structure Schema

The `inventory.txt` parsing framework uses sequential line arrays. Ensure your data entries follow this pattern exactly without skips:

```text
Commercial Blender
BLND-01
450.00
3
Industrial Fryer
FRY-02
1250.00
1
```

---

## 📄 License

Distributed under the **MIT License**. 

---

## ✉️ Contact
* **Author:** Jarrion Harris  
* **Development Date:** October 18, 2024  
* **Project Link:** https://github.com/soFAARsoGOOD/Chef-Shack-Food-Depreciation-Windows-Application
