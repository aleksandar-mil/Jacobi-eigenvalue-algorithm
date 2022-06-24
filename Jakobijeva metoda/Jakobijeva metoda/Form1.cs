using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jakobijeva_metoda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Label[] array;
        double[,] H;
        int n=0,k=0,l=0;
        int t;

        private void PostaviDataGridView(DataGridView dgv)
        {
            double w = 30, h = 30;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.ColumnHeadersVisible = false;
            dgv.RowHeadersVisible = false;
            dgv.ScrollBars = ScrollBars.None;
            dgv.RowCount = n;
            dgv.ColumnCount = n;
            dgv.Height = (int)(h * n) + 3;
            dgv.Width = (int)(w * n) + 3;

            for (int i = 0; i < n; i++)
            {
                dgv.Rows[i].Height = (int)h;
            }
            for (int j = 0; j < n; j++)
            {
                dgv.Columns[j].Width = (int)w;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dgv[j, i].Value = 0;
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            n = (int)numericUpDown1.Value;
            H = new double[n, n];
            PostaviDataGridView(dataGridView1);
        }

        private double MaxOffDiagonal(double[,] S)
        {
            double maxx = 0;

            for (int i=0; i<n-1; i++)
            {
                for(int j=i+1; j<n; j++)
                {
                    if(Math.Abs(S[i,j]) > maxx)
                    {
                        maxx = Math.Abs(S[i, j]);
                        k = Math.Max(i,j);
                        l = i+j-k;
                    }
                }
            }

            return maxx;
        }

        private double[,] Givens_Rotation_Matrix(double[,] S)
        {
            MaxOffDiagonal(S);
            
            double phi;
            double[,] G = new double[n,n];

            if (S[k, k] - S[l, l]<=Math.Abs(S[k,k]*0.0001)) phi = Math.PI / 4;
            else phi = Math.Atan(2*S[k,l] / (S[l, l] - S[k, k]))/2;

            G = new double[n, n];

            for(int i=0; i<n; i++)
            {
                for(int j=0; j<n; j++)
                {
                    if (i == j) G[i, j] = 1;
                    else G[i, j] = 0;
                }
            }

            G[k, k] = G[l, l] = Math.Round(Math.Cos(phi),9);
            G[k, l] = Math.Round(Math.Sin(phi),9);
            G[l, k] = Math.Round(-Math.Sin(phi),9);

            return G;
        }

        private double[,] Transponse(double[,] G)
        {
            double[,] tg = new double[n, n];

            for(int i=0; i<n; i++)
            {
                for(int j=0; j<n; j++)
                {
                    tg[i, j] = G[j, i];
                }
            }

            return tg;
        }

        private double[,] Multiply(double[,] A, double[,] B)
        {
            double[,] res = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    double rest = 0;

                    for (int p = 0; p < n; p++)
                    {
                        rest += A[i, p] * B[p, j];
                    }
                    
                    res[i, j] = Math.Round(rest,5);
                }
            }

            return res;
        }
        private double[,] Step(double[,] S)
        {
            double[,] G = Givens_Rotation_Matrix(S);
            double[,] TG = Transponse(G);
            double[,] P = Multiply(TG, S);

            return Multiply(P, G);
        }

        private void end(double[,] S)
        {
            for(int i=0; i<n; i++)
            {
                array[i].Visible = true;
                array[i].Text = "λ" + i + " = " + S[i, i];
            }
        }

        private void UpdateDGV(DataGridView dgv, double[,] M)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dgv[j, i].Value = M[i, j];
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StepByStep.Visible = false;
            DoForT.Visible = false;
            MatrixH.Visible = false;
            Givens.Visible = false;
            TransponseGivens.Visible = false;
            label3.Visible = false;
        }

        private void SetMatrixH_Click(object sender, EventArgs e)
        {
            StepByStep.Visible = true;
            DoForT.Visible = true;
            MatrixH.Visible = true;
            Givens.Visible = true;
            TransponseGivens.Visible = true;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    H[i, j] = Convert.ToDouble(dataGridView1[j, i].Value);
                }
            }

            int top = 15, left = n * 30 + 15;

            array = new Label[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = new Label();
                this.Controls.Add(array[i]);
                array[i].Top = top;
                array[i].Left = left;
                array[i].Visible = false;
                top += 30;
            }

            MaxOffDiagonal(H);
        }

        private void MatrixH_Click(object sender, EventArgs e)
        {
            UpdateDGV(dataGridView1, H);
        }

        private void Givens_Click(object sender, EventArgs e)
        {
            double[,] G = Givens_Rotation_Matrix(H);

            UpdateDGV(dataGridView1, G);

            label3.Text = k + " " + l + " " + H[k, l];
        }

        private void DoForT_Click(object sender, EventArgs e)
        {
            t = int.Parse(textBox1.Text);
            
            for(int i=0; i<t; i++)
            {
                H = Step(H);
            }

            UpdateDGV(dataGridView1,H);
        }

        private void TransponseGivens_Click(object sender, EventArgs e)
        {
            double[,] TG = Transponse(Givens_Rotation_Matrix(H));

            UpdateDGV(dataGridView1, TG);
        }

        private void StepByStep_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            H = Step(H);
            UpdateDGV(dataGridView1, H);
            end(H);
        }
    }
}
