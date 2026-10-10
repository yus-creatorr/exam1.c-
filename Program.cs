// task 1
// int a = Convert.ToInt32(Console.ReadLine());
// int[] levo = new int[a];
// for (int i = 0; i < a; i++)
// {
//     levo[i] = Convert.ToInt32(Console.ReadLine());
// }
// int k = Convert.ToInt32(Console.ReadLine());
// for (int i = k; i < a - 1; i++)
// {
//     levo[i] = levo[i + 1];
// }
// for (int i = 0; i < a - 1; i++)
// {
//     Console.WriteLine(levo[i]);
// }

// task 2
// int a = Convert.ToInt32(Console.ReadLine());
// int Even(int a)
// {
//     if (a == 0)
//     {
//         return 0;

//     }
//     int b = a%10;
//     if (b % 2 == 0)
//     {
//         return 1+ Even(a/10);
//     }
//     return Even(a/10);
// }
// System.Console.WriteLine("Even:"+ Even(a));


// int Odd(int a)
// {
// if (a == 0)
//     {
//         return 0;

//     }
//     int b = a%10;
//     if (b % 2 != 0)
//     {
//         return 1+ Even(a/10);
//     }
//     return Even(a/10);
// }
// System.Console.WriteLine("odd:" +Odd(a));

// int DigitCount(int a)
// {
//     if(a>0 && a < 10)
//     {
//         return 1;
//     }
//     return 1+ DigitCount(a/10);
// }
// System.Console.WriteLine("Digits:"+ DigitCount(a));

// int Sum(int a)
// {
    
//         int sum = 0;
//         for(int i=a;i>0;i/=10)
//         {
//             sum+=i%10;
//         }
//         return sum;
// }
// Console.WriteLine("Sum:"+  Sum(a));


// task 3
// string IsPalindrom(string a)
// {
//     string c="";
//     for(int i=0; i<a.Length; i++)
//     {
//         c+=a[a.Length-i-1];
//     }
//     if(c==a)
//     {
//         return "Yes";
//     }
//     else
//     {
//         return "No";
//     }
// }

// System.Console.WriteLine(IsPalindrom(Console.ReadLine()));


// task 4
//  int a = Convert.ToInt32(Console.ReadLine());
// int Sum(int a)
// {
//         int sum = 0;
//         for(int i=a;i>0;i/=10)
//         {
//             sum+=i%10;
//         }
//         return sum;
// }
// Console.WriteLine("The sum of the digits of the number " + a + " is : " + Sum(a));

// task 5
// int a = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[a];
// for(int i=0; i<a; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// void PlusPlus(ref int[] arr, int n, int a)
// {
//     for (int i = 0; i < a; i++)
//     {
//         arr[i] = arr[i] + n;
//     }
// }   
// int n = Convert.ToInt32(Console.ReadLine());

// PlusPlus(ref arr, n, a);

// for (int i = 0; i < a; i++)
// {
//     Console.Write(arr[i] + " ");
// }


// task 6
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// void Swap(ref int a, ref int b)
// {
//     int c = a;
//     a = b;
//     b = c;
// }
// Swap(ref a, ref b);
// Console.WriteLine("x = " + a);
// Console.WriteLine("y = " + b);


// task 7
// int a = Convert.ToInt32(Console.ReadLine());
// int SumDigit(int a )
// {
//     if(a == 0 )
//     {
//         return 0;
//     }
//     return a%10 + SumDigit(a/10);
// }
// System.Console.WriteLine(SumDigit(a));

// task 8
