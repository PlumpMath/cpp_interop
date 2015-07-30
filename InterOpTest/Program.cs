using System;
using System.Runtime.InteropServices;

/*
change the output of the c# project by 
Project Properties -> Build -> Output -> Output path: = '..\Debug\'
this is because c sharp builds in the bin folder instead of the local debug folder like c++
 */


namespace InterOpTest {

    class Program {


        [DllImport("DynamicLib.dll", CallingConvention = CallingConvention.Cdecl)] //this is also called "decorating" this is not in c++
        public static extern int multiply(int a, int b);


        //this doesn't work yet
        [DllImport("DynamicLib.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern string AMarvelousComputationHeavyMethod([MarshalAs(UnmanagedType.AnsiBStr)]string someLongString);

        static void Main(string[] args) {

            Console.WriteLine(multiply(10, 10));
            //todo: Console.WriteLine(AMarvelousComputationHeavyMethod("meah"));
            Console.ReadLine();
        }
    }
}
