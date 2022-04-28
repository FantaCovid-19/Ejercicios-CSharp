namespace Ejercicio_6
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTotPagar = new System.Windows.Forms.TextBox();
            this.TxtValCuotas = new System.Windows.Forms.TextBox();
            this.TxtTotSeguros = new System.Windows.Forms.TextBox();
            this.TxtInteres = new System.Windows.Forms.TextBox();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total a Pagar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor Cuotas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Interes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total Seguros:";
            // 
            // TxtTotPagar
            // 
            this.TxtTotPagar.Location = new System.Drawing.Point(142, 5);
            this.TxtTotPagar.Name = "TxtTotPagar";
            this.TxtTotPagar.ReadOnly = true;
            this.TxtTotPagar.Size = new System.Drawing.Size(100, 20);
            this.TxtTotPagar.TabIndex = 5;
            // 
            // TxtValCuotas
            // 
            this.TxtValCuotas.Location = new System.Drawing.Point(142, 42);
            this.TxtValCuotas.Name = "TxtValCuotas";
            this.TxtValCuotas.ReadOnly = true;
            this.TxtValCuotas.Size = new System.Drawing.Size(100, 20);
            this.TxtValCuotas.TabIndex = 6;
            // 
            // TxtTotSeguros
            // 
            this.TxtTotSeguros.Location = new System.Drawing.Point(142, 109);
            this.TxtTotSeguros.Name = "TxtTotSeguros";
            this.TxtTotSeguros.ReadOnly = true;
            this.TxtTotSeguros.Size = new System.Drawing.Size(100, 20);
            this.TxtTotSeguros.TabIndex = 7;
            // 
            // TxtInteres
            // 
            this.TxtInteres.Location = new System.Drawing.Point(142, 75);
            this.TxtInteres.Name = "TxtInteres";
            this.TxtInteres.ReadOnly = true;
            this.TxtInteres.Size = new System.Drawing.Size(100, 20);
            this.TxtInteres.TabIndex = 8;
            // 
            // BtnNew
            // 
            this.BtnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnNew.Location = new System.Drawing.Point(37, 145);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 9;
            this.BtnNew.Text = "Otro";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnSave.Location = new System.Drawing.Point(155, 145);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 184);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.TxtInteres);
            this.Controls.Add(this.TxtTotSeguros);
            this.Controls.Add(this.TxtValCuotas);
            this.Controls.Add(this.TxtTotPagar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtTotPagar;
        private System.Windows.Forms.TextBox TxtValCuotas;
        private System.Windows.Forms.TextBox TxtTotSeguros;
        private System.Windows.Forms.TextBox TxtInteres;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnSave;
    }
}