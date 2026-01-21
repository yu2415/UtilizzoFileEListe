using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UsoFileEListe
{
    public class Password
    {
        string nomeUtente { get; set; }
        int matricolaUtente { get; set; }
        string inserimentoPassword { get; set; }

        // costruttore completo
        public Password(string nomeUtente, int matricolaUtente, string inserimentoPassword)
        {
            this.nomeUtente = nomeUtente;
            this.matricolaUtente = matricolaUtente; 
            this.inserimentoPassword = inserimentoPassword;
        }

        // costruttore vuoto
        public Password() { }


        // costruttore per la deserializzazione
        public Password(string inserimentoPassword)
        {
            this.inserimentoPassword = inserimentoPassword;
        }

        public override string ToString() // riga che verrà visualizzata a schermo
        {
            return $"Nome Utente: {nomeUtente}, Matricola Utente: {matricolaUtente}, Password: {inserimentoPassword}";
        }


        public string RigaFile() //riga che verrà visualizzata nel file
        {
            return $"SECRET_{inserimentoPassword}";
        }

        // deserializzazione della riga del file e creazione dell'oggetto password
        public static  Password Deserializza(string rigaDelFile)
        {
            var parti = rigaDelFile.Split("_");
            return new Password(parti[1]);
        }
    }
}
