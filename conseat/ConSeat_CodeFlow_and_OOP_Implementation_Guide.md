# ConSeat Concert Reservation System - Code Flow & OOP Implementation Guide (Detailed)

## Project Overview
ConSeat is a Concert Seat Reservation System built with C# WinForms (.NET Framework 4.7.2) and MySQL. This guide explains the flow of the code and gives simple, line-by-line explanations of the most important OOP code in the project.

---

## 🔄 How the Code Flows (Step-by-Step)

1. **Program Starts**
   - The app launches and shows the Login form (Form1).

2. **User Logs In (Form1.cs)**
   - User enters email and password.
   - Password is hashed for security.
   - The system checks the database for a matching user.
   - If found, creates a `User` object (either `Admin` or `Customer` based on role).
   - Sets the current user in `SessionManager`.
   - Shows a welcome message and opens the correct dashboard (Admin or Customer).

3. **User Registers (Form2.cs)**
   - User enters details and password.
   - Password is hashed and saved to the database.
   - Always registers as a Customer.

4. **Customer Dashboard (Form3.cs)**
   - Shows a list of concerts from the database.
   - User can search, sort, and select concerts.
   - Clicking a concert opens the details and booking flow.

5. **Booking Flow (Forms 4-13)**
   - User selects seats, enters payment, and confirms booking.
   - Admin can create events and manage sales.

6. **SessionManager**
   - Keeps track of the current user and concert being booked.
   - Handles navigation between forms.

7. **DBConnection**
   - Handles all database connections and queries.

---

## ⭐ The Most Important OOP Code (Explained Simply)

### 1. User.cs (All 4 OOP Principles)

#### **Encapsulation**private int _id; // Only accessible inside the class
public int Id { get => _id; set => _id = value > 0 ? value : throw new ArgumentException("ID must be positive"); }- The field `_id` is private, so only the class can change it.
- The property `Id` lets other code read or set the value, but only if it's positive.

#### **Abstraction**public abstract class User { ... }
public abstract string GetWelcomeMessage();- `User` is an abstract class, meaning you can't create a User directly.
- Abstract methods are like promises: every child class must write its own version.

#### **Inheritance**public class Customer : User { ... }
public class Admin : User { ... }- `Customer` and `Admin` are both types of `User`.
- They inherit all the code from `User` and add their own features.

#### **Polymorphism**public override string GetWelcomeMessage() { ... }- Both `Customer` and `Admin` have their own version of `GetWelcomeMessage()`.
- When you call `user.GetWelcomeMessage()`, it runs the correct version for the user's type.

#### **Line-by-Line Example (Customer)**public class Customer : User
{
    public Customer() { Role = "Customer"; }
    public override string GetWelcomeMessage() { return $"Welcome!, {FirstName}! Ready to book your next concert?"; }
    public override string GetDashboardTitle() { return "Concert Tickets - Customer Portal"; }
    public override bool CanAccessAdminFeatures() { return false; }
    public override string GetUserTypeDescription() { return "Concert Fan & Ticket Buyer"; }
    public bool CanBookTickets() { return ValidateUserData(); }
}- The constructor sets the role to "Customer".
- Each method gives a different answer for a customer (polymorphism).
- `CanBookTickets()` uses a protected method from `User` to check if the user's data is valid.

#### **Line-by-Line Example (Admin)**public class Admin : User
{
    public Admin() { Role = "Admin"; }
    public override string GetWelcomeMessage() { return $"Welcome, Admin {FirstName}! Ready to manage the system?"; }
    public override string GetDashboardTitle() { return "ConSeat Administration Panel"; }
    public override bool CanAccessAdminFeatures() { return true; }
    public override string GetUserTypeDescription() { return "System Administrator"; }
    public bool CanManageEvents() { return ValidateUserData(); }
}- The constructor sets the role to "Admin".
- Each method gives a different answer for an admin.
- `CanManageEvents()` checks if the admin's data is valid.

### 2. DBConnection.cs (Encapsulation, Abstraction, Inheritance, Polymorphism)

#### **Encapsulation**private MySqlConnection _connection;
private readonly string _connectionString;- These fields are private, so only DBConnection can use them.

#### **Abstraction & Inheritance**public interface IDbConnection : IDisposable { ... }
internal class DBConnection : IDbConnection { ... }- The interface `IDbConnection` says what a database connection should do.
- `DBConnection` implements the interface, so it must have all those methods.

#### **Polymorphism**public DBConnection() { ... }
public DBConnection(string server, string database, string userId, string password) { ... }- There are two ways to create a DBConnection (different constructors).
- You can use the interface to work with any class that implements it.

#### **Line-by-Line Example**public void OpenConnection() {
    ValidateNotDisposed();
    if (_connection.State == ConnectionState.Closed) {
        _connection.Open();
    }
}- Checks if the connection is disposed.
- If the connection is closed, it opens it.

### 3. SessionManager.cs (Encapsulation, Abstraction, Inheritance, Polymorphism)

#### **Encapsulation**private static User _currentUser;
public static User CurrentUser { get => _currentUser; set => _currentUser = value; }- The field is private, but you can get/set it using the property.

#### **Abstraction**public interface INavigationService { ... }
public interface ISessionManager { ... }- These interfaces say what navigation/session managers should do.

#### **Inheritance & Polymorphism**internal class NavigationService : INavigationService { ... }
public static void NavigateToForm(Form currentForm, Form newForm, bool closeCurrentForm = true) { ... }- `NavigationService` implements the interface, so it must have all those methods.
- The navigation methods can work differently depending on the user type (polymorphism).

#### **Line-by-Line Example**public static void NavigateToUserHome(Form currentForm) {
    if (IsUserLoggedIn()) {
        _navigationService.NavigateBasedOnUserRole(_currentUser, currentForm);
    } else {
        NavigateToLogin(currentForm);
    }
}- If a user is logged in, it navigates to the correct home form based on their role.
- If not, it goes to the login form.

### 4. Form1.cs (Login Form - OOP in Action)

#### **Line-by-Line Example**string email = txtEmail.Text.Trim();
string password = txtPassword.Text;
string hashedPassword = PasswordHelper.HashPassword(password);- Gets the email and password from the form.
- Hashes the password for security.
User user;
if (role == "Admin") { user = new Admin(); } else { user = new Customer(); }- Creates the correct type of user based on the role (polymorphism).
SessionManager.CurrentUser = user;
MessageBox.Show(user.GetWelcomeMessage());- Sets the current user in the session manager.
- Shows a welcome message using polymorphism (the right message for the user type).

### 5. Form2.cs (Sign Up Form)

#### **Line-by-Line Example**string hashedPassword = PasswordHelper.HashPassword(password);
DBConnection db = new DBConnection();
MySqlConnection conn = db.GetConnection();- Hashes the password.
- Creates a new database connection.
string query = "INSERT INTO users ...";
MySqlCommand cmd = new MySqlCommand(query, conn);
cmd.Parameters.AddWithValue("@fn", firstName);
...
cmd.ExecuteNonQuery();- Prepares and runs the SQL command to add the new user.

---

## 📝 Summary: How the OOP Principles Work Together
- **Encapsulation** keeps data safe and only lets the right code change it.
- **Inheritance** lets you reuse code and create specialized types (Admin, Customer).
- **Polymorphism** lets you use the same method name but get different results depending on the object type.
- **Abstraction** hides complex details and lets you work with simple interfaces and base classes.

---

## 📚 Want to Learn More?
- Look at User.cs, DBConnection.cs, and SessionManager.cs for the best OOP examples.
- Try changing the role in the database and see how the system responds differently (polymorphism in action).
- Notice how private fields and properties protect your data (encapsulation).
- See how interfaces and abstract classes make the code easy to expand (abstraction and inheritance).

---

**This guide is designed to help you understand the code flow and the most important OOP concepts in simple terms!**