using System;
using System.Text;

namespace PracticaCursoSichar
{
    public class Matriz
    {
        //creamos los campos 
        private int[,] _data;

        //Creamos contructor para inicializar la matriz con sus filas y columnas
        public Matriz(int Filas, int Columnas)
        {
            _data = new int[Filas, Columnas];

        }

        //propiedades
        public int Filas { get { return _data.GetLength(0); }}
        public int Columnas { get { return _data.GetLength(1); } }

        //indexador para leer matriz
        public int this[int Fila, int Columna]
        {
            get
            {
                return _data[Fila, Columna];
            }
            set
            {
                _data[Fila, Columna] = value;
            }
        }

        //creamos operador
        public static Matriz operator +(Matriz MatrizA, Matriz MatrizB)
        {
            //definimos comportamiento
            if(MatrizA.Filas != MatrizB.Filas || MatrizA.Columnas != MatrizB.Columnas)
            {
                throw new ApplicationException("Las matrices deben ser de la misma dimension");
            }
            else
            {
                Matriz resultado = new Matriz(MatrizA.Filas, MatrizA.Columnas);
                //iteramos las filas y columnas de las dos matrices
                for(int i = 0; i < MatrizA.Filas; i++)
                {
                    for(int j = 0; j < MatrizA.Columnas; j++)
                    {
                        resultado[i, j] = MatrizA[i, j] + MatrizB[i, j];
                    }
                }

                return resultado;
            }
        }

        //Metodo para escribir en consola el resultado 
        public override string ToString()
        {
            var sb = new StringBuilder();
            var tmpFila = new int[Columnas];

            for (int i = 0; i < Filas; i++)
            {
                for (int j = 0; j < Columnas; j++)
                {
                    tmpFila[j] = this[i, j];
                }

                sb.AppendLine(string.Join("\t", tmpFila));
                sb.AppendLine("");
            }

            return sb.ToString();

        }
    }
}
