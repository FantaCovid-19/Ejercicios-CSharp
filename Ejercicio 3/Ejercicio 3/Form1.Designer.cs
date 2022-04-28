namespace Ejercicio_3
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
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPromedio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(229, 12);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 20);
            this.BtnCalcular.TabIndex = 0;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            this.BtnCalcular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPromedio_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Promedio:";
            // 
            // TxtPromedio
            // 
            this.TxtPromedio.Location = new System.Drawing.Point(112, 12);
            this.TxtPromedio.Name = "TxtPromedio";
            this.TxtPromedio.Size = new System.Drawing.Size(100, 20);
            this.TxtPromedio.TabIndex = 2;
            this.TxtPromedio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPromedio_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resultado:";
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResult.Location = new System.Drawing.Point(109, 43);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(78, 16);
            this.LblResult.TabIndex = 4;
            this.LblResult.Text = "None Text";
            this.LblResult.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.LblResult.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 80);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPromedio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPromedio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblResult;
    }
}

