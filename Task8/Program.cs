Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= N; i = i + 2)
    if(i=0)
        continue;
    Console.WriteLine("Число {0}", i);
    