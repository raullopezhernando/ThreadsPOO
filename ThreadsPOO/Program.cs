using System;
using System.Collections;
using System.Threading;

namespace ThreadsPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tareas Object1 = new Tareas("Hilo_1",8);
            //Tareas Object2 = new Tareas("Hilo_2", 16);

            //// Ejecutamos los metodos sobre neustros hilos
            //Thread hilo1 = new Thread(Object1.Tarea1);
            //Thread hilo2 = new Thread(Object2.Tarea2);
            ////Comienzo de los hilos
            //hilo1.Start();
            //hilo2.Start();

            ArrayList listTareas = new ArrayList();
            listTareas.Add("Hilo1");
            listTareas.Add("Hilo2");
            listTareas.Add("Hilo3");

            ArrayList listSecond = new ArrayList();
            listSecond.Add(8);
            listSecond.Add(16);
            listSecond.Add(24);

            for (int i = 0; i < listTareas.Count; i++) 
            {
                object tarea = listTareas[i];
                string tareas = Convert.ToString(tarea);
                object secs = listSecond[i];
                int sec = Convert.ToInt32(secs);
                Tareas Obj1 = new Tareas(tareas, sec);
                Obj1.Tarea1();
            
            }
        }
    }
}
