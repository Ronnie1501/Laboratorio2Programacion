using Laboratorio2Progra.DAO;
using Laboratorio2Progra.Models;

CrudNota CrudNota = new CrudNota();
Nota Nota = new Nota();

bool continuar = true;
while (continuar)
{
    Console.WriteLine("Calculador de notas");
    Console.WriteLine("***************************************");
    Console.WriteLine("1 Para calcular sus notas");
    Console.WriteLine("2 Para listar sus notas");

    var Menu = Convert.ToInt32(Console.ReadLine());
    switch(Menu)
    {
        case 1:
            Console.WriteLine("Ingrese el nombre de la materia");
            Nota.Materia = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del Estudiante ");
            Nota.NombreEstudiante = Console.ReadLine();
            Console.WriteLine("Ingrese la nota del laboratorio 1 ");
            Nota.Lab1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del Parcial 1 ");
            Nota.Parcial1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del laboratorio 2 ");
            Nota.Lab2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del Parcial 2 ");
            Nota.Parcial2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del laboratorio 3 ");
            Nota.Lab3 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del Parcial 3 ");
            Nota.Parcial3 = Convert.ToDecimal(Console.ReadLine());
            CrudNota.CalcularResultado(Nota);
            CrudNota.AgregarNota(Nota);
            Console.WriteLine($"El resultado es...  {Nota.Resultado}");
            Console.WriteLine("Las notas han sido guardadas.");

            break;

        case 2:
            Console.WriteLine("Lista de Notas");
            var ListarNotas = CrudNota.ListarNotas();
            foreach (var iteracionNota in ListarNotas)
            {
                Console.WriteLine($"ID: {iteracionNota.IdNotas},Nombre de la Materia: {iteracionNota.Materia},Nombre del Alumno:{iteracionNota.NombreEstudiante},lab 1:{iteracionNota.Lab1},parcial 2:{iteracionNota.Parcial1},lab 2: {iteracionNota.Lab2},parcial 2: {iteracionNota.Parcial2},lab 3:{iteracionNota.Lab3},parcial 3:{iteracionNota.Parcial3},Nota final: {iteracionNota.Resultado}");
            }
            break;

    }
    Console.WriteLine("¿Quiere continuar? S para si y N para No");
    var cont = Console.ReadLine();
    if (cont.Equals("N"))
    {
        continuar = false;
    }
}


