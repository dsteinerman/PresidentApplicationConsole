// See https://aka.ms/new-console-template for more information

bool approved = true;


Console.WriteLine("Are you a Natural Born Citzen?, Y/N ");
string Citzen = "";
while (Citzen == "")
{
    Citzen = Console.ReadLine();
    if (Citzen == "Y" || Citzen == "y")
    {
        
              

    }else if(Citzen == "N" || Citzen == "n")
    {
      
        approved = false;
    }
    else
    {
        Citzen = "";
        Console.WriteLine("Please enter Y or N to the question, are you a Natural Born Citzen");
    }
}

Console.WriteLine("What is your birth year?");
int birthYear = -1;

while (birthYear == -1)
{
    if (int.TryParse(Console.ReadLine(), out birthYear))
    {
        if (birthYear>DateTime.Now.Year-35)
        {
            approved = false;
        }

    }
    else
    {
        birthYear = -1;
        Console.WriteLine("Please enter a valid birth Year, ex 1984");
    }
}


Console.WriteLine("How many years have you lived in the US?");
int years = -1;
while (years == -1)
{
    if (int.TryParse(Console.ReadLine(), out years))
    {
        if (years < 14)
        {
            approved= false;
        }
        
    }
    else
    {
        years = -1;
        Console.WriteLine("Please enter a number between 0-120");
    }
}

Console.WriteLine("How many terms have you served?");
int termsServed = -1;
while (termsServed == -1)
{
    if (int.TryParse(Console.ReadLine(), out termsServed))
    {
        if (termsServed > 1)
        {
            approved = false;
        }

    }
    else
    {
        termsServed = -1;
        Console.WriteLine("Please enter a number between 0-2");
    }
}

Console.WriteLine("Have you rebelled against the US?, Y/N ");
string rebelled = "";
while (rebelled == "")
{
    rebelled = Console.ReadLine();
    if (rebelled == "Y" || rebelled == "y")
    {

        approved = false;

    }
    else if (rebelled == "N" || rebelled == "n")
    {

        
    }
    else
    {
        rebelled = "";
        Console.WriteLine("Please enter Y or N to the question, Have you rebelled against the US");
    }
}

if (approved)
{
    Console.WriteLine("Congratulations you are eligible To run for President.");
}
else
{
    Console.WriteLine("You are not eligible To run for President.");
}






