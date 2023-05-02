Console.WriteLine("Введите число: ");
int Num = Convert.ToInt32(Console.ReadLine());
double temp = Num;
int step = 0;
//узнаём количество разрядов в числе
while(temp > 1){
    step = step + 1;
    temp = temp / 10;
}
if (step == 3){
    //создаю массив длинной равный количеству разрядов числа
    int[] array = new int[step];
    //Заполняю массив числами из каждого разряда введённого числа
    int StepArray = 0;
    int digit = 0;
    while (StepArray < step)
    {
        digit = (step - 1) - StepArray;
        array[digit] = Num % 10;
        Num = Num / 10;
        StepArray++;
    }
    //вывожу второе число в массиве
    Console.Write($"Вторая цифра: {array[1]} ");
}
else {
    Console.WriteLine("Введено не трёхзначное число");
}