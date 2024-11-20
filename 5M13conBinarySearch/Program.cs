namespace _5M13conBinarySearch
{
    /*
     * zadeklaruj w Main() tablicę N elementów typu int
     * w funkcji wypełnij ją wartosciami losowymi
     * z przedziału [0,M]
     * wypisz tablicę, posortuj i wypisz
     * napisz funkcję do wyszukiwania elementu w tablicy
     * 
     * funkcja ma mieć parametry: tablica i element do wyszukania
     * zwraca pozycję, na której jest element lub -1 gdy nei ma go
     * użyj wyszukiwania liniowego
     * 
     * napisz funkcję jak wyżej, ale wyszukującą algorytmem binary search
     *
     * przyjmij:
     * N = 100;
     * M = 5 * N;
     */
    internal class Program
    {
        private const int N = 100;
        private const int M = N * 1;
        static void Main(string[] args)
        {
            int[] liczby = new int[N];
            wypelnijTablice(liczby);
            wypiszTablice(liczby);
            Array.Sort(liczby);
            wypiszTablice(liczby);
            int szukana = 15;
            int poz = wyszukajLiniowo(liczby, szukana);
            if(poz != -1)
                Console.WriteLine($"liczba {szukana} jest na pozycji {poz}");
            else
                Console.WriteLine($"liczba {szukana} nie znajduje się w tablicy");

            poz = wyszukajBinarnie(liczby, szukana);
            if (poz != -1)
                Console.WriteLine($"liczba {szukana} jest na pozycji {poz}");
            else
                Console.WriteLine($"liczba {szukana} nie znajduje się w tablicy");


            Console.WriteLine("Hello, World!");
        }
        private static int wyszukajBinarnie(int[] tablice, int szukana)
        {
            int p = 0;
            int k = tablice.Length-1; //p i k to indeksy początku i końca 
            int sr;
            while(p <= k)
            {
                sr = (p+k)/2;
                if (tablice[sr] == szukana)
                    return sr;
                if (szukana < tablice[sr])
                    k = sr - 1;
                else
                    p = sr + 1;
            }
            return -1;
        }
        private static int wyszukajLiniowo(int[] tablica, int szukana)
        {
            for (int i = 0; i<tablica.Length; i++)
                if(tablica[i] == szukana)
                    return i;
            return -1;
        }
        private static void wypelnijTablice(int[] tablica)
        {
            Random r = new Random();
            for (int i = 0; i < tablica.Length; i++) 
                tablica[i] = r.Next(0,M+1);
        }
        private static void wypiszTablice(int[] tablica)
        {
            foreach (int i in tablica)
                Console.Write($"{i}; ");
            Console.WriteLine();
        }
    }
}
