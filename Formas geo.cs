

using System;
using System.Collection.Generic; 
using System.Ling;
using System.Text;
using System.Threading.Tasks;

namespace Fig
{
    class Prog
    {
        static void Main(string[] args)
        {
            System.Double Pi = 3.1415926535897931;
            int a,b, area, nume;
            string si;
            console.WriteLine("Eliga una figura geometrica");
            Console.WriteLine("1. Circulo");
            Console.WriteLine("2. Rectangulo");
            Console.WriteLine("3. Triangulo");
            Console.WriteLine("4. Salir");
            nume = Convert.ToInt32(Console.ReadLine());
            Console.writeLine("Introduzca la base");
            b= Convert.ToInt32(Console.Readline());
            Console.Writeline("Introduzca el lado");
            a= Convert.ToInt32(console.ReadLine());
            switch (nume)
            {
                case 1:
                    area = Pi*b*a;
                    Console.WriteLine("El area del circulo es: "+area);
                    break;
                case 2:
                    area = b*a;
                    Console.WriteLine("El area del rectangulo es: "+area);
                    break;
                case 3:
                    area = b*a/2;
                    Console.WriteLine("El area del triangulo es: "+area);
                    break;
            }
            Consolr.WriteLine("¿Quiere volver a iniciar?");
            si = Console.ReadLine(); 
        }
        
    }
    
}