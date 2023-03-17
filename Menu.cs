namespace Concesionaria;

     class Menu{

    concesionaria concesionaria1 = new concesionaria(10);

     public bool ShowMenu(){

          Console.WriteLine("\nSeleccione una opcion");

          Console.WriteLine("(1) Agregar Automovil ");
          Console.WriteLine("(2) Eliminar Automovil ");
          Console.WriteLine("(3) Buscar Automovil");
          Console.WriteLine("(4) Listar todos ");
          Console.WriteLine("(5) Vaciar");
          Console.WriteLine("(6) Salir \n");
          Console.Write(" Opcion: ");

          switch(Console.ReadLine()){

            case "1":
               Console.WriteLine("Agregar auto");
               AgregarAuto();
               Console.ReadLine();
            return true;

            case "2":
               Console.WriteLine("Eliminar auto");
               
               EliminaAuto();
               Console.ReadLine();
               
            return true;

            case "3":
               Console.WriteLine("Buscar auto");
               
               BuscaAuto();
               Console.ReadLine();
               
            return true;

            case "4":
               Console.WriteLine(" Listar auto ");
               
               ListaAuto();
               Console.ReadLine();
               
            return true;

            case "5":
               Console.WriteLine(" Vaciar consecionaria ");
               VaciaConcesionaria();
               Console.ReadLine();
               
            return true;

            case "6":
               return false;
            default:
            return true;
          }
     }

     public void AgregarAuto(){

           Console.Clear();

           Console.WriteLine("Se esta creando un nuevo automovil...");
          
           Console.Write("Placa: ");
           string? Placa = Console.ReadLine();

           Console.Write("Marca: ");
           string? Marca = Console.ReadLine();

           Console.Write("Modelo: ");
           string? Modelo = Console.ReadLine();

           Console.Write("Km: ");
           string? Km = Console.ReadLine();

           Console.Write("Precio: ");
           string? Precio = Console.ReadLine();

           Automovil nuevo = new Automovil (

             Placa,
             Marca,
             Modelo,
             Convert.ToInt32(Km),
             Convert.ToDouble(Precio)

           );

           concesionaria1.AgregarAuto(nuevo);
           Console.WriteLine("Automovil agregado corectamente");
    }

    public void EliminaAuto(){
         Console.Clear();
         Console.WriteLine("Ingrese la placa:");
         string? Placa = Console.ReadLine();
         concesionaria1.EliminarAuto(Placa);
         Console.WriteLine("Automovil eliminado corectamente");
       
     
    }
    public void BuscaAuto(){
         Console.Clear();
         Console.WriteLine("Ingrese la placa:");
         string? Placa = Console.ReadLine();
         concesionaria1.MostrarAuto(Placa);

               
     
    }
    public void ListaAuto(){
 
         Console.Clear();
         concesionaria1.MostrarAutos();
  

    }

    public void VaciaConcesionaria(){
         Console.Clear();
         concesionaria1.VaciarConcesionaria();

    }
} 