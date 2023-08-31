using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demoç

{
    class Problema
    {
        public void saludar()
        {
            MessageBox.Show("Hola");
        }
    
        public void verFrutas(ListBox lst)
        {
            string[] Frutas = { "UVA", "PERA", "LIMON", "MANZANA" , "POMELO" };
            lst.Items.Clear();
            foreach (string Fruta in Frutas) 
            {
                lst.Items.Add(Fruta);           
            }
            
        }
    }

}
