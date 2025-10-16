int a = 2000000000;
int b = 2000000000;

checked
{
	try
	{
		Console.WriteLine(a + b);
	}
	catch (OverflowException e)
	{
        Console.WriteLine(e.Message);
	}

    Console.WriteLine("....");
}

uint n = 3;
uint cn = ~3u;



Console.WriteLine(n);
Console.WriteLine(cn);