using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alDijkstra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            al = new AlDijkstra();
        }

        public int countVertex;
        public AlDijkstra al;

        private void btnChangeCountVertex_Click(object sender, EventArgs e)
        {
            try
            {
                countVertex = int.Parse(txtCountVertex.Text);
                if (countVertex > 1) generateDataGridView(dgvBefore);
                else MessageBox.Show("Введите больше вершин");
            }
            catch
            {
                MessageBox.Show("Некоректный ввод числа вершин");
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int[,] arr = al.DGVToArr(dgvBefore);
            al.CreateGraph(arr);
            int start, end;
            try
            {
                start = int.Parse(txtStart.Text);
                end = int.Parse(txtEnd.Text);
            }
            catch
            {
                MessageBox.Show("Не введены начало или конец");
                return;
            }
            txtPath.Text = al.Algorithm(start, end);
        }

        private void generateDataGridView(DataGridView dataGridView)
        {
            try
            {
                dataGridView.Rows.Clear();
                dataGridView.Columns.Clear();
                for (int i = 0; i < countVertex + 1; i++)
                {
                    dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        HeaderText = i == 0 ? ("") : (Convert.ToChar(64 + i).ToString()),
                        Name = "Column" + Convert.ToString(i),
                        ValueType = typeof(string)
                    });
                    dataGridView.Columns[i].Width = 35;
                    if (i > 0) dataGridView.Rows.Add(Convert.ToChar(64 + i).ToString());
                }
                for (int i = 0; i < countVertex; i++)
                    for (int j = 0; j < countVertex; j++)
                    {
                        dataGridView.Rows[i].Cells[j + 1].Value = "";
                        if (i == j) dataGridView.Rows[i].Cells[j + 1].Style.BackColor = Color.Coral;
                    }
            }
            catch
            {
                MessageBox.Show("Некоректный ввод");
            }
        }

        private void btnMirror_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] graph = new int[countVertex, countVertex];
                for (int i = 0; i < graph.GetLength(0); i++)
                    for (int j = 0; j < graph.GetLength(1); j++)
                    {
                        string cell = dgvBefore.Rows[i].Cells[j + 1].Value.ToString();
                        try { if (cell != "" && i != j) graph[i, j] = int.Parse(cell); }
                        catch { graph[i, j] = 0; }
                    }


                for (int i = 0; i < graph.GetLength(0); i++)
                    for (int j = 0; j < graph.GetLength(1); j++)
                    {
                        if (graph[i, j] > graph[j, i] && graph[j, i] != 0)
                            graph[i, j] = graph[j, i];
                        else if (graph[i, j] != 0)
                            graph[j, i] = graph[i, j];
                    }
                for (int i = 0; i < graph.GetLength(0); i++)
                    for (int j = 0; j < graph.GetLength(1); j++)
                        dgvBefore.Rows[i].Cells[j + 1].Value = graph[i, j].ToString();
            }
            catch
            {
                if (txtCountVertex.Text == "")
                    MessageBox.Show("Не введен размер графа");
            }
        }
    }
}
