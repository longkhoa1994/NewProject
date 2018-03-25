using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreationalPatterns
{
    public static class SingleTonClass
    {

        public static SingleTonClass Intance1()
        {
            return null;
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
            SingleTonClass.Intance();
            //SingleTonClass abc = new SingleTonClass();
            NonSingleTonClass asfklds = new NonSingleTonClass();
            asfklds.Nontaticmethod();
        }
    }
}
