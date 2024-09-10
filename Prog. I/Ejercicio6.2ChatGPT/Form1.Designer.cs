namespace Ejercicio6._2ChatGPT
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
            lblInputNombre = new Label();
            lblLegajo = new Label();
            txtLegajo = new TextBox();
            txtNombre = new TextBox();
            lblEdad = new Label();
            txtEdad = new TextBox();
            lblSexo = new Label();
            cboSexo = new ComboBox();
            btnMostrarInfoEstudiante = new Button();
            btnGuardarInfo = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblInputNombre
            // 
            lblInputNombre.AutoSize = true;
            lblInputNombre.Location = new Point(302, 72);
            lblInputNombre.Name = "lblInputNombre";
            lblInputNombre.Size = new Size(182, 15);
            lblInputNombre.TabIndex = 0;
            lblInputNombre.Text = "Ingrese el nombre del estudiante:";
            // 
            // lblLegajo
            // 
            lblLegajo.AutoSize = true;
            lblLegajo.Location = new Point(302, 9);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new Size(13, 15);
            lblLegajo.TabIndex = 1;
            lblLegajo.Text = "c";
            lblLegajo.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new Point(12, 27);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(776, 23);
            txtLegajo.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 91);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(776, 23);
            txtNombre.TabIndex = 3;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(302, 138);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(166, 15);
            lblEdad.TabIndex = 4;
            lblEdad.Text = "Ingrese la edad del estudiante:";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(12, 156);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(776, 23);
            txtEdad.TabIndex = 5;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(302, 206);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(164, 15);
            lblSexo.TabIndex = 6;
            lblSexo.Text = "Ingrese el sexo del estudiante:";
            // 
            // cboSexo
            // 
            cboSexo.FormattingEnabled = true;
            cboSexo.Items.AddRange(new object[] { "M", "F", "X" });
            cboSexo.Location = new Point(12, 224);
            cboSexo.Name = "cboSexo";
            cboSexo.Size = new Size(776, 23);
            cboSexo.TabIndex = 7;
            // 
            // btnMostrarInfoEstudiante
            // 
            btnMostrarInfoEstudiante.BackColor = Color.Cyan;
            btnMostrarInfoEstudiante.FlatStyle = FlatStyle.Popup;
            btnMostrarInfoEstudiante.ForeColor = SystemColors.ActiveCaptionText;
            btnMostrarInfoEstudiante.Location = new Point(12, 303);
            btnMostrarInfoEstudiante.Name = "btnMostrarInfoEstudiante";
            btnMostrarInfoEstudiante.Size = new Size(187, 23);
            btnMostrarInfoEstudiante.TabIndex = 8;
            btnMostrarInfoEstudiante.Text = "Mostrar Informacion Estudiante";
            btnMostrarInfoEstudiante.UseVisualStyleBackColor = false;
            btnMostrarInfoEstudiante.Click += btnMostrarInfoEstudiante_Click;
            // 
            // btnGuardarInfo
            // 
            btnGuardarInfo.BackColor = Color.Lime;
            btnGuardarInfo.FlatStyle = FlatStyle.Popup;
            btnGuardarInfo.ForeColor = SystemColors.ActiveCaptionText;
            btnGuardarInfo.Location = new Point(601, 303);
            btnGuardarInfo.Name = "btnGuardarInfo";
            btnGuardarInfo.Size = new Size(187, 23);
            btnGuardarInfo.TabIndex = 9;
            btnGuardarInfo.Text = "Guardar Informacion";
            btnGuardarInfo.UseVisualStyleBackColor = false;
            btnGuardarInfo.Click += btnGuardarInfo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(302, 9);
            label1.Name = "label1";
            label1.Size = new Size(172, 15);
            label1.TabIndex = 10;
            label1.Text = "Ingrese el legajo del estudiante:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnGuardarInfo);
            Controls.Add(btnMostrarInfoEstudiante);
            Controls.Add(cboSexo);
            Controls.Add(lblSexo);
            Controls.Add(txtEdad);
            Controls.Add(lblEdad);
            Controls.Add(txtNombre);
            Controls.Add(txtLegajo);
            Controls.Add(lblLegajo);
            Controls.Add(lblInputNombre);
            Name = "Form1";
            Text = "Formulario | Datos del Estudiante";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInputNombre;
        private Label lblLegajo;
        private TextBox txtLegajo;
        private TextBox txtNombre;
        private Label lblEdad;
        private TextBox txtEdad;
        private Label lblSexo;
        private ComboBox cboSexo;
        private Button btnMostrarInfoEstudiante;
        private Button btnGuardarInfo;
        private Label label1;
    }
}
