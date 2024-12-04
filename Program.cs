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

//Hasta aca hice los metods que daban la respuesta void en lo adelante seran de cualquier tipo 
static long Factorial(int n)
{
    if (n == 1) return 1;

    return n * Factorial(n - 1);

}

static void ImprimiendoNumeros(int n)
{
    if (n < 0) return;

    Console.WriteLine(n);

    ImprimiendoNumeros(n - 1);
}

static void InvierteElOrden(int n)
{
    if (n < 0) return;

    InvierteElOrden(n - 1);

    Console.WriteLine(n);
}

static void SumandoHoras(int hour1, int min1, int hour2, int min2)
{
    int timeInMins, timeInHours, timeInDays;

    if (min1 + min2 >= 60)
    {
        timeInMins = (min1 + min2) % 60;
        timeInHours = (min1 + min2) / 60;

        if (hour1 + hour2 + timeInHours >= 24)
        {
            timeInHours = (timeInHours + hour1 + hour2) % 24;
            timeInDays = (timeInHours + hour1 + hour2) / 24;
            Console.WriteLine($"Han pasado {timeInDays} y son las {timeInHours}:{timeInMins} ");
        }

        else
        {
            timeInHours += hour1 + hour2;
            Console.WriteLine($"Son las {timeInHours}:{timeInMins} ");
        }

    }
    else
    {
        timeInMins = (min1 + min2);

        if (hour1 + hour2 >= 24)
        {
            timeInHours = (hour1 + hour2) % 24;
            timeInDays = (timeInHours + hour1 + hour2) / 24;
            Console.WriteLine($"Han pasado {timeInDays} y son las {timeInHours}:{timeInMins} ");
        }

        else
        {
            timeInHours = hour1 + hour2;
            Console.WriteLine($"Son las {timeInHours}:{timeInMins} ");
        }
    }
}

static void Avion(int hour1, int min1, int hour2, int min2)
{
    int timeInMins, timeInHours;
    if (min2 - min1 < 0)
    {
        timeInMins = 60 + min2 - min1;
        timeInHours = 1;

        if (hour2 - hour1 < 0)
        {
            timeInHours = 24 + hour2 - hour1 - 1;

            Console.WriteLine($"El tiempo de vuelo fue de: {timeInHours}:{timeInMins} ");
        }

        else
        {
            timeInHours = hour2 - hour1 - 1;

            Console.WriteLine($"El tiempo de vuelo fue de: {timeInHours}:{timeInMins} ");
        }
    }

    else
    {
        timeInMins = min2 - min1;

        if (hour2 - hour1 < 0)
        {
            timeInHours = 24 + hour2 - hour1;

            Console.WriteLine($"El tiempo de vuelo fue de: {timeInHours}:{timeInMins} ");
        }

        else
        {
            timeInHours = hour2 - hour1;

            Console.WriteLine($"El tiempo de vuelo fue de: {timeInHours}:{timeInMins} ");
        }
    }
}

// static void PuntoInterior(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4)
// {
//     double a, b, c, equation1, equation2, equation3, distance1, distance2, distance3, maxDistance;

//     a = y2 - y1;
//     b = x1 - x2;
//     c = x2 * y1 - x1 * y2;
//     equation1 = Math.Abs(a * x4 + b * y4 + c) / Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
//     distance1 = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));

//     a = y3 - y2;
//     b = x2 - x3;
//     c = x3 * y2 - x2 * y3;
//     equation2 = Math.Abs(a * x4 + b * y4 + c) / Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
//     distance2 = Math.Sqrt(Math.Pow((x2 - x3), 2) + Math.Pow((y2 - y3), 2));

//     a = y1 - y3;
//     b = x3 - x1;
//     c = x1 * y3 - x3 * y1;
//     equation3 = Math.Abs(a * x4 + b * y4 + c) / Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
//     distance3 = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));

//     maxDistance = Math.Max(equation1, Math.Max(equation2, equation3));

//     if(equation >= )


// } ESTE ME FALTA TERMINARLO CON LA MULTIPLICACION VECTORIAL Y PUEDO USAR LA SUMA DEL AREA DEL TRINAGULO GRANDE CON LOS TRES FORMADOS CON EL VERTICE 

static void Mayor()
{
    Console.WriteLine("Introduzca 3 numeros y averiguemos quie es el mayor: ");
    int number1 = int.Parse(Console.ReadLine());
    int number2 = int.Parse(Console.ReadLine());
    int number3 = int.Parse(Console.ReadLine());

    Console.WriteLine($"El mayor es: {Math.Max(number1, Math.Max(number2, number3))}");
}

static void Calculadora()
{
    Console.WriteLine("Adelante, puede calcular ");

    float number1 = float.Parse(Console.ReadLine());
    string operatorString = Console.ReadLine();
    float number2 = float.Parse(Console.ReadLine());

    switch (operatorString)
    {
        case "+":
            Console.WriteLine($"{number1} + {number2} = {number1 + number2} ");
            break;

        case "-":
            Console.WriteLine($"{number1} - {number2} = {number1 - number2} ");
            break;

        case "*":
            Console.WriteLine($"{number1} * {number2} = {number1 * number2} ");
            break;

        case "/":
            Console.WriteLine($"{number1} / {number2} = {number1 / number2} ");
            break;

        default:
            Console.WriteLine($"{number1} {operatorString} {number2} no es una operacion valida ");
            break;
    }
}






