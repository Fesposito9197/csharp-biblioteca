


using static System.Reflection.Metadata.BlobBuilder;

var user = new Utenti("esposito", "Francesco", "kekkoesp8@gmail.com", "12345678", 34203096);
var libri = new List<Libri>();
var dvds = new List<Dvd>();

Libri libro1 = new Libri("ISBN123", "Il Signore degli Anelli", 1954, "Fantasy", "S1", "J.R.R. Tolkien", 1178);
Libri libro2 = new Libri("ISBN456", "Harry Potter e la Pietra Filosofale", 1997, "Fantasy", "S2", "J.K. Rowling", 223);
Libri libro3 = new Libri("ISBN789", "1984", 1949, "Fiction", "S3", "George Orwell", 328);
Libri libro4 = new Libri("ISBN012", "Il Nome della Rosa", 1980, "Fiction", "S4", "Umberto Eco", 512);
Libri libro5 = new Libri("ISBN345", "Cronache del ghiaccio e del fuoco", 1996, "Fantasy", "S5", "George R.R. Martin", 694);

Dvd dvd1 = new Dvd("DVD001", "Pirati dei Caraibi: La Maledizione della Prima Luna", 2003, "Avventura", "S1", "Gore Verbinski", 143);
Dvd dvd2 = new Dvd("DVD002", "The Shawshank Redemption", 1994, "Drammatico", "S2", "Frank Darabont", 142);
Dvd dvd3 = new Dvd("DVD003", "Inception", 2010, "Fantascienza", "S3", "Christopher Nolan", 148);
Dvd dvd4 = new Dvd("DVD004", "Il Padrino", 1972, "Drammatico", "S4", "Francis Ford Coppola", 175);
Dvd dvd5 = new Dvd("DVD005", "La La Land", 2016, "Musicale", "S5", "Damien Chazelle", 128);

libri.Add(libro1);
libri.Add(libro2);
libri.Add(libro3);
libri.Add(libro4);
libri.Add(libro5);

dvds.Add(dvd1);
dvds.Add(dvd2);
dvds.Add(dvd3);
dvds.Add(dvd4);
dvds.Add(dvd5);


while (true)
{
    Console.WriteLine("Vuoi cercare per titolo o per codice documento?");
    var userInput = Console.ReadLine();

    string userTitle = "";
    string userCode = "";

    if (userInput == "titolo")
    {
        Console.WriteLine("Inserisci il titolo");
        userTitle = Console.ReadLine();
    }
    else if (userInput == "codice")
    {
        Console.WriteLine("Inserisci il codice");
        userCode = Console.ReadLine();
    }

    switch (userInput)
    {
        case "titolo":

            Console.WriteLine("Articoli trovati: ");
            Console.WriteLine();

            foreach (var libro in libri)
            {
                if (libro.getTitolo().ToLower() == userTitle)
                {
                    Console.WriteLine();
                    Console.WriteLine(libro);
                    Console.WriteLine();
                    break;
                }
            }

            foreach (var dvd in dvds)
            {
                if (dvd.getTitolo().ToLower() == userTitle)
                {
                    Console.WriteLine();
                    Console.WriteLine(dvd);
                    Console.WriteLine();
                    break;
                }
            }

            break;

        case "codice":

            Console.WriteLine("Articoli trovati: ");
            Console.WriteLine();

            foreach (var libro in libri)
            {

                if (libro.getCodiceIdentificativo() == userCode)
                {
                    Console.WriteLine();
                    Console.WriteLine(libro);
                    Console.WriteLine();
                    break;
                }
            }

            foreach (var dvd in dvds)
            {

                if (dvd.getTitolo() == userCode)
                {
                    Console.WriteLine();
                    Console.WriteLine(dvd);
                    Console.WriteLine();
                    break;
                }
            }

            break;
    }
};
