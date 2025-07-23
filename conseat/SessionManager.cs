using System;
using System.Drawing;

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
    }
}