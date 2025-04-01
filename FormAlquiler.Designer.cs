namespace sistemaAlquilerAutos
{
    partial class FormAlquiler
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNitAlquiler = new System.Windows.Forms.TextBox();
            this.textBoxPlacaAlquiler = new System.Windows.Forms.TextBox();
            this.textBoxFechaAlquiler = new System.Windows.Forms.TextBox();
            this.textBoxKmRecorrido = new System.Windows.Forms.TextBox();
            this.textBoxFechaDevolucion = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "FECHA ALQUILER:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "FECHA DE DEVOLUCIÓN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "KILOMETROS RECORRIDOS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "PLACA (AUTO ALQUILADO):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "NIT (CLIENTE ALQUILER):";
            // 
            // textBoxNitAlquiler
            // 
            this.textBoxNitAlquiler.Location = new System.Drawing.Point(255, 110);
            this.textBoxNitAlquiler.Name = "textBoxNitAlquiler";
            this.textBoxNitAlquiler.Size = new System.Drawing.Size(424, 22);
            this.textBoxNitAlquiler.TabIndex = 9;
            // 
            // textBoxPlacaAlquiler
            // 
            this.textBoxPlacaAlquiler.Location = new System.Drawing.Point(255, 165);
            this.textBoxPlacaAlquiler.Name = "textBoxPlacaAlquiler";
            this.textBoxPlacaAlquiler.Size = new System.Drawing.Size(424, 22);
            this.textBoxPlacaAlquiler.TabIndex = 10;
            // 
            // textBoxFechaAlquiler
            // 
            this.textBoxFechaAlquiler.Location = new System.Drawing.Point(255, 226);
            this.textBoxFechaAlquiler.Name = "textBoxFechaAlquiler";
            this.textBoxFechaAlquiler.Size = new System.Drawing.Size(424, 22);
            this.textBoxFechaAlquiler.TabIndex = 11;
            // 
            // textBoxKmRecorrido
            // 
            this.textBoxKmRecorrido.Location = new System.Drawing.Point(255, 333);
            this.textBoxKmRecorrido.Name = "textBoxKmRecorrido";
            this.textBoxKmRecorrido.Size = new System.Drawing.Size(424, 22);
            this.textBoxKmRecorrido.TabIndex = 12;
            // 
            // textBoxFechaDevolucion
            // 
            this.textBoxFechaDevolucion.Location = new System.Drawing.Point(255, 283);
            this.textBoxFechaDevolucion.Name = "textBoxFechaDevolucion";
            this.textBoxFechaDevolucion.Size = new System.Drawing.Size(424, 22);
            this.textBoxFechaDevolucion.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(700, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(464, 245);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(700, 361);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(173, 47);
            this.buttonGuardar.TabIndex = 15;
            this.buttonGuardar.Text = "GUARDAR";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // FormAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 450);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxFechaDevolucion);
            this.Controls.Add(this.textBoxKmRecorrido);
            this.Controls.Add(this.textBoxFechaAlquiler);
            this.Controls.Add(this.textBoxPlacaAlquiler);
            this.Controls.Add(this.textBoxNitAlquiler);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "FormAlquiler";
            this.Text = "FormAlquiler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNitAlquiler;
        private System.Windows.Forms.TextBox textBoxPlacaAlquiler;
        private System.Windows.Forms.TextBox textBoxFechaAlquiler;
        private System.Windows.Forms.TextBox textBoxKmRecorrido;
        private System.Windows.Forms.TextBox textBoxFechaDevolucion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonGuardar;
    }
}