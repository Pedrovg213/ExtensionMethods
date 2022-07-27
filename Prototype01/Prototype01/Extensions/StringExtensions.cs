
namespace System {
   internal static class StringExtensions {

      public static string Cut( this string _thisString , int _count ) {

         return ( _thisString.Length <= _count ?
            _thisString :
            _thisString.Substring( 0 , _count ) + "..." );

      }
   }
}
