
namespace LAB06_PRUEBAS.Models
{
    public interface IEstructuraDeDatos<T>
    {
        void Insertar(T valor);
        void Actualizar(int pos);
        void Eliminar(int pos);
        T Obtener(int pos);
    }

    public class ListaEnlazada<T> : IEstructuraDeDatos<T>
    {
        int Contador { get; set; }
        public bool Vacia { get; set; }
        public Nodo<T> PrimerNodo { get; set; }
        public Nodo<T> UltimoNodo { get; set; }
        public void Actualizar(int pos)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int pos)
        {
            throw new NotImplementedException();
        }

        public void Insertar(T valor)
        {
            var nodoInsertar = new Nodo<T>(valor);
            if (Contador == 0)
            {
                PrimerNodo = nodoInsertar;
                Contador = 1;
                Vacia = false;
                UltimoNodo = nodoInsertar;

            }
            else
            {
                UltimoNodo.Siguiente = nodoInsertar;
                UltimoNodo = nodoInsertar;
                Contador++;
            }
        }

        public T Obtener(int pos)
        {
            throw new NotImplementedException();
        }

        public class Nodo<T>
        {
            //El valor puede ser un int, string, objeto, etc
            public T Valor { get; set; }
            //se puede referenciar a si misma como una clase normal
            public Nodo<T> Siguiente { get; set; }

            //Constructor
            internal Nodo(T valor)
            {
                Valor = valor;
                //explicar This aqui
                Siguiente = null;
            }
        }

    }
}
