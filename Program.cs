using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Ejemplo de una lista
        List<int> numeros = new List<int>();
        numeros.Add(10);
        numeros.Add(20);
        numeros.Add(30);
        Console.WriteLine("Elementos de la lista:");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
        Console.WriteLine();

        // Ejemplo de un diccionario
        Dictionary<string, int> estudiantes = new Dictionary<string, int>();
        estudiantes.Add("Juan", 18);
        estudiantes.Add("María", 20);
        estudiantes.Add("Carlos", 19);
        Console.WriteLine("Información de los estudiantes:");
        foreach (KeyValuePair<string, int> estudiante in estudiantes)
        {
            string nombre = estudiante.Key;
            int edad = estudiante.Value;
            Console.WriteLine(nombre + ": " + edad);
        }
        Console.WriteLine();

        // Ejemplo de una cola
        Queue<string> mensajes = new Queue<string>();
        mensajes.Enqueue("Mensaje 1");
        mensajes.Enqueue("Mensaje 2");
        mensajes.Enqueue("Mensaje 3");
        Console.WriteLine("Elementos de la cola:");
        while (mensajes.Count > 0)
        {
            string mensaje = mensajes.Dequeue();
            Console.WriteLine(mensaje);
        }
        Console.WriteLine();

        // Ejemplo de una pila
        Stack<int> numerosPila = new Stack<int>();
        numerosPila.Push(10);
        numerosPila.Push(20);
        numerosPila.Push(30);
        Console.WriteLine("Elementos de la pila:");
        while (numerosPila.Count > 0)
        {
            int numero = numerosPila.Pop();
            Console.WriteLine(numero);
        }
        Console.WriteLine();

        // Ejemplo de un arreglo
        int[] arreglo = { 10, 20, 30 };
        Console.WriteLine("Elementos del arreglo:");
        for (int i = 0; i < arreglo.Length; i++)
        {
            Console.WriteLine(arreglo[i]);
        }
    }
}
