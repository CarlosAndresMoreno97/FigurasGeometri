//Enunciado: Realizar un algoritmo con C# donde me permita calcular el perímetro/circunferencia
//y área de las siguientes figuras geométricas: cuadrado, rectángulo, triángulo y círculo. Mostrar
//en pantalla los valores calculados por cada figura geométrica.


public class FigurasGeometricas
{
    static void Main(string[] args)
    {
        double ladocuadra, alturacuadra, baserectan, alturarecta, basetriangequil, alturatriangu, radiocirculo,
            perimetrocuadra, areacuadra, perimetrorecta, araarectan, perimetrotriang, areatriang, perimetrocirculo,
            areacirculo;

        Console.Write("Ingresar el lado del cuadrado: ");
        ladocuadra = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresar altura del cuadrado: ");
        alturacuadra = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresar base del rectangulo: ");
        baserectan = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresar altura del rectangulo: ");
        alturarecta = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresar la base del trigulo equilatero: ");
        basetriangequil = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresar altura del triangulo equilatero: ");
        alturatriangu = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresar el radio del circulo: ");
        radiocirculo = Convert.ToDouble(Console.ReadLine());

        perimetrocuadra = ladocuadra * 4;
        areacuadra = ladocuadra * alturacuadra;
        perimetrorecta = (2 * baserectan) + (2 * alturarecta);
        araarectan = (baserectan * alturarecta);
        perimetrotriang = basetriangequil * 3;
        areatriang = (basetriangequil * alturatriangu) / 2;
        perimetrocirculo = 2 * 3.1416 * radiocirculo;
        areacirculo = 3.1416 * Math.Pow(radiocirculo, 2);

        Console.Write("El perimetro del cuadrado es: " + perimetrocuadra);
        Console.Write("\n");

        Console.Write("El area del cuadrado es: " + areacuadra);
        Console.Write("\n");

        Console.Write("El perimetro del rectangulo es: " + perimetrorecta);
        Console.Write("\n");

        Console.Write("El area del rectanglo es: " + araarectan);
        Console.Write("\n");

        Console.Write("El perimetro del triangulo es: " + perimetrotriang);
        Console.Write("\n");

        Console.Write("El area del triangulo es: " + areatriang);
        Console.Write("\n");

        Console.Write("El perimetro del circulo es: " + perimetrocirculo);
        Console.Write("\n");

        Console.Write("El area del circulo es: " + areacirculo);
        Console.Write("\n");

    }







}