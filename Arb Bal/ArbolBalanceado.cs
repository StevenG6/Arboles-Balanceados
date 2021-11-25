using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arb_Bal
{
    class ArbolBalanceado
    {
        public Nodo Raiz;

        Graphics Dibujar;
        Pen Linea = new Pen(Color.DarkBlue, 1);
        Font font = new Font(FontFamily.GenericSansSerif, 10);

        public ArbolBalanceado(Form form)
        {
            //Instanciar el formulario en el que dibujara
            Dibujar = form.CreateGraphics();
        }

        #region Metodos Auxiliares
        public int CalcularAltura(Nodo Puntero) //Calcular Altura del Nodo
        {
            return (Puntero == null) ? 0 : 1 + Math.Max(CalcularAltura(Puntero.EnlaceIzquierdo), CalcularAltura(Puntero.EnlaceDerecho));
        }

        public int CalcularFE(Nodo Puntero) //Calcular FE del Nodo
        {
            return CalcularAltura(Puntero.EnlaceDerecho) - CalcularAltura(Puntero.EnlaceIzquierdo); 
        }

        private void FEArbol(Nodo Puntero) //Asigna FE a todos los nodos del arbol
        {
            if(Puntero != null)
            {
                Puntero.FE = CalcularFE(Puntero);
                FEArbol(Puntero.EnlaceIzquierdo);
                FEArbol(Puntero.EnlaceDerecho);
            }
        }
        #endregion

        #region Insertar
        public void Insertar(int numero, string nombre)
        {
            if (Raiz != null)
                Insercion(ref Raiz, numero, nombre);

            else
                CrearRaiz(numero, nombre);

            FEArbol(Raiz);

            Dibujar.Clear(Color.White);
            DibujarArbol(Raiz, 625, 40, "", 1);
        }

        private void CrearRaiz(int numero, string nombre)
        {
            Nodo nuevo = new Nodo(numero, nombre)
            {
                EnlaceIzquierdo = null,
                EnlaceDerecho = null,
            };

            Raiz = nuevo;
        }

        private void Insercion(ref Nodo Puntero, int numero, string nombre)
        {
            if (numero < Puntero.Numero)
            {
                if (Puntero.EnlaceIzquierdo == null)
                {
                    Nodo nuevo = new Nodo(numero, nombre)
                    {
                        EnlaceIzquierdo = null,
                        EnlaceDerecho = null
                    };

                    Puntero.EnlaceIzquierdo = nuevo;
                }
                else
                    Insercion(ref Puntero.EnlaceIzquierdo, numero, nombre);

                //Despues de insertar, Verificar si el Puntero quedó fuera de equilibrio
                if (CalcularFE(Puntero) == -2)
                {
                    Puntero = ReestructuraIzq(Puntero); //Reestructuración por Izquierda
                }
            }
            else
            {
                if (numero > Puntero.Numero)
                {
                    if (Puntero.EnlaceDerecho == null)
                    {
                        Nodo nuevo = new Nodo(numero, nombre)
                        {
                            EnlaceIzquierdo = null,
                            EnlaceDerecho = null
                        };

                        Puntero.EnlaceDerecho = nuevo;
                    }
                    else
                        Insercion(ref Puntero.EnlaceDerecho, numero, nombre);

                    //Despues de insertar, Verificar si el Puntero quedó fuera de equilibrio
                    if (CalcularFE(Puntero) == 2)
                    {
                        Puntero = ReestructuraDer(Puntero);  //Reestructuración por Derecha
                    }
                }
                else
                    MessageBox.Show("El número ya pertenece a un registro", "Error");
            }
        }
        #endregion

        #region Eliminar
        public void Eliminacion(ref Nodo Puntero, int numero)
        {
            if (Puntero != null)
            {
                if (numero < Puntero.Numero)
                {
                    //Buscar nodo por izquierda
                    Eliminacion(ref Puntero.EnlaceIzquierdo, numero);

                    //Despues de eliminar, Verificar si el Puntero quedó fuera de equilibrio
                    if (CalcularFE(Puntero) == 2)
                    {
                        Puntero = ReestructuraDer(Puntero);  //Reestructuración por Derecha
                    }
                }
                else
                {
                    if (numero > Puntero.Numero)
                    {
                        //Buscar nodo por derecha
                        Eliminacion(ref Puntero.EnlaceDerecho, numero);

                        //Despues de eliminar, Verificar si el Puntero quedó fuera de equilibrio
                        if (CalcularFE(Puntero) == -2)
                        {
                            Puntero = ReestructuraIzq(Puntero); //Reestructuración por Izquierda
                        }
                    }
                    else
                    {
                        //Nodo encontrado
                        Nodo nodoEliminar = Puntero;

                        if (nodoEliminar.EnlaceDerecho == null) //Si el nodo a eliminar no tiene hijo derecho, copiamos a Puntero el hijo Izquierdo del nodo a Eliminar
                        {
                            Puntero = nodoEliminar.EnlaceIzquierdo;
                        }
                        else
                        {
                            if (nodoEliminar.EnlaceIzquierdo == null) //Si el nodo a eliminar no tiene hijo izquierdo, copiamos a Puntero el hijo Derecho del nodo a Eliminar
                            {
                                Puntero = nodoEliminar.EnlaceDerecho;
                            }
                            else //Tiene hijos por ambos lados
                            {
                                //eliminación por izquierda
                                Nodo Aux1 = null;
                                Nodo Aux = Puntero.EnlaceIzquierdo;
                                bool band = false;

                                while (Aux.EnlaceDerecho != null)
                                {
                                    Aux1 = Aux; //para guardar el ultimo nodo visitado antes de que Aux.Derecha sea null
                                    Aux = Aux.EnlaceDerecho;
                                    band = true;
                                }

                                //Reasignar información
                                Puntero.Numero = Aux.Numero;
                                Puntero.Nombre = Aux.Nombre;

                                nodoEliminar = Aux;

                                if (band)
                                    Aux1.EnlaceDerecho = Aux.EnlaceIzquierdo;
                                else
                                    Puntero.EnlaceIzquierdo = Aux.EnlaceIzquierdo;

                                //Despues de eliminar, Verificar si el Puntero quedó fuera de equilibrio
                                if (CalcularFE(Puntero) == 2)
                                {
                                    Puntero = ReestructuraDer(Puntero);  //Reestructuración por Derecha
                                }
                            }
                        }
                    }
                }
                    FEArbol(Raiz);
                    Dibujar.Clear(Color.White);
                    DibujarArbol(Raiz, 625, 40, "", 1);
            }
            else
                MessageBox.Show("Registro no encontrado", "Error");
        }
        #endregion

        #region Rotaciones
        private Nodo ReestructuraIzq(Nodo Puntero)
        {
            Nodo Aux1 = Puntero.EnlaceIzquierdo;

            if (CalcularFE(Aux1) <= 0) //Rotación II
            {
                MessageBox.Show("Rotación II", "Reestructuración");

                Puntero.EnlaceIzquierdo = Aux1.EnlaceDerecho;
                Aux1.EnlaceDerecho = Puntero;

                return Aux1;
            }
            else //Rotación ID
            {
                MessageBox.Show("Rotación ID", "Reestructuración");
                Nodo Aux2 = Aux1.EnlaceDerecho;

                Aux1.EnlaceDerecho = Aux2.EnlaceIzquierdo;
                Aux2.EnlaceIzquierdo = Aux1;
                Puntero.EnlaceIzquierdo = Aux2.EnlaceDerecho;
                Aux2.EnlaceDerecho = Puntero;

                return Aux2;
            }
        }

        private Nodo ReestructuraDer(Nodo Puntero)
        {
            Nodo Aux1 = Puntero.EnlaceDerecho;

            if (CalcularFE(Aux1) >= 0) //Rotación DD
            {
                MessageBox.Show("Rotación DD", "Reestructuración");

                Puntero.EnlaceDerecho = Aux1.EnlaceIzquierdo;
                Aux1.EnlaceIzquierdo = Puntero;

                return Aux1;
            }
            else //Rotación DI
            {
                MessageBox.Show("Rotación DI", "Reestructuración");
                Nodo Aux2 = Aux1.EnlaceIzquierdo;

                Aux1.EnlaceIzquierdo = Aux2.EnlaceDerecho;
                Aux2.EnlaceDerecho = Aux1;
                Puntero.EnlaceDerecho = Aux2.EnlaceIzquierdo;
                Aux2.EnlaceIzquierdo = Puntero;
                return Aux2;
            }
        }
        #endregion

        #region Recorridos
        public void Preorden(Nodo Puntero, DataGridView dataGridView)
        {
            if (Puntero != null)
            {
                dataGridView.Rows.Add(Convert.ToString(Puntero.Numero), Puntero.Nombre);
                Preorden(Puntero.EnlaceIzquierdo, dataGridView);
                Preorden(Puntero.EnlaceDerecho, dataGridView);
            }
        }

        public void Inorden(Nodo Puntero, DataGridView dataGridView)
        {
            if (Puntero != null)
            {
                Inorden(Puntero.EnlaceIzquierdo, dataGridView);
                dataGridView.Rows.Add(Convert.ToString(Puntero.Numero), Puntero.Nombre);
                Inorden(Puntero.EnlaceDerecho, dataGridView);
            }
        }

        public void Posorden(Nodo Puntero, DataGridView dataGridView)
        {
            if (Puntero != null)
            {
                Posorden(Puntero.EnlaceIzquierdo, dataGridView);
                Posorden(Puntero.EnlaceDerecho, dataGridView);
                dataGridView.Rows.Add(Convert.ToString(Puntero.Numero), Puntero.Nombre);
            }
        }
        #endregion

        #region Dibujar
        private void DibujarArbol(Nodo Puntero, float coordenadaX, float CoordenadaY, string hijo, float aux)
        {
            if (Puntero != null)
            {
                DibujarNodo(Puntero, coordenadaX, CoordenadaY, hijo, aux);
                DibujarArbol(Puntero.EnlaceIzquierdo, coordenadaX - (200 / aux), CoordenadaY + 50, "Izquierdo", aux + 2);
                DibujarArbol(Puntero.EnlaceDerecho, coordenadaX + (200 / aux), CoordenadaY + 50, "Derecho", aux + 2);
            }
        }

        private void DibujarNodo(Nodo Puntero, float coordenadaX, float coordenadaY, string hijo, float aux)
        {
            if (Puntero == Raiz)
            {
                Dibujar.FillEllipse(Brushes.DarkBlue, coordenadaX, coordenadaY, 30, 30);
                Dibujar.DrawString(Convert.ToString(Puntero.Numero), font, Brushes.White, coordenadaX + 5, coordenadaY + 5);
                Dibujar.DrawString(Convert.ToString(Puntero.FE), font, Brushes.Navy, coordenadaX + 30, coordenadaY - 3);
            }
            else
            {
                if (hijo == "Izquierdo")
                {
                    Dibujar.FillEllipse(Brushes.DarkBlue, coordenadaX, coordenadaY, 30, 30);
                    Dibujar.DrawString(Convert.ToString(Puntero.Numero), font, Brushes.White, coordenadaX + 5, coordenadaY + 5);
                    Dibujar.DrawLine(Linea, coordenadaX + 15, coordenadaY, (coordenadaX + (200 / (aux - 2))) + 15, coordenadaY - 30);
                    Dibujar.DrawString(Convert.ToString(Puntero.FE), font, Brushes.Navy, coordenadaX + 30, coordenadaY - 3);
                }
                else
                {
                    Dibujar.FillEllipse(Brushes.DarkBlue, coordenadaX, coordenadaY, 30, 30);
                    Dibujar.DrawString(Convert.ToString(Puntero.Numero), font, Brushes.White, coordenadaX + 5, coordenadaY + 5);
                    Dibujar.DrawLine(Linea, coordenadaX + 15, coordenadaY, (coordenadaX - (200 / (aux - 2))) + 15, coordenadaY - 30);
                    Dibujar.DrawString(Convert.ToString(Puntero.FE), font, Brushes.Navy, coordenadaX + 30, coordenadaY - 3);
                }
            }
        }
        #endregion
    }
}
