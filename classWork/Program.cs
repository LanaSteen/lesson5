namespace classWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //დაწერეთ პროგრამა რომელიც თავისით მიხვდება და კონსოლში დაბეჭდავს მასივის ბოლო ელემენტს.
            int[] numbers = { 1, 2, 3, 4, 5 };
       
            //PrintLastElementFromArr(numbers);

           
            //string[] words = { "hi", "hello", "some" };
            //PrintLastElementFromArrGen(words);
            //double[] decimals = { 1.1, 2.2, 3.3 };
            //PrintLastElementFromArrGen(decimals);
            //PrintLastElementFromArrGen(numbers);


        }
        static void PrintLastElementFromArr(int[] array)
        {
           
            Console.WriteLine("Last element: " + array[array.Length - 1]);
        }




        static void PrintLastElementFromArrGen<T>(T[] array)
        {
            
                Console.WriteLine("Last element: " + array[array.Length - 1]);
          
        }

        static T PrintLastElFromArrGen<T>(T[] array)
        {

            return array[array.Length - 1];

        }
    }
}
