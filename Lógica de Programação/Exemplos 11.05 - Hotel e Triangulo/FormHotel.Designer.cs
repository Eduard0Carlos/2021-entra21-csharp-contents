
namespace PrimeiroProjeto
{
    partial class FormHotel
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
            this.txtQtdPessoas = new System.Windows.Forms.TextBox();
            this.txtQtdDias = new System.Windows.Forms.TextBox();
            this.rdStandart = new System.Windows.Forms.RadioButton();
            this.rdLuxo = new System.Windows.Forms.RadioButton();
            this.rdSuperLuxo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtQtdPessoas
            // 
            this.txtQtdPessoas.Location = new System.Drawing.Point(124, 73);
            this.txtQtdPessoas.Name = "txtQtdPessoas";
            this.txtQtdPessoas.Size = new System.Drawing.Size(100, 20);
            this.txtQtdPessoas.TabIndex = 0;
            // 
            // txtQtdDias
            // 
            this.txtQtdDias.Location = new System.Drawing.Point(124, 128);
            this.txtQtdDias.Name = "txtQtdDias";
            this.txtQtdDias.Size = new System.Drawing.Size(100, 20);
            this.txtQtdDias.TabIndex = 1;
            // 
            // rdStandart
            // 
            this.rdStandart.AutoSize = true;
            this.rdStandart.Location = new System.Drawing.Point(124, 223);
            this.rdStandart.Name = "rdStandart";
            this.rdStandart.Size = new System.Drawing.Size(65, 17);
            this.rdStandart.TabIndex = 2;
            this.rdStandart.TabStop = true;
            this.rdStandart.Text = "Standart";
            this.rdStandart.UseVisualStyleBackColor = true;
            // 
            // rdLuxo
            // 
            this.rdLuxo.AutoSize = true;
            this.rdLuxo.Location = new System.Drawing.Point(124, 257);
            this.rdLuxo.Name = "rdLuxo";
            this.rdLuxo.Size = new System.Drawing.Size(48, 17);
            this.rdLuxo.TabIndex = 3;
            this.rdLuxo.TabStop = true;
            this.rdLuxo.Text = "Luxo";
            this.rdLuxo.UseVisualStyleBackColor = true;
            // 
            // rdSuperLuxo
            // 
            this.rdSuperLuxo.AutoSize = true;
            this.rdSuperLuxo.Location = new System.Drawing.Point(124, 292);
            this.rdSuperLuxo.Name = "rdSuperLuxo";
            this.rdSuperLuxo.Size = new System.Drawing.Size(76, 17);
            this.rdSuperLuxo.TabIndex = 4;
            this.rdSuperLuxo.TabStop = true;
            this.rdSuperLuxo.Text = "SuperLuxo";
            this.rdSuperLuxo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quantidade de pessoas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quantidade de dias";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo de quarto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total: ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(168, 383);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 13);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "lblTotal";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(124, 336);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(85, 23);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // FormHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdSuperLuxo);
            this.Controls.Add(this.rdLuxo);
            this.Controls.Add(this.rdStandart);
            this.Controls.Add(this.txtQtdDias);
            this.Controls.Add(this.txtQtdPessoas);
            this.Name = "FormHotel";
            this.Text = "FormHotel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQtdPessoas;
        private System.Windows.Forms.TextBox txtQtdDias;
        private System.Windows.Forms.RadioButton rdStandart;
        private System.Windows.Forms.RadioButton rdLuxo;
        private System.Windows.Forms.RadioButton rdSuperLuxo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCalcular;
    }
}