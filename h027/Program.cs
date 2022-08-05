int A = int.Parse(Console.ReadLine()!);

        int dev = 0;

int aa = 0;
void NumSum (int num) 
{
    for (int i = 0; num > 0; i++)
    {
        aa += num % 10;
        num = num/10;
        dev += 1;
    }
    Console.WriteLine(aa);

}

NumSum(A);