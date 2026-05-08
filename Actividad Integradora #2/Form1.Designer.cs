namespace Actividad_Integradora__2
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
            lblComisionComun = new Label();
            lblComisionPremiumBase = new Label();
            lblComisionPremiumExcedente = new Label();
            lblComisionTotal = new Label();
            lblTotalInvertido = new Label();
            dgvInversiones = new DataGridView();
            dgvAcciones = new DataGridView();
            dgvInversores = new DataGridView();
            legajo = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            dni = new DataGridViewTextBoxColumn();
            tipo = new DataGridViewTextBoxColumn();
            TotalInvertido = new DataGridViewTextBoxColumn();
            btnModificarA = new Button();
            btnBorrarA = new Button();
            btnAgregarA = new Button();
            btnModificarI = new Button();
            btnBorrarI = new Button();
            btnAgregarI = new Button();
            btnComprar = new Button();
            btnVender = new Button();
            label1 = new Label();
            lblCodigoPartes = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInversiones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAcciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInversores).BeginInit();
            SuspendLayout();
            // 
            // lblComisionComun
            // 
            lblComisionComun.AutoSize = true;
            lblComisionComun.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComisionComun.Location = new Point(799, 492);
            lblComisionComun.Name = "lblComisionComun";
            lblComisionComun.Size = new Size(171, 28);
            lblComisionComun.TabIndex = 0;
            lblComisionComun.Text = "Comision Comun";
            // 
            // lblComisionPremiumBase
            // 
            lblComisionPremiumBase.AutoSize = true;
            lblComisionPremiumBase.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComisionPremiumBase.Location = new Point(799, 521);
            lblComisionPremiumBase.Name = "lblComisionPremiumBase";
            lblComisionPremiumBase.Size = new Size(240, 28);
            lblComisionPremiumBase.TabIndex = 1;
            lblComisionPremiumBase.Text = "Comision Premium Base";
            // 
            // lblComisionPremiumExcedente
            // 
            lblComisionPremiumExcedente.AutoSize = true;
            lblComisionPremiumExcedente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComisionPremiumExcedente.Location = new Point(799, 549);
            lblComisionPremiumExcedente.Name = "lblComisionPremiumExcedente";
            lblComisionPremiumExcedente.Size = new Size(293, 28);
            lblComisionPremiumExcedente.TabIndex = 2;
            lblComisionPremiumExcedente.Text = "Comision Premium Excedente";
            // 
            // lblComisionTotal
            // 
            lblComisionTotal.AutoSize = true;
            lblComisionTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComisionTotal.Location = new Point(799, 577);
            lblComisionTotal.Name = "lblComisionTotal";
            lblComisionTotal.Size = new Size(152, 28);
            lblComisionTotal.TabIndex = 3;
            lblComisionTotal.Text = "Comision Total";
            // 
            // lblTotalInvertido
            // 
            lblTotalInvertido.AutoSize = true;
            lblTotalInvertido.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalInvertido.Location = new Point(799, 605);
            lblTotalInvertido.Name = "lblTotalInvertido";
            lblTotalInvertido.Size = new Size(152, 28);
            lblTotalInvertido.TabIndex = 4;
            lblTotalInvertido.Text = "Total Invertido";
            // 
            // dgvInversiones
            // 
            dgvInversiones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInversiones.Location = new Point(450, 107);
            dgvInversiones.Name = "dgvInversiones";
            dgvInversiones.RowHeadersWidth = 51;
            dgvInversiones.Size = new Size(300, 324);
            dgvInversiones.TabIndex = 5;
            // 
            // dgvAcciones
            // 
            dgvAcciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAcciones.Location = new Point(874, 107);
            dgvAcciones.Name = "dgvAcciones";
            dgvAcciones.RowHeadersWidth = 51;
            dgvAcciones.Size = new Size(300, 324);
            dgvAcciones.TabIndex = 6;
            // 
            // dgvInversores
            // 
            dgvInversores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInversores.Columns.AddRange(new DataGridViewColumn[] { legajo, nombre, apellido, dni, tipo, TotalInvertido });
            dgvInversores.Location = new Point(37, 107);
            dgvInversores.Name = "dgvInversores";
            dgvInversores.ReadOnly = true;
            dgvInversores.RowHeadersWidth = 51;
            dgvInversores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInversores.Size = new Size(289, 324);
            dgvInversores.TabIndex = 7;
            // 
            // legajo
            // 
            legajo.DataPropertyName = "Legajo";
            legajo.HeaderText = "Legajo";
            legajo.MinimumWidth = 6;
            legajo.Name = "legajo";
            legajo.ReadOnly = true;
            legajo.Width = 125;
            // 
            // nombre
            // 
            nombre.DataPropertyName = "Nombre";
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 125;
            // 
            // apellido
            // 
            apellido.DataPropertyName = "Apellido";
            apellido.HeaderText = "Apellido";
            apellido.MinimumWidth = 6;
            apellido.Name = "apellido";
            apellido.ReadOnly = true;
            apellido.Width = 125;
            // 
            // dni
            // 
            dni.DataPropertyName = "DNI";
            dni.HeaderText = "DNI";
            dni.MinimumWidth = 6;
            dni.Name = "dni";
            dni.ReadOnly = true;
            dni.Width = 125;
            // 
            // tipo
            // 
            tipo.DataPropertyName = "Tipo";
            tipo.HeaderText = "Tipo";
            tipo.MinimumWidth = 6;
            tipo.Name = "tipo";
            tipo.ReadOnly = true;
            tipo.Width = 125;
            // 
            // TotalInvertido
            // 
            TotalInvertido.DataPropertyName = "TotalInvertido";
            TotalInvertido.HeaderText = "Total Invertido";
            TotalInvertido.MinimumWidth = 6;
            TotalInvertido.Name = "TotalInvertido";
            TotalInvertido.ReadOnly = true;
            TotalInvertido.Width = 125;
            // 
            // btnModificarA
            // 
            btnModificarA.Location = new Point(283, 617);
            btnModificarA.Name = "btnModificarA";
            btnModificarA.Size = new Size(140, 57);
            btnModificarA.TabIndex = 8;
            btnModificarA.Text = "Modificar Accion";
            btnModificarA.UseVisualStyleBackColor = true;
            btnModificarA.Click += btnModificarA_Click;
            // 
            // btnBorrarA
            // 
            btnBorrarA.Location = new Point(283, 534);
            btnBorrarA.Name = "btnBorrarA";
            btnBorrarA.Size = new Size(140, 57);
            btnBorrarA.TabIndex = 9;
            btnBorrarA.Text = "Borrar Accion";
            btnBorrarA.UseVisualStyleBackColor = true;
            btnBorrarA.Click += btnBorrarA_Click;
            // 
            // btnAgregarA
            // 
            btnAgregarA.Location = new Point(283, 456);
            btnAgregarA.Name = "btnAgregarA";
            btnAgregarA.Size = new Size(140, 57);
            btnAgregarA.TabIndex = 10;
            btnAgregarA.Text = "Agregar Accion";
            btnAgregarA.UseVisualStyleBackColor = true;
            btnAgregarA.Click += btnAgregarA_Click;
            // 
            // btnModificarI
            // 
            btnModificarI.Location = new Point(60, 617);
            btnModificarI.Name = "btnModificarI";
            btnModificarI.Size = new Size(140, 57);
            btnModificarI.TabIndex = 11;
            btnModificarI.Text = "Modificar Inversor";
            btnModificarI.UseVisualStyleBackColor = true;
            btnModificarI.Click += btnModificarI_Click;
            // 
            // btnBorrarI
            // 
            btnBorrarI.Location = new Point(49, 534);
            btnBorrarI.Name = "btnBorrarI";
            btnBorrarI.Size = new Size(140, 57);
            btnBorrarI.TabIndex = 12;
            btnBorrarI.Text = "Borrar Inversor";
            btnBorrarI.UseVisualStyleBackColor = true;
            btnBorrarI.Click += btnBorrarI_Click;
            // 
            // btnAgregarI
            // 
            btnAgregarI.Location = new Point(60, 456);
            btnAgregarI.Name = "btnAgregarI";
            btnAgregarI.Size = new Size(140, 57);
            btnAgregarI.TabIndex = 13;
            btnAgregarI.Text = "Agregar inversor";
            btnAgregarI.UseVisualStyleBackColor = true;
            btnAgregarI.Click += btnAgregarI_Click;
            // 
            // btnComprar
            // 
            btnComprar.Location = new Point(480, 492);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(140, 57);
            btnComprar.TabIndex = 14;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = true;
            btnComprar.Click += btnComprar_Click;
            // 
            // btnVender
            // 
            btnVender.Location = new Point(480, 597);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(140, 57);
            btnVender.TabIndex = 15;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = true;
            btnVender.Click += btnVender_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(543, 9);
            label1.Name = "label1";
            label1.Size = new Size(162, 32);
            label1.TabIndex = 16;
            label1.Text = "INVEST S.A";
            // 
            // lblCodigoPartes
            // 
            lblCodigoPartes.AutoSize = true;
            lblCodigoPartes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigoPartes.Location = new Point(799, 633);
            lblCodigoPartes.Name = "lblCodigoPartes";
            lblCodigoPartes.Size = new Size(177, 28);
            lblCodigoPartes.TabIndex = 17;
            lblCodigoPartes.Text = "Partes del codigo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 763);
            Controls.Add(lblCodigoPartes);
            Controls.Add(label1);
            Controls.Add(btnVender);
            Controls.Add(btnComprar);
            Controls.Add(btnAgregarI);
            Controls.Add(btnBorrarI);
            Controls.Add(btnModificarI);
            Controls.Add(btnAgregarA);
            Controls.Add(btnBorrarA);
            Controls.Add(btnModificarA);
            Controls.Add(dgvInversores);
            Controls.Add(dgvAcciones);
            Controls.Add(dgvInversiones);
            Controls.Add(lblTotalInvertido);
            Controls.Add(lblComisionTotal);
            Controls.Add(lblComisionPremiumExcedente);
            Controls.Add(lblComisionPremiumBase);
            Controls.Add(lblComisionComun);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInversiones).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAcciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInversores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblComisionComun;
        private Label lblComisionPremiumBase;
        private Label lblComisionPremiumExcedente;
        private Label lblComisionTotal;
        private Label lblTotalInvertido;
        private DataGridView dgvInversiones;
        private DataGridView dgvAcciones;
        private DataGridView dgvInversores;
        private Button btnModificarA;
        private Button btnBorrarA;
        private Button btnAgregarA;
        private Button btnModificarI;
        private Button btnBorrarI;
        private Button btnAgregarI;
        private Button btnComprar;
        private Button btnVender;
        private DataGridViewTextBoxColumn legajo;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn tipo;
        private DataGridViewTextBoxColumn TotalInvertido;
        private Label label1;
        private Label lblCodigoPartes;
    }
}
