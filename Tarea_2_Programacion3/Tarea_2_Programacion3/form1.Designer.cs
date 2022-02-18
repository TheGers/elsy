namespace Tarea_2_Programacion3
{
    partial class form1
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
            this.fecha_empleado_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ventas_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tiempo_laboral_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.laborar_tiempo_agregar_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.salario_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fecha_empleado_dateTimePicker
            // 
            this.fecha_empleado_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_empleado_dateTimePicker.Location = new System.Drawing.Point(277, 33);
            this.fecha_empleado_dateTimePicker.Name = "fecha_empleado_dateTimePicker";
            this.fecha_empleado_dateTimePicker.Size = new System.Drawing.Size(89, 23);
            this.fecha_empleado_dateTimePicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese su edad ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese sus ventas Mensuales Promedio : ";
            // 
            // ventas_textBox
            // 
            this.ventas_textBox.Location = new System.Drawing.Point(277, 162);
            this.ventas_textBox.Name = "ventas_textBox";
            this.ventas_textBox.Size = new System.Drawing.Size(100, 23);
            this.ventas_textBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingrese su tiempo  laborando en la empresa :";
            // 
            // tiempo_laboral_dateTimePicker
            // 
            this.tiempo_laboral_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tiempo_laboral_dateTimePicker.Location = new System.Drawing.Point(277, 87);
            this.tiempo_laboral_dateTimePicker.Name = "tiempo_laboral_dateTimePicker";
            this.tiempo_laboral_dateTimePicker.Size = new System.Drawing.Size(85, 23);
            this.tiempo_laboral_dateTimePicker.TabIndex = 7;
            // 
            // laborar_tiempo_agregar_button
            // 
            this.laborar_tiempo_agregar_button.Location = new System.Drawing.Point(437, 116);
            this.laborar_tiempo_agregar_button.Name = "laborar_tiempo_agregar_button";
            this.laborar_tiempo_agregar_button.Size = new System.Drawing.Size(75, 23);
            this.laborar_tiempo_agregar_button.TabIndex = 8;
            this.laborar_tiempo_agregar_button.Text = "Agregar";
            this.laborar_tiempo_agregar_button.UseVisualStyleBackColor = true;
            this.laborar_tiempo_agregar_button.Click += new System.EventHandler(this.laborar_tiempo_agregar_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ingrese su salario :";
            // 
            // salario_textBox
            // 
            this.salario_textBox.Location = new System.Drawing.Point(277, 225);
            this.salario_textBox.Name = "salario_textBox";
            this.salario_textBox.Size = new System.Drawing.Size(100, 23);
            this.salario_textBox.TabIndex = 10;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 310);
            this.Controls.Add(this.salario_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.laborar_tiempo_agregar_button);
            this.Controls.Add(this.tiempo_laboral_dateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ventas_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fecha_empleado_dateTimePicker);
            this.Name = "form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker fecha_empleado_dateTimePicker;
        private Button edad_agregar_button;
        private Label label1;
        private Label label2;
        private TextBox ventas_textBox;
        private Button ventas_agregar_button;
        private Label label3;
        private DateTimePicker tiempo_laboral_dateTimePicker;
        private Button laborar_tiempo_agregar_button;
        private Button agregar_prueba_button;
        private Label label4;
        private TextBox salario_textBox;
    }
}