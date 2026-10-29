using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;

Console.WriteLine("Hello, World!"); // IMPRIME EN PANTALLA, COMO UN PRINT
Console.WriteLine("Hola, soy Joaquín Vera y estudio II");
Console.Write("Hola Joaquín, ¿como estas?");
Console.WriteLine(); //A diferencia del Write normal, este no se salta una linea y se escribe al lado del mensaje anterior.
Console.WriteLine("------------------");
int edad= 23;
Console.WriteLine(edad);
float estatura=1.6f; //Se agrega una f para tratado estrictamente como un tipo float
double peso=60.5;
bool esEstudiante=true;
string nombre="Mario";
double pesoIdeal=70;
int peso2=(int)pesoIdeal;
Console.WriteLine("Ingrese nombre del jugador");
string player=Console.ReadLine();
System.Console.WriteLine("El jugador es: " + player);
System.Console.WriteLine("Ingrese el nivel del jugador: ");
int nivel=int.Parse(Console.ReadLine()); //Lee el texto de la consola, lo convierte a número entero y lo guarda en 'nivel'.
System.Console.WriteLine("El nivel del jugador es {0} y su nombre es {1}" ,nivel,player);

if (edad>=18)
{
    Console.Write("Eres mayor de edad,");
        Console.WriteLine("por lo tanto puedes entrar al juego");
}else if(edad>=15 && edad<18) //&& lo que hace es validad de manera doble
{
    Console.WriteLine("Puedes entrar pero con restricciones");
}
//a ++ , le agrega 1 a la variable a, a -- le resta 1 a la variable a
int tabla=5;
for(int i=1; i<=10; i++)
{
    Console.WriteLine(tabla+" x "+ i +" = "+(tabla*i));
}

tabla=7;
int cont=1;
while (cont <=10)
{
    Console.WriteLine(tabla+" x "+ cont + " = "+(tabla*cont));
    cont++;
}
Console.WriteLine("----------------DO-WHILE----------------");
tabla=9;
cont=1;
do
{
    Console.WriteLine(tabla+" x "+ cont + " = "+(tabla*cont));
    cont++;
}while (cont<=10);
Console.WriteLine("----------------SWITCH----------------");
int opcion=2;
switch (opcion)
{
    case 1:
        Console.WriteLine("Opcion 1");
        break;
    case 2:
        Console.WriteLine("Opcion 2");
        break;
    case 3:
        Console.WriteLine("Opcion 3");
        break;
    default:
        Console.WriteLine("Opcion no valida");
        break;
}

Jugador j=new Jugador("Maria", 30);
Console.WriteLine(j);
j.Name="Javiera";
j.Edad=32;
System.Console.WriteLine(j);