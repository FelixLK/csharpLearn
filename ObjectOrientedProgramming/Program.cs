namespace ObjectOrientedProgramming;

internal class Program
{
    private static void Main()
    {
        // b)
        var human = new Mensch
        {
            sVorname = "Felix",
            sNachname = "Kreuzberger",
            sHaarfrabe = "Dunkel-Blond",
            iAlter = 23
        };
    }
}

// a)
internal class Mensch
{
    // c)
    internal Mensch()
    {
        Console.WriteLine("Used default constructor.");

        sVorname = "unbekannt";
        sNachname = "unbekannt";
        sHaarfrabe = "unbekannt";
        iAlter = -1;
    }

    // d)
    internal Mensch(string sVorname, string sNachname, string sHaarfrabe, int iAlter)
    {
        this.sVorname = sVorname;
        this.sNachname = sNachname;
        this.sHaarfrabe = sHaarfrabe;
        this.iAlter = iAlter;
    }
    public string sVorname { get; set; }
    public string sNachname { get; set; }
    public string sHaarfrabe { get; set; }
    public int iAlter { get; set; }

    // e)
    internal void SichSelbstVorstellen()
    {
        Console.WriteLine(string.Join(",", sVorname, sNachname, sHaarfrabe, iAlter));
    }
}