int[] years = { 2016, 2018 };
foreach(int year in years)
{
    if (IfYearIsLeap(year))
        Console.WriteLine($"The year {year} is a leap year.");
    else
        Console.WriteLine($"The year {year} is not a leap year");
}

bool IfYearIsLeap(int  year)
{
    return year % 4 == 0;
}