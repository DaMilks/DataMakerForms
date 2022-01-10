using Statistics;
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.WindowsForms;
using OxyPlot.Series;
using OxyPlot.Axes;
using System.Drawing;
using FunctionParser;

namespace DataMakerForms
{
    public partial class Form1 : Form
    {
        PlotView pv = new PlotView();
        public Form1()
        {
            InitializeComponent();
        }
        delegate string GenerateType(double[] input);
        GenerateType generate;
        private void GenerationTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AutocorPanel.Visible = false;
            DistribusionPanel.Visible = false;
            PirsonGroupbox.Visible = false;
            switch(GenerationTypeBox.SelectedIndex)
            {
                case 0:
                generate = GenerateByDistribusion;
                DistribusionPanel.Visible = true;
                break;
                case 1:
                generate = GenerateByP;
                PirsonGroupbox.Visible = true;
                break;
                case 2:
                generate = GenerateAuto;
                AutocorPanel.Visible = true;
                break;
            }
        }

        private void InputTypeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(InputValuesTextbox.Text == "")
                InputValuesTextbox.Enabled = false;
            InputValuesTextbox.ReadOnly = true;
            GenerateInputGroupbox.Visible=false;

            switch(InputTypeCombobox.SelectedIndex)
            {
                case 0:
                InputValuesTextbox.Enabled = true;
                InputValuesTextbox.ReadOnly = false;
                break;
                case 1:
                GenerateInputGroupbox.Visible = true;
                break;
            }
        }

        private void GenerateInputButton_Click(object sender, EventArgs e)
        {
            StringBuilder inputValues = new StringBuilder();
            double min = double.Parse(InputMinTextbox.Text);
            double max = double.Parse(InputMaxTextBox.Text);
            double step = double.Parse(InputStepTextBox.Text);
            uint n = ((uint)Math.Floor((max - min) / step)) + 1;
            for(int i = 0; i < n; ++i)
            {
                inputValues.AppendLine(Convert.ToString(min + i * step));
            }
            InputValuesTextbox.Text = inputValues.ToString();
            InputValuesTextbox.Enabled = true;
            GenerateInputGroupbox.Visible = false;
        }

        private void GenerateOutputButton_Click(object sender, EventArgs e)
        {
            double[] input = Array.ConvertAll(InputValuesTextbox.Text.Split('\n', StringSplitOptions.RemoveEmptyEntries), double.Parse);

            OutputValuesTextbox.Text = generate(input);
            OutputValuesTextbox.Enabled = true;
        }

        private void DistribusionTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Param1Label.Visible = true;
            Param1Textbox.Visible = true;
            Param2Label.Visible = true;
            Param2Textbox.Visible = true;
            switch(DistribusionTypeBox.SelectedIndex)
            {
                case 0:
                Param1Label.Text = "Sigma";
                Param2Label.Text = "Mean";
                break;
                case 1:
                Param1Label.Text = "Min";
                Param2Label.Text = "Max";
                break;
                case 2:
                Param1Label.Text = "A";
                Param2Label.Text = "K";
                break;
                case 3:
                Param1Label.Text = "Location";
                Param2Label.Text = "Scale";
                break;
                case 4:
                Param1Label.Text = "Rate";
                Param2Label.Visible = false;
                Param2Textbox.Visible = false;
                break;
                case 5:
                Param1Label.Text = "Location";
                Param2Label.Text = "Scale";
                break;
                case 6:
                Param1Label.Text = "Shape";
                Param2Label.Text = "Scale";
                break;
                case 7:
                Param1Label.Text = "Degrees Freedom";
                Param2Label.Visible = false;
                Param2Textbox.Visible = false;
                break;
            }
        }

        private void FunctionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FunctionPanel.Visible = FunctionCheckBox.Checked;
        }

        private void DomainCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            DomainOutputGroupbox.Visible = DomainCheckbox.Checked;
        }

        private void PlotButton_Click(object sender, EventArgs e)
        {
            double[] yvalues = Array.ConvertAll(OutputValuesTextbox.Text.Split('\n', StringSplitOptions.RemoveEmptyEntries), double.Parse);
            double[] xvalues= Array.ConvertAll(InputValuesTextbox.Text.Split('\n', StringSplitOptions.RemoveEmptyEntries), double.Parse);
            double min = Math.Min(yvalues.Min(), xvalues.Min());
            double max = Math.Max(yvalues.Max(), xvalues.Max());
            this.Controls.Add(pv);
            LinearAxis xAxis = new LinearAxis { Position = OxyPlot.Axes.AxisPosition.Bottom, Minimum = min, Maximum = max };
            LinearAxis yAxis = new LinearAxis { Minimum = min, Maximum = max };
            pv.Model = new PlotModel();
            pv.Model.Axes.Add(xAxis);
            pv.Model.Axes.Add(yAxis);
            ScatterSeries ls = new ScatterSeries();
            ls.MarkerSize = 2.5;
            ls.MarkerType = MarkerType.Circle;
            for(int i = 0; i < yvalues.Length; ++i)
            {
                ls.Points.Add(new ScatterPoint(xvalues[i], yvalues[i]));
            }
            pv.Model.Series.Add(ls);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            pv.Location = new Point(445, 25);
            pv.Size = new Size(675, 675);
            
        }

        private string GenerateByDistribusion(double[] input)
        {
            Distribusion d = SetDistribusion();
            
            if(FunctionCheckBox.Checked)
            {
                string equation = FunctionTextbox.Text;
                var variables = new string[] { "x" };
                if(Expression.IsExpression(equation, variables))
                {
                    Expression expression = new Expression(equation, variables, null);
                    double[] value = new double[1];
                    for(int i = 0; i < input.Length; i++)
                    {
                        value[0] = input[i];
                        input[i] = expression.CalculateValue(value);
                    }
                }
            }
            return string.Join("\n", Statistics.Model.GenerateByDistribusion(input, d));
        }

        private string GenerateByP(double[] inputValues)
        {
            double p = double.Parse(PirsonTextbox.Text);
            return string.Join("\n", Statistics.Model.GenerateByP(inputValues, p));
        }

        private string GenerateAuto(double[] input)
        {
            int sgn = 1;
            if(SgnCorrCheckbox.Checked)
                sgn = -1;
            if(DomainCheckbox.Checked)
            {
                Domain yDomain = default;
                if(OutputMaxTextbox.Text != "")
                    yDomain.max = double.Parse(OutputMaxTextbox.Text);
                if(OutputMinTextbox.Text != "")
                    yDomain.min = double.Parse(OutputMinTextbox.Text);
                return string.Join("\n", Statistics.Model.GenerateAuto(input, yDomain, sgn));
            }
            else
                return string.Join("\n", Statistics.Model.GenerateAuto(input, sgn));
        }

        private Distribusion SetDistribusion()
        {
            Distribusion distribusion = new NormalDistribusion();
            double p1 = double.Parse(Param1Textbox.Text);
            double p2 = double.Parse(Param2Textbox.Text);
            switch(DistribusionTypeBox.SelectedIndex)
            {
                case 0:
                distribusion = new NormalDistribusion(p1, p2);
                break;
                case 1:
                distribusion = new UniformDistribusion(p1, p2);
                break;
                case 2:
                distribusion = new ParetoDistribusion(p1, p2);
                break;
                case 3:
                distribusion = new KauchyDistribusion(p1, p2);
                break;
                case 4:
                distribusion = new ExponentialDistribusion(p1);
                break;
                case 5:
                distribusion = new LaplaceDistribusion(p1, p2);
                break;
                case 6:
                distribusion = new GammaDistribusion(p1, p2);
                break;
                case 7:
                distribusion = new ChiSquaredDistribusion(p1);
                break;
            }
            return distribusion;
        }
    }
}
