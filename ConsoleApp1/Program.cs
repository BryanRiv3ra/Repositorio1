int numeroEntero = 65;
char caracter = Convert.ToChar(numeroEntero);
Console.WriteLine("El numero entero " + numeroEntero + " es equivalente al caracter: " + caracter);

int entero = 5;
decimal valordecimal = entero;
Console.WriteLine("El numero entero " + entero + " es equivalente al decimal: " + valordecimal);

float numeroFloat = 3.14f;
int valorentero = (int)numeroFloat;
Console.WriteLine("El dato float " + numeroFloat + " es equivalente al entero: " + valorentero);

char letra = 'A';
int valorNumerico = (int)letra; 
Console.WriteLine("El valor eqivalente de " + letra + " a valor numerico es " + valorNumerico);

decimal numeroDecimal = 3.1416m;
float numeroFlotante = (float)numeroDecimal;
Console.WriteLine("El valor " + numeroDecimal + " su equivalente en tipo float es " + numeroFlotante);
