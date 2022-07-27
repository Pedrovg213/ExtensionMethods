
namespace Prototype01 {
   internal class Program {
      static void Main( string[ ] args ) {

         DateTime dt = new DateTime(2022, 07, 26, 12, 10, 45);
         Console.WriteLine( dt.ElapsedTime() );
         Console.WriteLine();

         string s01 = "Good morning dear students!";
         Console.WriteLine( s01.Cut( 15 ) );

      }
   }
}