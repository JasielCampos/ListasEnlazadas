using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasEnlazadas
{
    class ListaSimplementeEnlazada
    {
        public Nodo tope = null;

        private bool VaciaPila()
        {
            if (tope == null)
                return true;
            else
                return false;
        }

        public void InsertarPila(int elemento)
        {
            Nodo p;
            if (VaciaPila())
            {
                tope = new Nodo();
                tope.Informacion = elemento;
                tope.Enlace = null;
            }
            else
            {
                p = new Nodo();
                p.Informacion = elemento;
                p.Enlace = tope;
                tope = p;
            }
        }

        public void EliminarPila()
        {
            Nodo p;
            if (VaciaPila())
            {
                MessageBox.Show("La pila esta vacia, no se puede eliminar elementos");
            }
            else
            {
                MessageBox.Show("El elemento eliminado es: "+tope.Informacion);
                p = tope;
                tope = tope.Enlace;
                p.Enlace = null;
                p = null;
            }
        }
    }
}
