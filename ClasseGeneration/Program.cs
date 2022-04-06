/* -------------------------------------------- ESERCIZIO ----------------------------------
Un po' come ragionato questa mattina con la rimessa Auto, l'idea è quella di immaginare un programma che gestisca una vostra classe
di alunni dove voi siete il professore/professoressa del corso e volete tenere traccia dei vostri iscritti e avere qualche informazione
e statistica sulla classe. In particolare voi volete tenere traccia dei:
nomi
cognomi
eta
numero di partecipanti attuali nel corso
dei vostri alunni.
La classe all'inizio sarà vuota, ma sapete che avrete al massimo 10 sedie, ossia 10 posti nell'aula, pertanto come ragionato questa mattina pensate bene 
all'inizializzazione delle vostre variabili globali.
A questo punto avete bisogno di delle funzioni per gestire al meglio la vostra classe, e le funzioni sono ad esempio le seguenti 
(non vi indico che cosa devono restituire, se devono restituire qualcosa, e di che parametri di input hanno bisogno, pensateci):
stampaCognomeAlunni: vi permette di stampare tutti i cognomi dei vostri alunni
stampaNomiAlunni: vi permette di stampare i nomi dei vostri alunni
stampaEtaAlunni: vi permette di stampare l'età dei vostri alunni (riciclate stampaArray() :faccia_leggermente_sorridente: ).
aggiungiAlunno: che vi permette di aggiungere un alunno alla vostra classe (nome, cognome ed età);
rimuoviUltimoAlunno: che vi "toglie" l'ultimo alunno della classe, ossia "sbianca" gli array nell'ultimo posto occupato.
Definite queste funzioni di base, usatele per compilare la vostra ipotetica classe di alunni, provando ad aggiungere e rimuovere alunni al bisogno 
e stampando di volta in volta i risultati delle vostre operazioni sulla classe. Chiedete all'utente come fatto questa mattina per la rimessa auto,
se vuole aggiungere o rimuovere un alunno dalla classe e mostrategli ciò che succede.
A questo punto volete avere delle statistiche sulla vostra classe, pertanto vi si chiede di fornire tramite funzioni le seguenti cose:
una funzione calcolaEtaMediaClasse che vi restituisca l'età media della classe.
una funzione EtaPiuGiovane che vi restituisce l'età dell'alunno più giovane in classe.
una funzione EtàPiuVecchio che vi restituisce l'età dell'alunno più vecchio.
Testate le vostre funzioni di statistiche, per esempio aggiungendo l'opzione "statistiche" per l'utente, che una volta scritto a console "statistiche"
vi stampi i risultati delle funzioni appena dichiarate. */


//------------------------- PROGRAMMA PRINCIPALE --------------------------------

//Numero massimo di studenti in aula
int quantitàStudenti = 10;

//DICHIARAZIONE DEGLI ARRAY COME VARIABILI GLOBALI
string[] nomi = new string[quantitàStudenti];
string[] cognomi = new string[quantitàStudenti];
int[] età = new int[quantitàStudenti];



//---------------------- FINE PROGRAMMA PRINCIPALE ------------------------------

//--------------------------------- FUNZIONI ------------------------------------

//stampa i cognomi degli alunni
void stampaCognomeAlunni(string[] cognome)
{
    for (int i = 0; i < cognome.Length; i++)
    {
        Console.WriteLine("Cognome del " + i + "° alunno: " + cognome[i]);
    }
}

//stampa i nomi degli alunni
void stampanomiAlunni(string[] nome)
{
    for (int i = 0; i < nome.Length; i++)
    {
        Console.WriteLine("nome del " + i + "° alunno: " + nome[i]);
    }
}

//stampa le età degli alunni
void stampaEtaAlunni(string[] eta)
{
    for (int i = 0; i < eta.Length; i++)
    {
        Console.WriteLine("età del " + i + "° alunno: " + eta[i]);
    }
}
//------------------------------- FINE FUNZIONI ---------------------------------