using System;

namespace Credito_residuo_bancomat
{
    class Program
    {
        static void Main(string[] args)
        {
            double totacquisti = 0, credito, acquistidafare, importo;
            Console.Write("Inserisci il credito residuo sul tuo bancomat: ");
            credito = double.Parse(Console.ReadLine());
            Console.Write("Inserisci il numero degli acquisti che vuoi fare: ");
            acquistidafare = double.Parse(Console.ReadLine());
            if (credito > 0)
            {
                while(totacquisti < acquistidafare)
                {
                    Console.WriteLine("Inserisci l'importo dell'acquisto che vuoi fare: ");
                    importo = double.Parse(Console.ReadLine());
                    if(importo > credito)
                    {
                        Console.WriteLine("Non puoi eseguire questa transizione perchè non hai abbastanza soldi");
                        break;
                    }
                    else
                    {
                        credito = credito - importo;
                        totacquisti++;
                        Console.WriteLine($"Il tuo credito dopo questo è di {credito} euro");
                    }
                }
                Console.WriteLine($"Hai eseguito {totacquisti} acquisto/i e il tuo saldo finale è di {credito} ");
            }
            else
            {
                Console.WriteLine("Non puoi eseguire nessun acquisto perchè il tuo credito residuo è 0");
            }
            
        }
    }
}

