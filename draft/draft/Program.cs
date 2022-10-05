



Console.WriteLine(GetDay(37));
Console.ReadLine();

static string GetDay (int dayNum)
{   string dayName;
    
    switch (dayNum)
    {
        case 0: 
            dayName = "Sunday";
            break;
        case 1: 
            dayName = "Monday";
            break ;
        case 2:
            dayName = "Tuesday";
            break;
      default:
            dayName = "please enter a number from 0 - 2";
            break;

    }

    return dayName;
}
