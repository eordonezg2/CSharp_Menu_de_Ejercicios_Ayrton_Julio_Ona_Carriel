using System;
class Program
{
    static void Main()
    {
        ///Algoritmo en donde se pide la edad del usuario; si es mayor de edad debeaparecer un mensaje indicándolo.


        string Ejercicio_1()
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 >= 18)
            {

                return "El usuario es mayor de edad";
            }
            else
            {
                return "El usuario es menor de edad";
            }
        }
        //Construir un algoritmo tal, que dado como dato la calificación de un alumno en unexamen, escriba
        //“APROBADO” en caso que esa calificación fuese mayor que 8. Obs.: el alumno aprueba si la calificación es mayor a 8
        string Ejercicio_2()
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 > 8)
            {
                return "APROBADO";
            }
            else
            {
                return "REPROBADO";
            }
        }
        string Ejercicio_3()
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                return "El mayor es " + num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                return "El mayor es " + num2;
            }
            else
            {
                return "El mayor es " + num3;
            }
        }
        string Ejercicio_4()
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 == 0)
            {
                return "El numero ingresado es neutro";
            }
            else if (num1 > 0)
            {
                return "El numero es (+)Positivo";
            }
            else
            {
                return "El numero es (-)Negativo";
            }

        }
        string Ejercicio_5()
        {
            int dia = Convert.ToInt32(Console.ReadLine());
            if (dia == 1)
            {
                return "LUNES";
            }
            else if (dia == 2)
            {
                return "MARTES";
            }
            else if (dia == 3)
            {
                return "MIERCOLES";
            }
            else if (dia == 4)
            {
                return "JUEVES";
            }
            else if (dia == 5)
            {
                return "VIERNES";
            }
            else if (dia == 6)
            {
                return "SABADO";
            }
            else if (dia == 7)
            {
                return "DOMINGO";
            }
            else
            {
                return "No corresponde a un dia de la semana";
            }

        }
        //Realizar un programa que permita introducir un número por teclado y no devuelva como resultadoa que día de la semana corresponde
        string Ejercicio_6()
        {
            int contador = 1;
            int suma = 0;
            while (contador <= 100)
            {
                if (contador % 2 != 0)
                {
                    suma = suma + contador;
                }
                contador = contador + 1;
            }
            return "La suma de los numeros impares del 1 al 100 es: " + suma;
        }
        string Ejercicio_7()
        {
            int suma = 0;
            int ingresado = 0;
            while (ingresado >= 0)
            {
                suma += ingresado;
                Console.WriteLine("ingrese numero: ");
                ingresado = int.Parse(Console.ReadLine());
            }
            return "la suma es: " + suma;
        }
        string Ejercicio_8()
        {
            int inicial = 0;
            int final = 0;
            int suma = 0;
            Console.WriteLine("ingrese un numero inicial: ");
            inicial = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un numero final: ");
            final = int.Parse(Console.ReadLine());
            while (inicial <= final)
            {
                if (inicial % 2 == 0)
                {
                    suma = suma + inicial;
                }
                inicial = inicial + 1;
            }
            return "La suma de los pares entre el rango de numeros es: " + suma;
        }
        string Ejercicio_9()
        {
            int inicial = 0;
            int final = 0;
            int producto = 1;
            Console.WriteLine("ingrese un numero inicial: ");
            inicial = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un numero final: ");
            final = int.Parse(Console.ReadLine());
            for (int i = inicial; i <= final; i++)
            {
                if (i % 5 == 0)
                {
                    producto = producto * i;
                }
            }
            return "El producto ded multiplo de 5 del rango es: " + producto;
        }
        string Ejercicio_10()
        {
            Console.WriteLine("Ingrese la frase: ");
            string frase = Console.ReadLine().ToLower();
            int longitud = frase.Length;
            int contador = 0;
            for (int i = 0; i < longitud; i++)
            {
                if (frase[i] == 'a')
                {
                    contador = contador + 1;
                }
            }
            return "La cantidad de a encontradas es: " + contador;
        }
        string Ejercicio_11()
        {
            Console.WriteLine("[Elias, Ayrton, Adriana, Melany, David]");
            Console.WriteLine("Ingresa el nombre a buscar ");
            string[] listaNombres = { "Elias", "Ayrton", "Adriana", "Melany", "David" };
            int indicador = -1;
            string nombre = Console.ReadLine().ToLower();
            for (int i = 0; i < listaNombres.Length; i++)
            {
                if (nombre == listaNombres[i].ToLower())
                {
                    indicador = i;
                    break;
                }
            }
            if (indicador == -1)
            {
                return "El nombre no se encontro ";
            }
            else
            {
                return "El nombre se encuentra en la posicion" + indicador;
            }
        }
        string Ejercicio_12()
        {
            Console.WriteLine("Bienvenido al juego de piedra papel o tijera");
            Console.WriteLine("Ingresa 1 para piedra, 2 para papel y 3 para tijera");
            int jugador = int.Parse(Console.ReadLine());

            Random random = new Random();
            int maquina = random.Next(1, 4);
            string maquinaStr = "";

            if (maquina == 1)
            {
                maquinaStr = "La maquina escogio piedra";
            }
            else if (maquina == 2)
            {
                maquinaStr = "La maquina escogio papel";
            }
            else if (maquina == 3)
            {
                maquinaStr = "La maquina escogio tijera";
            }


            if (jugador == maquina)
            {
                return maquinaStr + "(EMPATE)";
            }
            else if (jugador == 2 && maquina == 1)
            {
                return maquinaStr + "(GANASTE)";
            }
            else if (jugador == 3 && maquina == 2)
            {
                return maquinaStr + "(GANASTE)";
            }
            else if (jugador == 1 && maquina == 3)
            {
                return maquinaStr + "(GANASTE)";
            }
            else
            {
                return maquinaStr + "(PERDISTE)";
            }


        }
        string Ejercicio_13()
        {
            Console.WriteLine("Ingrese la frase: ");
            string frase = Console.ReadLine().ToLower();
            int longitud = frase.Length;
            int contador = 0;
            for (int i = 0; i < longitud; i++)
            {
                if (frase[i] == 'a' || frase[i] == 'e' || frase[i] == 'i' || frase[i] == 'o' || frase[i] == 'u')
                {
                    contador = contador + 1;
                }
            }
            return "La cantidad de vocales es: " + contador;
        }

        string Ejercicio_14()
        {
            Console.WriteLine("2,5,19,7,12,9,46");
            int[] listaNumeros ={
            2,5,19,7,12,9,46
        };
            int contadorPares = 0;
            int contadorImpares = 0;
            for (int i = 0; i < listaNumeros.Length; i++)
            {
                if (listaNumeros[i] % 2 == 0)
                {
                    contadorPares++;
                }
                else
                {
                    contadorImpares++;
                }
            }
            return "La cantidad de numeros pares es: " + contadorPares + "\n" + " La cantidad de numeros pares es: " + contadorImpares;
        }
        string Ejercicio_15()
        {
            Console.WriteLine("Ingresa un numero");
            int numeroIngresado = int.Parse(Console.ReadLine());
            int contador = 1;
            int producto = 1;
            while (contador <= numeroIngresado)
            {
                producto *= contador;
                contador++;
            }
            return "El factorial de " + numeroIngresado + " es: " + producto;
        }
        bool i = true;
        while (i)
        {
            Console.WriteLine("1. Identificar mayor de edad");
            Console.WriteLine("2. Verificar APROBADO ");
            Console.WriteLine("3. Mayor de tres numeros");
            Console.WriteLine("4. Verificar positivo o negativo");
            Console.WriteLine("5. Dia de la semana");
            Console.WriteLine("6. Suma de numeros impares del 1 al 100 ");
            Console.WriteLine("7. Suma de numeros positivos hasta ingresar uno negativo");
            Console.WriteLine("8. Suma de pares en un rango de numeros");
            Console.WriteLine("9. Producto de multiplo de 5 de un rango de numero");
            Console.WriteLine("10. Cuantas a hay en una frase");
            Console.WriteLine("11. El nombre se encuentra en la posicion");
            Console.WriteLine("12. Juego de piedra, papel y tijera ");
            Console.WriteLine("13. Contar Vocales");
            Console.WriteLine("14. Contar pares e impares");
            Console.WriteLine("15. Factorial de un numero");
            Console.WriteLine("Seleccione una opcion:");
            int opcion = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingresa Tu edad");
                    Console.WriteLine(Ejercicio_1());
                    Thread.Sleep(5000);
                    Console.Clear();
                    break;
                case 2:
                    Console.WriteLine("Ingrese su calificacion");
                    Console.WriteLine(Ejercicio_2());
                    Thread.Sleep(5000);
                    Console.Clear();
                    break;
                case 3:
                    Console.WriteLine("Ingrese tres numeros");
                    Console.WriteLine(Ejercicio_3());
                    Thread.Sleep(5000);
                    Console.Clear();
                    break;
                case 4:
                    Console.WriteLine("Ingrese un numero");
                    Console.WriteLine(Ejercicio_4());
                    Thread.Sleep(5000);
                    Console.Clear();
                    break;
                case 5:
                    Console.WriteLine("Ingrese un numero");
                    Console.WriteLine(Ejercicio_5());
                    Thread.Sleep(5000);
                    Console.Clear();
                    break;
                case 6:
                    Console.WriteLine(Ejercicio_6());
                    Thread.Sleep(5000);
                    Console.Clear();
                    break;
                case 7:
                    Console.WriteLine(Ejercicio_7());
                    Thread.Sleep(5000);
                    Console.Clear();
                    break;
                case 8:
                    Console.WriteLine(Ejercicio_8());
                    Thread.Sleep(5000);
                    Console.Clear();
                    break;
                case 9:
                    Console.WriteLine(Ejercicio_9());
                    Thread.Sleep(5000);
                    Console.Clear();
                    break;
                case 10:
                    Console.WriteLine(Ejercicio_10());
                    Thread.Sleep(5000);
                    Console.Clear();
                    break;
                case 11:
                    Console.WriteLine(Ejercicio_11());
                    Thread.Sleep(5000);
                    Console.Clear();
                    break;
                case 12:
                    Console.WriteLine("");
                    Console.WriteLine(Ejercicio_12());
                    Thread.Sleep(5000);
                    Console.Clear();
                    break;
                case 13:
                    Console.WriteLine("");
                    Console.WriteLine(Ejercicio_13());
                    Thread.Sleep(5000);
                    Console.Clear();
                    break;
                case 14:
                    Console.WriteLine("");
                    Console.WriteLine(Ejercicio_14());
                    Thread.Sleep(5000);
                    Console.Clear();
                    break;
                case 15:
                    Console.WriteLine("");
                    Console.WriteLine(Ejercicio_15());
                    Thread.Sleep(5000);
                    Console.Clear();
                    break;
                case 16:
                    Console.WriteLine("selecciono la opcion 16 salir");
                    Thread.Sleep(5000);
                    Console.Clear();
                    i = false;
                    break;
            }

        }

    }
}