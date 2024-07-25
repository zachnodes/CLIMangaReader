using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Spectre.Console;

namespace ConsoleUI
{
    public class View
    {
        static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            // Enter swtich for app options 
            try
            {

                AnsiConsole.Write(new Rule("[yellow]Search[/]"));

                var searchTerm = AnsiConsole.Prompt(
                    new TextPrompt<string>("Enter your search term:")
                        .ValidationErrorMessage("[red]That's not a valid search term[/]")
                        .Validate(term => !string.IsNullOrEmpty(term)));

                var results = await MangaCaller.SearchManga(client, searchTerm, 10);

                var mangaTitles = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("Select Title")
                        .PageSize(10)
                        .AddChoices(results));

                int idIndex = mangaTitles.IndexOf("Id: ") + "Id: ".Length;
                string id = mangaTitles.Substring(idIndex);
                var chapList = await MangaCaller.ChapterList(client, id.Trim());

                var chapters = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("Select Chapter")
                        .PageSize(10)
                        .AddChoices(chapList));

                int chapId = chapters.IndexOf("Id: ") + "Id: ".Length;
                string chapId2 = chapters.Substring(chapId);

                await MangaCaller.ReadManga(client, chapId2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
