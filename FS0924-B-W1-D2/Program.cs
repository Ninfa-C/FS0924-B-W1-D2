using FS0924_B_W1_D2;
using FS0924_B_W1_D2.Models;

Persona persona = new("Mario", "Rossi", 35);

Console.WriteLine("Nome: " + persona.GetNome());
Console.WriteLine("Cognome: " + persona.GetCognome());
Console.WriteLine("Età: " + persona.GetEta());
Console.WriteLine("Dettagli: " + persona.GetDettagli());

