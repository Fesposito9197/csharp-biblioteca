using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Environment;



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
    public override string ToString()
    {
        return $"codice: {codiceIdentificativo}" + NewLine
             + $"titolo: {titolo}" + NewLine
             + $"anno: {anno}" + NewLine
             + $"settore: {settore}" + NewLine
             + $"scaffale: {scaffale}" + NewLine
             + $"autore: {autore}";
                
    }

    public string getCodiceIdentificativo()
    {
        return this.codiceIdentificativo;
    }


    public string getTitolo()
    {
        return this.titolo;
    }

    public int getAnno()
    {
        return this.anno;
    }

    public string getSettore()
    {
        return this.settore;
    }

    public string getScaffale()
    {
        return this.scaffale;
    }
    public string getAutore() 
    {
        return this.autore;
    }
}
public class Libri : Documenti
{
    int numeroPagine;

    public Libri(string codiceIdentificativo, string titolo, int anno, string settore, string scaffale, string autore, int numeroPagine) : base(codiceIdentificativo, titolo, anno, settore, scaffale, autore)
    {
        this.numeroPagine = numeroPagine;
    }

    public int getNumeroPagine()
    {
        return this.numeroPagine;
    }

    public override string ToString()
    {
        return base.ToString() + NewLine
            + $"numero pagine: {numeroPagine}";
    }

}

public class Dvd : Documenti
{
    int durata;

    public Dvd(string codiceIdentificativo, string titolo, int anno, string settore, string scaffale, string autore, int durata) : base(codiceIdentificativo, titolo, anno, settore, scaffale, autore)
    {
        this.durata = durata;
    }

    public int getDurata() 
    {
        return this.durata;
    }

    public override string ToString()
    {
        return base.ToString() + NewLine
              + $"durate: {durata}";
    }
}

