/* -------------------------------------------- ESERCIZIO ----------------------------------
 BONUS: Per chi se la sente chiedo anche di definire 2 ulteriori funzioni chiamate StudentePiuGiovane e StudentePiuVecchio che vi stampa il nome,
il cognome e l'età dello studente più giovane e vecchio rispettivamente una volta che l'utente sceglie come opzione "statistiche".
*/




//------------------------- PROGRAMMA PRINCIPALE --------------------------------

//Numero massimo di studenti in aula
int quantitàStudenti = 10;
int alunniPresenti = 0;
string sceltaUtente;

//DICHIARAZIONE DEGLI ARRAY COME VARIABILI GLOBALI
string[] nomi = new string[quantitàStudenti];
string[] cognomi = new string[quantitàStudenti];
int[] età = new int[quantitàStudenti];

Console.WriteLine("----------------- Registro di Classe -----------------");
ApriChiudiRegistro();

Console.WriteLine("vuoi stampare la lista degli alunni in classe? [si/no]");
sceltaUtente = (Console.ReadLine());
sceltaUtente = sceltaUtente.ToLower();
switch (sceltaUtente)
{
    case "si":
        stampaCognomeAlunni(cognomi);
        stampanomiAlunni(nomi);
        stampaEtaAlunni(età);
        break;
    case "no":
        Console.WriteLine("Ok, grazie di aver utilizzato il nostro servizio di registro classe");
        break;
    default:
        Console.WriteLine("Comando errato, reinserire un nuovo imput");
        break;
}

Console.WriteLine("vuoi apportare altre modifiche ?");
sceltaUtente = (Console.ReadLine());
sceltaUtente = sceltaUtente.ToLower();
switch (sceltaUtente)
{
    case "si":
        ApriChiudiRegistro();
        break;
    case "no":
        Console.WriteLine("Ok, grazie di aver utilizzato il nostro servizio di registro classe");
        break;
    default:
        Console.WriteLine("Comando errato, reinserire un nuovo imput");
        break;
}

Console.WriteLine("\nl'età media degli studenti è: " + calcolaEtaMediaClasse(età));
Console.WriteLine("lo studente più giovane è: " + EtaPiuGiovane(età));
Console.WriteLine("lo studente più vecchio è: " + EtaPiuVecchio(età));


//---------------------- FINE PROGRAMMA PRINCIPALE ------------------------------


//--------------------------------- FUNZIONI ------------------------------------

//stampa i cognomi degli alunni
void stampaCognomeAlunni(string[] cognome)
{
    Console.WriteLine();
    Console.WriteLine("Cognomi di tutti gli studenti della classe presenti in aula: ");
    for (int i = 0; i < cognome.Length; i++)
    {
        Console.WriteLine("Cognome del " + (i + 1) + "° alunno: " + cognome[i]);
    }
}

//stampa i nomi degli alunni
void stampanomiAlunni(string[] nome)
{
    Console.WriteLine();
    Console.WriteLine("Nomi di tutti gli studenti della classe presenti in aula: ");
    for (int i = 0; i < nome.Length; i++)
    {
        Console.WriteLine("nome del " + (i + 1) + "° alunno: " + nome[i]);
    }
}

//stampa le età degli alunni
void stampaEtaAlunni(int[] eta)
{
    Console.WriteLine();
    Console.WriteLine("età di tutti gli studenti della classe presenti in aula: ");
    for (int i = 0; i < eta.Length; i++)
    {
        Console.WriteLine("età del " + (i + 1) + "° alunno: " + eta[i]);
    }
}


//aggiunge il nome dell'alunno alla classe
void aggiungiNomeAlunno()
{
    Console.WriteLine("Inserisci il nome del " + (alunniPresenti + 1) + "° studente: ");
    nomi[alunniPresenti] = Console.ReadLine();
}

//aggiunge il cognome dell'alunno alla classe
void aggiungiCognomeAlunno()
{
    Console.WriteLine("Inserisci il cognome del " + (alunniPresenti + 1) + "° studente: ");
    cognomi[alunniPresenti] = Console.ReadLine();
}

//aggiunge l'età dell'alunno alla classe
void aggiungietàAlunno()
{
    Console.WriteLine("Inserisci l'età del " + (alunniPresenti + 1) + "° studente: ");
    età[alunniPresenti] = int.Parse(Console.ReadLine());
}

//aggiunge un alunno alla classe
void aggiungiAlunno()
{
    aggiungiNomeAlunno();
    aggiungiCognomeAlunno();
    aggiungietàAlunno();
    alunniPresenti++;
}

//Rimuove l'ultimo alunno
void rimuoviUltimoAlunno(string[] nomeAlunno, string[] cognomeAlunno, int[] etàAlunno)
{
    nomeAlunno[alunniPresenti - 1] = "";
    cognomeAlunno[alunniPresenti - 1] = "";
    etàAlunno[alunniPresenti - 1] = 0;
    Console.WriteLine("Ultimo alunno in lista Rimosso");
    alunniPresenti--;
}

//funzione che gestisce il registro di classe aggiungendo o rimuovendo gli studenti
void ApriChiudiRegistro()
{
    //variabile Flag per smettere di aggiungere/togliere studenti dal registro
    bool chiudiRegistro = true;
    while (chiudiRegistro)
    {
        Console.WriteLine("\nScegli se Aggiungere, Rimuovere un alunno o chiudere il registro: [aggiungi/rimuovi/chiudi]");
        sceltaUtente = (Console.ReadLine());
        sceltaUtente = sceltaUtente.ToLower();
        if (alunniPresenti <= quantitàStudenti)
        {
            switch (sceltaUtente)
            {
                case "aggiungi":
                    aggiungiAlunno();
                    break;
                case "rimuovi":
                    rimuoviUltimoAlunno(nomi, cognomi, età);
                    break;
                case "chiudi":
                    chiudiRegistro = false;
                    break;
                default:
                    Console.WriteLine("Comando errato, reinserire un nuovo imput");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Mi dispiace, non possiamo più aggiungere studenti");
        }
    }
}

//somma gli elementi di un array
int Somma(int[] num)
{
    int somma = 0;
    for (int i = 0; i < num.Length; i++)
    {
        somma = somma + num[i];
    }
    return somma;
}

//calcola l'Eta Media della Classe
int calcolaEtaMediaClasse(int[] etaStudenti)
{
    int media = Somma(etaStudenti) / alunniPresenti;
    return media;
}

int EtaPiuGiovane(int[] etaStudenti)
{
    int piùGiovane = etaStudenti[0];
    for (int i = 0; i < etaStudenti.Length; i++)
    {
        if (piùGiovane > etaStudenti[i] && etaStudenti[i] != 0)
        {
            piùGiovane = etaStudenti[i];
        }
    }
    return piùGiovane;
}

int EtaPiuVecchio(int[] etaStudenti)
{
    int piùVecchio = etaStudenti[0];
    for (int i = 0; i < etaStudenti.Length; i++)
    {
        if (piùVecchio < etaStudenti[i])
        {
            piùVecchio = etaStudenti[i];
        }
    }
    return piùVecchio;
}
//------------------------------- FINE FUNZIONI ---------------------------------