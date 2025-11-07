using Spectre.Console;
using SuperApp.Core;
AnsiConsole.MarkupLine("[bold green]🚀 Starting SuperApp...[/]");
var name = AnsiConsole.Ask<string>("What is your name?");
var message = Greeter.Greet(name);
AnsiConsole.MarkupLine($"[yellow]{message}[/]");