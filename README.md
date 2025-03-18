### **📜 ChecklistApp - Official Documentation**  
#### **Author:** Jamison Stalter  
#### **Version:** 1.0.0  
#### **Date:** 03/12/2025
#### **Repository:** [GitHub - ChecklistApp](https://github.com/JayStalt/ChecklistApp)  

---

## **1. Introduction**  
ChecklistApp is a **Windows desktop application** designed to assist users in managing their daily and weekly tasks efficiently. The application provides an intuitive interface for task tracking, allowing users to **preload, edit, delete, and mark tasks as completed** while earning **stars** as a form of reward.  

This application was developed to fulfill a specific need for a structured **checklist system** that aids in daily planning and organization.

---

## **2. Features**  
- **Preloaded Weekly Tasks** – Automatically loads tasks based on the selected day.  
- **Star Reward System** – Users earn stars for completing tasks, providing motivation.  
- **Task Management** – Users can add, edit, and delete tasks as needed.  
- **Day-Based Filtering** – Allows users to view tasks based on the selected day.  
- **Task Completion Tracking** – Provides a visual representation of task progress.  
- **SQLite Database Integration** – Ensures that all tasks and progress are saved persistently.  
- **Self-Contained Deployment** – Eliminates dependency on external software installations.  

---

## **3. System Requirements**  
### **Minimum Requirements**  
- **Operating System:** Windows 10 / Windows 11  
- **.NET 8.0 Runtime** (Only required if using a framework-dependent deployment)  
- **Storage:** ~50MB of free disk space  

---

## **4. Installation Guide**  
### **Option 1: Direct Download and Execution**  
1. **Download the latest release** from [GitHub Releases](https://github.com/JayStalt/ChecklistApp/releases).  
2. **Extract the ZIP file** to a designated folder.  
3. **Run `ChecklistApp_LH.exe`** to launch the application.  

### **Option 2: Using the Setup Installer (If Available)**  
1. Download `Setup.exe` from the GitHub repository.  
2. Execute the installer and follow the installation steps.  
3. Upon completion, the application will be accessible via the **Start Menu**.  

---

## **5. Application Usage**  
1. **Task Management**  
   - **Adding Tasks:** Click "Add Task" to create a new task.  
   - **Editing Tasks:** Select a task and click "Edit Task" to modify it.  
   - **Deleting Tasks:** Select a task and click "Delete Task" to remove it.  
2. **Task Completion Tracking**  
   - Users may mark tasks as completed by selecting the task and clicking "Toggle Completed".  
   - Stars are awarded upon task completion.  
3. **Day-Based Task Filtering**  
   - Users may select a specific day from the dropdown to view scheduled tasks for that day.  

---

## **6. Development Setup**  
### **Cloning the Repository**  
```sh
git clone https://github.com/JayStalt/ChecklistApp.git
cd ChecklistApp
```

### **Opening in Visual Studio**  
1. Open **Visual Studio 2022**.  
2. Click **"Open a Project"** and select `ChecklistApp_LH.sln`.  
3. **Build the project** using (`Ctrl + Shift + B`).  

### **Running the Application Locally**  
```sh
dotnet run
```

---

## **7. Troubleshooting & FAQs**  
### **Issue: Application Fails to Launch**  
✔ **Solution:** Ensure the appropriate version of **.NET 8.0 Runtime** is installed, or download the **self-contained version**.  

### **Issue: ClickOnce Installer Fails**  
✔ **Solution:** Manually extract the `.exe` from the `publish` folder and execute it directly.  

### **Issue: Database Not Found**  
✔ **Solution:** If `checklist.db` is missing, the application will automatically regenerate it upon launch.  

---

## **8. Future Enhancements**  
The following features are under consideration for future versions:  
- **Task Reminder Notifications** – Alerts to remind users of pending tasks.  
- **Task Exporting** – Ability to export task lists in CSV or PDF formats.  
- **Cloud Backup & Synchronization** – Option to sync tasks across multiple devices.  
- **User Customization** – Personalization options for themes and interface layouts.  

---

## **9. Contribution Guidelines**  
Developers interested in contributing to ChecklistApp are encouraged to:  
1. **Fork the repository.**  
2. **Create a new feature branch.**  
3. **Submit a pull request with detailed documentation of changes.**  

For detailed contribution guidelines, please refer to the [GitHub Repository](https://github.com/JayStalt/ChecklistApp).  

---

## **10. Version History & Changelog**  
- **v1.0.0** - Initial release with preloaded tasks, star system, and task management features.  

---

## **11. Licensing & Attribution**  
This project is **open-source** and follows an MIT License. Users are free to modify and distribute the application for personal and professional use.  

For licensing details, please review the `LICENSE` file in the repository.

---

## **12. Contact Information**  
👤 **Author:** Jamison Stalter  
📧 stalterjamison@gmail.com
🔗 **GitHub:** [JayStalt](https://github.com/JayStalt)  
🚀 _(Other social links, if applicable)_  

---

### **📢 Closing Notes**  
ChecklistApp is designed to improve productivity by offering an intuitive and structured checklist system. Feedback and contributions are always welcome to enhance its functionality.  

Thank you for using ChecklistApp! 🎉  
