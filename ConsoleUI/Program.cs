using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Spectre.Console;

namespace ConsoleUI
{
    public class Program
    {
        static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            // Enter swtich for app options 
            try
            {

                //await MangaCaller.ChapterList(client, "801513ba-a712-498c-8f57-cae55b38cc92");
                // await MangaCaller.ReadManga(client, "da63389a-3d60-4634-8652-47a52e35eacc");

                var layout = new Layout("Root")
                .SplitRows(
                    new Layout("Search"),
                    new Layout("Bottom")
                    .SplitColumns(
                        new Layout("Left"),
                        new Layout("Right")));

                layout["Search"].MinimumSize(10);

                AnsiConsole.Write(layout);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
