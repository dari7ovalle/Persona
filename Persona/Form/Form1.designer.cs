namespace Persona.Entidad
{
    partial class FormRegistro
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
            this.PersonaIdtextBox = new System.Windows.Forms.TextBox();
            this.NombrestextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TipoTelefonoscomboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TelefonosdataGridView = new System.Windows.Forms.DataGridView();
            this.TipoTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TelefonotextBox = new System.Windows.Forms.TextBox();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.TelefonosdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // PersonaIdtextBox
            // 
            this.PersonaIdtextBox.Location = new System.Drawing.Point(39, 89);
            this.PersonaIdtextBox.Name = "PersonaIdtextBox";
            this.PersonaIdtextBox.Size = new System.Drawing.Size(207, 20);
            this.PersonaIdtextBox.TabIndex = 1;
            // 
            // NombrestextBox
            // 
            this.NombrestextBox.Location = new System.Drawing.Point(38, 135);
            this.NombrestextBox.Name = "NombrestextBox";
            this.NombrestextBox.Size = new System.Drawing.Size(201, 20);
            this.NombrestextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombres:";
            // 
            // TipoTelefonoscomboBox
            // 
            this.TipoTelefonoscomboBox.FormattingEnabled = true;
            this.TipoTelefonoscomboBox.Location = new System.Drawing.Point(252, 135);
            this.TipoTelefonoscomboBox.Name = "TipoTelefonoscomboBox";
            this.TipoTelefonoscomboBox.Size = new System.Drawing.Size(80, 21);
            this.TipoTelefonoscomboBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipos de Telefono:";
            // 
            // TelefonosdataGridView
            // 
            this.TelefonosdataGridView.AllowUserToAddRows = false;
            this.TelefonosdataGridView.AllowUserToDeleteRows = false;
            this.TelefonosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TelefonosdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoTelefono,
            this.Telefono});
            this.TelefonosdataGridView.Location = new System.Drawing.Point(38, 212);
            this.TelefonosdataGridView.Name = "TelefonosdataGridView";
            this.TelefonosdataGridView.ReadOnly = true;
            this.TelefonosdataGridView.Size = new System.Drawing.Size(288, 168);
            this.TelefonosdataGridView.TabIndex = 6;
            // 
            // TipoTelefono
            // 
            this.TipoTelefono.HeaderText = "Telefonos";
            this.TipoTelefono.Name = "TipoTelefono";
            this.TipoTelefono.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "TipoTelefonos";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 140;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(252, 89);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 7;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Registro de Personas";
            // 
            // TelefonotextBox
            // 
            this.TelefonotextBox.Location = new System.Drawing.Point(38, 186);
            this.TelefonotextBox.Name = "TelefonotextBox";
            this.TelefonotextBox.Size = new System.Drawing.Size(120, 20);
            this.TelefonotextBox.TabIndex = 9;
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Location = new System.Drawing.Point(164, 183);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(75, 23);
            this.Agregarbutton.TabIndex = 10;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefonos:";
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(38, 409);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 23);
            this.Nuevobutton.TabIndex = 12;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(146, 409);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 13;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(251, 409);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton.TabIndex = 14;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechadateTimePicker.Location = new System.Drawing.Point(252, 183);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(80, 20);
            this.FechadateTimePicker.TabIndex = 15;
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(379, 458);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(this.TelefonotextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.TelefonosdataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TipoTelefonoscomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NombrestextBox);
            this.Controls.Add(this.PersonaIdtextBox);
            this.Controls.Add(this.label1);
            this.Name = "FormRegistro";
            this.Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)(this.TelefonosdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PersonaIdtextBox;
        private System.Windows.Forms.TextBox NombrestextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TipoTelefonoscomboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView TelefonosdataGridView;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TelefonotextBox;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
    }
}

