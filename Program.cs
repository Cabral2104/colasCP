using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colasCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una cola de enteros
            Queue<int> cola = new Queue<int>(); //Queue<T> es una colección genérica que implementa una cola.

            // Agregar elementos a la cola
            cola.Enqueue(1);
            cola.Enqueue(2);
            cola.Enqueue(3);

            // Imprimir el contenido de la cola
            Console.WriteLine("Contenido de la cola:");
            foreach (int elemento in cola)
            {
                Console.WriteLine(elemento);
            }

            // Verificar si la cola está vacía
            if (cola.Count == 0)
            {
                Console.WriteLine("La cola está vacía.");
            }
            else
            {
                Console.WriteLine("La cola NO está vacía.");
            }

            // Eliminar elementos de la cola
            int elementoEliminado = cola.Dequeue();
            Console.WriteLine($"Elemento eliminado de la cola: {elementoEliminado}");

            // Verificar el elemento en la parte frontal de la cola (sin eliminarlo)
            int elementoEnFrente = cola.Peek();
            Console.WriteLine($"Elemento en la parte frontal de la cola: {elementoEnFrente}");

            // Verificar el tamaño actual de la cola
            Console.WriteLine($"Tamaño actual de la cola: {cola.Count}");

            // Limpiar la cola (quitar todos los elementos)
            cola.Clear();

            // Verificar si la cola está vacía después de limpiarla
            if (cola.Count == 0)
            {
                Console.WriteLine("La cola está vacía después de limpiarla.");
            }
           
            Console.ReadKey();
        }
    }
}
