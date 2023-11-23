using Xunit;
using LAB06_PRUEBAS.Models;
using System.Diagnostics.CodeAnalysis;

namespace TestProject1
{
    [ExcludeFromCodeCoverage]
    public class UnitTest1
    {
        [Fact]
        public void Insertar_ValoresDiferentes_PrimerYUltimoNodoDiferentes()
        {
            // Preparacion
            var lista = new ListaEnlazada<int>();

            // Accion
            lista.Insertar(1);
            lista.Insertar(3);

            // Afirmacion
            Assert.NotEqual(lista.PrimerNodo, lista.UltimoNodo);
        }

        [Fact]
        public void Insertar_PrimerValor_PrimerNodoEsCorrecto()
        {
            // Preparacion
            var lista = new ListaEnlazada<int>();

            // Accion
            lista.Insertar(5);

            // Afirmacion
            Assert.Equal(5, lista.PrimerNodo.Valor);
        }

        [Fact]
        public void Insertar_DosValores_EnlazadoCorrectamente()
        {
            // Preparacion
            var lista = new ListaEnlazada<int>();

            // Accion
            lista.Insertar(10);
            lista.Insertar(20);

            // Afirmacion
            Assert.Equal(20, lista.PrimerNodo.Siguiente.Valor);
        }

        [Fact]
        public void ListaNueva_EsVacia()
        {
            // Preparacion
            var lista = new ListaEnlazada<int>();

            // Afirmación
            Assert.True(lista.Vacia);
        }
    }
}
