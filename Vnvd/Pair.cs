
namespace Vnvd
{
   /// <summary>
   /// A pair is a combination of two objects.
   /// This class uses generics to make a pair of anything one could want.
   /// </summary>
   /// <typeparam name="EFirst">The first type of the pair</typeparam>
   /// <typeparam name="ESecond">The second type of the pair</typeparam>
   public class Pair<EFirst, ESecond>
   {
      private EFirst first;
      private ESecond second;

      /// <summary>
      /// Constructor of the pair.
      /// </summary>
      /// <param name="first">The first object in the pair</param>
      /// <param name="second">The second object in the pair</param>
      public Pair(EFirst first, ESecond second)
      {
         this.first = first;
         this.second = second;
      }

      /// <summary>
      /// The first object in the pair.
      /// </summary>
      public EFirst First
      {
         get { return first; }
         set { first = value; }
      }

      /// <summary>
      /// The second object in the pair.
      /// </summary>
      public ESecond Second
      {
         get { return second; }
         set { second = value; }
      }
   }

}