var input = "y";

while (input == "y")
{
    Console.Clear();

    Console.WriteLine("Escriba su nombre:");

    string name = Console.ReadLine();

    Console.WriteLine($"Hola {name}!");
    Console.WriteLine("Desea continuar? Y/N");

    input = Console.ReadLine();
}

 if (input.ToUpper() == "N")
{
    Console.WriteLine("Programa finalizado correctamente.");
}
else
{
    Console.WriteLine("Opcion no valida.");
}




