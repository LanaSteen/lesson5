using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	დაწერეთ ფუნქცია რომელიც პარამეტრად აიღებს ტექსტს, ფუნქციამ უნდა დააბრუნოს ამ ტექსტში არსებული იმ სიმბოლოების რაოდენობა რომელსაც მომხმარებელი გადასცემს ამ ფუნქციას.

            //Console.WriteLine("Enter some text");
            //string text = Console.ReadLine();
            //Console.WriteLine(CountSymbols(text));

            //•	დაწერეთ ფუნქცია რომელიც გამოითვლის და დააბრუნებს მასივის შემადგენელი ყველა ელემენტის ჯამს.

            //int[] numArr = [20, 60, 30, 40];
            //Console.WriteLine(CountSum(numArr));


            //•	დაწერეთ ფუნქცია რომელიც გამოითვლის და დააბრუნებს მასივის შემადგენელი ყველა კენტი ელემენტის ჯამს.
            //int[] numArr = [20, 11, 30, 43];
            //Console.WriteLine(CountSumOdd(numArr));

            //•	დაწერეთ ფუნქცია რომელიც დააბრუნებს ორი გადაცემული რცხვის ჯამს

            //int num1 = 10;
            //int num2 = 20;
            //Console.WriteLine(SumTwoNum(num1, num2));

            //•	დაწერეთ ფუნქცია რომელიც მასივში მოძებნის მაქსიმალურ ელემენტს.

            //int[] numArr = [20, 11, 30, 43];
            //Console.WriteLine(FindMaxInArr(numArr));


            //•	დაწერეთ ფუნქცია რომელიც მასივში მოძებნის იმ ელემენტს რომელსაც მომხმარებელი გადასცემს.
            //int[] numArr = [20, 11, 30, 43];
            //string num = Console.ReadLine();
            //int.TryParse(num, out int number);
            //Console.WriteLine(FindAnElementInArray(numArr, number));

            //•	დაწერეთ ფუნქცია რომელიც დაალაგებს int ების მასივს ზრდადობის მიხედვით. (არ გამოიყენოთ C#-ში არსებული მზა ფუნქციები მაგალითად OrderBy ან რაიმე მსგავსი სრული ფუნქციონალი დაწერეთ ხელით)
            int[] numArr = [20, 11, 30, 43];
            foreach (int num in SortArray(numArr)) {
                Console.WriteLine(num);
              }

            //• დაწერეთ ფუნქცია Contains, ფუნქციამ უნდა შეამოწმოს გადაცემული ტექსტი შეიცავს თუ არა კონკრეტულ გადაცემულ სიმბოლოს.
            //• დაწერეთ ფუნქცია All, ფუნქციამ უნდა შეამოწმოს გადაცემული ტექსტის ყველა ელემენტი უდრის თუ არა გადაცემულ კონკრეტულ სიმბოლოს.

            //დავალება 1
            //მომხმარებელს კლავიატურის გამოყენებით შეჰყავს ტექსტი. აპლიკაციამ თითოეული წინადადების
            //პირველი ასო, მაღალი რეგისტრის ასოთი უნდა ჩაანაცვლოს. 
            //მაგალითად, თუ მომხმარებელმა შეიყვანა : «today is a good day for walking. i will try to walk near the 
            //sea».
            //აპლიკაციის შედეგი უნდა იყოს შემდეგი: «Today is a good day for walking. I will try to walk near the sea».


        }

        //static int CountSymbols(string text)
        //{

        //    return text.Length;
        //}

        //static int CountSum(int[] arr)
        //{
        //    int sum = 0;
        //    foreach (var item in arr)
        //    {
        //        sum += item;
        //    }
        //    return sum;
        //}


        //static int CountSumOdd(int[] numArr) { 

        //    int sum = 0;
        //    foreach (int num in numArr) { 
        //        if(num%2==1)  sum += num;
        //    }
        //    return sum;
        //}


        //static int SumTwoNum(int num1, int num2)
        //{
        //    return num1 + num2;
        //}



        //static int FindMaxInArr(int[] arr)
        //{

        //    int max = arr[0];
        //    foreach (int number in arr)
        //    {
        //        if (number > max)  max = number;

        //    }
        //    return max;
        //}



        //static string FindAnElementInArray(int[] arr, int number)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] == number)
        //        {
        //            return $"{number} was found on {i} index";
        //        }
        //    }
        //    return $"{number} was not found";
        //}


        static int[] SortArray(int[] arr) {
            for (int i =0; i<arr.Length; i++)
            {
                if (arr[i]> arr[i+1])
                {
                    int temp = arr[i];
                    arr[i] = arr[i+1];
                    arr[i+1] = temp;
                }
            }
            return arr;
        }
    }
}
