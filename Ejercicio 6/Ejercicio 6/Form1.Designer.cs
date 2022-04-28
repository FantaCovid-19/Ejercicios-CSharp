namespace Ejercicio_6
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCuotas = new System.Windows.Forms.NumericUpDown();
            this.BtnNext = new System.Windows.Forms.Button();
            this.RBtnTaxTrue = new System.Windows.Forms.RadioButton();
            this.RBtnTaxFalse = new System.Windows.Forms.RadioButton();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtMonto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RBtnFireTrue = new System.Windows.Forms.RadioButton();
            this.RBtnFireFalse = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCuotas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(216, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "UF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cuotas";
            // 
            // TxtCuotas
            // 
            this.TxtCuotas.Location = new System.Drawing.Point(90, 70);
            this.TxtCuotas.Name = "TxtCuotas";
            this.TxtCuotas.Size = new System.Drawing.Size(120, 20);
            this.TxtCuotas.TabIndex = 6;
            // 
            // BtnNext
            // 
            this.BtnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnNext.Location = new System.Drawing.Point(67, 217);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(87, 28);
            this.BtnNext.TabIndex = 7;
            this.BtnNext.Text = "Siguiente";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // RBtnTaxTrue
            // 
            this.RBtnTaxTrue.AutoSize = true;
            this.RBtnTaxTrue.Location = new System.Drawing.Point(75, 19);
            this.RBtnTaxTrue.Name = "RBtnTaxTrue";
            this.RBtnTaxTrue.Size = new System.Drawing.Size(39, 20);
            this.RBtnTaxTrue.TabIndex = 8;
            this.RBtnTaxTrue.TabStop = true;
            this.RBtnTaxTrue.Text = "Si";
            this.RBtnTaxTrue.UseVisualStyleBackColor = true;
            // 
            // RBtnTaxFalse
            // 
            this.RBtnTaxFalse.AutoSize = true;
            this.RBtnTaxFalse.Location = new System.Drawing.Point(144, 19);
            this.RBtnTaxFalse.Name = "RBtnTaxFalse";
            this.RBtnTaxFalse.Size = new System.Drawing.Size(45, 20);
            this.RBtnTaxFalse.TabIndex = 9;
            this.RBtnTaxFalse.TabStop = true;
            this.RBtnTaxFalse.Text = "No";
            this.RBtnTaxFalse.UseVisualStyleBackColor = true;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(90, 10);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(120, 20);
            this.TxtName.TabIndex = 12;
            // 
            // TxtMonto
            // 
            this.TxtMonto.Location = new System.Drawing.Point(90, 40);
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(120, 20);
            this.TxtMonto.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBtnTaxTrue);
            this.groupBox1.Controls.Add(this.RBtnTaxFalse);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(15, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 47);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Desgravamen";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RBtnFireTrue);
            this.groupBox2.Controls.Add(this.RBtnFireFalse);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(15, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 47);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Incendio";
            // 
            // RBtnFireTrue
            // 
            this.RBtnFireTrue.AutoSize = true;
            this.RBtnFireTrue.Location = new System.Drawing.Point(75, 19);
            this.RBtnFireTrue.Name = "RBtnFireTrue";
            this.RBtnFireTrue.Size = new System.Drawing.Size(39, 20);
            this.RBtnFireTrue.TabIndex = 8;
            this.RBtnFireTrue.TabStop = true;
            this.RBtnFireTrue.Text = "Si";
            this.RBtnFireTrue.UseVisualStyleBackColor = true;
            // 
            // RBtnFireFalse
            // 
            this.RBtnFireFalse.AutoSize = true;
            this.RBtnFireFalse.Location = new System.Drawing.Point(144, 19);
            this.RBtnFireFalse.Name = "RBtnFireFalse";
            this.RBtnFireFalse.Size = new System.Drawing.Size(45, 20);
            this.RBtnFireFalse.TabIndex = 9;
            this.RBtnFireFalse.TabStop = true;
            this.RBtnFireFalse.Text = "No";
            this.RBtnFireFalse.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 254);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtMonto);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.TxtCuotas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtCuotas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown TxtCuotas;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.RadioButton RBtnTaxTrue;
        private System.Windows.Forms.RadioButton RBtnTaxFalse;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtMonto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RBtnFireTrue;
        private System.Windows.Forms.RadioButton RBtnFireFalse;
    }
}

