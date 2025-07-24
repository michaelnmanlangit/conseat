using System;

namespace conseat
{
    // ABSTRACTION: Abstract base class defining common user behavior
    // ENCAPSULATION: Protected access to internal state
    public abstract class User
    {
        // ENCAPSULATION: Private fields with public properties
        private int _id;
        private string _email;
        private string _firstName;
        private string _lastName;
        private string _role;

        // ENCAPSULATION: Controlled access through properties
        public int Id 
        { 
            get => _id; 
            set => _id = value > 0 ? value : throw new ArgumentException("ID must be positive"); 
        }
        
        public string Email 
        { 
            get => _email; 
            set => _email = !string.IsNullOrWhiteSpace(value) ? value.Trim().ToLower() : 
                   throw new ArgumentException("Email cannot be empty"); 
        }
        
        public string FirstName 
        { 
            get => _firstName; 
            set => _firstName = !string.IsNullOrWhiteSpace(value) ? value.Trim() : 
                   throw new ArgumentException("First name cannot be empty"); 
        }
        
        public string LastName 
        { 
            get => _lastName; 
            set => _lastName = !string.IsNullOrWhiteSpace(value) ? value.Trim() : 
                   throw new ArgumentException("Last name cannot be empty"); 
        }
        
        public string Role 
        { 
            get => _role; 
            protected set => _role = value; // Only derived classes can set role
        }

        // ENCAPSULATION: Read-only computed property
        public string FullName => $"{FirstName} {LastName}";

        // ABSTRACTION: Abstract methods must be implemented by derived classes
        public abstract string GetWelcomeMessage();
        public abstract string GetDashboardTitle();
        public abstract bool CanAccessAdminFeatures();

        // POLYMORPHISM: Virtual method that can be overridden
        public virtual string GetUserTypeDescription()
        {
            return "General User";
        }

        // ENCAPSULATION: Protected method for derived classes
        protected virtual bool ValidateUserData()
        {
            return !string.IsNullOrWhiteSpace(Email) && 
                   !string.IsNullOrWhiteSpace(FirstName) && 
                   !string.IsNullOrWhiteSpace(LastName);
        }
    }

    // INHERITANCE: Customer inherits from User
    // POLYMORPHISM: Overrides abstract and virtual methods
    public class Customer : User
    {
        public Customer()
        {
            Role = "Customer"; // ENCAPSULATION: Set role in constructor
        }

        // POLYMORPHISM: Different implementation for customer
        public override string GetWelcomeMessage()
        {
            return $"Welcome!, {FirstName}! Ready to book your next concert?";
        }

        public override string GetDashboardTitle()
        {
            return "Concert Tickets - Customer Portal";
        }

        public override bool CanAccessAdminFeatures()
        {
            return false; // POLYMORPHISM: Customers cannot access admin features
        }

        public override string GetUserTypeDescription()
        {
            return "Concert Fan & Ticket Buyer";
        }

        // ENCAPSULATION: Customer-specific method
        public bool CanBookTickets()
        {
            return ValidateUserData();
        }
    }

    // INHERITANCE: Admin inherits from User
    // POLYMORPHISM: Different behavior than Customer
    public class Admin : User
    {
        public Admin()
        {
            Role = "Admin"; // ENCAPSULATION: Set role in constructor
        }

        // POLYMORPHISM: Different implementation for admin
        public override string GetWelcomeMessage()
        {
            return $"Welcome, Admin {FirstName}! Ready to manage the system?";
        }

        public override string GetDashboardTitle()
        {
            return "ConSeat Administration Panel";
        }

        public override bool CanAccessAdminFeatures()
        {
            return true; // POLYMORPHISM: Admins can access admin features
        }

        public override string GetUserTypeDescription()
        {
            return "System Administrator";
        }

        // ENCAPSULATION: Admin-specific methods
        public bool CanManageEvents()
        {
            return ValidateUserData();
        }

        
    }
}
