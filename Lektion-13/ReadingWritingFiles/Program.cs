namespace ReadingWritingFiles;

class Program
{
    static void Main()
    {
        var path = Environment.CurrentDirectory + "/data/log.txt";
        Console.WriteLine(path);

        // Text som ska skrivas till filen...
        /* 
         var message = "Info added again " + DateTime.Now.ToShortDateString();
         */

        // Skriv texten till filen...
        /* 
        File.WriteAllText(path, message);
        */

        // Läs innehållet ifrån filen...
        /* 
        var text = File.ReadAllText(path);
        Console.WriteLine(text);
        */

        // Här använder vi StreamWriter klassen.
        // För att skriva till en fil...
        using StreamWriter sw = new(path);
        var message = "Info added " + DateTime.Now;
        sw.WriteLine(message);

        message = "Info added again" + DateTime.Now;
        sw.WriteLine(message);

        sw.Close();
        // Vi använder StreamReader klassen för att läsa in en fil.
        using StreamReader sr = new(path);
        var text = sr.ReadToEnd();
        Console.WriteLine(text);
        sr.Close();
    }
}
