static void Divisible()
{
    Console.WriteLine("Introduzca dos numeros: ");

    double number1 = double.Parse(Console.ReadLine());
    double number2 = double.Parse(Console.ReadLine());

    if (number1 % number2 == 0) Console.WriteLine($"El numero {number1} es divisible por {number2} ");

    else Console.WriteLine($"El numero {number1} no es divisible por {number2} ");
}

static void Carnet()
{
    Console.WriteLine("Intoduzca su carnet de identidad: ");

    string id = Console.ReadLine();

    if (id[id.Length - 2] % 2 == 0) Console.WriteLine("Tu sexo es masculino ");

    else Console.WriteLine("Tu sexso es femenino");

}

static void ValorAbsoluto_1()
{
    Console.WriteLine("Introduzca un numero: ");

    double number1 = double.Parse(Console.ReadLine());

    if (number1 >= 0) Console.WriteLine($"El valor absoluto de {number1} es: {number1} ");

    else Console.WriteLine($"El valor absoluto de {number1} es: {-number1} ");
}

static void ValorAbsoluto_2()
{
    Console.WriteLine("Introduzca un numero: ");

    double number1 = double.Parse(Console.ReadLine());

    number1 = Math.Sqrt(Math.Pow(number1, 2));

    Console.WriteLine($"El valor absoluto de {number1} es: {number1} ");
}

static void FormaFecha()
{

    Console.WriteLine("Introduzca el dia: ");
    int day = int.Parse(Console.ReadLine());

    Console.WriteLine("Introduzca el mes: ");
    int month = int.Parse(Console.ReadLine());

    Console.WriteLine("Intorduzca el año: ");
    int year = int.Parse(Console.ReadLine());

    if (year > 0 && month >= 1 && month <= 12 && Tools.ValidDay(day, month, year)) Console.WriteLine($"La fecha es: {day}/{month}/{year} ");

    else Console.WriteLine("La fecha no es valida ");
}

static void Triangle()
{
    Console.WriteLine("Introduzca el lado a: ");
    int a = int.Parse(Console.ReadLine());

    Console.WriteLine("Introduzca el lado b: ");
    int b = int.Parse(Console.ReadLine());

    Console.WriteLine("Introduzca el lado c: ");
    int c = int.Parse(Console.ReadLine());

    if (a + b > c && a + c > b && b + c > a)
    {
        if (a == b && b == c) Console.WriteLine((int)Classification.Equilatero);

        else if (a == b || a == c || b == c) Console.WriteLine((int)Classification.Isosceles);

        else Console.WriteLine((int)Classification.Escaleno);
    }

    else Console.WriteLine((int)Classification.NoTringle);
}

static void DiaSemana()
{
    Console.WriteLine("Introduzca el dia ");
    int day = int.Parse(Console.ReadLine());

    Console.WriteLine("Introduzca el mes: ");
    int month = int.Parse(Console.ReadLine());

    Console.WriteLine("Introduzca el año: ");
    int year = int.Parse(Console.ReadLine());

    int totalDays = 0;
    for (int i = 1; i < year; i++)
    {
        totalDays += Tools.IsLeap(i) ? 366 : 365;
    }

    int[] arrayMonth = { 31, Tools.IsLeap(year) ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    for (int i = 0; i < month - 1; i++)
    {
        totalDays += arrayMonth[i];
    }

    totalDays += day;

    int dayOfWeek = totalDays % 7;

    Console.WriteLine($"El dia de la semana es: {(Week)dayOfWeek}");
}

static void DiaDespues()
{

    Console.WriteLine("Introduzca el dia: ");
    int day = int.Parse(Console.ReadLine());

    Console.WriteLine("Introduzca el mes: ");
    int month = int.Parse(Console.ReadLine());

    Console.WriteLine("Introduzca el año: ");
    int year = int.Parse(Console.ReadLine());

    int[] arrayMonth = { 31, Tools.IsLeap(year) ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    if (day == 31 && month == 12)
    {
        day = 1;
        month = 1;
        year += 1;

        Console.WriteLine($"La fecha es {day}/{month}/{year} ");
    }

    else if (day == arrayMonth[month - 1])
    {
        day = 1;
        month += 1;

        Console.WriteLine($"La fecha es {day}/{month}/{year} ");
    }

    else
    {
        day += 1;

        Console.WriteLine($"La fecha es {day}/{month}/{year} ");
    }
}

static void DosFechas()
{

    Console.WriteLine("Introduzca el dia del la primera fecha: ");
    int day1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Introduzca el mes del la primera fecha: ");
    int month1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Introduzca el año del la primera fecha: ");
    int year1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Introduzca el dia del la segunda fecha: ");
    int day2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Introduzca el mes del la segunda fecha: ");
    int month2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Introduzca el año del la segunda fecha: ");
    int year2 = int.Parse(Console.ReadLine());

    int different = Math.Abs(Tools.NumberOfDays(day1, month1, year1) - Tools.NumberOfDays(day2, month2, year2));

    Console.WriteLine($"La diferencia en dias de las dos fechas es: {different} ");

}













