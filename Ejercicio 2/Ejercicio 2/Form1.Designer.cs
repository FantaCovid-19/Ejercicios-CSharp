namespace Ejercicio_2
{
    partial class Form
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
            this.ComBoxUniversity = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtArancel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carrera:";
            // 
            // ComBoxUniversity
            // 
            this.ComBoxUniversity.FormattingEnabled = true;
            this.ComBoxUniversity.Location = new System.Drawing.Point(100, 15);
            this.ComBoxUniversity.Name = "ComBoxUniversity";
            this.ComBoxUniversity.Size = new System.Drawing.Size(166, 21);
            this.ComBoxUniversity.TabIndex = 1;
            this.ComBoxUniversity.SelectedIndexChanged += new System.EventHandler(this.ComBoxUniversity_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(16, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Arancel:";
            // 
            // TxtArancel
            // 
            this.TxtArancel.Location = new System.Drawing.Point(100, 51);
            this.TxtArancel.Name = "TxtArancel";
            this.TxtArancel.Size = new System.Drawing.Size(166, 20);
            this.TxtArancel.TabIndex = 3;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 280);
            this.Controls.Add(this.TxtArancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComBoxUniversity);
            this.Controls.Add(this.label1);
            this.Name = "Form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComBoxUniversity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtArancel;
    }
}

