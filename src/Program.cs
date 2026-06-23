//
using System.Reflection;

var asembly = Assembly.GetExecutingAssembly();
var version = asembly.GetName().Version;

Console.WriteLine("                         ");
Console.WriteLine("|| Sistema de gestión de Inventario ||");
Console.WriteLine();
Console.WriteLine($"Versión 1.0.0");
Console.WriteLine($"Plataforma: {Environment.OSVersion}");
Console.WriteLine($".NET Versión: {Environment.Version}");
Console.WriteLine();
Console.WriteLine("Estado: Proyecto Inicializado");
Console.WriteLine($" Version: {version}");
