void WaitX (string dot){
    Console.Write($"Введите координаты по оси X {dot}");
}
void WaitY (string dot){
    Console.Write($"Введите координаты по оси Y {dot}");
}
void WaitZ (string dot){
    Console.Write($"Введите координаты по оси Z {dot}");
}
double Input (){
    Console.WriteLine("");
    string Input = Console.ReadLine();
    double num = Convert.ToDouble(Input);
    return num;
}
double SumKvadr (double NumA, double NumB){
    double Sum;
    Sum = (NumA - NumB) * (NumA - NumB);
    return Sum;
}
WaitX("первой точки");
double DotOneX = Input();
WaitY("первой точки");
double DotOneY = Input();
WaitZ("первой точки");
double DotOneZ = Input();
WaitX("второй точки");
double DotTwoX = Input();
WaitY("второй точки");
double DotTwoY = Input();
WaitZ("второй точки");
double DotTwoZ = Input();
double Rezult = SumKvadr(DotOneX, DotTwoX) + SumKvadr(DotOneY, DotTwoY) + SumKvadr(DotOneZ, DotTwoZ);
Rezult = Math. Sqrt(Rezult);
Console.WriteLine($"XYZ первой точки: {DotOneX} {DotOneY} {DotOneZ} XYZ второй точки {DotTwoX} {DotTwoY} {DotTwoZ}");
Console.WriteLine($"Расстояние между точками: {Rezult}");