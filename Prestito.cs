using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Environment;

public class Prestito
{

    public Documenti Documenti { get; set; }

    public Utenti Utenti { get; set; }

    public DateTime DataInizio { get; set; }

    public DateTime DataFine { get;set; }
    public Prestito(Documenti documenti, Utenti utenti, DateTime dataInizio, DateTime dataFine)
    {
        Documenti = documenti;
        Utenti = utenti;
        DataInizio = dataInizio;
        DataFine = dataFine;
    }

    public override string ToString()
    {
        return $"{Documenti}" + NewLine
             + $"{Utenti}" + NewLine
             + $"inzio prestito:{DataInizio}" + NewLine
             + $"fine prestito: {DataFine}";
    }
}

