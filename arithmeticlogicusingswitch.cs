int a = 18;
int b = 6;
int c, d;
c = Convert.ToInt32(Console.ReadLine());
switch(c)
{
    case 1: {
            d = a + b;
            Console.WriteLine(d);
            break;
    }
    case 2: {
            d = a - b;
            Console.WriteLine(d);
            break;
    }
    case 3: {
            d = a * b;
            Console.WriteLine(d);
            break;
    }
    case 4: {
            d = a / b;
            Console.WriteLine(d);
            break;
    }
    case 5: {
            d = a % b;
            Console.WriteLine(d);
            break;
    }
}