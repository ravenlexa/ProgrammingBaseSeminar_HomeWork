/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.*/
//Рассчитывает растояние между двух точек в трехмерном пространстве.
double DistansionABin2D(int coordx1, int coordy1, int coordz1, int coordx2, int coordy2, int coordz2)
{
    double distasionAB = Math.Sqrt(Math.Pow(coordx2-coordx1, 2) + Math.Pow(coordy2-coordy1, 2) + Math.Pow(coordz2-coordz1, 2));
    return distasionAB;
}

System.Console.WriteLine( "Введите координаты двух точек");
System.Console.WriteLine( "Введите координаты первой точки: ");
System.Console.Write("x1 = ");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("y1 = ");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("z1 = ");
int z1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine( "Введите координаты второй точки: ");
System.Console.Write("x2 = ");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("y2 = ");
int y2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("z2 = ");
int z2 = Convert.ToInt32(Console.ReadLine());

double distasion = DistansionABin2D(x1, y1, z1, x2, y2, z2);
System.Console.WriteLine(distasion);
