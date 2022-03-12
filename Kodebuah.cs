class Program
{
    static void Main(string[] args)
    {
        KodeBuah table_Kodebuah = new KodeBuah();
        Console.WriteLine("========= MEMANGGIL KODE BUAH =========");
        Console.WriteLine("Masukan Kode BUAH: ");
        string buah = Console.ReadLine();
        Console.WriteLine("========= OUTPUT ========= ");
        table_Kodebuah.getKodeBuah(buah);
        Console.WriteLine("==== JAWABAN NO 3 C ====");
        table_Kodebuah.getAllKodeBuah();
    }

}

class KodeBuah
{
    Dictionary<string, string > dic = new Dictionary<string, string>()
    {
            {"Apel", "A00"},
            {"Aprikot" ,"B00"},
            {"Aplukat","C00"},
            {"Pisang","D00"},
            {"Paprika","E00"},
            {"Blackberry","F00"},
            {"Ceri","H0"},
            {"Kelapa","I00"},
            {"Jagung","J00"},
            {"Kurma","K00"},
            {"Durian","L00"},
            {"Anggur","M00"},
            {"Melon","N00"},
            {"Semangka","O00"}
    };

    public void getKodeBuah(string fruit)
    {
        if (dic.ContainsKey(fruit))
        {
            Console.WriteLine(fruit + " : " + dic[fruit]);
        }
        else
        {
            Console.WriteLine(fruit + " tidak ditemukan");
        }
    }

    public void getAllKodeBuah()
    {
        foreach (KeyValuePair<string, string> elel in dic)
        {
            Console.WriteLine("{0} \t {1}", elel.Key, elel.Value);
        }
    }
  
}