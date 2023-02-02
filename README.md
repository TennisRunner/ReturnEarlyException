# ReturnEarlyException
A simple C# custom exception type for using return early style coding practices.

# What is return early?
Return early means instead of wrapping your conditions in nested if/else braces.

You instead do a single condition check and then break out of that entire block if any
of the conditions are untrue.

# What are the advantages?
Return early style is less verbose since you no longer need to wrap everything in curly braces.

It also does not risk extending past the horizontal limit of your screen.

Lastly it is easier to read since it is a top down linear flow.

# Examples


## Return Early Style
```C#
while (true)
{
	try
	{
		int foo = 123;

		if (foo == 555)
			throw new ReturnEarlyException("Foo is 555. Not allowed");

		if (foo == 777)
			throw new ReturnEarlyException("Foo is 777. Not allowed");

		if (foo == 888)
			throw new ReturnEarlyException("Foo is 888. Not allowed");

		if (foo == 999)
			throw new ReturnEarlyException("Foo is 999. Not allowed");

		Console.WriteLine("Foo is valid");
	}
	catch (ReturnEarlyException e)
	{
		Console.WriteLine(e.Message);
	}

	Thread.Sleep(1000);
}
```



## Nested Style
```C#
while (true)
{
	int foo = 123;

	if (foo != 555)
	{
		if (foo != 777)
		{
			if (foo != 888)
			{
				if (foo != 999)
				{
					Console.WriteLine("Foo is valid");
				}
				else
					Console.WriteLine("Foo is 999. Not allowed");
			}
			else
				Console.WriteLine("Foo is 888. Not allowed");
		}
		else
			Console.WriteLine("Foo is 777. Not allowed");
	}
	else
		Console.WriteLine("Foo is 555. Not allowed");
	
	Thread.Sleep(1000);
}
```