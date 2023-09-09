using System.Collections;

internal class Program
{
    public static void Main(string[] args)
    {
        //System.Collections namespace

        ArrayList liste= new ArrayList();
        liste.Add("kopek");    //string
        liste.Add(37);         //int
        liste.Add(true);       //boolean
        liste.Add('$');        //char

        //Icerisindeki verilere erisim
        Console.WriteLine(liste[1]);//index numarasi ile

        foreach (var item in liste)//foreach ile
        {
            Console.WriteLine(item);
        }

        //AddRange
        Console.WriteLine("ADD RANGE");
        string[] renkler={"mor","pembe","sari","yesil"};
        List <int> sayilar =new List<int>(){1,8,6,93,45,21,34};
        liste.AddRange(renkler);
        liste.AddRange(sayilar);

        foreach (var item in liste)
        {
           Console.WriteLine(item); 
        }

        //Sort
        Console.WriteLine("SORT");//int tipinde siralama yapar
        ArrayList liste1=new ArrayList();
        liste1.AddRange(sayilar);
        liste1.Sort();
        foreach (var item in liste1)
        {
            Console.WriteLine(item);
        }

        //Binary Search
        Console.WriteLine("BINARY SEARCH");
        Console.WriteLine(liste1.BinarySearch(21));//21 sayisinin index'ini getirir

        //Reverse
        Console.WriteLine("REVERSE");
        liste1.Reverse();

        foreach (var item in liste1)
        {
            Console.WriteLine(item);
        }

        //Clear
        Console.WriteLine("CLEAR");
        liste.Clear();

        foreach (var item in liste)
        {
           Console.WriteLine(item); 
        }
    }
}