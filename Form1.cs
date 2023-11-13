﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MetodosOrdenamiento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
                                               // DECLARACION DE VARIABLES GLOBALES//
        public List<int> numeros;
        public int aux;
        public string cargando = "";
        int iteraciones = 0;
        
        List<int> sortedArr = new List<int>();
                                               // GENERAR VECTOR CON NUMEROS RANDOM//
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value >= 1)
            {
                int l = Convert.ToInt32(numericUpDown1.Value);
                numeros = new List<int>(l);
                Random random = new Random();
                for (int i = 0; i < l; i++)
                {
                    numeros.Add(random.Next(0, 100));

                }
                MessageBox.Show("Vector Creado", "Informacion");
                GraficoDesordenado(grDesordenado, numeros);
            }
            else
            {
                MessageBox.Show("Ingresar un numero de elementos positivos", "Error");
            }
        }
                                          // FUNCIONES DE METODO QUICK SORT//
        private void Quick(List<int> arr, int left, int right, out int iteraciones, out double tiempo)
        {
            iteraciones = 0;
            Stopwatch time = new Stopwatch();
            time.Start();

            sortedArr = Quicksort(arr, ref iteraciones);

            time.Stop();
            tiempo = time.Elapsed.TotalMilliseconds;
        }
        private List<int> Quicksort(List<int> arr, ref int iteraciones)
        {
            if (arr.Count <= 1)
            {
                return arr;
            }

            int pivot = arr[0];
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] < pivot)
                {
                    left.Add(arr[i]);
                }
                else if (arr[i] > pivot)
                {
                    right.Add(arr[i]);
                }
                iteraciones++;
            }

            List<int> res = new List<int>();
            res.AddRange(Quicksort(left, ref iteraciones));
            res.Add(pivot);
            res.AddRange(Quicksort(right, ref iteraciones));

            return res;
        }
                                               // FUNCIONES CON EL METODO MERGE//
        private void Mergesort(List<int> arr, out int iteraciones, out double tiempo)
        {
            iteraciones = 0;
            Stopwatch time = new Stopwatch();
            time.Start();

            MergeSort(arr, ref iteraciones);

            time.Stop();
            tiempo = time.Elapsed.TotalMilliseconds;

        }
        private void MergeSort(List<int> arr, ref int iteraciones)
        {
            if (arr.Count <= 1)
            {
                return;
            }

            int mitad = arr.Count / 2;

            List<int> izq = arr.GetRange(0, mitad);
            List<int> der = arr.GetRange(mitad, arr.Count - mitad);

            // Llamadas recursivas para ordenar las dos mitades
            MergeSort(izq, ref iteraciones);
            MergeSort(der, ref iteraciones);

            // Combinar las dos mitades ordenadas
            Merge(arr, izq, der, ref iteraciones);

        }
        private void Merge(List<int> arr, List<int> izq, List<int> der, ref int iteraciones)
        {

            int i = 0; //para recorrer izq
            int a = 0; // para recorrer der
            int e = 0; //para recorrer arr

            while (i < izq.Count && a < der.Count)
            {
                iteraciones++;
                if (izq[i] <= der[a])
                {
                    arr[e++] = izq[i++];
                }
                else
                {
                    arr[e++] = der[a++];
                }
            }

            //ordena los elementos que quedaron sueltos sin ordenar
            while (i < izq.Count)
            {
                iteraciones++;
                arr[e++] = izq[i++];
            }

            while (a < der.Count)
            {
                iteraciones++;
                arr[e++] = der[a++];
            }

        }
                                             // LLAMADO DE FUNCIONES Y METODO BURBUJA//

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            int iteraciones = 0;
            if (optBubble.Checked == true && numericUpDown1.Value >= 1)
            {
                Stopwatch time = new Stopwatch();
                time.Start();
                for (int i = 0; i < numeros.Count; i++)
                {
                    iteraciones++;
                    for (int J = 0; J < numeros.Count - 1 - i; J++)
                    {
                        if (numeros[J] > numeros[J + 1])
                        {
                            aux = numeros[J];
                            numeros[J] = numeros[J + 1];
                            numeros[J + 1] = aux;

                        }
                        iteraciones++;
                    }
                }
                time.Stop();
                dgvMetodos.Rows.Add("Bubble Sort", iteraciones, time.Elapsed.TotalMilliseconds, numericUpDown1.Value);
                txtIteraciones.Text = iteraciones.ToString();
                txtTiempo.Text = time.Elapsed.TotalMilliseconds.ToString();
                iteraciones = 0;

            }
            if (optQuick.Checked == true && numericUpDown1.Value >= 1)
            {

                iteraciones = 0;
                double tiempo = 0;

                Quick(numeros, 0, numeros.Count - 1, out iteraciones, out tiempo);

                dgvMetodos.Rows.Add("Quick Sort", iteraciones, tiempo, numericUpDown1.Value);
                txtIteraciones.Text = iteraciones.ToString();
                txtTiempo.Text = tiempo.ToString();

            }
            if (optMerge.Checked == true && numericUpDown1.Value >= 1)
            {

                iteraciones = 0;
                double tiempo = 0;
                Mergesort(numeros, out iteraciones, out tiempo);

                txtIteraciones.Text = iteraciones.ToString();
                txtTiempo.Text = tiempo.ToString();
                dgvMetodos.Rows.Add("Merge Sort", iteraciones, tiempo, numericUpDown1.Value);

            }
            GraficoOrdenado(grOrdenado, sortedArr);
        }
                                                         // GRAFICOS //

        private void GraficoDesordenado(Chart chart, List<int> data)
        {
            grDesordenado.Series.Clear();
            grDesordenado.Series.Add("Desordenado");
            grDesordenado.Series["Desordenado"].ChartType = SeriesChartType.Column;

            for (int i = 0; i < data.Count; i++)
            {
                chart.Series["Desordenado"].Points.AddXY(i, data[i]);
            }
        }

        private void GraficoOrdenado(Chart chart, List<int> data)
        {
            grOrdenado.Series.Clear();
            grOrdenado.Series.Add("Ordenado");
            grOrdenado.Series["Ordenado"].ChartType = SeriesChartType.Column;

            for (int i = 0; i < data.Count; i++)
            {
                chart.Series["Ordenado"].Points.AddXY(i, data[i]);
            }
        }
                                                         //LIMPIAR GRILLA//
        private void button1_Click(object sender, EventArgs e)
        {
            dgvMetodos.Rows.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void txtVector_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
