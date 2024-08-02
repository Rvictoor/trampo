namespace trampo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbvalor1 = new TextBox();
            tbvalor2 = new TextBox();
            lblvalor1 = new Label();
            lblvalor2 = new Label();
            lbtotal = new Label();
            lbresultado = new Label();
            SuspendLayout();
            // 
            // tbvalor1
            // 
            tbvalor1.Location = new Point(103, 106);
            tbvalor1.Name = "tbvalor1";
            tbvalor1.Size = new Size(100, 23);
            tbvalor1.TabIndex = 0;
            // 
            // tbvalor2
            // 
            tbvalor2.Location = new Point(103, 149);
            tbvalor2.Name = "tbvalor2";
            tbvalor2.Size = new Size(100, 23);
            tbvalor2.TabIndex = 1;
            // 
            // lblvalor1
            // 
            lblvalor1.AutoSize = true;
            lblvalor1.Location = new Point(42, 109);
            lblvalor1.Name = "lblvalor1";
            lblvalor1.Size = new Size(39, 15);
            lblvalor1.TabIndex = 2;
            lblvalor1.Text = "Valor1";
            // 
            // lblvalor2
            // 
            lblvalor2.AutoSize = true;
            lblvalor2.Location = new Point(42, 152);
            lblvalor2.Name = "lblvalor2";
            lblvalor2.Size = new Size(39, 15);
            lblvalor2.TabIndex = 3;
            lblvalor2.Text = "Valor2";
            // 
            // lbtotal
            // 
            lbtotal.AutoSize = true;
            lbtotal.Location = new Point(42, 205);
            lbtotal.Name = "lbtotal";
            lbtotal.Size = new Size(32, 15);
            lbtotal.TabIndex = 4;
            lbtotal.Text = "Total";
            // 
            // lbresultado
            // 
            lbresultado.AutoSize = true;
            lbresultado.Location = new Point(103, 205);
            lbresultado.Name = "lbresultado";
            lbresultado.Size = new Size(16, 15);
            lbresultado.TabIndex = 5;
            lbresultado.Text = "...";
            lbresultado.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbresultado);
            Controls.Add(lbtotal);
            Controls.Add(lblvalor2);
            Controls.Add(lblvalor1);
            Controls.Add(tbvalor2);
            Controls.Add(tbvalor1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbvalor1;
        private TextBox tbvalor2;
        private Label lblvalor1;
        private Label lblvalor2;
        private Label lbtotal;
        private Label lbresultado;
    }
}
