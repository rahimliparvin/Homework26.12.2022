using Enum;
using System;


int rolId = 3;

switch (rolId)
{
	case (int)WeekDays.Monday:
		Console.WriteLine("The day is Monday");
		break;
    case (int)WeekDays.Tuesday:
		Console.WriteLine("The day is Tuesday");
        break;
	case (int)WeekDays.Wednesday:
		Console.WriteLine("The day is Wednesday");
		break;
	case (int)WeekDays.Thursday:
		Console.WriteLine("The day is Thursday");
		break;
	case (int)WeekDays.Friday:
		Console.WriteLine("The day is Friday");
        break;
	case (int)WeekDays.Saturday:
		Console.WriteLine("The day is Saturday");
        break;
	case (int)WeekDays.Sunday:
		Console.WriteLine("The day is Sunday");
        break;

    default:
		Console.WriteLine("The day was not found");
		break;
}

