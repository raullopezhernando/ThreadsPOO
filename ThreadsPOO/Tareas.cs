using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ThreadsPOO
{
    public class Tareas
    {
        private String name;
        private int second;

        // Constructor
        public Tareas(String name, int second) 
        {
            this.name = name;
            this.second = second; 
        
        }

        public void Tarea1() 
        {
            Console.WriteLine(name + "Esta tarea solo tendra" + second + "segundos.");
            Thread.Sleep(second * 1000); //Thread.Sleep. Suspende el subproceso actual durante un periodo de tiempo especificado.
            Console.WriteLine("Tarea terminada " + name);

        }

        public void Tarea2()
        {
            Console.WriteLine(name + "Esta tarea solo tendra" + second + "segundos.");
            Thread.Sleep(second * 1000); //Thread.Sleep. Suspende el subproceso actual durante un periodo de tiempo especificado.
            Console.WriteLine("Tarea terminada " + name);

        }

    }
}
