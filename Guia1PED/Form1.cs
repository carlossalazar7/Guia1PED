namespace Guia1PED
{
    public partial class Ejemplo1 : Form
    {
        public  double Num1, Num2, Resultado;
        public bool Is1, Is2, Es_op;
        int Operacion;

        private void btn0_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("3");

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("9");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            limpiar_pantalla();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = obtener_valor();
                Is1 = true;     //actualizamos el valor de la variable de control
                Operacion = 0;  //"0" indicará  la operación  matemática "suma"
            }
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = obtener_valor();
                Is1 = true;     //actualizamos el valor de la variable de control
                Operacion = 1;  //"1" indicará  la operación  matemática "resta"
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = obtener_valor();
                Is1 = true;     //actualizamos el valor de la variable de control
                Operacion = 2;  //"2" indicará  la operación  matemática "multiplicación"
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = obtener_valor();
                Is1 = true;     //actualizamos el valor de la variable de control
                Operacion = 3;  //"3" indicará  la operación  matemática "división"
            }
        }

        private void btnExponente_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Exponente");
            if (!Is1)
            {
                Num1 = obtener_valor();
                Is1 = true;     //actualizamos el valor de la variable de control
                Operacion = 7;  //"7" indicará  la operación  matemática "exponente"
            }
        }

        public double operar(double op1,double op2, String signo)
        {
            double Resultado = 0.0;
            switch (signo)
            {
                case "+":
                    Resultado = op1 + op2;
                    break;
                case "-":
                    Resultado = op1 - op2;
                    break;
                case "*":
                    Resultado = op1 * op2;
                    break;
                case "/":
                    Resultado = op1 / op2;
                    break;
                case "^":
                    Resultado = Math.Pow(op1,op2);
                    break;
                default:
                    MessageBox.Show("operación no encontrada");
                    break;
            }
            return Resultado;
        }
        public double operar_avanzado(double op1, String signo)
        {
            {
                double Resultado = 0.0;
                switch (signo)
                {
                    case "sen":
                        Resultado = Math.Sin(op1*(Math.PI/180));
                        break;
                    case "cos":
                        Resultado = Math.Cos(op1 * (Math.PI / 180));
                        break;
                    case "tan":
                        Resultado = Math.Tan(op1 * (Math.PI / 180));
                        break;
                    case "log":
                        Resultado = Math.Log10(op1);
                        break;
                    case "ln":
                        Resultado = Math.Log(op1);
                        break;
                    default:
                        MessageBox.Show("operación no encontrada");
                        break;
                }

                        return Resultado;
            }
        }
            private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                if(Operacion == 0) // si se ha presionado el valor de la suma
                {
                    if (Is1)
                    {
                        Num2 = obtener_valor(); //para obtener el segundo valor de la resta
                        actualizar_pantalla(operar(Num1, Num2, "+").ToString());
                        Is1 = false;
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operación para realizar");
                    }
                }
                if (Operacion == 1) // si se ha presionado el valor de la resta
                {
                    if (Is1)
                    {
                        Num2 = obtener_valor(); //para obtener el segundo valor de la resta
                        actualizar_pantalla(operar(Num1, Num2, "-").ToString());
                        Is1 = false;
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operación para realizar");
                    }
                }
                if (Operacion == 2) // si se ha presionado el valor de la multiplicación
                {
                    if (Is1)
                    {
                        Num2 = obtener_valor(); //para obtener el segundo valor de la multiplicación
                        actualizar_pantalla(operar(Num1, Num2, "*").ToString());
                        Is1 = false;
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operación para realizar");
                    }
                }
                if (Operacion == 3) // si se ha presionado el valor de la división
                {
                    if (Is1)
                    {
                        Num2 = obtener_valor(); //para obtener el segundo valor de la división
                        if (Num2 == 0)
                        {
                            MessageBox.Show("No se puede dividir entre 0");
                        }
                        else
                        {
                            actualizar_pantalla(operar(Num1, Num2, "/").ToString());
                            Is1 = false;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operación para realizar");
                    }
                }

                //inicio de operaciones avanzadas

                if (Operacion == 4) // si se ha presionado el valor de la sen
                {
                    if (Is1)
                    {
                        Num1 = Convert.ToDouble(Pantalla.Text.Substring(4));
                        limpiar_pantalla();
                        actualizar_pantalla(operar_avanzado(Num1, "sen").ToString());
                        Is1 = false;
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operación para realizar");
                    }
                }
                if (Operacion == 5) // si se ha presionado el valor de la cos
                {
                    if (Is1)
                    {
                        Num1 = Convert.ToDouble(Pantalla.Text.Substring(4));
                        limpiar_pantalla();
                        actualizar_pantalla(operar_avanzado(Num1, "cos").ToString());
                        Is1 = false;
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operación para realizar");
                    }
                }
                if (Operacion == 6) // si se ha presionado el valor de la tan
                {
                    if (Is1)
                    {
                        Num1 = Convert.ToDouble(Pantalla.Text.Substring(4));
                        limpiar_pantalla();
                        actualizar_pantalla(operar_avanzado(Num1, "tan").ToString());
                        Is1 = false;
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operación para realizar");
                    }
                }
                if (Operacion == 7) // si se ha presionado el valor de la exponente
                {
                    if (Is1)
                    {
                        Num2 = obtener_valor(); //para obtener el segundo valor de la suma
                        actualizar_pantalla(operar(Num1, Num2, "^").ToString());
                        Is1 = false;
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operación para realizar");
                    }
                }
                if (Operacion == 8) // si se ha presionado el valor de la log
                {
                    if (Is1)
                    {
                        Num1 = Convert.ToDouble(Pantalla.Text.Substring(4));
                        limpiar_pantalla();
                        actualizar_pantalla(operar_avanzado(Num1, "log").ToString());
                        Is1 = false;
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operación para realizar");
                    }
                }
                if (Operacion == 9) // si se ha presionado el valor de la logaritmo natural
                {
                    if (Is1)
                    {
                        Num1 = Convert.ToDouble(Pantalla.Text.Substring(4));
                        limpiar_pantalla();
                        actualizar_pantalla(operar_avanzado(Num1, "ln").ToString());
                        Is1 = false;
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operación para realizar");
                    }
                }
                //fin de operaciones avanzadas

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Esta operación require dos operando");
            }
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            actualizar_pantalla(".");
        }

        private void btnSen_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                //Num1 = obtener_valor();
                Is1 = true;     //actualizamos el valor de la variable de control
                Operacion = 4;  //"4" indicará  la operación  matemática "seno"
                actualizar_pantalla("sin("); //seno
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                //Num1 = obtener_valor();
                Is1 = true;     //actualizamos el valor de la variable de control
                Operacion = 5;  //"5" indicará  la operación  matemática "coseno"
                actualizar_pantalla("cos("); //coseno
            }
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                //Num1 = obtener_valor();
                Is1 = true;     //actualizamos el valor de la variable de control
                Operacion = 6;  //"6" indicará  la operación  matemática "tangente"
                actualizar_pantalla("tan("); //tangente
            }
        }

    

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                //Num1 = obtener_valor();
                Is1 = true;     //actualizamos el valor de la variable de control
                Operacion = 8;  //"8" indicará  la operación  matemática "logaritmo"
                actualizar_pantalla("log("); //logaritmo
            }
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                //Num1 = obtener_valor();
                Is1 = true;     //actualizamos el valor de la variable de control
                Operacion = 8;  //"8" indicará  la operación  matemática "logaritmo"
                actualizar_pantalla("ln("); //logaritmo natural
            }
        }

        public Ejemplo1()
        {
            InitializeComponent();
            Is1 = Is2 = false;
        }

        public void limpiar_pantalla() //para limpirar el textbox llamado "Pantalla"
        {
            Pantalla.Text = "";
        }

        public double obtener_valor() //Para transformar lo que  se digite  en el textbox a formato númerico
        {
            double valor = Convert.ToDouble(Pantalla.Text);
            limpiar_pantalla();
            return valor;
        }

        public void actualizar_pantalla(String texto) //Para actualizar  lo que se visualiza en el textbox
        {
            Pantalla.Text = Pantalla.Text + texto;
        }
    }
}