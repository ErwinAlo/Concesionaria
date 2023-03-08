  namespace Concesionaria;
   
      public class Automovil{
        public string Placa;
        public string Marca;
        public string Modelo;

        public int Km = 0;
        public double Precio = 0;

        public override string ToString(){
         return $"Id: {Placa}"+ $"Marca: {Marca}" + $"Modelo: {Modelo}"+ "kM: {Km} "+ $"Precio: {Precio}";
       }

    }