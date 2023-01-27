//Напишите программу, которая на вход принимает три числа и выдаёт, какое число большее, а какое меньшее.

            Console.Write("Введите первое число ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье число ");
            int c = Convert.ToInt32(Console.ReadLine());
           
           
           int max=a;
           
            if (b>max)max=b;
            if (c>max)max=c;

           Console.WriteLine("макс число :{0}", max);
