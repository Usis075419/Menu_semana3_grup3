using System;

namespace semana3_estructuras_de_control
{
    class Program
    {
        static void Main(string[] args)
        {

            principal();

        }

        static void principal()
        {
            int repetir_menu;//console12345//
            System.Console.WriteLine("\nEstructuras de control en Visual C#");
            System.Console.WriteLine("1. Menú de opciones");
            System.Console.WriteLine("2. Salir");

            System.Console.WriteLine("Ingrese 1 para mostrar menú o 2 para salir. ");
            repetir_menu = Int32.Parse(Console.ReadLine());

            while (repetir_menu == 1)
            {
                opciones();
            }


        }


        static void opciones()
        {

            int opcion;

            System.Console.WriteLine("\nEjemplos de estructuras de control");
            System.Console.WriteLine("1- Mostrar los requisitos para instalar versiones de windows");
            System.Console.WriteLine("2- Mostrar programa de incio de sesion");
            System.Console.WriteLine("3- Mostrar programa de calculadora");
            System.Console.WriteLine("4- Mostrar programa de calcular promedio");

            System.Console.WriteLine("Ingrese la opción: ");
            opcion = Int32.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    programa1();
                    break;
                case 2:
                    programa2();
                    break;
                case 3:
                    programa3();
                    break;
                case 4:
                    programa4();
                    break;
                default:
                    System.Console.WriteLine("Opción equivocada");
                    break;
            }
            //System.Console.ReadKey();
            principal();

        }

        static void programa1()
        {
            System.Console.WriteLine("\nVersiones de Windows");
            System.Console.WriteLine("Windows 7");
            System.Console.WriteLine("Procesador de 1 gigahercio ghz " +
                                     "o más rápido de 32 bits x86 o de 64 bits x64" +
                                     "1 GB de RAM 32 bits o 2 GB de RAM x64" +
                                     "16 GB de espacio disponible en el disco duro x32 bits 20 GB x64 bits" +
                                     "Tarjeta gráfica DirectX 9 con controlador WDDM 1.0 o superior.");
            System.Console.WriteLine("Windows 8");
            System.Console.WriteLine("Procesador Intel® Celeron® 847, 1,10 GHz o superior" +
                "Tarjeta gráfica: Dispositivo gráfico Directx 9 con controlador WDDM de 1.0 o mayor." +
                "Procesador de 1GHz o de mayor velocidad" +
                "Tarjeta gráfica: Dispositivo gráfico Directx 9 con controlador WDDM de 1.0 o mayor." +
                "Memoria RAM: 1GB (32 - bit) o 2GB (64 - bit)" +
                "Espacio de disco duro: 16GB (32 bits) o 20GB (64 bits).");
            System.Console.WriteLine("Windows 10");
            System.Console.WriteLine("Procesador a 1 GHz o más rápido o sistema en un chip (SoC)" +
                "1 GB para 32 bits o 2 GB para 64 bits" +
                "16 GB para SO de 32 bits; 32 GB para SO de 64 bits" +
                "DirectX 9 o posterior con controlador WDDM 1.0" +
                "Resolucio 800x600");
            System.Console.WriteLine("Windows 11");
            System.Console.WriteLine("Procesador: 1 giga Hertz (GHz) o más rápido con 2 o más núcleos en un procesador de 64 bits compatible o sistema en un chip (SoC)" +
                "RAM: 4 gigabyte (GB)" +
                "Almacenamiento: Dispositivo de almacenamiento de 64 GB o más" +
                "Tarjeta gráfica: Compatible con DirectX 12 o posterior con controlador WDDM 2.0" +
                "Pantalla: Pantalla de alta definición (720p) de más de 9″ en diagonal, con canal de 8 bits por color");



        }

        static void programa2()
        {
            System.Console.WriteLine("\nPrograma de inicio de sesion");
            //programa que pide un usuario y contraseña Basicamente un programa de inicio de sesion.

            string nom, contra;
            Console.WriteLine("Ingrese su codigo de usuario: ");
            nom = Console.ReadLine();


            while (nom != "SMIS133220")
            {

                Console.WriteLine("\nUsuario incorrecto");
                Console.WriteLine("\nIngrese de nuevo el usuario");
                nom = Console.ReadLine();

            }
            Console.WriteLine("\nIngrese su contraseña: ");
            contra = Console.ReadLine();


            while (contra != "UsulutanUGB")
            {
                Console.WriteLine("\nContraseña incorrecta");
                Console.WriteLine("\nIngrese de nuevo su contraseña");
                contra = Console.ReadLine();


            }

            Console.WriteLine("\nUsuario y contraseña correctos.");

            if (nom == "SMIS133220" && contra == "UsulutanUGB")
            {
                Console.WriteLine("\nBienvenido, usuario " + nom);
            }


        }

        static void programa3()
        {
            System.Console.WriteLine("\nPrograma de calculadora");
            char opcion;
            string continuar;
            double sumar;
            double restar;
            double multiplicar;
            double dividir;

            do
            {
                Console.WriteLine("|*************************************************|");
                Console.WriteLine("|*                                               *|");
                Console.WriteLine("|*       1.-Suma dos numeros (A + B)             *|");
                Console.WriteLine("|*       2.-reste dos numeros (A - B)            *|");
                Console.WriteLine("|*       3.-Multiplique dos numeros (A * B)      *|");
                Console.WriteLine("|*       4.-Divida dos numeros (A / B)           *|");
                Console.WriteLine("|*       5.-Todas las Operaciones                *|");
                Console.WriteLine("|*                                               *|");
                Console.WriteLine("|*       0.-salir                                *|");
                Console.WriteLine("|*                                               *|");
                Console.WriteLine("|*                                               *|");
                Console.Write("\n");
                Console.Write("Dime una opcion:   ");

                do
                {
                    opcion = Console.ReadKey(true).KeyChar;
                }
                while (opcion < '0' || opcion > '5');
                switch (opcion)
                {
                    case '0':
                        {
                            opciones();
                        }
                        break;
                    case '1':
                        {
                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("--------------------");

                            Console.Write("ingrese el numero (A):");
                            double numeroA = double.Parse(Console.ReadLine());

                            Console.Write("ingrese el numero (B):");
                            double numeroB = double.Parse(Console.ReadLine());

                            Console.WriteLine("------------------------");
                            sumar = (numeroA + numeroB);
                            Console.WriteLine("El resultado de la suma es:" + sumar);

                        }
                        break;
                    case '2':
                        {
                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("--------------------");

                            Console.Write("ingrese el numero (A):");
                            double numeroA = double.Parse(Console.ReadLine());

                            Console.Write("ingrese el numero (B):");
                            double numeroB = double.Parse(Console.ReadLine());

                            Console.WriteLine("------------------------");
                            restar = (numeroA - numeroB);
                            Console.WriteLine("El resultado de la resta es:" + restar);

                        }
                        break;
                    case '3':

                        {
                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("--------------------");

                            Console.Write("ingrese el numero (A):");
                            double numeroA = double.Parse(Console.ReadLine());

                            Console.Write("ingrese el numero (B):");
                            double numeroB = double.Parse(Console.ReadLine());

                            Console.WriteLine("------------------------");
                            multiplicar = (numeroA * numeroB);
                            Console.WriteLine("El resultado de la Multiplicacion es:" + multiplicar);

                        }

                        break;
                    case '4':

                        {
                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("--------------------");

                            Console.Write("ingrese el numero (A):");
                            double numeroA = double.Parse(Console.ReadLine());

                            Console.Write("ingrese el numero (B):");
                            double numeroB = double.Parse(Console.ReadLine());

                            Console.WriteLine("------------------------");
                            dividir = (numeroA / numeroB);
                            Console.WriteLine("El resultado de la division es:" + dividir);

                        }

                        break;

                    case '5':

                        {

                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("--------------------");

                            Console.Write("ingrese el numero (A):");
                            double numeroA = double.Parse(Console.ReadLine());

                            Console.Write("ingrese el numero (B):");
                            double numeroB = double.Parse(Console.ReadLine());

                            Console.WriteLine("------------------------");
                            sumar = (numeroA + numeroB);
                            restar = (numeroA - numeroB);
                            multiplicar = (numeroA * numeroB);
                            dividir = (numeroA / numeroB);

                            Console.WriteLine("El resultado de la suma es           :" + sumar);
                            Console.WriteLine("El resultado de la resta es          :" + restar);
                            Console.WriteLine("El resultado de la Multiplicacion es :" + multiplicar);
                            Console.WriteLine("El resultado de la division es       :" + dividir);

                        }
                        break;
                }
                Console.WriteLine("*********************************");
                Console.Write("¿deseas continuar? Si/No");
                continuar = Console.ReadLine();
                Console.WriteLine("\n");
                Console.Clear();
            }
            while (continuar != "n");

        }

        static void programa4()
        {
            System.Console.WriteLine("\nPrograma de calcular promedio");
            //Programa que calcula el promedio de 3 numeros
            //Variables
            double n1 = 0.0;
            double n2 = 0.0;
            double n3 = 0.0;
            double Promedio = 0.0;
            String dato = "";

            Console.WriteLine("Dame un numero");
            dato = Console.ReadLine();
            n1 = Convert.ToDouble(dato);

            Console.WriteLine("Dame el siguiente numero");
            dato = Console.ReadLine();
            n2 = Convert.ToDouble(dato);

            Console.WriteLine("otro numero por favor");
            dato = Console.ReadLine();
            n3 = Convert.ToDouble(dato);

            Promedio = (n1 + n2 + n3) / 3.0;

            Console.WriteLine("El Promedio es {0}", Promedio);

            if (Promedio >= 6)
            {
                Console.WriteLine("Has aprobado");
            }
            else
            {
                Console.WriteLine("Has reprobado");
            }
        }

    }
}