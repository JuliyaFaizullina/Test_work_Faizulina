string[] mass1 = new string[3] { "hello", "2", ";-)" };
string[] mass2 = new string[mass1.Length];
int count = 0;
void MassCheck(string[] mass1, string[] mass2)
{
    for (int i = 0; i < mass1.Length; i++)
    {
        if (mass1[i].Length <= 3)
        {
            mass2[count] = mass1[i];
            count++;
        }
    }
}
MassCheck(mass1, mass2);
void PrintMass(string[] mass)
{
    for (int i = 0; i < mass2.Length; i++)
    {
        Console.Write($"{mass2[i]} ");
    }
}
PrintMass(mass2);
