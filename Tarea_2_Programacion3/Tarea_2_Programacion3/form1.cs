namespace Tarea_2_Programacion3
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void laborar_tiempo_agregar_button_Click(object sender, EventArgs e)
        {

            //creacion de variable para identificar la fecha 
            DateTime fecha_empleado = fecha_empleado_dateTimePicker.Value;
            DateTime fecha_actual = DateTime.Now;
            int edad_actual = fecha_actual.Year - fecha_empleado.Year;



            DateTime tiempo_labor = tiempo_laboral_dateTimePicker.Value;
            DateTime fecha_actualv2 = DateTime.Now;
            int tiempo_lab = fecha_actualv2.Year - tiempo_labor.Year;



            int ventas_mensual = Convert.ToInt32(ventas_textBox.Text);
            int salario_inicial = Convert.ToInt32(salario_textBox.Text);

            double salario_porcentaje = salario_inicial * 0.05;
            double salario_final = salario_porcentaje + salario_inicial;



            if (edad_actual >= 30 & tiempo_lab >= 10 &  ventas_mensual > 10000 )
            {
                MessageBox.Show("Usted ha sido admitido al aumento de salario al cumplir los 3 requisitos :D"
                    + " Su nuevo salario es: "+salario_final+" lempiras");

            }
            else
            {
                MessageBox.Show("No cumple los requisitos para el aumento salarial por uno mas motivos");
            }
        }

        //Gerson David Garcia Calderon
        //2019-1003-218
        //Lenguaje de programacion 3 
        //seccion 1400

    }
}
