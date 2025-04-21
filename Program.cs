int[] years = { 2016, 2018, 2000, 2100 };
foreach(int year in years)
{
    if (IfYearIsLeap(year))
        Console.WriteLine($"The year {year} is a leap year.");
    else
        Console.WriteLine($"The year {year} is not a leap year");
}

bool IfYearIsLeap(int  year)
{
    if(year % 4 == 0)
    {
        if(year % 100 == 0) { return year % 400 == 0; }
        return true;
    }
    return false;
}