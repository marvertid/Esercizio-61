/* Scrivere un programma che conti il numero di vocali inserite in una casella di testo multiriga. Allo
scopo, agire sulla propriet� booleana Multiline della textBox; impostare, inoltre, la propriet�
ScrollBars su Vertical per visualizzare la barra di scorrimento verticale. Il conteggio pu� essere
effettuato in fase di digitazione gestendo l�evento TextChanged, generato quando il valore della
propriet� Text del controllo viene modificato.
MARVERTI DIEGO 4AI*/
namespace Esercizio_22
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Esercizio22());
        }
    }
}