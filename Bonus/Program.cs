/* -------------------------------------------- ESERCIZIO ----------------------------------
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

//variabile Flag per smettere di aggiungere/togliere studenti dal registro
bool chiudiRegistro = true;

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

void rimuoviUltimoAlunno()
{
    nomi[alunniPresenti] = "";
    cognomi[alunniPresenti] = "";
    età[alunniPresenti] = 0;
    Console.WriteLine("Ultimo alunno in lista Rimosso");
    alunniPresenti--;
}

//funzione che gestisce il registro di classe aggiungendo o rimuovendo gli studenti
void ApriChiudiRegistro()
{
    while (chiudiRegistro)
    {
        Console.WriteLine("Scegli se Aggiungere, Rimuovere un alunno o chiudere il registro: [aggiungi/rimuovi/chiudi]");
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
                    rimuoviUltimoAlunno();
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
//------------------------------- FINE FUNZIONI ---------------------------------