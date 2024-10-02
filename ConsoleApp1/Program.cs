// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;
using System.Reflection.PortableExecutable;

class program { 
     private static void Main(string[] arg){

        Alarme a1 = new Alarme();
        Alarme a2 = new Alarme();
        laptp t2 = new Laptp(1);
        Machine m1 = new Machine();
        m1.OnTempersup90 += a2.sonner;
        m1.OnTempersup90 += a2.sonner;
        m1.OnTempersup90 += t2.sonner;
        Machine.Alarme.Add(a1);
        Machine.Alarme.Add(a2);
        Console.ReadLine();


    }


}