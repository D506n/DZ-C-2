Console.WriteLine("Введите номер дня: ");
int Day = Convert.ToInt32(Console.ReadLine());
if (Day > 0 & Day <=7){
    if (Day > 5){
        Console.WriteLine ("Выходной");
    }
    else Console.WriteLine ("Рабочий");
}
else {
    Console.WriteLine ("Введён не день недели");
}