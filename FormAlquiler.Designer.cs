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
            this.textBoxNit = new System.Windows.Forms.TextBox();
            this.textBoxPlaca = new System.Windows.Forms.TextBox();
            this.textBoxKmRecorrido = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labelMayorKm = new System.Windows.Forms.Label();
            this.dateTimePickerAlquiler = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDevolucion = new System.Windows.Forms.DateTimePicker();
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
            // textBoxNit
            // 
            this.textBoxNit.Location = new System.Drawing.Point(255, 110);
            this.textBoxNit.Name = "textBoxNit";
            this.textBoxNit.Size = new System.Drawing.Size(424, 22);
            this.textBoxNit.TabIndex = 9;
            // 
            // textBoxPlaca
            // 
            this.textBoxPlaca.Location = new System.Drawing.Point(255, 165);
            this.textBoxPlaca.Name = "textBoxPlaca";
            this.textBoxPlaca.Size = new System.Drawing.Size(424, 22);
            this.textBoxPlaca.TabIndex = 10;
            // 
            // textBoxKmRecorrido
            // 
            this.textBoxKmRecorrido.Location = new System.Drawing.Point(255, 333);
            this.textBoxKmRecorrido.Name = "textBoxKmRecorrido";
            this.textBoxKmRecorrido.Size = new System.Drawing.Size(424, 22);
            this.textBoxKmRecorrido.TabIndex = 12;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "ALQUILER CON MAYOR KM:";
            // 
            // labelMayorKm
            // 
            this.labelMayorKm.AutoSize = true;
            this.labelMayorKm.Location = new System.Drawing.Point(252, 376);
            this.labelMayorKm.Name = "labelMayorKm";
            this.labelMayorKm.Size = new System.Drawing.Size(0, 16);
            this.labelMayorKm.TabIndex = 17;
            // 
            // dateTimePickerAlquiler
            // 
            this.dateTimePickerAlquiler.Location = new System.Drawing.Point(255, 223);
            this.dateTimePickerAlquiler.Name = "dateTimePickerAlquiler";
            this.dateTimePickerAlquiler.Size = new System.Drawing.Size(298, 22);
            this.dateTimePickerAlquiler.TabIndex = 18;
            // 
            // dateTimePickerDevolucion
            // 
            this.dateTimePickerDevolucion.Location = new System.Drawing.Point(255, 280);
            this.dateTimePickerDevolucion.Name = "dateTimePickerDevolucion";
            this.dateTimePickerDevolucion.Size = new System.Drawing.Size(298, 22);
            this.dateTimePickerDevolucion.TabIndex = 19;
            // 
            // FormAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 513);
            this.Controls.Add(this.dateTimePickerDevolucion);
            this.Controls.Add(this.dateTimePickerAlquiler);
            this.Controls.Add(this.labelMayorKm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxKmRecorrido);
            this.Controls.Add(this.textBoxPlaca);
            this.Controls.Add(this.textBoxNit);
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
        private System.Windows.Forms.TextBox textBoxNit;
        private System.Windows.Forms.TextBox textBoxPlaca;
        private System.Windows.Forms.TextBox textBoxKmRecorrido;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelMayorKm;
        private System.Windows.Forms.DateTimePicker dateTimePickerAlquiler;
        private System.Windows.Forms.DateTimePicker dateTimePickerDevolucion;
    }
}