// Zadanie domowe dzień 4.

string name = "Adam";
int Age = 31;
bool jestKobietą = true;


if (Age < 18 && jestKobietą == false)
{ 
 Console.WriteLine("Mężczyzna niepełnoletni");
}

else if (Age >= 18 && jestKobietą == false)
{
Console.WriteLine("Mężczyzna pełnoletni");
}
else if (Age > 30 && jestKobietą == true)
{
    Console.WriteLine("Kobieta po 30");
}
  
