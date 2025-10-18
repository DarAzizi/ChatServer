# 💬 ChatServer (WinForms Client)

**ChatServer** is a Windows Forms application built in C#. It serves as a graphical client for interacting with the [ChatServerApi](https://github.com/DarAzizi/ChatServerApi), a RESTful backend built with ASP.NET Core. This project is ideal for beginners learning how to build client-server chat systems using .NET technologies.

---

## 🧩 Features

- Simple and intuitive user interface
- Connects to a remote REST API
- User registration and login
- Send and receive messages
- Display chat history in a conversation window

---

## 🔗 Backend Dependency: ChatServerApi

This client communicates with the following endpoints exposed by ChatServerApi:

| Endpoint              | Description                        |
|-----------------------|------------------------------------|
| `/api/register`       | Register a new user                |
| `/api/login`          | Authenticate user credentials      |
| `/api/messages/send`  | Send a message                     |
| `/api/messages`       | Retrieve all messages              |

---

## 🛠️ Requirements

- Visual Studio 2019 or 2022
- .NET Framework 4.7.2 or later
- Internet connection to reach the API
- A running instance of ChatServerApi (locally or hosted)

---

## 🚀 Getting Started

1. Clone this repository:
   ```bash
   git clone https://github.com/DarAzizi/ChatServer.git
   ```

2. Open `ChatServer.sln` in Visual Studio

3. Update the API base URL in `Form1.cs` to match your ChatServerApi instance:
   ```csharp
   string apiBaseUrl = "http://localhost:5000/api"; // Adjust as needed
   ```

4. Build and run the project

---

## 🧪 How to Use

1. Launch the application
2. Click “Register” to create a new account
3. Log in with your credentials
4. Send messages to other users
5. View chat history in the main window

---

## 📁 Project Structure

```
ChatServer/
├── Form1.cs              # Main UI logic
├── Form1.Designer.cs     # UI layout
├── Program.cs            # Application entry point
├── ChatServer.csproj     # Project file
├── CamTalk.ico           # Custom icon
```

---

## 🧠 Future Improvements

- Role-based UI (ServerMaster, Guest, etc.)
- User search by name, email, gender, etc.
- Message pagination
- Input validation and error handling
- Integration with Swagger test users

---

## 🤝 Contributing

Contributions are welcome! Feel free to submit issues, suggest features, or improve the codebase.

---

## 📄 License

This project is open-source under the MIT License. 💙
