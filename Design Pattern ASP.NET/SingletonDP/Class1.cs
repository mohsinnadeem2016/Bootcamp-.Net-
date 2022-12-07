
namespace SingletonDP
{
    public class SinClass // Class

    {
        public int MyNumber = 15; // Value

        private static SinClass MySingletonInstance = new SinClass(); // Obj

        private SinClass() // constructor
        {
        }
        public static SinClass GetInstance()  // Method
        {

            return SinClass.MySingletonInstance;
        }



    }
}
