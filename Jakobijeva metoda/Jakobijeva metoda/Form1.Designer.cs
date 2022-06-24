
namespace Jakobijeva_metoda
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DoForT = new System.Windows.Forms.Button();
            this.SetMatrixH = new System.Windows.Forms.Button();
            this.StepByStep = new System.Windows.Forms.Button();
            this.MatrixH = new System.Windows.Forms.Button();
            this.Givens = new System.Windows.Forms.Button();
            this.TransponseGivens = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // DoForT
            // 
            this.DoForT.Location = new System.Drawing.Point(919, 110);
            this.DoForT.Name = "DoForT";
            this.DoForT.Size = new System.Drawing.Size(114, 62);
            this.DoForT.TabIndex = 0;
            this.DoForT.Text = "Do for t";
            this.DoForT.UseVisualStyleBackColor = true;
            this.DoForT.Click += new System.EventHandler(this.DoForT_Click);
            // 
            // SetMatrixH
            // 
            this.SetMatrixH.Location = new System.Drawing.Point(988, 64);
            this.SetMatrixH.Name = "SetMatrixH";
            this.SetMatrixH.Size = new System.Drawing.Size(90, 40);
            this.SetMatrixH.TabIndex = 0;
            this.SetMatrixH.Text = "Set Matrix H";
            this.SetMatrixH.UseVisualStyleBackColor = true;
            this.SetMatrixH.Click += new System.EventHandler(this.SetMatrixH_Click);
            // 
            // StepByStep
            // 
            this.StepByStep.Location = new System.Drawing.Point(1039, 110);
            this.StepByStep.Name = "StepByStep";
            this.StepByStep.Size = new System.Drawing.Size(114, 62);
            this.StepByStep.TabIndex = 0;
            this.StepByStep.Text = "Step by Step";
            this.StepByStep.UseVisualStyleBackColor = true;
            this.StepByStep.Click += new System.EventHandler(this.StepByStep_Click);
            // 
            // MatrixH
            // 
            this.MatrixH.Location = new System.Drawing.Point(963, 178);
            this.MatrixH.Name = "MatrixH";
            this.MatrixH.Size = new System.Drawing.Size(157, 23);
            this.MatrixH.TabIndex = 0;
            this.MatrixH.Text = "Matrix H";
            this.MatrixH.UseVisualStyleBackColor = true;
            this.MatrixH.Click += new System.EventHandler(this.MatrixH_Click);
            // 
            // Givens
            // 
            this.Givens.Location = new System.Drawing.Point(963, 207);
            this.Givens.Name = "Givens";
            this.Givens.Size = new System.Drawing.Size(157, 23);
            this.Givens.TabIndex = 2;
            this.Givens.Text = "Givens";
            this.Givens.UseVisualStyleBackColor = true;
            this.Givens.Click += new System.EventHandler(this.Givens_Click);
            // 
            // TransponseGivens
            // 
            this.TransponseGivens.Location = new System.Drawing.Point(963, 236);
            this.TransponseGivens.Name = "TransponseGivens";
            this.TransponseGivens.Size = new System.Drawing.Size(157, 23);
            this.TransponseGivens.TabIndex = 0;
            this.TransponseGivens.Text = "Transponse Givens";
            this.TransponseGivens.UseVisualStyleBackColor = true;
            this.TransponseGivens.Click += new System.EventHandler(this.TransponseGivens_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1039, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(892, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dimension of matrix (max 20)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(904, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Maximum number of steps";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, -3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(223, 175);
            this.dataGridView1.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(1039, 12);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1015, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 590);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DoForT);
            this.Controls.Add(this.SetMatrixH);
            this.Controls.Add(this.StepByStep);
            this.Controls.Add(this.MatrixH);
            this.Controls.Add(this.Givens);
            this.Controls.Add(this.TransponseGivens);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button DoForT;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StepByStep;
        private System.Windows.Forms.Button MatrixH;
        private System.Windows.Forms.Button Givens;
        private System.Windows.Forms.Button TransponseGivens;
        private System.Windows.Forms.Button SetMatrixH;
        private System.Windows.Forms.Label label3;
    }
}

