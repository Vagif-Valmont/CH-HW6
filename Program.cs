// HomeWork 6
//Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
	// 0, 7, 8, -2, -2 -> 2
	// 1, -7, 567, 89, 223-> 3
	

// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
	// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
	// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
	

	void Task_1()
	{
	    int len = ReadInt("number of numbers");
	    int [] array = new int[len];
	    array = fillingArray(array);
	    Console.WriteLine(string.Join(", ", array));
	    checkArray(array);
	}
	

	void Task_2()
	{
	    string taskCondition = "y = k1 * x + b1 \ny = k2 * x + b2";
	    Console.WriteLine(taskCondition);
	    int b1 = ReadInt("b1");
	    int k1 = ReadInt("k1");
	    int b2 = ReadInt("b2");
	    int k2 = ReadInt("k2");
	    equationTask2(b1, k1, b2, k2);
	}
	

	int ReadInt(string argumrntName)
	{
	    Console.Write($"Input {argumrntName}: ");
	    
	    int number = 0;
	    while (!int.TryParse(Console.ReadLine(), out number))
	    {
	        Console.WriteLine("It's not a number");
	    }
	

	    return number;
	}
	

	int[] fillingArray(int[] array)
	{
	    for (int i = 0; i < array.Length; i++)
	    {
	        array[i] = ReadInt($"number {i+1} ");
	    }
	

	    return array;
	}
	

	void checkArray(int[] array)
	{
	    int count = 0;
	

	    for (int i = 0; i < array.Length; i++)
	    {
	        if (array[i] > 0)
	        {
	            count +=1;
	        }
	    }
	

	    Console.WriteLine($"чисел больше 0: {count}"); 
	}
	

	void equationTask2(int b1, int k1, int b2, int k2)
	{
	    if ( k1 != k2 )
	    {
	        double x = (double) (b2 - b1) / (k1 - k2);
	        double y = (double) k1 * x + b1;
	        Console.WriteLine($"x = {x}\ny = {y}");
	    }
	    else   
	    {
	        Console.WriteLine("прямые совпадают или параллельны");
	    }
	}
	

	bool inWork = true;
	

	while (inWork)
	{
	    Console.Write("Выберите задачу ");
	

	    if (int.TryParse(Console.ReadLine(), out int i))
	    {
	        switch(i)
	        {
	            case 1:
	            {
	                Task_1();
	                
	                break;
	            }
	

		    case 2:
	            {
	                Task_2();
	                
	                break;
	            }
	

	            case -1: inWork = false; break;
	        }
	    }
	}



