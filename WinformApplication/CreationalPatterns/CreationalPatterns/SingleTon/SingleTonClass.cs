using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreationalPatterns
{
    public class Singleton
    {
        private static Singleton instance;

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
    public class NonSingleTonClass
    {
        public void Nontaticmethod()
        {
        
        }
        public static void Nontaticmethod1()
        {
        
        }

    }

    public class Test
    {
        public void Tests()
        {
            NonSingleTonClass.Nontaticmethod1();
            //SingleTonClass.Intance();
            //SingleTonClass abc = new SingleTonClass();
            NonSingleTonClass asfklds = new NonSingleTonClass();
            asfklds.Nontaticmethod();
        }
    }
}
