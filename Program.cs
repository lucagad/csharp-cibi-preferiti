// See https://aka.ms/new-console-template for more information
using System;

//Esercizio di oggi sugli Array:
//Miei cibi preferiti
//Nome repo: csharp - cibi - preferiti
//Create un progetto App Console CibiPreferiti con VS2022. Nel programma inizializzate un array con la classifica dei vostri cibi preferiti (minimo 5, massimo 10 elementi). L’array deve essere già inizializzato nel programma, e i vostri cibi preferiti non vanno chiesti all’utente tramite input.
//Una volta dichiarato l’array di cibi preferiti, stampate a video le seguenti informazioni:
//La lunghezza della classifica
//La vostra classifica (dunque stampare l’intero array in ordine indicando la posizione in classifica)
//Il vostro cibo top (prima posizione della classifica)
//Il vostro cibo preferito ma non troppo (ultima posizione della classifica)
//Le modalità di consegna sono le solite: repo GitHub, commit e push
//BONUS Stampate a video anche il cibo di mezza classifica, cioè che si trova nella posizione mediana. Attenzione: gestire anche il caso se aveste una classifica con un numero di elementi pari. In questo caso vanno stampati i 2 elementi in centro alla vostra classifica.
//Buon pomeriggio e buon lavoro!


string[] CibiPreferiti = { "Pizza", "Lasegne", "Pasta allo Scoglio", "Ribs", "Tagliata di manzo" };

int LunghezzaClassifica = CibiPreferiti.Length;

Console.WriteLine("Benvenuti!");
Console.WriteLine("La classifica è formata da "+ LunghezzaClassifica + " Elementi.");

Console.WriteLine("------------------------------------------");

for (int i = 0; i < CibiPreferiti.Length; i++)
{
    Console.WriteLine( i+1 +"° Classificato: " + CibiPreferiti[i] );
}

Console.WriteLine("------------------------------------------");

Console.WriteLine("Il cibo preferito è: " + CibiPreferiti[0]);

Console.WriteLine("------------------------------------------");

Console.WriteLine("Il cibo ultimo in classifica è: " + CibiPreferiti[CibiPreferiti.Length - 1]);

