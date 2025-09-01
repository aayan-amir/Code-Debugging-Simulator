# 🖥️ Code Debugging Simulator

Code Debugging Simulator is a **C# Windows Forms educational project** built to help students practice coding, debugging, and problem-solving in an interactive way.  
It connects to a **MySQL database** that stores buggy code, solutions, fill-in-the-blanks, and MCQs.  
A sample `codes.sql` file is included if you want to run the project with MySQL support.

---

## ✨ Features
- **Fully Database-Driven**
  - Stores buggy code, solutions, fill-in-the-blanks, MCQs, usernames, and scores in MySQL  
  - Retrieves data dynamically for each session  
- **Three Learning Modules**
  - **Debugging** → fix faulty C# code snippets  
  - **Fill-in-the-Blanks** → complete missing code statements  
  - **MCQs** → answer multiple-choice questions with real-time feedback  
- **Score Tracking**
  - Tracks performance for each attempt  
  - Logs incorrect answers and updates scores in the database  
- **Scoreboard**
  - Displays high scores from all users  
  - Encourages friendly competition  
- **User-Friendly Interface**
  - Built with Windows Forms  
  - Clean navigation between modules  
- **Persistent Storage**
  - Uses MySQL to ensure all progress, scores, and questions are stored permanently  

---

## 📂 Project Structure
├── Code Debugging.sln # Visual Studio solution file
├── Code Debugging.csproj # Project configuration
├── Program.cs # Entry point of the app
├── Menu.cs / Menu.Designer.cs # Main menu form
├── Option 1.cs / Designer / resx # Debugging challenges
├── Option 2.cs / Designer / resx # Fill-in-the-blanks
├── Option 3.cs / Designer / resx # MCQ quiz
├── Properties/ # Project settings
├── Resources/ # App resources
├── codes.sql # Database file for MySQL (optional)
├── bin/ # Build output
├── obj/ # Temporary build files
└── .vs/ # Visual Studio config


---

## 🛠️ Technologies Used
- C# (.NET Framework, Windows Forms)  
- MySQL (database for storing questions & scores)  
- Visual Studio  
- ReaLTaiizor (custom UI library for buttons and controls)  

---

## 🚀 How to Run
1. Clone or download this repository  
2. Open the solution file `Code Debugging.sln` in Visual Studio  
3. Build the project to restore dependencies  
4. Run the application  
5. Import `codes.sql` into MySQL because of database-driven questions and scoring  

---

## 📌 Future Improvements
- Add more categories of debugging questions  
- Implement a scoring system with leaderboard  
- Timed quiz modes  
- Progress tracking for each user  
- Syntax highlighting in code editor  
- Web-based version for accessibility  


