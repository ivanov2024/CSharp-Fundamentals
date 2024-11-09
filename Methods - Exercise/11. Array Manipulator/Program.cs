namespace Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            Output(n, command);
        }

        static void Output(int[] n, string command)
        {
            while (command != "end")
            {
                string[] arr = command.Split();
                switch (arr[0])
                {
                    case "exchange": 
                        int index = int.Parse(arr[1]); 
                        Exchange(n, command, arr, index); break;
                     
                    case "max":
                        if (arr[1] == "even")
                        {
                            Max_Even(n, arr);
                        }
                        else
                        {
                            Max_Odd(n, arr);
                        }
                        ; break;

                    case "min":
                        if (arr[1] == "even")
                        {
                            Min_Even(n, arr);
                        }
                        else
                        {
                            Min_Odd(n, arr);
                        }
                        ; break;

                    case "first":
                        if (arr[1] == "even")
                        {
                            First_Even(n, arr);
                        }
                        else
                        {
                            First_Odd(n, arr);
                        }
                        ; break;

                    case "last":
                        if (arr[1] == "even")
                        {
                            Last_Even(n, arr);
                        }
                        else
                        {
                            Last_Odd(n, arr);
                        }
                        ; break;
                }
            }
        }


        static int Exchange(int[] n, string command, string[] arr, int index)
        {
            if (index < 0 || index >= n.Length)
            {

            }
        }

        static int Max_Even(int[] n, string[] arr)
        {

        }

        static int Max_Odd(int[] n, string[] arr)
        {

        }

        static int Min_Even(int[] n, string[] arr)
        {

        }
        static int Min_Odd(int[] n, string[] arr)
        {

        }

        static int First_Even(int[] n, string[] arr)
        {

        }

        static int First_Odd(int[] n, string[] arr)
        {

        }

        static int Last_Even(int[] n, string[] arr)
        {

        }

        static int Last_Odd(int[] n, string[] arr)
        {

        }
    }
}