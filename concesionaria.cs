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

           if( NumActual < LimiteAuto ){

              lista.Add(Auto);
              NumActual ++;
              
           }else{

              Console.WriteLine(" No hay espacio ");

           }

       }
       public void MostrarAuto(Automovil Auto){
         
            if( Auto != null ){

                foreach(Automovil item in lista){

                      if( item == Auto ){
                            Console.WriteLine(item);
                            return;
                      }
                   
                }
                Console.WriteLine("No se encontro el auto");

            }

       }
       public void EliminarAuto(Automovil Auto){

         if( NumActual != 0 ){

                foreach(Automovil item in lista){

                      if(item == Auto){
                            lista.Remove(item);
                            NumActual --;  
                            return;  
                      }

                }

            }else{
               Console.WriteLine("Esta vacio");
            }

       }
       public void MostrarAutos(Automovil Auto){

         foreach(Automovil item in lista){
            Console.WriteLine(item);
         }

       }
       public void VaciarConcesionaria(Automovil Auto){

            foreach(Automovil item in lista){
            lista.Clear();
            Console.WriteLine("No hay autos");

         }

       }

      } 