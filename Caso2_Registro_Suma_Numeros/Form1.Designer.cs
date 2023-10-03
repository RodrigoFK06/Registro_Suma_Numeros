namespace Caso2_Registro_Suma_Numeros
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
            txtNum2 = new TextBox();
            txtNum1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataListado = new DataGridView();
            btnRegistrar_Sumar = new Button();
            btnMostrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataListado).BeginInit();
            SuspendLayout();
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(114, 172);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(121, 23);
            txtNum2.TabIndex = 20;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(114, 122);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(121, 23);
            txtNum1.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 175);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 18;
            label3.Text = "Segundo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 125);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 17;
            label2.Text = "Primero:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(305, 32);
            label1.Name = "label1";
            label1.Size = new Size(235, 21);
            label1.TabIndex = 16;
            label1.Text = "CASO 2 - SUMA DE NUMEROS";
            // 
            // dataListado
            // 
            dataListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataListado.Location = new Point(365, 125);
            dataListado.Name = "dataListado";
            dataListado.RowTemplate.Height = 25;
            dataListado.Size = new Size(389, 188);
            dataListado.TabIndex = 15;
            // 
            // btnRegistrar_Sumar
            // 
            btnRegistrar_Sumar.Location = new Point(41, 251);
            btnRegistrar_Sumar.Name = "btnRegistrar_Sumar";
            btnRegistrar_Sumar.Size = new Size(146, 23);
            btnRegistrar_Sumar.TabIndex = 14;
            btnRegistrar_Sumar.Text = "Registrar y Sumar";
            btnRegistrar_Sumar.UseVisualStyleBackColor = true;
            btnRegistrar_Sumar.Click += btnRegistrar_Sumar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(204, 251);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 21;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 365);
            Controls.Add(btnMostrar);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataListado);
            Controls.Add(btnRegistrar_Sumar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataListado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum2;
        private TextBox txtNum1;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataListado;
        private Button btnRegistrar_Sumar;
        private Button btnMostrar;
    }
}