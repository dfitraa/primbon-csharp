using System;

namespace Primbon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Neptu Hari Lahir\t\tNeptu Nama Hari Pasaran Jawa");
            Console.WriteLine("=======================================================");
            Console.WriteLine("Minggu \t= 5\t\t\tWage\t= 4");
            Console.WriteLine("Senin \t= 4\t\t\tKliwon\t= 8");
            Console.WriteLine("Selasa \t= 3\t\t\tLegi\t= 5");
            Console.WriteLine("Rabu \t= 7\t\t\tPahing\t= 9");
            Console.WriteLine("Kamis \t= 8\t\t\tPon\t= 7");
            Console.WriteLine("Jumat \t= 6");
            Console.WriteLine("Sabtu \t= 9");

            Console.Write("\n\nMasukkan Jumlah Neptu Pria: ");
            int input1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Masukkan Jumlah Neptu Wanita: ");
            int input2 = Convert.ToInt16(Console.ReadLine());
            int result = input1 + input2;

            int[] pegat = {1,9,17,25,33};
            int[] ratu = {2,10,18,26,34};
            int[] jodoh = {3,11,19,27,35};
            int[] topo = {4,12,20,28,36};
            int[] tinari = {5,13,21,29};
            int[] padu = {6,14,22,30};
            int[] sujanan = {7,15,23,31};
            int[] pesthi = {8,16,24,32};


            Console.Write("\n\n");
            for (int i = 0; i < pegat.Length; i++)
                if (result == pegat[i])
                {
                    Console.Write("Hasil Weton PEGAT");
                }

            for (int i = 0; i < ratu.Length; i++)
                if (result == ratu[i])
                {
                    Console.Write("Hasil Weton RATU");
                }

            for (int i = 0; i < jodoh.Length; i++)
                if (result == jodoh[i])
                {
                    Console.Write("Hasil Weton JODOH");
                }

            for (int i = 0; i < topo.Length; i++)
                if (result == topo[i])
                {
                    Console.Write("Hasil Weton TOPO");
                }

            for (int i = 0; i < tinari.Length; i++)
                if (result == tinari[i])
                {
                    Console.Write("Hasil Weton TINARI");
                }

            for (int i = 0; i < padu.Length; i++)
                if (result == padu[i])
                {
                    Console.Write("Hasil Weton PADU");
                }

            for (int i = 0; i < sujanan.Length; i++)
                if (result == sujanan[i])
                {
                    Console.Write("Hasil Weton SUJANAN");
                }

            for (int i = 0; i < pesthi.Length; i++)
                if (result == pesthi[i])
                {
                    Console.Write("Hasil Weton PESTHI");
                }
        }
    }
}
