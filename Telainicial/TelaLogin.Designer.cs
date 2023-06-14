namespace Telainicial
{
    partial class TelaLogin
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
            usariotxt = new Label();
            senhatxt = new Label();
            textusuario = new TextBox();
            textsenha = new TextBox();
            btsalvar = new Button();
            SuspendLayout();
            // 
            // usariotxt
            // 
            usariotxt.AutoSize = true;
            usariotxt.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            usariotxt.Location = new Point(193, 181);
            usariotxt.Name = "usariotxt";
            usariotxt.Size = new Size(67, 21);
            usariotxt.TabIndex = 0;
            usariotxt.Text = "Usúario";
            // 
            // senhatxt
            // 
            senhatxt.AutoSize = true;
            senhatxt.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            senhatxt.Location = new Point(203, 223);
            senhatxt.Name = "senhatxt";
            senhatxt.Size = new Size(57, 21);
            senhatxt.TabIndex = 1;
            senhatxt.Text = "Senha ";
            // 
            // textusuario
            // 
            textusuario.Location = new Point(268, 183);
            textusuario.Name = "textusuario";
            textusuario.Size = new Size(254, 23);
            textusuario.TabIndex = 2;
            // 
            // textsenha
            // 
            textsenha.Location = new Point(268, 221);
            textsenha.Name = "textsenha";
            textsenha.Size = new Size(254, 23);
            textsenha.TabIndex = 3;
            // 
            // btsalvar
            // 
            btsalvar.Location = new Point(333, 285);
            btsalvar.Name = "btsalvar";
            btsalvar.Size = new Size(111, 45);
            btsalvar.TabIndex = 4;
            btsalvar.Text = "Salvar";
            btsalvar.UseVisualStyleBackColor = true;
            btsalvar.Click += btsalvar_Click;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btsalvar);
            Controls.Add(textsenha);
            Controls.Add(textusuario);
            Controls.Add(senhatxt);
            Controls.Add(usariotxt);
            Name = "TelaLogin";
            Text = "TelaLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label usariotxt;
        private Label senhatxt;
        private TextBox textusuario;
        private TextBox textsenha;
        private Button btsalvar;
    }
}