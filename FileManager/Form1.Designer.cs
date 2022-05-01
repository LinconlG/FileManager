
namespace FileManager
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
            this.btnExecutar = new System.Windows.Forms.Button();
            this.txtPlanilha = new System.Windows.Forms.TextBox();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPastas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLinhas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(168, 278);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(82, 27);
            this.btnExecutar.TabIndex = 5;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // txtPlanilha
            // 
            this.txtPlanilha.Location = new System.Drawing.Point(9, 89);
            this.txtPlanilha.Name = "txtPlanilha";
            this.txtPlanilha.Size = new System.Drawing.Size(297, 20);
            this.txtPlanilha.TabIndex = 1;
            // 
            // txtArquivo
            // 
            this.txtArquivo.Location = new System.Drawing.Point(9, 158);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(395, 20);
            this.txtArquivo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Caminho da planilha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Caminho onde estão os arquivos";
            // 
            // txtPastas
            // 
            this.txtPastas.Location = new System.Drawing.Point(9, 222);
            this.txtPastas.Name = "txtPastas";
            this.txtPastas.Size = new System.Drawing.Size(395, 20);
            this.txtPastas.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Caminho das pastas";
            // 
            // txtLinhas
            // 
            this.txtLinhas.Location = new System.Drawing.Point(327, 88);
            this.txtLinhas.Name = "txtLinhas";
            this.txtLinhas.Size = new System.Drawing.Size(77, 20);
            this.txtLinhas.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Linhas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 372);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLinhas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPastas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.txtPlanilha);
            this.Controls.Add(this.btnExecutar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.TextBox txtPlanilha;
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPastas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLinhas;
        private System.Windows.Forms.Label label4;
    }
}

