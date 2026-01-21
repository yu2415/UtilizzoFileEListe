using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoFileEListe
{
    public class Utente
    {
        string nome { get; set; }
        string cognome { get; set; }
        int numeroDiMatricola { get; set; }

        // costruttore completo
        public Utente(string nome, string cognome, int numeroDiMatricola)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.numeroDiMatricola = numeroDiMatricola;
        }

        // Utente visuallizzato a schermo
        public override string ToString()
        {
            return $"Nome: {nome}, Cognome: {cognome}, Numero di Matricola: {numeroDiMatricola}";
        }
    }
}

