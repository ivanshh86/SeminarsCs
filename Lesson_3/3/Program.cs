//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).


int Diapasone(int quatro)
{
    int quatro1;
    int quatro2;
    int quatro3;
    int quatro4;
    if (quatro == 1) ; return 1;
    if (quatro == 2) return 2;
    if (quatro == 3) return 3;
    else return 4;
}

Console.WriteLine("Enter quatro ");
int a = Convert.ToInt32(Console.ReadLine());

int result;

if (a<=0 || a>=5) Console.WriteLine("Entering not quatro");
else
{
    result = Diapasone(a);
    if (result == 1) Console.WriteLine("x>0, y>0");
    if (result == 2) Console.WriteLine("x<0, y>0");
    if (result == 3) Console.WriteLine("x<0, y<0");
    if (result == 4) Console.WriteLine("x>0, y<0");
}

