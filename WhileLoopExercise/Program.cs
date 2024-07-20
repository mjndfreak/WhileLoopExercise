
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;

int i = 1 ;


while (i < 11)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!" );
    i++;
}
Console.Write("\n");


int i2 = 1 ;
while (i2 <= 20)
{
    Console.Write(i2 + ", ");
    i2 += 1;
}
Console.WriteLine("\n");



int i3 = 0 ;
while (i3 <= 18)
{
    i3 += 2;
    Console.Write(i3 + ", ");
}
Console.WriteLine("\n");




int i4 = 50;
int sum = 0 ;
while (i4 <= 150)
{
    sum += i4;
    i4++ ;
}
Console.WriteLine(sum);
Console.Write("\n");



int i5 = 1 ;
int sumOdd = 0 ;
int sumEven = 0 ;
while (i5 <= 120)
{
    if (i5 % 2 == 0)
    {
        sumEven += i5;
    }
    
    else
    {
        sumOdd += i5;
    }
    
    
    i5++;
}


Console.WriteLine("Sum Odd: " + sumOdd + "\nSum Even: " + sumEven);


