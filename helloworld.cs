using System;
class HolaMundo{

    static int suma(int a, int b){
        return a + b;
    }

    static int resta(int a, int b){
        return a - b;
    }

    static void Main(){
        int a = 0, b = 0;
        int op = 0;

        do{

            Console.WriteLine("Que desea hacer: 1.Sumar 2.Restar" );
            op = Int32.Parse(Console.ReadLine());

            switch (op){
                case 1:
                    a = Int32.Parse(Console.ReadLine());
                    b = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(suma(a, b));
                    break;
                case 2:
                    a = Int32.Parse(Console.ReadLine());
                    b = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(resta(a, b));
                    break;
            }

        }while(true);
    }
}

/*
**Using es el equivalente a import
**Main con m mayúscula
*/