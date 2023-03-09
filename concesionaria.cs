  namespace Concesionaria;
  
      public class concesionaria{

       public List<Automovil> lista;
       public int LimiteAuto;
       public int NumActual;

       public concesionaria(int LimiteAuto){

          lista = new List<Automovil>();
          this.LimiteAuto = LimiteAuto;
          this.NumActual = 0;
       }

       public void AgregarAuto( Automovil Auto){

           if( Auto != null && NumActual != LimiteAuto ){
            Automovil? autoencontrado = lista.Find((b)=>b.Placa==Auto.Placa);

              if(autoencontrado == null){
                        lista.Add(Auto);
                        NumActual ++;
              }
              
           }

       }
       public void MostrarAuto(string Placa){
            
            Automovil? Autoencontrado =lista.Find((auto)=>auto.Placa==Placa);
            if(Autoencontrado!=null){
               Console.WriteLine(NumActual.ToString());

            }
       }

       public void EliminarAuto(String Placa){

         if( Placa != " "&& NumActual != 0 ){

                Automovil? AutoEncontrado = lista.Find((Auto)=>Auto.Placa==Placa);
                if(AutoEncontrado!= null){
                   lista.Remove(AutoEncontrado);
                            NumActual--;  
                            
                 }
                           
         }

       }
   

       
       public void MostrarAutos(Automovil Auto){

         foreach(Automovil item in lista){
            Console.WriteLine(Auto);
         }

       }

       public void VaciarConcesionaria(Automovil Auto){

            
            lista.Clear();
            Console.WriteLine("No hay autos");

      }

   }  

      