using System;
using System.Collections.Generic;
using System.Text;

namespace ListasEnlazadas
{
    class CListasEnlazadas
    {
        //es el encabezado o "head"
        private CNodo ancla; //cabeza

        public void Agregar(int pValor) { // si la lista esta vacia se agrega una cabeza 
            if(estaVacia() == true) {
                ancla = new CNodo(pValor);
                return;
            }

            CNodo nodoActual = ancla;
            while (nodoActual.siguiente != null) {
                nodoActual = nodoActual.siguiente; // si el nodo actual no es nulo se brinca al siguiente
            }
            nodoActual.siguiente = new CNodo(pValor); // sze busca el siguiente null para poder agregar el siguiente nodo
        }


        public void Borrar(int pValor) {
            if (estaVacia() == true)
                return; // no puede borrar nada porqque4 ya esta vacia

            bool banderaBusqueda = false; //ubicar el numero que estamos bucando
            CNodo nodoAnterior = null; //pasado
            CNodo NodoActual = ancla; //actual
            while (true) {
                if (NodoActual.Dato == pValor){
                    banderaBusqueda = true;
                    break; //intercambia el pasado y el actual, siempre ciclan el break para en el num cuando ya se encontro
                }
                else {
                    nodoAnterior = NodoActual; 
                    NodoActual = NodoActual.siguiente;//intercambia entre actual y pasado
                }
            }

            if (banderaBusqueda == true) {
                nodoAnterior.siguiente = NodoActual.siguiente;
            }
        }

        public void Imprimir() {
            if (estaVacia() == true)
                return;

            CNodo nodoActual = ancla;
            while (nodoActual != null) {
                Console.WriteLine(nodoActual.ToString());
                nodoActual = nodoActual.siguiente; //busca si hay coordenadas para imprimir el siguiente numero y va ciclando cuando no hay es null y deja de imprimir
            }
        }

        public bool estaVacia()
        {
            if (ancla == null){
                return true;
            }
            else{
                return false;
            }
        }
    }
}
