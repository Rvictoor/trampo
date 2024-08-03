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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txvalor1 = new TextBox();
            txvalor2 = new TextBox();
            lblvalor1 = new Label();
            lblvalor2 = new Label();
            lbtotal = new Label();
            lbresultado = new Label();
            btnsoma = new Button();
            btnmultiplicacao = new Button();
            btnsub = new Button();
            SuspendLayout();
            // 
            // txvalor1
            // 
            txvalor1.Location = new Point(103, 106);
            txvalor1.Name = "txvalor1";
            txvalor1.Size = new Size(100, 23);
            txvalor1.TabIndex = 0;
            // 
            // txvalor2
            // 
            txvalor2.Location = new Point(103, 149);
            txvalor2.Name = "txvalor2";
            txvalor2.Size = new Size(100, 23);
            txvalor2.TabIndex = 1;
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
            lbtotal.Click += lbtotal_Click;
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
            // btnsoma
            // 
            btnsoma.Location = new Point(64, 266);
            btnsoma.Name = "btnsoma";
            btnsoma.Size = new Size(75, 23);
            btnsoma.TabIndex = 6;
            btnsoma.Text = "soma";
            btnsoma.UseVisualStyleBackColor = true;
            btnsoma.Click += btnsoma_Click;
            // 
            // btnmultiplicacao
            // 
            btnmultiplicacao.Location = new Point(217, 266);
            btnmultiplicacao.Name = "btnmultiplicacao";
            btnmultiplicacao.Size = new Size(92, 23);
            btnmultiplicacao.TabIndex = 7;
            btnmultiplicacao.Text = "multiplicacao";
            btnmultiplicacao.UseVisualStyleBackColor = true;
            btnmultiplicacao.Click += btnmultiplicacao_Click;
            // 
            // btnsub
            // 
            btnsub.Location = new Point(366, 269);
            btnsub.Name = "btnsub";
            btnsub.Size = new Size(75, 23);
            btnsub.TabIndex = 8;
            btnsub.Text = "subtracao";
            btnsub.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(641, 450);
            Controls.Add(btnsub);
            Controls.Add(btnmultiplicacao);
            Controls.Add(btnsoma);
            Controls.Add(lbresultado);
            Controls.Add(lbtotal);
            Controls.Add(lblvalor2);
            Controls.Add(lblvalor1);
            Controls.Add(txvalor2);
            Controls.Add(txvalor1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txvalor1;
        private TextBox txvalor2;
        private Label lblvalor1;
        private Label lblvalor2;
        private Label lbtotal;
        private Label lbresultado;
        private Button btnsoma;
        private Button btnmultiplicacao;
        private Button btnsub;
    }
}
