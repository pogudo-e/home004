
void FillArr(int[] coll)
{
    int i = 0;
    while(i < coll.Length)
    {
        coll[i] = new Random().Next(1, 100);
        i++;
    }
    Console.WriteLine("[{0}]", string.Join(", ", coll));
}

int lenArray = new Random().Next(2,20);
int[] array = new int[lenArray];

FillArr(array);