using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace conseat
{
    public static class SessionManager
    {
        public static User CurrentUser { get; set; }
        public static string CurrentConcertId { get; set; }
        public static string CurrentConcertName { get; set; }
        public static DateTime CurrentConcertDate { get; set; }
        public static string CurrentConcertTime { get; set; }
        public static string CurrentConcertVenue { get; set; }
        public static Image CurrentConcertImage { get; set; }
        
        public static void SetConcertContext(string concertId, string concertName, DateTime concertDate, string concertTime, string venue)
        {
            CurrentConcertId = concertId;
            CurrentConcertName = concertName;
            CurrentConcertDate = concertDate;
            CurrentConcertTime = concertTime;
            CurrentConcertVenue = venue;
        }
        
        public static void SetConcertContext(string concertId, string concertName, DateTime concertDate, string concertTime, string venue, Image concertImage)
        {
            CurrentConcertId = concertId;
            CurrentConcertName = concertName;
            CurrentConcertDate = concertDate;
            CurrentConcertTime = concertTime;
            CurrentConcertVenue = venue;
            CurrentConcertImage = concertImage;
        }
        
        public static void ClearSession()
        {
            CurrentUser = null;
            CurrentConcertId = null;
            CurrentConcertName = null;
            CurrentConcertDate = default(DateTime);
            CurrentConcertTime = null;
            CurrentConcertVenue = null;
            CurrentConcertImage = null;
        }
        
        // Helper method for proper form navigation
        public static void NavigateToForm(Form currentForm, Form newForm, bool closeCurrentForm = true)
        {
            currentForm.Hide();
            newForm.Show();
            newForm.BringToFront();
            
            if (closeCurrentForm)
            {
                // Close current form after showing new one
                newForm.FormClosed += (s, e) => { };
                currentForm.Close();
            }
        }
        
        // Helper method for modal dialog navigation
        public static void ShowModalDialog(Form parentForm, Form dialogForm)
        {
            parentForm.Hide();
            dialogForm.FormClosed += (s, e) => parentForm.Show();
            dialogForm.ShowDialog();
        }
        
        // Helper method to close all forms except specific ones
        public static void CloseAllFormsExcept(params string[] formNamesToKeep)
        {
            Form[] openForms = Application.OpenForms.Cast<Form>().ToArray();
            foreach (Form form in openForms)
            {
                bool shouldKeep = false;
                foreach (string nameToKeep in formNamesToKeep)
                {
                    if (form.Name == nameToKeep || form.GetType().Name == nameToKeep)
                    {
                        shouldKeep = true;
                        break;
                    }
                }
                
                if (!shouldKeep)
                {
                    try
                    {
                        form.Close();
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine($"Error closing form {form.Name}: {ex.Message}");
                    }
                }
            }
        }
        
        // Helper method to close all reservation/shopping related forms
        public static void CloseAllReservationForms(Form formToKeep = null)
        {
            string[] formsToClose = {
                "frmConcertDetails",    // Form4
                "frmSelectSeat",        // Form5  
                "frmSelectVip",         // Form6
                "frmCheckOut",          // Form7
                "frmSelectUpper",       // Form8
                "frmSelectGenAd",       // Form9
                "frmPaymentMethod",     // Form10
                "frmSendPayment"        // Form11
            };
            
            Form[] openForms = Application.OpenForms.Cast<Form>().ToArray();
            foreach (Form form in openForms)
            {
                if (form == formToKeep) continue;
                
                string formTypeName = form.GetType().Name;
                bool shouldClose = formsToClose.Contains(formTypeName) ||
                                 form.Name.Contains("Payment") ||
                                 form.Name.Contains("Select") ||
                                 form.Name.Contains("CheckOut") ||
                                 form.Name.Contains("Concert");
                                 
                if (shouldClose)
                {
                    try
                    {
                        form.Close();
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine($"Error closing form {form.Name}: {ex.Message}");
                    }
                }
            }
        }
    }
}