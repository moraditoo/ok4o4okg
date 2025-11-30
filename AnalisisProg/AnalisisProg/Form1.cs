using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace AnalisisProg
{
    public partial class Form1 : Form
    {
        List<long> numeros = new List<long>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            btnGenerar.Enabled = false;
            int cantidad = int.Parse(tbCantidadRegistros.Text);
            Random rdn = new Random();
            numeros.Clear();
            Stopwatch sw = new Stopwatch();
            lblInicio.Text = "Inicio: " + DateTime.Now.ToString("hh:mm:ss");
            sw.Start();
            for (int i = 0; i < cantidad; i++)
            {
                numeros.Add((long)rdn.Next(100, 500));
            }
            lbDatos.DataSource = null;
            lbDatos.DataSource = numeros;
            sw.Stop();
            lblFin.Text = "Fin: " + DateTime.Now.ToString("hh:mm:ss");
            lblDuracion.Text = "Duración: " + sw.Elapsed.TotalMilliseconds / 1000 + " segundos";
            btnGenerar.Enabled = true;
            gbRegistros.Text = "Registros: " + numeros.Count;
        }

        private void Merge(List<long> lista, int inicio, int medio, int fin)
        {
            List<long> temp = new List<long>();
            int i = inicio;
            int j = medio + 1;
            while (i <= medio && j <= fin)
            {
                if (lista[i] <= lista[j])
                {
                    temp.Add(lista[i]);
                    i++;
                }
                else
                {
                    temp.Add(lista[j]);
                    j++;
                }
            }
            while (i <= medio)
            {
                temp.Add(lista[i]);
                i++;
            }
            while (j <= fin)
            {
                temp.Add(lista[j]);
                j++;
            }
            for (int k = 0; k < temp.Count; k++)
            {
                lista[inicio + k] = temp[k];
            }
        }

        private void MergeSort(List<long> lista, int inicio, int fin)
        {
            if (inicio < fin)
            {
                int medio = (inicio + fin) / 2;
                MergeSort(lista, inicio, medio);
                MergeSort(lista, medio + 1, fin);
                Merge(lista, inicio, medio, fin);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void gbRegistros_Enter(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void lbOrdenados_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnOrdenarMergeSort_Click(object sender, EventArgs e)
        {
            if (numeros == null || numeros.Count == 0)
                return;
            btnOrdenarMergeSort.Enabled = false;
            btnGenerar.Enabled = false;
            List<long> listaParaOrdenar = new List<long>(numeros);
            Stopwatch sw = new Stopwatch();
            lblInicio2.Text = "Inicio: " + DateTime.Now.ToString("hh:mm:ss");
            sw.Start();
            MergeSort(listaParaOrdenar, 0, listaParaOrdenar.Count - 1);
            sw.Stop();
            lblFin2.Text = "Fin: " + DateTime.Now.ToString("hh:mm:ss");
            lblDuracion2.Text = "Duración: " + sw.Elapsed.TotalMilliseconds / 1000 + " segundos";
            lbOrdenadosMerge.DataSource = null;
            lbOrdenadosMerge.DataSource = listaParaOrdenar;
            btnOrdenarMergeSort.Enabled = true;
            btnGenerar.Enabled = true;
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            btnOrdenar.Enabled = false;
            int cantidad = int.Parse(tbCantidadRegistros.Text);
            Stopwatch sw = new Stopwatch();
            lblInicio1.Text = "Inicio: " + DateTime.Now.ToString("hh:mm:ss");
            sw.Start();
            for (int i = 0; i < cantidad; i++)
            {
                for (int j = i + 1; j < cantidad; j++)
                {
                    if (numeros[i] > numeros[j])
                    {
                        long temp = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = temp;
                    }
                }
            }
            lbOrdenados.DataSource = null;
            lbOrdenados.DataSource = numeros;
            lblDuracion1.Text = "Duración: " + sw.Elapsed.TotalMilliseconds / 1000 + " segundos";
            sw.Stop();
            lblFin1.Text = "Fin: " + DateTime.Now.ToString("hh:mm:ss");
            btnOrdenar.Enabled = true;
            gbRegistros.Text = "Registros: " + numeros.Count;
        }

        private List<long> GetSortedSource()
        {
            if (lbOrdenadosMerge.DataSource is IList<long> dsMerge)
                return new List<long>(dsMerge);
            if (lbOrdenadosMerge.Items != null && lbOrdenadosMerge.Items.Count > 0)
            {
                var list = new List<long>(lbOrdenadosMerge.Items.Count);
                foreach (var itm in lbOrdenadosMerge.Items)
                {
                    if (itm is long l) list.Add(l);
                    else
                    {
                        long val;
                        if (long.TryParse(itm?.ToString() ?? "", out val))
                            list.Add(val);
                    }
                }
                if (list.Count > 0) return list;
            }
            if (lbOrdenados.DataSource is IList<long> dsOrd)
                return new List<long>(dsOrd);
            if (lbOrdenados.Items != null && lbOrdenados.Items.Count > 0)
            {
                var list = new List<long>(lbOrdenados.Items.Count);
                foreach (var itm in lbOrdenados.Items)
                {
                    if (itm is long l) list.Add(l);
                    else
                    {
                        long val;
                        if (long.TryParse(itm?.ToString() ?? "", out val))
                            list.Add(val);
                    }
                }
                if (list.Count > 0) return list;
            }
            return new List<long>(numeros);
        }

        private int FindIndexInListBox(ListBox lb, long value)
        {
            if (lb == null) return -1;
            for (int i = 0; i < lb.Items.Count; i++)
            {
                var itm = lb.Items[i];
                if (itm is long lv && lv == value) return i;
                long parsed;
                if (long.TryParse(itm?.ToString() ?? "", out parsed) && parsed == value) return i;
            }
            return -1;
        }

        private void SelectValueInTwoListBoxes(long value)
        {
            int idxOrdenados = FindIndexInListBox(lbOrdenados, value);
            if (idxOrdenados >= 0)
            {
                lbOrdenados.SelectedIndex = idxOrdenados;
                lbOrdenados.TopIndex = Math.Max(0, idxOrdenados - 3);
            }
            else
            {
                lbOrdenados.ClearSelected();
            }

            int idxMerge = FindIndexInListBox(lbOrdenadosMerge, value);
            if (idxMerge >= 0)
            {
                lbOrdenadosMerge.SelectedIndex = idxMerge;
                lbOrdenadosMerge.TopIndex = Math.Max(0, idxMerge - 3);
            }
            else
            {
                lbOrdenadosMerge.ClearSelected();
            }
        }

        private int JumpSearch(List<long> arr, long x)
        {
            int n = arr.Count;
            if (n == 0) return -1;
            int step = (int)Math.Floor(Math.Sqrt(n));
            int prev = 0;
            while (prev < n && arr[Math.Min(step, n) - 1] < x)
            {
                prev = step;
                step += (int)Math.Floor(Math.Sqrt(n));
                if (prev >= n) return -1;
            }
            int start = prev;
            int end = Math.Min(step, n) - 1;
            for (int i = start; i <= end; i++)
            {
                if (arr[i] == x) return i;
            }
            return -1;
        }

        private int InterpolationSearch(List<long> arr, long x)
        {
            int low = 0;
            int high = arr.Count - 1;
            while (low <= high && x >= arr[low] && x <= arr[high])
            {
                if (arr[low] == arr[high])
                {
                    if (arr[low] == x) return low;
                    return -1;
                }
                long num = x - arr[low];
                long den = arr[high] - arr[low];
                int pos = low + (int)((double)num * (high - low) / (double)den);
                if (pos < low) pos = low;
                if (pos > high) pos = high;
                if (arr[pos] == x) return pos;
                if (arr[pos] < x) low = pos + 1;
                else high = pos - 1;
            }
            if (low < arr.Count && arr[low] == x) return low;
            return -1;
        }

        private void btnJumpSearch_Click_1(object sender, EventArgs e)
        {
            long value;
            if (!long.TryParse(tbTextoBuscar.Text.Trim(), out value))
            {
                MessageBox.Show("Introduce un número entero válido para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var source = GetSortedSource();
            if (source.Count == 0)
            {
                MessageBox.Show("No hay datos para buscar. Genera y ordena primero.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            btnJumpSearch.Enabled = false;
            lblInicio4.Text = "Inicio: " + DateTime.Now.ToString("hh:mm:ss");
            Stopwatch sw = Stopwatch.StartNew();
            int index = JumpSearch(source, value);
            sw.Stop();
            lblFin4.Text = "Fin: " + DateTime.Now.ToString("hh:mm:ss");
            lblDuracion4.Text = "Duración: " + sw.Elapsed.TotalMilliseconds / 1000 + " segundos";
            if (index >= 0)
            {
                long foundValue = source[index];
                SelectValueInTwoListBoxes(foundValue);
                MessageBox.Show($"Valor {foundValue} encontrado en índice {index} (lista ordenada).", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lbOrdenados.ClearSelected();
                lbOrdenadosMerge.ClearSelected();
                MessageBox.Show($"Valor {value} no encontrado.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnJumpSearch.Enabled = true;
        }

        private void btnBusquedaInterpolada_Click(object sender, EventArgs e)
        {
            long value;
            if (!long.TryParse(tbTextoBuscar.Text.Trim(), out value))
            {
                MessageBox.Show("Introduce un número entero válido para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var source = GetSortedSource();
            if (source.Count == 0)
            {
                MessageBox.Show("No hay datos para buscar. Genera y ordena primero.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            btnBusquedaInterpolada.Enabled = false;
            label7.Text = "Inicio: " + DateTime.Now.ToString("hh:mm:ss");
            Stopwatch sw = Stopwatch.StartNew();
            int index = InterpolationSearch(source, value);
            sw.Stop();
            label6.Text = "Fin: " + DateTime.Now.ToString("hh:mm:ss");
            label5.Text = "Duración: " + sw.Elapsed.TotalMilliseconds / 1000 + " segundos";
            if (index >= 0)
            {
                long foundValue = source[index];
                SelectValueInTwoListBoxes(foundValue);
                MessageBox.Show($"Valor {foundValue} encontrado en índice {index} (lista ordenada).", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lbOrdenados.ClearSelected();
                lbOrdenadosMerge.ClearSelected();
                MessageBox.Show($"Valor {value} no encontrado.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnBusquedaInterpolada.Enabled = true;
        }
    }
}