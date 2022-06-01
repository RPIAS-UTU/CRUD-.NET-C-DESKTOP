namespace Vista
{
    partial class frmDirectores
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mtxtCredencial = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnObtenerCedula = new System.Windows.Forms.Button();
            this.mtxtFecha = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.mtxtCedula = new System.Windows.Forms.MaskedTextBox();
            this.btnObtenerFecha = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCrearDirector = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCrearAlumno = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.01398F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.98602F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tableLayoutPanel1.Controls.Add(this.mtxtCredencial, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label10, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnObtenerCedula, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.mtxtFecha, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtSegundoApellido, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtSueldo, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCedula, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPrimerNombre, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSegundoNombre, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPrimerApellido, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.mtxtCedula, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnObtenerFecha, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.button1, 4, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.29412F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.70588F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 192);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // mtxtCredencial
            // 
            this.mtxtCredencial.Location = new System.Drawing.Point(603, 82);
            this.mtxtCredencial.Mask = "LLL-#####";
            this.mtxtCredencial.Name = "mtxtCredencial";
            this.mtxtCredencial.Size = new System.Drawing.Size(100, 20);
            this.mtxtCredencial.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(603, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Credencial con mascaras";
            // 
            // btnObtenerCedula
            // 
            this.btnObtenerCedula.Location = new System.Drawing.Point(292, 115);
            this.btnObtenerCedula.Name = "btnObtenerCedula";
            this.btnObtenerCedula.Size = new System.Drawing.Size(126, 23);
            this.btnObtenerCedula.TabIndex = 2;
            this.btnObtenerCedula.Text = "Obtener Cédula";
            this.btnObtenerCedula.UseVisualStyleBackColor = true;
            this.btnObtenerCedula.Click += new System.EventHandler(this.btnObtenerCedula_Click);
            // 
            // mtxtFecha
            // 
            this.mtxtFecha.Location = new System.Drawing.Point(443, 82);
            this.mtxtFecha.Mask = "00/00/0000";
            this.mtxtFecha.Name = "mtxtFecha";
            this.mtxtFecha.Size = new System.Drawing.Size(100, 20);
            this.mtxtFecha.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(443, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Fechas con mascaras";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(292, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cédula con mascaras";
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Location = new System.Drawing.Point(603, 23);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(94, 20);
            this.txtSegundoApellido.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cédula";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(107, 82);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(94, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(3, 82);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(98, 20);
            this.txtSueldo.TabIndex = 4;
            this.txtSueldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Edad";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(3, 23);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(94, 20);
            this.txtCedula.TabIndex = 2;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sueldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Primer Nombre";
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Location = new System.Drawing.Point(107, 23);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(94, 20);
            this.txtPrimerNombre.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(603, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Segundo apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Segundo Nombre";
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Location = new System.Drawing.Point(292, 23);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(94, 20);
            this.txtSegundoNombre.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Primer Apellido";
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Location = new System.Drawing.Point(443, 23);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(94, 20);
            this.txtPrimerApellido.TabIndex = 11;
            // 
            // mtxtCedula
            // 
            this.mtxtCedula.Location = new System.Drawing.Point(292, 82);
            this.mtxtCedula.Mask = "##.###.###-#";
            this.mtxtCedula.Name = "mtxtCedula";
            this.mtxtCedula.Size = new System.Drawing.Size(100, 20);
            this.mtxtCedula.TabIndex = 14;
            this.mtxtCedula.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtCedula_KeyPress);
            // 
            // btnObtenerFecha
            // 
            this.btnObtenerFecha.Location = new System.Drawing.Point(443, 115);
            this.btnObtenerFecha.Name = "btnObtenerFecha";
            this.btnObtenerFecha.Size = new System.Drawing.Size(126, 23);
            this.btnObtenerFecha.TabIndex = 18;
            this.btnObtenerFecha.Text = "Obtener Fecha";
            this.btnObtenerFecha.UseVisualStyleBackColor = true;
            this.btnObtenerFecha.Click += new System.EventHandler(this.btnObtenerFecha_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(603, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Obtener Credencial";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCrearAlumno);
            this.groupBox2.Controls.Add(this.btnCrearDirector);
            this.groupBox2.Location = new System.Drawing.Point(16, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(772, 79);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // btnCrearDirector
            // 
            this.btnCrearDirector.Location = new System.Drawing.Point(11, 32);
            this.btnCrearDirector.Name = "btnCrearDirector";
            this.btnCrearDirector.Size = new System.Drawing.Size(163, 23);
            this.btnCrearDirector.TabIndex = 0;
            this.btnCrearDirector.Text = "Crear Director y Profesor";
            this.btnCrearDirector.UseVisualStyleBackColor = true;
            this.btnCrearDirector.Click += new System.EventHandler(this.btnCrearDirector_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 327);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(770, 166);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnCrearAlumno
            // 
            this.btnCrearAlumno.Location = new System.Drawing.Point(180, 32);
            this.btnCrearAlumno.Name = "btnCrearAlumno";
            this.btnCrearAlumno.Size = new System.Drawing.Size(163, 23);
            this.btnCrearAlumno.TabIndex = 1;
            this.btnCrearAlumno.Text = "Crear Alumno";
            this.btnCrearAlumno.UseVisualStyleBackColor = true;
            this.btnCrearAlumno.Click += new System.EventHandler(this.btnCrearAlumno_Click);
            // 
            // frmDirectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDirectores";
            this.Text = "Mantenimiento de Directores";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label label2;


        private bool ValidarEntradaNumerica(string enviado, char valor, char permitido)
        {
            bool salida = false;
            if (!char.IsControl(valor) && !char.IsDigit(valor) && (valor != permitido))
                salida = true;

            // Solamente permite un punto decimal
            if ((valor == permitido) && (enviado.IndexOf(permitido) > -1))
                salida = true;

            return salida;

        }

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mtxtCedula;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mtxtFecha;
        private System.Windows.Forms.MaskedTextBox mtxtCredencial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnObtenerCedula;
        private System.Windows.Forms.Button btnObtenerFecha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCrearDirector;
        private System.Windows.Forms.Button btnCrearAlumno;
    }




}

