using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS0924_B_W1_D2.Models
{
    public class Persona
    {
        public string? Nome { get; set; }
        public string? Cognome { get; set; }
        public int Età { get; set; }

        public Persona(string nome, string cognome, int età)
        {
            Nome = nome;
            Cognome = cognome;
            Età = età;
        }

        // metodi GetNome, GetCognome, GetEta e GetDettagli che restituisca in una stringa le informazioni sulla persona in questione.
        public string GetNome()
        {
            return Nome;
        }

        public string GetCognome()
        {
            return Cognome;
        }

        public int GetEta()
        {
            return Età;
        }

        public string GetDettagli()
        {
            return $"Nome: {Nome}, Cognome: {Cognome}, Età: {Età}";
        }

    }
}
