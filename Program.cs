﻿Console.WriteLine("QUADRANTE");
Console.WriteLine("Digite um numero que indique um ponto");

double X;
double Y;

Console.WriteLine("Ponto X:");
X = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ponto Y:");
Y = Convert.ToDouble(Console.ReadLine());

if (X > 0 && Y > 0)
    {Console.WriteLine($" O ponto ({X}, {Y}) esta no quadrante I.");}

    else if (X < 0 && Y > 0)
    {Console.WriteLine($" O ponto ({X}, {Y}) esta no quadrante II.");}

    else if (X < 0 && Y < 0)
    {Console.WriteLine($" O ponto ({X}, {Y}) esta no quadrante III.");}

    else if (X > 0 && Y < 0) 
    {Console.WriteLine($" O ponto ({X}, {Y}) esta no quadrante IV.");}

    if (X == 0 && Y < 0 || X == 0 && Y > 0 )
    {Console.WriteLine($" O ponto ({X}, {Y}) esta sob o eixo Y");}

    else if (Y == 0 && X < 0 || Y == 0 && X > 0 )
    {Console.WriteLine($" O ponto ({X}, {Y}) esta sob o eixo X");}

    else
    {Console.Write("O ponto (0, 0) esta na origem.");}