using System.Globalization;

namespace System {
   internal static class DateTimeExtensions {

      public static string ElapsedTime( this DateTime thisObj ) {

         TimeSpan durantion = DateTime.Now.Subtract(thisObj);

         if ( durantion.TotalHours < 24 )
            return ( durantion.TotalHours.ToString( "F1" , CultureInfo.InvariantCulture ) + " hours" );

         return ( durantion.TotalDays.ToString( "F1" , CultureInfo.InvariantCulture ) + " days" );

      }
   }
}
