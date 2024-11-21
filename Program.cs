int maxSterne = 40;
int space = maxSterne / 2;

for (int sterneanzahl = 1; sterneanzahl <= maxSterne; sterneanzahl += 2)
{
    for (int i = 0; i < space; i++)
    {
        Console.Write(" ");
    }
    for (int i = 0; i < sterneanzahl; i++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
    space--;
}