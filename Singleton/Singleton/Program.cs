using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSingleton<DoubleCheckAndLock>();
            TestSingleton<StaticInstance>();
            TestSingleton<NestedStaticInstance>();
            TestSingleton<UsingLazy>();

            //Just to stop the console
            Console.ReadLine();
        }       

        static void TestSingleton<T>()
        {
            var taskList = new List<Task<T>>
            {
                new Task<T>(() => {return (T)typeof(T).GetMethod("GetInstance").Invoke(null, null); }),
                new Task<T>(() => {return (T)typeof(T).GetMethod("GetInstance").Invoke(null, null); }),
                new Task<T>(() => {return (T)typeof(T).GetMethod("GetInstance").Invoke(null, null); }),
                new Task<T>(() => {return (T)typeof(T).GetMethod("GetInstance").Invoke(null, null); }),
                new Task<T>(() => {return (T)typeof(T).GetMethod("GetInstance").Invoke(null, null); }),
                new Task<T>(() => {return (T)typeof(T).GetMethod("GetInstance").Invoke(null, null); }),
                new Task<T>(() => {return (T)typeof(T).GetMethod("GetInstance").Invoke(null, null); }),
                new Task<T>(() => {return (T)typeof(T).GetMethod("GetInstance").Invoke(null, null); }),
                new Task<T>(() => {return (T)typeof(T).GetMethod("GetInstance").Invoke(null, null); }),
                new Task<T>(() => {return (T)typeof(T).GetMethod("GetInstance").Invoke(null, null); })
            };

            Parallel.ForEach(taskList, task => task.Start());
            Task.WaitAll(taskList.ToArray());

            if (taskList.All(task =>  EqualityComparer<T>.Default.Equals(task.Result, taskList.First().Result)))
            {
                Console.WriteLine("{0} implemnetation passed", typeof(T).FullName);
            }
            else
            {
                Console.WriteLine("{0} implementation failed", typeof(T).FullName);
            }
        }
    }
}
