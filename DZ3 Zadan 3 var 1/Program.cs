int Qube (int temp){
    int Result = temp * temp * temp;
    return Result;
}
Console.WriteLine ("Введите число: ");
int Num = Convert.ToInt32(Console.ReadLine());
int step = 1;
int QubeNum = 0;
while (step <= Num){
    QubeNum = Qube(step);
    Console.WriteLine($"{step}^3={QubeNum}");
    step++;
}