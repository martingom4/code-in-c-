// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Console.WriteLine("Manda tu nombre");

//int numero_1= int.Parse(Console.ReadLine());

//int Numero_1 = int.Parse(Console.ReadLine());


//Console.WriteLine(numero_1);

//Console.WriteLine(Numero_1);

//int max = int.MaxValue;
//    Console.WriteLine(max);
//DateTime nombre= new DateTime( 2332, 33,23 );

//Console.WriteLine(nombre);

using C_2;

int addnumbers(int a, int b, int c )
{
    c = 100;
    int sum = a + b + c;
    return sum;
}


//Console.WriteLine(addnumbers(1, 2,2 ));


//Console.WriteLine(Utilities.Hola(1,2));

//string a = Console.ReadLine();

string texto = "alha";
texto = texto.ToUpper();
char[] array = texto.ToCharArray();
Array.Reverse(array);
string textoInvertido = new(array);
Console.WriteLine(textoInvertido);


textoInvertido= textoInvertido.ToUpper();
Console.WriteLine(textoInvertido);
bool x = textoInvertido.Contains(texto);
Console.WriteLine(x);
