namespace UsoFileEListe
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Benvenuto nel sistema di gestione dipendenti!");
            Console.WriteLine("1. Visualizza liste password");
            Console.WriteLine("2. Accedi dipendente");
            Console.WriteLine("3. Inserimento nuovo dipendente");
            
            int scelta = int.Parse(Console.ReadLine());
            switch (scelta)
            {
                case 1:
                    break;
                case 2:

                    break;


            }

        }
        
    }
}


/*
 
dipendente
{
- nome 
- cognome
- numero di matricola
}
Program
{
- funzione registraPasswordRete()
- nuovo dipendente()
- cancella dipendente()
- ricerca dipendente()
- visualizzaDati()

- Serializza()
- Deserializza()
}



 
 
 */
