using mathlib;

namespace calculator
{
    public partial class Form1 : Form
    {
        double a = 0;
        double b = 0;
        int c = 0;
        double d = 0;
        double result = 0;
        bool add = false;
        bool subtract = false;
        bool multiply = false;
        bool divide = false;
        bool power = false;
        bool sqrroot = false;
        bool modulo = false;
        bool pokracovani_scitani = false;
        bool pokracovani_odecitani = false;
        bool pokracovani_nasobeni = false;
        bool pokracovani_deleni = false;



        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        public void mazani()
        {
            if (textbox.Text.Length > 0)
            {
                // Odstraňte poslední znak
                textbox.Text = textbox.Text.Remove(textbox.Text.Length - 1);
            }

        }

        public void vysledek()
        {
            if (add == true)
            {
                if (double.TryParse(textbox.Text, out b))
                {

                }
                result = math.Scitani(a, b);

                if (pokracovani_scitani == false)
                {
                    textbox.Text = Convert.ToString(result);
                    history.Text += b + "=";
                    add = false;
                    b = 0;
                    a = 0;
                }

                else if (pokracovani_scitani == true)
                {
                    history.Text += b + "=" + Convert.ToString(result) + "+";
                    textbox.Text = "";
                    a = result;
                }
                pokracovani_scitani = false;
            }

            else if (subtract == true)
            {
                if (double.TryParse(textbox.Text, out b))
                {

                }
                result = math.Odecitani(a, b);

                if (pokracovani_odecitani == false)
                {
                    textbox.Text = Convert.ToString(result);
                    history.Text += b + "=";
                    subtract = false;
                    b = 0;
                    a = 0;
                }

                else if (pokracovani_odecitani == true)
                {
                    history.Text += b + "=" + Convert.ToString(result) + "-";
                    textbox.Text = "";
                    a = result;
                }
                pokracovani_odecitani = false;
            }

            else if (multiply == true)
            {
                if (double.TryParse(textbox.Text, out b))
                {

                }
                result = math.Nasobeni(a, b);

                if (pokracovani_nasobeni == false)
                {
                    textbox.Text = Convert.ToString(result);
                    history.Text += b + "=";
                    multiply = false;
                    b = 0;
                    a = 0;
                }

                else if (pokracovani_nasobeni == true)
                {
                    history.Text += b + "=" + Convert.ToString(result) + "×";
                    textbox.Text = "";
                    a = result;
                }
                pokracovani_nasobeni = false;
            }

            else if (divide == true)
            {
                if (double.TryParse(textbox.Text, out b))
                {

                }

                if (b != 0)
                {
                    result = math.Deleni(a, b);

                    if (pokracovani_deleni == false)
                    {
                        textbox.Text = Convert.ToString(result);
                        history.Text += b + "=";
                        divide = false;
                        b = 0;
                        a = 0;
                    }

                    else if (pokracovani_deleni == true)
                    {
                        history.Text += b + "=" + Convert.ToString(result) + "/";
                        textbox.Text = "";
                        a = result;
                    }
                    pokracovani_deleni = false;
                }


                else
                {
                    pictureBox1.Visible = true;
                    error();
                }
            }

            else if (divide == true && double.TryParse(textbox.Text, out b) && b != 0)
            {
                history.Text += b + "=";
                result = math.Deleni(a, b);
                textbox.Text = Convert.ToString(result);
                a = result;
            }

            else if (power == true && int.TryParse(textbox.Text, out c))
            {
                history.Text += c + "=";

                result = math.Umocneni(a, c);
                textbox.Text = Convert.ToString(result);
                a = result;
            }

            else if (sqrroot == true && double.TryParse(textbox.Text, out b) && b >= 0)
            {
                history.Text += b + "=";

                result = math.Odmocnina(b, a);
                textbox.Text = Convert.ToString(result);
                a = result;
            }

            else if (modulo == true && double.TryParse(textbox.Text, out b) && b != 0)
            {
                history.Text += b + "=";
                result = math.Modulo(a, b);
                textbox.Text = Convert.ToString(result);
                a = result;
            }

            else
            {

            }
        }

        public double scitani()
        {
            if (a != 0 && double.TryParse(textbox.Text, out b))
            {
                pokracovani_scitani = true;
                vysledek();
                return b;

            }

            else if (double.TryParse(textbox.Text, out a))
            {
                divide = false;
                add = true;
                subtract = false;
                multiply = false;
                power = false;
                sqrroot = false;
                modulo = false;
                history.Text = Convert.ToString(a) + "+";
                textbox.Text = "";
                return a;
            }

            else
            {
                error();
                return 0;
            }
        }

        public double odcitani()
        {
            if (a != 0 && double.TryParse(textbox.Text, out b))
            {
                pokracovani_odecitani = true;
                vysledek();
                return b;

            }

            else if (double.TryParse(textbox.Text, out a))
            {
                divide = false;
                add = false;
                subtract = true;
                multiply = false;
                power = false;
                sqrroot = false;
                modulo = false;
                history.Text = Convert.ToString(a) + "-";
                textbox.Text = "";
                return a;
            }
            else
            {
                error();
                return 0;
            }
        }

        public double nasobeni()
        {
            if (a != 0 && double.TryParse(textbox.Text, out b))
            {
                pokracovani_nasobeni = true;
                vysledek();
                return b;

            }

            else if (double.TryParse(textbox.Text, out a))
            {
                divide = false;
                add = false;
                subtract = false;
                multiply = true;
                power = false;
                sqrroot = false;
                modulo = false;
                history.Text = Convert.ToString(a) + "×";
                textbox.Text = "";
                return a;
            }
            else
            {
                error();
                return 0;
            }
        }

        public double deleni()
        {
            if (a != 0 && double.TryParse(textbox.Text, out b))
            {
                pokracovani_deleni = true;
                vysledek();
                return b;

            }

            else if (double.TryParse(textbox.Text, out a))
            {
                divide = true;
                add = false;
                subtract = false;
                multiply = false;
                power = false;
                sqrroot = false;
                modulo = false;
                history.Text = Convert.ToString(a) + "/";
                textbox.Text = "";
                return a;
            }
            else
            {
                error();
                return 0;
            }
        }

        public double faktorial()
        {
            if (int.TryParse(textbox.Text, out c))
            {
                if(c < 0)
                {
                    error();
                    return 0;
                }
                
                divide = false;
                add = false;
                subtract = false;
                multiply = false;
                power = false;
                sqrroot = false;
                history.Text = Convert.ToString(c) + "!";
                textbox.Text = Convert.ToString(math.Faktorial(c));
                return a;
            }
            else
            {
                error();
                return 0;
            }
        }

        public double mocnina()
        {
            if (double.TryParse(textbox.Text, out a))
            {
                divide = false;
                add = false;
                subtract = false;
                multiply = false;
                power = true;
                sqrroot = false;
                modulo = false;
                history.Text = Convert.ToString(a) + "^";
                textbox.Text = "";
                return a;
            }
            else
            {
                error();
                return 0;
            }
        }

        public double odmocnina()
        {
            if (double.TryParse(textbox.Text, out a))
            {
                divide = false;
                add = false;
                subtract = false;
                multiply = false;
                power = false;
                sqrroot = true;
                modulo = false;
                history.Text = Convert.ToString(a) + "√";
                textbox.Text = "";
                return a;
            }
            else
            {
                error();
                return 0;
            }
        }

        public double modul()
        {
            if (double.TryParse(textbox.Text, out a))
            {
                divide = false;
                add = false;
                subtract = false;
                multiply = false;
                power = false;
                sqrroot = false;
                modulo = true;
                history.Text = Convert.ToString(a) + "%";
                textbox.Text = "";
                return a;
            }
            else
            {
                error();
                return 0;
            }
        }

        private void error()
        {
            // Konverze selhala, vypíšeme do TextBoxu chybovou hlášku
            textbox.Text = "ERROR";
            history.Text = "";
            pictureBox1.Visible = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            textbox.Text += 1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textbox.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textbox.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textbox.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textbox.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textbox.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textbox.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textbox.Text += 8;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            textbox.Text += 9;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textbox.Text += 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            scitani();
        }

        private void button_subtract_Click(object sender, EventArgs e)
        {
            odcitani();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            nasobeni();
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            deleni();
        }

        private void button_factorial_Click(object sender, EventArgs e)
        {
            faktorial();
        }

        private void button_power_Click(object sender, EventArgs e)
        {
            mocnina();
        }

        private void button_sqrroot_Click(object sender, EventArgs e)
        {
            odmocnina();
        }

        private void button_modulo_Click(object sender, EventArgs e)
        {
            modul();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textbox.Text = "";
            history.Text = "";
            a = 0;
            b = 0;
            pictureBox1.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            vysledek();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textbox.Text += ",";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textbox.Text, out d))
            {
                textbox.Text = Convert.ToString(math.ZmenaZnamenka(d));
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            mazani();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.E)
            {
                vysledek();
            }

            else if (e.KeyCode == Keys.Add)
            {
                scitani();
            }

            else if (e.KeyCode == Keys.Subtract)
            {
                odcitani();
            }

            else if (e.KeyCode == Keys.Multiply)
            {
                nasobeni();
            }

            else if (e.KeyCode == Keys.Divide)
            {
                deleni();
            }

            else if (e.KeyCode == Keys.Decimal)
            {
                textbox.Text += ",";
            }

            else if (e.KeyCode == Keys.C)
            {
                textbox.Text = "";
                history.Text = "";
                a = 0;
                b = 0;
                pictureBox1.Visible = false;
            }

            else if (e.KeyCode == Keys.Delete)
            {
                mazani();
            }

            else if (e.KeyCode == Keys.NumPad0)
            {
                textbox.Text += 0;
            }

            else if (e.KeyCode == Keys.NumPad1)
            {
                textbox.Text += 1;
            }

            else if (e.KeyCode == Keys.NumPad2)
            {
                textbox.Text += 2;
            }

            else if (e.KeyCode == Keys.NumPad3)
            {
                textbox.Text += 3;
            }

            else if (e.KeyCode == Keys.NumPad4)
            {
                textbox.Text += 4;
            }

            else if (e.KeyCode == Keys.NumPad5)
            {
                textbox.Text += 5;
            }

            else if (e.KeyCode == Keys.NumPad6)
            {
                textbox.Text += 6;
            }

            else if (e.KeyCode == Keys.NumPad7)
            {
                textbox.Text += 7;
            }

            else if (e.KeyCode == Keys.NumPad8)
            {
                textbox.Text += 8;
            }

            else if (e.KeyCode == Keys.NumPad9)
            {
                textbox.Text += 9;
            }

            else if (e.KeyCode == Keys.Delete)
            {
                mazani();
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
