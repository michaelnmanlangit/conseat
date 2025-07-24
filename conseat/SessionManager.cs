using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace conseat
{
    // ABSTRACTION: Interface for navigation services
    public interface INavigationService
    {
        void NavigateToForm(Form currentForm, Form targetForm, bool closeCurrentForm = true);
        void ShowModalDialog(Form parentForm, Form dialogForm);
        void NavigateBasedOnUserRole(User user, Form currentForm);
    }

    // ABSTRACTION: Interface for session management
    public interface ISessionManager
    {
        User CurrentUser { get; set; }
        string CurrentConcertId { get; set; }
        void SetConcertContext(string concertId, string concertName, DateTime concertDate, string concertTime, string venue);
        void ClearSession();
        bool IsUserLoggedIn();
    }

    // ENCAPSULATION: Static class with controlled access to session data
    // INHERITANCE: Implements multiple interfaces (composition over inheritance)
    public static class SessionManager
    {
        // ENCAPSULATION: Private static fields with public properties
        private static User _currentUser;
        private static readonly ConcertContext _concertContext = new ConcertContext();
        private static readonly NavigationService _navigationService = new NavigationService();

        // ENCAPSULATION: Controlled access to current user
        public static User CurrentUser
        {
            get => _currentUser;
            set => _currentUser = value;
        }

        // ABSTRACTION: Expose concert context properties
        public static string CurrentConcertId
        {
            get => _concertContext.ConcertId;
            set => _concertContext.ConcertId = value;
        }

        public static string CurrentConcertName
        {
            get => _concertContext.ConcertName;
            set => _concertContext.ConcertName = value;
        }

        public static DateTime CurrentConcertDate
        {
            get => _concertContext.ConcertDate;
            set => _concertContext.ConcertDate = value;
        }

        public static string CurrentConcertTime
        {
            get => _concertContext.ConcertTime;
            set => _concertContext.ConcertTime = value;
        }

        public static string CurrentConcertVenue
        {
            get => _concertContext.ConcertVenue;
            set => _concertContext.ConcertVenue = value;
        }

        public static Image CurrentConcertImage
        {
            get => _concertContext.ConcertImage;
            set => _concertContext.ConcertImage = value;
        }

        // POLYMORPHISM: Multiple overloads for setting concert context
        public static void SetConcertContext(string concertId, string concertName, DateTime concertDate, string concertTime, string venue)
        {
            _concertContext.SetContext(concertId, concertName, concertDate, concertTime, venue);
        }

        public static void SetConcertContext(string concertId, string concertName, DateTime concertDate, string concertTime, string venue, Image concertImage)
        {
            _concertContext.SetContext(concertId, concertName, concertDate, concertTime, venue, concertImage);
        }

        // ABSTRACTION: High-level session management
        public static void ClearSession()
        {
            _currentUser = null;
            _concertContext.Clear();
        }

        public static bool IsUserLoggedIn()
        {
            return _currentUser != null;
        }

        // POLYMORPHISM: Different navigation methods
        public static void NavigateToForm(Form currentForm, Form newForm, bool closeCurrentForm = true)
        {
            _navigationService.NavigateToForm(currentForm, newForm, closeCurrentForm);
        }

        public static void ShowModalDialog(Form parentForm, Form dialogForm)
        {
            _navigationService.ShowModalDialog(parentForm, dialogForm);
        }

        // ABSTRACTION: Role-based navigation
        public static void NavigateToUserHome(Form currentForm)
        {
            if (IsUserLoggedIn())
            {
                _navigationService.NavigateBasedOnUserRole(_currentUser, currentForm);
            }
            else
            {
                NavigateToLogin(currentForm);
            }
        }

        public static void NavigateToLogin(Form currentForm)
        {
            ClearSession();
            var loginForm = new frmLogin();
            NavigateToForm(currentForm, loginForm);
        }

        // ABSTRACTION: Form cleanup methods
        public static void CloseAllFormsExcept(params string[] formNamesToKeep)
        {
            FormManager.CloseAllFormsExcept(formNamesToKeep);
        }

        public static void CloseAllReservationForms(Form formToKeep = null)
        {
            FormManager.CloseAllReservationForms(formToKeep);
        }
    }

    // ENCAPSULATION: Internal class to manage concert context
    // ABSTRACTION: Hides complex concert data management
    internal class ConcertContext
    {
        public string ConcertId { get; set; }
        public string ConcertName { get; set; }
        public DateTime ConcertDate { get; set; }
        public string ConcertTime { get; set; }
        public string ConcertVenue { get; set; }
        public Image ConcertImage { get; set; }

        public void SetContext(string concertId, string concertName, DateTime concertDate, string concertTime, string venue)
        {
            ConcertId = concertId;
            ConcertName = concertName;
            ConcertDate = concertDate;
            ConcertTime = concertTime;
            ConcertVenue = venue;
        }

        public void SetContext(string concertId, string concertName, DateTime concertDate, string concertTime, string venue, Image concertImage)
        {
            SetContext(concertId, concertName, concertDate, concertTime, venue);
            ConcertImage = concertImage;
        }

        public void Clear()
        {
            ConcertId = null;
            ConcertName = null;
            ConcertDate = default(DateTime);
            ConcertTime = null;
            ConcertVenue = null;
            ConcertImage = null;
        }
    }

    // INHERITANCE: Implements INavigationService
    // ENCAPSULATION: Internal navigation logic
    internal class NavigationService : INavigationService
    {
        public void NavigateToForm(Form currentForm, Form targetForm, bool closeCurrentForm = true)
        {
            currentForm?.Hide();
            targetForm?.Show();
            targetForm?.BringToFront();

            if (closeCurrentForm && currentForm != null)
            {
                targetForm.FormClosed += (s, e) => { };
                currentForm.Close();
            }
        }

        public void ShowModalDialog(Form parentForm, Form dialogForm)
        {
            parentForm?.Hide();
            if (dialogForm != null)
            {
                dialogForm.FormClosed += (s, e) => parentForm?.Show();
                dialogForm.ShowDialog();
            }
        }

        // POLYMORPHISM: Different behavior based on user type
        public void NavigateBasedOnUserRole(User user, Form currentForm)
        {
            if (user == null) return;

            Form targetForm = CreateFormForUser(user);
            if (targetForm != null)
            {
                NavigateToForm(currentForm, targetForm);
            }
        }

        // ABSTRACTION: Factory method for creating user-specific forms
        private Form CreateFormForUser(User user)
        {
            // POLYMORPHISM: Different form types based on user role
            return user.CanAccessAdminFeatures() 
                ? new frmAdminDashboard(user) as Form
                : new frmCustomHome(user) as Form;
        }
    }

    // ENCAPSULATION: Static utility class for form management
    // ABSTRACTION: Hides complex form cleanup logic
    internal static class FormManager
    {
        public static void CloseAllFormsExcept(params string[] formNamesToKeep)
        {
            var openForms = Application.OpenForms.Cast<Form>().ToArray();
            var formsToKeepSet = new HashSet<string>(formNamesToKeep);

            foreach (var form in openForms)
            {
                if (!formsToKeepSet.Contains(form.Name) && !formsToKeepSet.Contains(form.GetType().Name))
                {
                    TryCloseForm(form);
                }
            }
        }

        public static void CloseAllReservationForms(Form formToKeep = null)
        {
            var reservationFormNames = new[]
            {
                "frmConcertDetails", "frmSelectSeat", "frmSelectVip", "frmCheckOut",
                "frmSelectUpper", "frmSelectGenAd", "frmPaymentMethod", "frmSendPayment"
            };

            var openForms = Application.OpenForms.Cast<Form>().ToArray();
            foreach (var form in openForms)
            {
                if (form == formToKeep) continue;

                var formTypeName = form.GetType().Name;
                var shouldClose = reservationFormNames.Contains(formTypeName) ||
                                formTypeName.Contains("Payment") ||
                                formTypeName.Contains("Select") ||
                                formTypeName.Contains("CheckOut") ||
                                formTypeName.Contains("Concert");

                if (shouldClose)
                {
                    TryCloseForm(form);
                }
            }
        }

        private static void TryCloseForm(Form form)
        {
            try
            {
                form?.Close();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error closing form {form?.Name}: {ex.Message}");
            }
        }
    }
}