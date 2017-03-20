using System;

namespace DataStructures
{
    public class Stack<T>
    {
        private T[] _items;
        private int _currentIndex;

        /// <summary>
        /// Crea una nueva instancia de pila con capacidad inicial 100
        /// </summary>
        public Stack() : this(100) { }

        /// <summary>
        /// Crea una nueva instancia de pila con capacidad definida
        /// </summary>
        /// <param name="capacity">int - debe ser mayor a 0</param>
        public Stack(int capacity)
        {
            if (capacity < 0)
                throw new ArgumentOutOfRangeException("capacity");

            _items = new T[capacity];
            _currentIndex = 0;
        }

        /// <summary>
        /// Inserta un elemento en la pila
        /// </summary>
        /// <param name="item">elemento a insertar</param>
        public void Push(T item)
        {
            if (_currentIndex >= _items.Length)
            {
                throw new StackOverflowException();
            }
            _items[_currentIndex++] = item;
        }

        /// <summary>
        /// Saca un elemento de la pila
        /// </summary>
        /// <returns>último elemento agregado a la pila</returns>
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("La pila está vacia");
            }
            T item = _items[--_currentIndex];
            _items[_currentIndex] = default(T);
            return item;
        }

        /// <summary>
        /// Comprueba si la pila está vacia
        /// </summary>
        /// <returns>bandera que representa si la pila está vacia o no</returns>
        public bool IsEmpty()
        {
            if (_currentIndex == 0)
                return true;
            return false;
        }
    }
}
