int Qube (int temp){
    int Result = temp * temp * temp;
    return Result;
}
Console.WriteLine ("Введите число: ");
int Num = Convert.ToInt32(Console.ReadLine());
int step = 0;
int[] array = new int[Num];
while (step < Num){
    array[step] = Qube(step+1);
    Console.WriteLine($"{step+1}^3={array[step]}");
    step++;
}