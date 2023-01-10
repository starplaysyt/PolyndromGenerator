namespace PolyndromProject
{
    public partial class Form1 : Form
    {
        public GenerationType genType = GenerationType.ProgramWay;
        public GenerationMode genMode = GenerationMode.DoOverrideAccess;
        public Form1()
        {
            InitializeComponent();
            genType = GenerationType.ProgramWay;
        }

        private void generationButton_Click(object sender, EventArgs e)
        {
            if (doClearOutputOnNewGeneration.Checked) outputListBox.Items.Clear();
            if (genType == GenerationType.ProgramWay)
            {
                if (genMode == GenerationMode.DoOverrideAccess)
                {
                    if (programValueTB.Text.Trim()[programValueTB.Text.Length - 1] == '0')
                    {
                        MessageBox.Show("Для существования полиндрома поле value не должно оканчиваться на 0.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string reverced = new string(programValueTB.Text.ToCharArray().Reverse().ToArray());
                    if (programUseSeparatorCB.Checked)
                    {
                        reverced += programSeparatorN.Value + programValueTB.Text;
                        outputListBox.Items.Add(reverced);
                    }
                    else
                    {
                        reverced += programValueTB.Text;
                        outputListBox.Items.Add(reverced);
                    }
                }
                else
                {
                    Random rand = new Random();
                    if (rand.Next(0, 2) == 1)
                    {
                        programUseSeparatorCB.Checked = true;
                        programSeparatorN.Value = rand.Next(0, 9);
                    }
                    int val = rand.Next(0, 10000);
                    programValueTB.Text = val % 10 == 0 ? (val + 1).ToString() : val.ToString();

                    if (programValueTB.Text.Trim()[programValueTB.Text.Length - 1] == '0')
                    {
                        MessageBox.Show("Для существования полиндрома поле value не должно оканчиваться на 0.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string reverced = new string(programValueTB.Text.ToCharArray().Reverse().ToArray());
                    if (programUseSeparatorCB.Checked)
                    {
                        reverced += programSeparatorN.Value + programValueTB.Text;
                        outputListBox.Items.Add(reverced);
                    }
                    else
                    {
                        reverced += programValueTB.Text;
                        outputListBox.Items.Add(reverced);
                    }
                }
            }
            if (genType == GenerationType.MathWay)
            {
                if (genMode == GenerationMode.DoOverrideAccess)
                {
                    long returnValue = 0;
                    if (dMathValue.Enabled)
                    {
                        returnValue += mathUseSeparatorCB.Checked ? Convert.ToInt32(dMathValue.Value) * 100000000 : Convert.ToInt32(dMathValue.Value) * 10000000;
                        returnValue += mathUseSeparatorCB.Checked ? Convert.ToInt32(cMathValue.Value) * 10000000 : Convert.ToInt32(cMathValue.Value) * 1000000;
                        returnValue += mathUseSeparatorCB.Checked ? Convert.ToInt32(bMathValue.Value) * 1000000 : Convert.ToInt32(bMathValue.Value) * 100000;
                        returnValue += mathUseSeparatorCB.Checked ? Convert.ToInt32(aMathValue.Value) * 100000 : Convert.ToInt32(aMathValue.Value) * 10000;
                        if (mathUseSeparatorCB.Checked)
                        {
                            returnValue += Convert.ToInt32(mathSeparatorN.Value) * 10000;
                        }
                        returnValue += Convert.ToInt32(dMathValue.Value);
                        returnValue += Convert.ToInt32(cMathValue.Value) * 10;
                        returnValue += Convert.ToInt32(bMathValue.Value) * 100;
                        returnValue += Convert.ToInt32(aMathValue.Value) * 1000;
                    }
                    else
                    if (cMathValue.Enabled)
                    {
                        returnValue += mathUseSeparatorCB.Checked ? Convert.ToInt32(cMathValue.Value) * 1000000 : Convert.ToInt32(cMathValue.Value) * 100000;
                        returnValue += mathUseSeparatorCB.Checked ? Convert.ToInt32(bMathValue.Value) * 100000 : Convert.ToInt32(bMathValue.Value) * 10000;
                        returnValue += mathUseSeparatorCB.Checked ? Convert.ToInt32(aMathValue.Value) * 10000 : Convert.ToInt32(aMathValue.Value) * 1000;
                        if (mathUseSeparatorCB.Checked)
                        {
                            returnValue += Convert.ToInt32(mathSeparatorN.Value) * 1000;
                        }
    
                        returnValue += Convert.ToInt32(cMathValue.Value);
                        returnValue += Convert.ToInt32(bMathValue.Value) * 10;
                        returnValue += Convert.ToInt32(aMathValue.Value) * 100;
                    }
                    else
                    if (bMathValue.Enabled)
                    {
                        returnValue += mathUseSeparatorCB.Checked ? Convert.ToInt32(bMathValue.Value) * 10000 : Convert.ToInt32(bMathValue.Value) * 1000;
                        returnValue += mathUseSeparatorCB.Checked ? Convert.ToInt32(aMathValue.Value) * 1000 : Convert.ToInt32(aMathValue.Value) * 100;
                        if (mathUseSeparatorCB.Checked)
                        {
                            returnValue += Convert.ToInt32(mathSeparatorN.Value) * 100;
                        }

                        returnValue += Convert.ToInt32(bMathValue.Value);
                        returnValue += Convert.ToInt32(aMathValue.Value) * 10;
                    }
                    else
                    if (aMathValue.Enabled)
                    {
                        returnValue += mathUseSeparatorCB.Checked ? Convert.ToInt32(aMathValue.Value) * 100 : Convert.ToInt32(aMathValue.Value) * 10;
                        if (mathUseSeparatorCB.Checked)
                        {
                            returnValue += Convert.ToInt32(mathSeparatorN.Value) * 10;
                        }


                        returnValue += Convert.ToInt32(aMathValue.Value);
                    }
                    outputListBox.Items.Add(returnValue);
                } //-------------------------------------------------------------RANDOM HERE
                else
                {
                    Random rnd = new Random();

                    int amountofvar = rnd.Next(1, 5);
                    mathAmountVarsN.Value = amountofvar;
                    numericUpDown3_ValueChanged(null, null);
                    if (rnd.Next(0,2) == 1)
                    {
                        mathUseSeparatorCB.Checked = true;
                        mathSeparatorN.Value = rnd.Next(1, 10);
                    }
                    int a = rnd.Next(1, 9);
                    int b = rnd.Next(1, 9);
                    int c = rnd.Next(1, 9);
                    int d = rnd.Next(1, 9);
                    aMathValue.Value = a;
                    bMathValue.Value = b;
                    cMathValue.Value = c;
                    dMathValue.Value = d;
                    mathOverridePanel.Enabled = true;

                    long returnValue = 0;
                    if (dMathValue.Enabled)
                    {
                        returnValue += mathUseSeparatorCB.Checked ? Convert.ToInt32(dMathValue.Value) * 100000000 : Convert.ToInt32(dMathValue.Value) * 10000000;
                        returnValue += mathUseSeparatorCB.Checked ? Convert.ToInt32(cMathValue.Value) * 10000000 : Convert.ToInt32(cMathValue.Value) * 1000000;
                        returnValue += mathUseSeparatorCB.Checked ? Convert.ToInt32(bMathValue.Value) * 1000000 : Convert.ToInt32(bMathValue.Value) * 100000;
                        returnValue += mathUseSeparatorCB.Checked ? Convert.ToInt32(aMathValue.Value) * 100000 : Convert.ToInt32(aMathValue.Value) * 10000;
                        if (mathUseSeparatorCB.Checked)
                        {
                            returnValue += Convert.ToInt32(mathSeparatorN.Value) * 10000;
                        }
                        returnValue += Convert.ToInt32(dMathValue.Value);
                        returnValue += Convert.ToInt32(cMathValue.Value) * 10;
                        returnValue += Convert.ToInt32(bMathValue.Value) * 100;
                        returnValue += Convert.ToInt32(aMathValue.Value) * 1000;
                    }
                    else
                    if (cMathValue.Enabled)
                    {
                        returnValue += mathUseSeparatorCB.Checked ? Convert.ToInt32(cMathValue.Value) * 1000000 : Convert.ToInt32(cMathValue.Value) * 100000;
                        returnValue += mathUseSeparatorCB.Checked ? Convert.ToInt32(bMathValue.Value) * 100000 : Convert.ToInt32(bMathValue.Value) * 10000;
                        returnValue += mathUseSeparatorCB.Checked ? Convert.ToInt32(aMathValue.Value) * 10000 : Convert.ToInt32(aMathValue.Value) * 1000;
                        if (mathUseSeparatorCB.Checked)
                        {
                            returnValue += Convert.ToInt32(mathSeparatorN.Value) * 1000;
                        }

                        returnValue += Convert.ToInt32(cMathValue.Value);
                        returnValue += Convert.ToInt32(bMathValue.Value) * 10;
                        returnValue += Convert.ToInt32(aMathValue.Value) * 100;
                    }
                    else
                    if (bMathValue.Enabled)
                    {
                        returnValue += mathUseSeparatorCB.Checked ? Convert.ToInt32(bMathValue.Value) * 10000 : Convert.ToInt32(bMathValue.Value) * 1000;
                        returnValue += mathUseSeparatorCB.Checked ? Convert.ToInt32(aMathValue.Value) * 1000 : Convert.ToInt32(aMathValue.Value) * 100;
                        if (mathUseSeparatorCB.Checked)
                        {
                            returnValue += Convert.ToInt32(mathSeparatorN.Value) * 100;
                        }

                        returnValue += Convert.ToInt32(bMathValue.Value);
                        returnValue += Convert.ToInt32(aMathValue.Value) * 10;
                    }
                    else
                    if (aMathValue.Enabled)
                    {
                        returnValue += mathUseSeparatorCB.Checked ? Convert.ToInt32(aMathValue.Value) * 100 : Convert.ToInt32(aMathValue.Value) * 10;
                        if (mathUseSeparatorCB.Checked)
                        {
                            returnValue += Convert.ToInt32(mathSeparatorN.Value) * 10;
                        }


                        returnValue += Convert.ToInt32(aMathValue.Value);
                    }
                    outputListBox.Items.Add(returnValue);
                    mathOverridePanel.Enabled = false;
                }
            }
            if (genType == GenerationType.ProgramMathWay)
            {
                if (genMode == GenerationMode.DoOverrideAccess)
                {
                    int result = (Convert.ToInt32(pmathAField.Value) + Convert.ToInt32(pmathCField.Value)) % 10 * (int)Math.Pow(10, Convert.ToInt32(pmathLField.Value)-1);
                    MessageBox.Show(result.ToString());
                    for (int i = 1; i < Convert.ToInt32(pmathLField.Value); i++)
                    {
                        int pow = Convert.ToInt32(pmathLField.Value) - i -1;
                        int qE = result / (int)Math.Pow(10, pow + 1);
                        result += (qE + Convert.ToInt32(pmathCField.Value)) % 10 * (int)Math.Pow(10, pow);
                        //MessageBox.Show("i = " + i.ToString() + " res = " + result.ToString() +  " qe = " + qE.ToString());
                    }
                    //MessageBox.Show("Result =" + result);
                    if (Convert.ToInt32(pmathBField.Value) == 0)
                    {
                        result *= (int)Math.Pow(10, Convert.ToInt32(pmathLField.Value));
                        //MessageBox.Show("ResultPS2 =" + result.ToString());
                        result += (Convert.ToInt32(pmathAField.Value) + Convert.ToInt32(pmathCField.Value))%10;
                        for (int i = 0; i < Convert.ToInt32(pmathLField.Value)-1; i++)
                        {
                            int pow = i + 1;
                            int qE = result / (int)Math.Pow(10, i) % 10;
                            result += (qE + Convert.ToInt32(pmathCField.Value)) % 10 * (int)Math.Pow(10, pow);
                        }
                        
                    }
                    else
                    {
                        result *= (int)Math.Pow(10, Convert.ToInt32(pmathLField.Value)+1);
                        result += Convert.ToInt32(pmathCField.Value) * (int)Math.Pow(10, Convert.ToInt32(pmathLField.Value));
                        result += (Convert.ToInt32(pmathAField.Value) + Convert.ToInt32(pmathCField.Value))%10;
                        for (int i = 0; i < Convert.ToInt32(pmathLField.Value) - 1; i++)
                        {
                            int pow = i + 1;
                            int qE = result / (int)Math.Pow(10, i) % 10;
                            result += (qE + Convert.ToInt32(pmathCField.Value)) % 10 * (int)Math.Pow(10, pow);
                        }
                    }
                    outputListBox.Items.Add(result);
                }
                else
                {
                    Random rnd = new();
                    pmathAField.Value = rnd.Next(1, 9);
                    pmathCField.Value = rnd.Next(1, 9);
                    pmathLField.Value = rnd.Next(1, 5);
                    pmathBField.Value = rnd.Next(0, 1);

                    int result = (Convert.ToInt32(pmathAField.Value) + Convert.ToInt32(pmathCField.Value)) % 10 * (int)Math.Pow(10, Convert.ToInt32(pmathLField.Value) - 1);
                    MessageBox.Show(result.ToString());
                    for (int i = 1; i < Convert.ToInt32(pmathLField.Value); i++)
                    {
                        int pow = Convert.ToInt32(pmathLField.Value) - i - 1;
                        int qE = result / (int)Math.Pow(10, pow + 1);
                        result += (qE + Convert.ToInt32(pmathCField.Value)) % 10 * (int)Math.Pow(10, pow);
                        //MessageBox.Show("i = " + i.ToString() + " res = " + result.ToString() +  " qe = " + qE.ToString());
                    }
                    //MessageBox.Show("Result =" + result);
                    if (Convert.ToInt32(pmathBField.Value) == 0)
                    {
                        result *= (int)Math.Pow(10, Convert.ToInt32(pmathLField.Value));
                        //MessageBox.Show("ResultPS2 =" + result.ToString());
                        result += (Convert.ToInt32(pmathAField.Value) + Convert.ToInt32(pmathCField.Value)) % 10;
                        for (int i = 0; i < Convert.ToInt32(pmathLField.Value) - 1; i++)
                        {
                            int pow = i + 1;
                            int qE = result / (int)Math.Pow(10, i) % 10;
                            result += (qE + Convert.ToInt32(pmathCField.Value)) % 10 * (int)Math.Pow(10, pow);
                        }

                    }
                    else
                    {
                        result *= (int)Math.Pow(10, Convert.ToInt32(pmathLField.Value) + 1);
                        result += Convert.ToInt32(pmathCField.Value) * (int)Math.Pow(10, Convert.ToInt32(pmathLField.Value));
                        result += (Convert.ToInt32(pmathAField.Value) + Convert.ToInt32(pmathCField.Value)) % 10;
                        for (int i = 0; i < Convert.ToInt32(pmathLField.Value) - 1; i++)
                        {
                            int pow = i + 1;
                            int qE = result / (int)Math.Pow(10, i) % 10;
                            result += (qE + Convert.ToInt32(pmathCField.Value)) % 10 * (int)Math.Pow(10, pow);
                        }
                    }
                    outputListBox.Items.Add(result);
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void useSeparatorCB_CheckedChanged(object sender, EventArgs e)
        {
            programSeparatorN.Enabled = programUseSeparatorCB.Checked;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            switch (mathAmountVarsN.Value)
            {
                case 1:
                    bMathValue.Enabled = false;
                    cMathValue.Enabled = false;
                    dMathValue.Enabled = false;
                    break;
                case 2:
                    bMathValue.Enabled = true;
                    cMathValue.Enabled = false;
                    dMathValue.Enabled = false;
                    break;
                case 3:
                    bMathValue.Enabled = true;
                    cMathValue.Enabled = true;
                    dMathValue.Enabled = false;
                    break;
                case 4:
                    bMathValue.Enabled = true;
                    cMathValue.Enabled = true;
                    dMathValue.Enabled = true;
                    break;
                default:
                    MessageBox.Show("some error happened. "); return;
                    break;
            }
        }

        private void mathUseSeparatorCB_CheckedChanged(object sender, EventArgs e)
        {
            mathSeparatorN.Enabled = mathUseSeparatorCB.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dMathValue.Enabled)
            {
                MessageBox.Show("С четным количеством цифр: y = d*10.000.000 + c*1.000.000 + b*100.000 + a*10.000 + a*1.000 + b*100 + c*10 + d \nC нечетным количеством цифр: y = d*100.000.000 + c*10.000.000 + b*1.000.000 + a * 100.000 + s * 10.000 + a * 1.000 + b * 100 + c * 10 + d.");
            }else if (cMathValue.Enabled)
            {
                MessageBox.Show("С четным количеством цифр: y = c*100.000 + b*10.000 + a*1.000 + a*100 + b*10 + c \nC нечетным количеством цифр: y = c*1.000.000 + b*100.000 + a * 10.000 + s * 1.000 + a * 100 + b * 10 + c");
            } else if (bMathValue.Enabled)
            {
                MessageBox.Show("С четным количеством цифр: y = b*1.000 + a*100 + a*10 + b \nC нечетным количеством цифр: y = b*10.000 + a * 1.000 + s * 100 + a * 10 + b");
            }
            else if (aMathValue.Enabled)
            {
                MessageBox.Show("С четным количеством цифр: y = a*10 + a\nC нечетным количеством цифр: y = a * 100 + s * 10 + a");
            }
        }

        private void clearOutputButton_Click(object sender, EventArgs e)
        {
            outputListBox.Items.Clear();
        }

        private void saveAsButton_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(new FileStream("output.txt", FileMode.Create, FileAccess.Write));
            foreach (var outstr in outputListBox.Items)
            {
                writer.WriteLine(outstr);
            }
            writer.Close();
        }

        private void generationTypeChanged(object sender, EventArgs e)
        {
            if (sender == null) throw new Exception("object was null where it cannot be null.");
            if ((sender as RadioButton).Checked)
            {
                switch ((sender as RadioButton).Name)
                {
                    case "useFirstWayRB": genType = GenerationType.ProgramWay; UIReset(); break;
                    case "useSecondWayRB": genType = GenerationType.MathWay; UIReset(); break;
                    case "useThirdWayRB": genType = GenerationType.ProgramMathWay; UIReset();
                        break;
                    default:
                        MessageBox.Show("Some unexpected error happened. Choose another generation option.");
                        break;
                }
            }
        }

        private void UIReset()
        {
            programOverridePanel.Enabled = false;
            mathOverridePanel.Enabled = false;
            pmathOverridePanel.Enabled = false;
            if (genMode == GenerationMode.DoOverrideAccess)
            {
                switch (genType)
                {
                    case GenerationType.ProgramWay:
                        programOverridePanel.Enabled = true;
                        break;
                    case GenerationType.MathWay:
                        mathOverridePanel.Enabled = true;
                        break;
                    case GenerationType.ProgramMathWay:
                        pmathOverridePanel.Enabled = true;
                        break;
                }
            }
        }

        private void generationSettingsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                if ((sender as RadioButton).Name == "useRandomGenRB")
                {
                    genMode = GenerationMode.DoRandomGeneration;
                    UIReset();
                    MessageBox.Show("TestRG");
                }
                else if ((sender as RadioButton).Name == "useOverrideGenRB")
                {
                    genMode = GenerationMode.DoOverrideAccess;
                    UIReset();
                    MessageBox.Show("TestOA");
                }
                else MessageBox.Show("Unexpected error happened. Please, choose another option.");
            }
        }
    }
}