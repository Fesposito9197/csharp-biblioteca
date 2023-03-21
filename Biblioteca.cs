using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Biblioteca
{
}

public class Utenti
{
    string cognome;
    string nome;
    string email;
    string password;
    int recapitoTelefonico;

    public Utenti(string cognome, string nome, string email, string password, int recapitoTelefonico)
    {
        this.cognome = cognome;
        this.nome = nome;
        this.email = email;
        this.password = password;
        this.recapitoTelefonico = recapitoTelefonico;
    }
}

public class Documenti
{
    string codiceIdentificativo;
    string titolo;
    int anno;
    string settore;
    string scaffale;
    string autore;

    public Documenti(string codiceIdentificativo, string titolo, int anno, string settore, string scaffale, string autore)
    {
        this.codiceIdentificativo = codiceIdentificativo;
        this.titolo = titolo;
        this.anno = anno;
        this.settore = settore;
        this.scaffale = scaffale;
        this.autore = autore;
    }
}

public class Libri : Documenti
{
    int numeroPagine;

    public Libri(string codiceIdentificativo, string titolo, int anno, string settore, string scaffale, string autore, int numeroPagine) : base(codiceIdentificativo, titolo, anno, settore, scaffale, autore)
    {
        this.numeroPagine = numeroPagine;
    }
}

public class Dvd : Documenti
{
    int durata;

    public Dvd(string codiceIdentificativo, string titolo, int anno, string settore, string scaffale, string autore, int durata) : base(codiceIdentificativo, titolo, anno, settore, scaffale, autore)
    {
        this.durata = durata;
    }
}

