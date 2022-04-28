namespace Ejercicio_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.BtnSum = new System.Windows.Forms.Button();
            this.BtnRest = new System.Windows.Forms.Button();
            this.BtnMulti = new System.Windows.Forms.Button();
            this.BtnDiv = new System.Windows.Forms.Button();
            this.BtnPor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2:";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(145, 9);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(163, 20);
            this.txtNum1.TabIndex = 2;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(145, 46);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(163, 20);
            this.txtNum2.TabIndex = 3;
            // 
            // BtnSum
            // 
            this.BtnSum.Location = new System.Drawing.Point(379, 9);
            this.BtnSum.Name = "BtnSum";
            this.BtnSum.Size = new System.Drawing.Size(75, 20);
            this.BtnSum.TabIndex = 4;
            this.BtnSum.Text = "Sumar";
            this.BtnSum.UseVisualStyleBackColor = true;
            this.BtnSum.Click += new System.EventHandler(this.BtnSum_Click);
            // 
            // BtnRest
            // 
            this.BtnRest.Location = new System.Drawing.Point(379, 43);
            this.BtnRest.Name = "BtnRest";
            this.BtnRest.Size = new System.Drawing.Size(75, 23);
            this.BtnRest.TabIndex = 5;
            this.BtnRest.Text = "Restar";
            this.BtnRest.UseVisualStyleBackColor = true;
            this.BtnRest.Click += new System.EventHandler(this.BtnRest_Click);
            // 
            // BtnMulti
            // 
            this.BtnMulti.Location = new System.Drawing.Point(379, 81);
            this.BtnMulti.Name = "BtnMulti";
            this.BtnMulti.Size = new System.Drawing.Size(75, 23);
            this.BtnMulti.TabIndex = 6;
            this.BtnMulti.Text = "Multiplicar";
            this.BtnMulti.UseVisualStyleBackColor = true;
            this.BtnMulti.Click += new System.EventHandler(this.BtnMulti_Click);
            // 
            // BtnDiv
            // 
            this.BtnDiv.Location = new System.Drawing.Point(379, 120);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(75, 23);
            this.BtnDiv.TabIndex = 7;
            this.BtnDiv.Text = "Dividir";
            this.BtnDiv.UseVisualStyleBackColor = true;
            this.BtnDiv.Click += new System.EventHandler(this.BtnDiv_Click);
            // 
            // BtnPor
            // 
            this.BtnPor.Location = new System.Drawing.Point(379, 159);
            this.BtnPor.Name = "BtnPor";
            this.BtnPor.Size = new System.Drawing.Size(75, 23);
            this.BtnPor.TabIndex = 8;
            this.BtnPor.Text = "Resto";
            this.BtnPor.UseVisualStyleBackColor = true;
            this.BtnPor.Click += new System.EventHandler(this.BtnPor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Resultado:";
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtTotal.Location = new System.Drawing.Point(182, 81);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(90, 20);
            this.txtTotal.TabIndex = 10;
            this.txtTotal.Text = "None Text";
            this.txtTotal.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 204);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnPor);
            this.Controls.Add(this.BtnDiv);
            this.Controls.Add(this.BtnMulti);
            this.Controls.Add(this.BtnRest);
            this.Controls.Add(this.BtnSum);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button BtnSum;
        private System.Windows.Forms.Button BtnRest;
        private System.Windows.Forms.Button BtnMulti;
        private System.Windows.Forms.Button BtnDiv;
        private System.Windows.Forms.Button BtnPor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtTotal;
    }
}

