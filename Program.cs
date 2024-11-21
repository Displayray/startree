Console.Write("Anzahl Sterne: ");
int n = Convert.ToInt16(Console.ReadLine());

for(int i = 1; i <= n; i++)
{
    int sterne = 2;
    if (i == 1) sterne = 1;
    else if (i == n) sterne = n;
    int offset = i-2;
    int punkte = n - i;
    if (offset > 0) punkte = ((n - sterne) - offset);
    
    for(int xi = 0; xi < sterne; xi++)
    {
        Console.Write("*");
        if(offset > 0 && xi == 0 && i != n)
        {
            for(int x = 0; x < offset; x++)
            {
                Console.Write(".");
            }
            offset--;
        }
    }
    
    for(; punkte > 0; punkte--)
    {
        Console.Write(".");
    }
    
    Console.WriteLine();
}

/* 
    for(int xi = 0; xi < i; xi++)
    {
        Console.Write("*");
    }
    for(int punkte = n-i; punkte > 0; punkte--)
    {
        Console.Write(".");
    }
    Console.WriteLine();
*/