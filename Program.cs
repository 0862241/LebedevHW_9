// Task.1. Set the value to N. Write a program that outputs all natural numbers in the range from N to 1.

/*
void ReduceNumber(int n, int m)
{
    if (m > n)
    {
        Console.WriteLine("Please input a number n more then 1 ");
    }
    else
    {
        ReduceNumber(n, m + 1);
        Console.Write(m + " ");
    }
     
}
Console.WriteLine("Input a number n:  ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 1;
ReduceNumber(n, m);
*/

/*
Task.2. Set the values of M and N. 
Write a program that finds the sum of natural elements in the range from M to N.
*/
/*
Console.WriteLine("Input the number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the number N: ");
int n = Convert.ToInt32(Console.ReadLine());
int temp = m;
if (m > n) 
{
    m = n; 
    n = temp;
}
ShowSum(m, n, temp = 0);
void ShowSum(int m, int n, int sum)
{
    sum += n;
    if (n <= m)
    {
        Console.Write($"The sum of the elements in the range from M to N is equal to {sum}.");
        return;
    }
    ShowSum(m, n - 1, sum);   
}
*/

/*
Task.3. Write a program for calculating the Ackerman function using recursion. 
Two non-negative numbers m and n are given.
*/
/*
Console.WriteLine("Input the number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the number N: ");
int n = Convert.ToInt32(Console.ReadLine());
int Ackerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ackerman(m - 1, 1);
  else return Ackerman(m - 1, Ackerman(m, n - 1));
}

int ResultFonct = Ackerman(m, n);

Console.Write($"The Ackerman function is equal to {ResultFonct}.");
*/
