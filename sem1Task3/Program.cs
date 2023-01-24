Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int current = 2;
while (current <= number){
    Console.Write(current + " ");
    current = current + 2;
}
