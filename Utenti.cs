﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Environment;



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

    public override string ToString()
    {
        return $"nome utente: {nome}" + NewLine
              +$"cognome utente: {cognome}";
    }

    public string getCognome()
    {
        return this.cognome;
    }

  
    public string getNome()
    {
        return this.nome;
    }
   
    public string getEmail()
    {
        return this.email;
    }

    public string getPassword()
    {
        return this.password;
    }

    public int getRecapitoTelefonico()
    {
        return this.recapitoTelefonico;
    }
   
}


