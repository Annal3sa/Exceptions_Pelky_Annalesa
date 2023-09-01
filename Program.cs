namespace Exceptions_Pelky_Annalesa
{
    internal class Program
    {
        // assigns float and myOtherFloat as 65.4f and 0.0f
        static void Main(string[] args)
        {
            float myFloat = 65.4f;
            float myOtherFloat = 0.0f;
            float result;
            // i really need help please. 

            Random rand = new Random();
            int myInt = rand.Next(2, 30);

            // I just don't know what to put :,(
            try
            {
                result = Divide(myFloat, myOtherFloat);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(("Please enter a number other than zero.");
                myOtherFloat = (float)Convert.ToDouble(Console.ReadLine());

                // I also forgot my glasses and can't read any of this.
                try
                {
                    result = Divide(myFloat, myOtherFloat); 
                }
                catch (Exception e2)
                {
                    Console.WriteLine(e2.Message);
                }
            }
            finally
            {
                Console.WriteLine("Calculations completed with a result of" + result);
            }

            // I can only read this if i get uncomfortably close to my monior
            try
            {
                CheckAge(myInt);
            }catch (Exception e)
            {
                Console.WriteLine("You are {myInt}, not old enough!");
            }
        }

        // i also cant see if there are any red squigglies so I can't fix the errors
        static float Divide(float x, float y)
        {
            if (y == 0)
            {
                throw DivideByZeroException;
            }
            else
            {
                return x / y;
            }

            // there also shouldn't be any errors cause I followed your video perfectly

            static void CheckAge(int age)
            {
                if(age >= 17)
                {
                    Console.WriteLine($"You are {age}, you can play mature games!");
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
    }
}