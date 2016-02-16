using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;


namespace Proyecto2
{
  public   class ClassControl
    {

     
      public string nom { set; get; }

      public ClassControl(){

        
      
      }
      public void CrearArchivo() {


          File.Create(nom).Close();
          MessageBox.Show("Archivo creado");
          
          
      
      }//fin metodo crear archivo

      public void AgregarDatos(ref string mens) {

          StreamWriter Arch = new StreamWriter(nom);

          Arch.WriteLine(mens);
          MessageBox.Show("Mensaje Agregado");
          Arch.Close();
      
          
      
      }

      public void Mostrar(ListBox lista) {
          lista.Items.Clear();
          StreamReader Arch = new StreamReader(nom);


          lista.Items.Add(Arch.ReadLine());
          Arch.Close();
      
      }

  
  }// fin class
}// fin namespace
