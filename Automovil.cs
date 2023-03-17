  namespace Concesionaria;
   
      public class Automovil{

        public string? Placa;
        // public int MyProperty { get; set; }
        public string? Marca;
        public string? Modelo;

        public int? Km = 0;
        public double? Precio = 0;

    public Automovil(string? placa, string? marca, string? modelo, int? km, double? precio)
    {
        Placa = placa;
        Marca = marca;
        Modelo = modelo;
        Km = km;
        Precio = precio;
    }

    public override string ToString(){
         return $" Placa: {this.Placa}"+ $" Marca: {this.Marca}" + $" Modelo: {this.Modelo}"+ $" Km: {this.Km} "+ $" Precio: {this.Precio}";
       }

    }