Console.WriteLine("Введите число: ");
int Num = Convert.ToInt32(Console.ReadLine());
double temp = Num;
int step = 0;
//узнаём количество разрядов в числе
while(temp > 1){
    step = step + 1;
    temp = temp / 10;
}
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
//проверяю массив на зеркальность
StepArray = 0;
int Match = 0;
int control = 0;
while(StepArray != step & step > StepArray){
    if (array[StepArray] == array[step-1]){
        Match++;
    }
    control++;
    StepArray++;
    step--;
}
//выдаю ответ
if (control == Match){
    Console.WriteLine("Является палиндромом");
}
else{
    Console.WriteLine("Не является палиндромом");
}