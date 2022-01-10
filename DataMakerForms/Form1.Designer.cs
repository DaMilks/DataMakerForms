
namespace DataMakerForms
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
            if(disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DistribusionTypeBox = new System.Windows.Forms.ComboBox();
            this.DistribusionTypeLabel = new System.Windows.Forms.Label();
            this.Param1Label = new System.Windows.Forms.Label();
            this.Param2Label = new System.Windows.Forms.Label();
            this.Param1Textbox = new System.Windows.Forms.TextBox();
            this.DistribusionGroupBox = new System.Windows.Forms.GroupBox();
            this.Param2Textbox = new System.Windows.Forms.TextBox();
            this.PirsonGroupbox = new System.Windows.Forms.GroupBox();
            this.PirsonTextbox = new System.Windows.Forms.TextBox();
            this.PirsonLabel = new System.Windows.Forms.Label();
            this.GenerationTypeBox = new System.Windows.Forms.ComboBox();
            this.GenerationTypeLabel = new System.Windows.Forms.Label();
            this.InputTypeLabel = new System.Windows.Forms.Label();
            this.OutputValuesTextbox = new System.Windows.Forms.TextBox();
            this.InputValuesTextbox = new System.Windows.Forms.TextBox();
            this.GenerateInputGroupbox = new System.Windows.Forms.GroupBox();
            this.InputStepTextBox = new System.Windows.Forms.TextBox();
            this.InputMaxTextBox = new System.Windows.Forms.TextBox();
            this.InputMinTextbox = new System.Windows.Forms.TextBox();
            this.GenerateInputButton = new System.Windows.Forms.Button();
            this.InputStepLabel = new System.Windows.Forms.Label();
            this.InputMaxLabel = new System.Windows.Forms.Label();
            this.InputMinLabel = new System.Windows.Forms.Label();
            this.InputTypeCombobox = new System.Windows.Forms.ComboBox();
            this.GenerateOutputButton = new System.Windows.Forms.Button();
            this.DomainOutputGroupbox = new System.Windows.Forms.GroupBox();
            this.OutputMaxTextbox = new System.Windows.Forms.TextBox();
            this.OutputMinTextbox = new System.Windows.Forms.TextBox();
            this.OutputMaxLabel = new System.Windows.Forms.Label();
            this.OutputMinLabel = new System.Windows.Forms.Label();
            this.FunctionCheckBox = new System.Windows.Forms.CheckBox();
            this.PlotButton = new System.Windows.Forms.Button();
            this.SgnCorrCheckbox = new System.Windows.Forms.CheckBox();
            this.DomainCheckbox = new System.Windows.Forms.CheckBox();
            this.AutocorPanel = new System.Windows.Forms.Panel();
            this.FunctionTextbox = new System.Windows.Forms.TextBox();
            this.FunctionLabel = new System.Windows.Forms.Label();
            this.FunctionPanel = new System.Windows.Forms.Panel();
            this.DistribusionPanel = new System.Windows.Forms.Panel();
            this.DistribusionGroupBox.SuspendLayout();
            this.PirsonGroupbox.SuspendLayout();
            this.GenerateInputGroupbox.SuspendLayout();
            this.DomainOutputGroupbox.SuspendLayout();
            this.AutocorPanel.SuspendLayout();
            this.FunctionPanel.SuspendLayout();
            this.DistribusionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DistribusionTypeBox
            // 
            this.DistribusionTypeBox.FormattingEnabled = true;
            this.DistribusionTypeBox.Items.AddRange(new object[] {
            "Нормальное",
            "Равномерное",
            "Парето",
            "Коши",
            "Экспоненциальное",
            "Лапласа",
            "Гамма",
            "Хи квадрат"});
            this.DistribusionTypeBox.Location = new System.Drawing.Point(192, 26);
            this.DistribusionTypeBox.Name = "DistribusionTypeBox";
            this.DistribusionTypeBox.Size = new System.Drawing.Size(194, 28);
            this.DistribusionTypeBox.TabIndex = 0;
            this.DistribusionTypeBox.SelectedIndexChanged += new System.EventHandler(this.DistribusionTypeBox_SelectedIndexChanged);
            // 
            // DistribusionTypeLabel
            // 
            this.DistribusionTypeLabel.AutoSize = true;
            this.DistribusionTypeLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DistribusionTypeLabel.Location = new System.Drawing.Point(6, 27);
            this.DistribusionTypeLabel.Name = "DistribusionTypeLabel";
            this.DistribusionTypeLabel.Size = new System.Drawing.Size(165, 23);
            this.DistribusionTypeLabel.TabIndex = 1;
            this.DistribusionTypeLabel.Text = "Тип распределения";
            // 
            // Param1Label
            // 
            this.Param1Label.AutoSize = true;
            this.Param1Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Param1Label.Location = new System.Drawing.Point(6, 60);
            this.Param1Label.Name = "Param1Label";
            this.Param1Label.Size = new System.Drawing.Size(68, 23);
            this.Param1Label.TabIndex = 2;
            this.Param1Label.Text = "param1";
            this.Param1Label.Visible = false;
            // 
            // Param2Label
            // 
            this.Param2Label.AutoSize = true;
            this.Param2Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Param2Label.Location = new System.Drawing.Point(6, 93);
            this.Param2Label.Name = "Param2Label";
            this.Param2Label.Size = new System.Drawing.Size(68, 23);
            this.Param2Label.TabIndex = 3;
            this.Param2Label.Text = "param2";
            this.Param2Label.Visible = false;
            // 
            // Param1Textbox
            // 
            this.Param1Textbox.Location = new System.Drawing.Point(192, 60);
            this.Param1Textbox.Name = "Param1Textbox";
            this.Param1Textbox.Size = new System.Drawing.Size(194, 27);
            this.Param1Textbox.TabIndex = 5;
            this.Param1Textbox.Visible = false;
            // 
            // DistribusionGroupBox
            // 
            this.DistribusionGroupBox.Controls.Add(this.Param2Textbox);
            this.DistribusionGroupBox.Controls.Add(this.Param1Textbox);
            this.DistribusionGroupBox.Controls.Add(this.Param2Label);
            this.DistribusionGroupBox.Controls.Add(this.DistribusionTypeBox);
            this.DistribusionGroupBox.Controls.Add(this.DistribusionTypeLabel);
            this.DistribusionGroupBox.Controls.Add(this.Param1Label);
            this.DistribusionGroupBox.Location = new System.Drawing.Point(7, 3);
            this.DistribusionGroupBox.Name = "DistribusionGroupBox";
            this.DistribusionGroupBox.Size = new System.Drawing.Size(392, 138);
            this.DistribusionGroupBox.TabIndex = 6;
            this.DistribusionGroupBox.TabStop = false;
            this.DistribusionGroupBox.Text = "Распределение";
            // 
            // Param2Textbox
            // 
            this.Param2Textbox.Location = new System.Drawing.Point(192, 93);
            this.Param2Textbox.Name = "Param2Textbox";
            this.Param2Textbox.Size = new System.Drawing.Size(194, 27);
            this.Param2Textbox.TabIndex = 6;
            this.Param2Textbox.Visible = false;
            // 
            // PirsonGroupbox
            // 
            this.PirsonGroupbox.Controls.Add(this.PirsonTextbox);
            this.PirsonGroupbox.Controls.Add(this.PirsonLabel);
            this.PirsonGroupbox.Location = new System.Drawing.Point(12, 113);
            this.PirsonGroupbox.Name = "PirsonGroupbox";
            this.PirsonGroupbox.Size = new System.Drawing.Size(250, 76);
            this.PirsonGroupbox.TabIndex = 14;
            this.PirsonGroupbox.TabStop = false;
            this.PirsonGroupbox.Text = "Коэфициент корреляции";
            this.PirsonGroupbox.Visible = false;
            // 
            // PirsonTextbox
            // 
            this.PirsonTextbox.Location = new System.Drawing.Point(51, 30);
            this.PirsonTextbox.Name = "PirsonTextbox";
            this.PirsonTextbox.Size = new System.Drawing.Size(179, 27);
            this.PirsonTextbox.TabIndex = 1;
            // 
            // PirsonLabel
            // 
            this.PirsonLabel.AutoSize = true;
            this.PirsonLabel.Location = new System.Drawing.Point(28, 37);
            this.PirsonLabel.Name = "PirsonLabel";
            this.PirsonLabel.Size = new System.Drawing.Size(17, 20);
            this.PirsonLabel.TabIndex = 0;
            this.PirsonLabel.Text = "P";
            // 
            // GenerationTypeBox
            // 
            this.GenerationTypeBox.BackColor = System.Drawing.SystemColors.Window;
            this.GenerationTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenerationTypeBox.FormattingEnabled = true;
            this.GenerationTypeBox.Items.AddRange(new object[] {
            "С заданной случайной величиной",
            "По коэфициенту корреляции",
            "Автомоделирование"});
            this.GenerationTypeBox.Location = new System.Drawing.Point(172, 79);
            this.GenerationTypeBox.Name = "GenerationTypeBox";
            this.GenerationTypeBox.Size = new System.Drawing.Size(267, 28);
            this.GenerationTypeBox.TabIndex = 7;
            this.GenerationTypeBox.SelectedIndexChanged += new System.EventHandler(this.GenerationTypeBox_SelectedIndexChanged);
            // 
            // GenerationTypeLabel
            // 
            this.GenerationTypeLabel.AutoSize = true;
            this.GenerationTypeLabel.Location = new System.Drawing.Point(12, 79);
            this.GenerationTypeLabel.Name = "GenerationTypeLabel";
            this.GenerationTypeLabel.Size = new System.Drawing.Size(152, 20);
            this.GenerationTypeLabel.TabIndex = 8;
            this.GenerationTypeLabel.Text = "Тип моделирования";
            // 
            // InputTypeLabel
            // 
            this.InputTypeLabel.AutoSize = true;
            this.InputTypeLabel.Location = new System.Drawing.Point(12, 45);
            this.InputTypeLabel.Name = "InputTypeLabel";
            this.InputTypeLabel.Size = new System.Drawing.Size(127, 20);
            this.InputTypeLabel.TabIndex = 9;
            this.InputTypeLabel.Text = "Входные данные";
            // 
            // OutputValuesTextbox
            // 
            this.OutputValuesTextbox.Enabled = false;
            this.OutputValuesTextbox.Location = new System.Drawing.Point(225, 309);
            this.OutputValuesTextbox.Multiline = true;
            this.OutputValuesTextbox.Name = "OutputValuesTextbox";
            this.OutputValuesTextbox.ReadOnly = true;
            this.OutputValuesTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutputValuesTextbox.Size = new System.Drawing.Size(207, 347);
            this.OutputValuesTextbox.TabIndex = 11;
            // 
            // InputValuesTextbox
            // 
            this.InputValuesTextbox.Enabled = false;
            this.InputValuesTextbox.Location = new System.Drawing.Point(12, 309);
            this.InputValuesTextbox.Multiline = true;
            this.InputValuesTextbox.Name = "InputValuesTextbox";
            this.InputValuesTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InputValuesTextbox.Size = new System.Drawing.Size(207, 347);
            this.InputValuesTextbox.TabIndex = 12;
            // 
            // GenerateInputGroupbox
            // 
            this.GenerateInputGroupbox.Controls.Add(this.InputStepTextBox);
            this.GenerateInputGroupbox.Controls.Add(this.InputMaxTextBox);
            this.GenerateInputGroupbox.Controls.Add(this.InputMinTextbox);
            this.GenerateInputGroupbox.Controls.Add(this.GenerateInputButton);
            this.GenerateInputGroupbox.Controls.Add(this.InputStepLabel);
            this.GenerateInputGroupbox.Controls.Add(this.InputMaxLabel);
            this.GenerateInputGroupbox.Controls.Add(this.InputMinLabel);
            this.GenerateInputGroupbox.Location = new System.Drawing.Point(445, 25);
            this.GenerateInputGroupbox.Name = "GenerateInputGroupbox";
            this.GenerateInputGroupbox.Size = new System.Drawing.Size(360, 178);
            this.GenerateInputGroupbox.TabIndex = 13;
            this.GenerateInputGroupbox.TabStop = false;
            this.GenerateInputGroupbox.Text = "Входные данные";
            this.GenerateInputGroupbox.Visible = false;
            // 
            // InputStepTextBox
            // 
            this.InputStepTextBox.Location = new System.Drawing.Point(122, 104);
            this.InputStepTextBox.Name = "InputStepTextBox";
            this.InputStepTextBox.Size = new System.Drawing.Size(125, 27);
            this.InputStepTextBox.TabIndex = 6;
            // 
            // InputMaxTextBox
            // 
            this.InputMaxTextBox.Location = new System.Drawing.Point(122, 71);
            this.InputMaxTextBox.Name = "InputMaxTextBox";
            this.InputMaxTextBox.Size = new System.Drawing.Size(125, 27);
            this.InputMaxTextBox.TabIndex = 5;
            // 
            // InputMinTextbox
            // 
            this.InputMinTextbox.Location = new System.Drawing.Point(122, 38);
            this.InputMinTextbox.Name = "InputMinTextbox";
            this.InputMinTextbox.Size = new System.Drawing.Size(125, 27);
            this.InputMinTextbox.TabIndex = 4;
            // 
            // GenerateInputButton
            // 
            this.GenerateInputButton.Location = new System.Drawing.Point(211, 143);
            this.GenerateInputButton.Name = "GenerateInputButton";
            this.GenerateInputButton.Size = new System.Drawing.Size(126, 29);
            this.GenerateInputButton.TabIndex = 3;
            this.GenerateInputButton.Text = "Сгенерировать";
            this.GenerateInputButton.UseVisualStyleBackColor = true;
            this.GenerateInputButton.Click += new System.EventHandler(this.GenerateInputButton_Click);
            // 
            // InputStepLabel
            // 
            this.InputStepLabel.AutoSize = true;
            this.InputStepLabel.Location = new System.Drawing.Point(38, 107);
            this.InputStepLabel.Name = "InputStepLabel";
            this.InputStepLabel.Size = new System.Drawing.Size(37, 20);
            this.InputStepLabel.TabIndex = 2;
            this.InputStepLabel.Text = "Шаг";
            // 
            // InputMaxLabel
            // 
            this.InputMaxLabel.AutoSize = true;
            this.InputMaxLabel.Location = new System.Drawing.Point(38, 74);
            this.InputMaxLabel.Name = "InputMaxLabel";
            this.InputMaxLabel.Size = new System.Drawing.Size(82, 20);
            this.InputMaxLabel.TabIndex = 1;
            this.InputMaxLabel.Text = "Максимум";
            // 
            // InputMinLabel
            // 
            this.InputMinLabel.AutoSize = true;
            this.InputMinLabel.Location = new System.Drawing.Point(38, 41);
            this.InputMinLabel.Name = "InputMinLabel";
            this.InputMinLabel.Size = new System.Drawing.Size(78, 20);
            this.InputMinLabel.TabIndex = 0;
            this.InputMinLabel.Text = "Минимум";
            // 
            // InputTypeCombobox
            // 
            this.InputTypeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputTypeCombobox.FormattingEnabled = true;
            this.InputTypeCombobox.Items.AddRange(new object[] {
            "Вручную",
            "Генерировать",
            "Из файла"});
            this.InputTypeCombobox.Location = new System.Drawing.Point(172, 42);
            this.InputTypeCombobox.Name = "InputTypeCombobox";
            this.InputTypeCombobox.Size = new System.Drawing.Size(267, 28);
            this.InputTypeCombobox.TabIndex = 7;
            this.InputTypeCombobox.SelectedIndexChanged += new System.EventHandler(this.InputTypeCombobox_SelectedIndexChanged);
            // 
            // GenerateOutputButton
            // 
            this.GenerateOutputButton.Location = new System.Drawing.Point(40, 662);
            this.GenerateOutputButton.Name = "GenerateOutputButton";
            this.GenerateOutputButton.Size = new System.Drawing.Size(120, 29);
            this.GenerateOutputButton.TabIndex = 7;
            this.GenerateOutputButton.Text = "Моделировать";
            this.GenerateOutputButton.UseVisualStyleBackColor = true;
            this.GenerateOutputButton.Click += new System.EventHandler(this.GenerateOutputButton_Click);
            // 
            // DomainOutputGroupbox
            // 
            this.DomainOutputGroupbox.Controls.Add(this.OutputMaxTextbox);
            this.DomainOutputGroupbox.Controls.Add(this.OutputMinTextbox);
            this.DomainOutputGroupbox.Controls.Add(this.OutputMaxLabel);
            this.DomainOutputGroupbox.Controls.Add(this.OutputMinLabel);
            this.DomainOutputGroupbox.Location = new System.Drawing.Point(4, 54);
            this.DomainOutputGroupbox.Name = "DomainOutputGroupbox";
            this.DomainOutputGroupbox.Size = new System.Drawing.Size(304, 110);
            this.DomainOutputGroupbox.TabIndex = 15;
            this.DomainOutputGroupbox.TabStop = false;
            this.DomainOutputGroupbox.Text = "Границы выходных значений";
            this.DomainOutputGroupbox.Visible = false;
            // 
            // OutputMaxTextbox
            // 
            this.OutputMaxTextbox.Location = new System.Drawing.Point(109, 71);
            this.OutputMaxTextbox.Name = "OutputMaxTextbox";
            this.OutputMaxTextbox.Size = new System.Drawing.Size(181, 27);
            this.OutputMaxTextbox.TabIndex = 3;
            // 
            // OutputMinTextbox
            // 
            this.OutputMinTextbox.Location = new System.Drawing.Point(109, 38);
            this.OutputMinTextbox.Name = "OutputMinTextbox";
            this.OutputMinTextbox.Size = new System.Drawing.Size(181, 27);
            this.OutputMinTextbox.TabIndex = 2;
            // 
            // OutputMaxLabel
            // 
            this.OutputMaxLabel.AutoSize = true;
            this.OutputMaxLabel.Location = new System.Drawing.Point(10, 74);
            this.OutputMaxLabel.Name = "OutputMaxLabel";
            this.OutputMaxLabel.Size = new System.Drawing.Size(82, 20);
            this.OutputMaxLabel.TabIndex = 1;
            this.OutputMaxLabel.Text = "Максимум";
            // 
            // OutputMinLabel
            // 
            this.OutputMinLabel.AutoSize = true;
            this.OutputMinLabel.Location = new System.Drawing.Point(10, 41);
            this.OutputMinLabel.Name = "OutputMinLabel";
            this.OutputMinLabel.Size = new System.Drawing.Size(78, 20);
            this.OutputMinLabel.TabIndex = 0;
            this.OutputMinLabel.Text = "Минимум";
            // 
            // FunctionCheckBox
            // 
            this.FunctionCheckBox.AutoSize = true;
            this.FunctionCheckBox.Location = new System.Drawing.Point(13, 152);
            this.FunctionCheckBox.Name = "FunctionCheckBox";
            this.FunctionCheckBox.Size = new System.Drawing.Size(144, 24);
            this.FunctionCheckBox.TabIndex = 16;
            this.FunctionCheckBox.Text = "Задать функцию";
            this.FunctionCheckBox.UseVisualStyleBackColor = true;
            this.FunctionCheckBox.CheckedChanged += new System.EventHandler(this.FunctionCheckBox_CheckedChanged);
            // 
            // PlotButton
            // 
            this.PlotButton.Location = new System.Drawing.Point(281, 662);
            this.PlotButton.Name = "PlotButton";
            this.PlotButton.Size = new System.Drawing.Size(120, 29);
            this.PlotButton.TabIndex = 23;
            this.PlotButton.Text = "График";
            this.PlotButton.UseVisualStyleBackColor = true;
            this.PlotButton.Click += new System.EventHandler(this.PlotButton_Click);
            // 
            // SgnCorrCheckbox
            // 
            this.SgnCorrCheckbox.AutoSize = true;
            this.SgnCorrCheckbox.Location = new System.Drawing.Point(3, 3);
            this.SgnCorrCheckbox.Name = "SgnCorrCheckbox";
            this.SgnCorrCheckbox.Size = new System.Drawing.Size(226, 24);
            this.SgnCorrCheckbox.TabIndex = 21;
            this.SgnCorrCheckbox.Text = "Отрицательная корреляция";
            this.SgnCorrCheckbox.UseVisualStyleBackColor = true;
            // 
            // DomainCheckbox
            // 
            this.DomainCheckbox.AutoSize = true;
            this.DomainCheckbox.Location = new System.Drawing.Point(4, 26);
            this.DomainCheckbox.Name = "DomainCheckbox";
            this.DomainCheckbox.Size = new System.Drawing.Size(259, 24);
            this.DomainCheckbox.TabIndex = 17;
            this.DomainCheckbox.Text = "Ограничить выходные значения";
            this.DomainCheckbox.UseVisualStyleBackColor = true;
            this.DomainCheckbox.CheckedChanged += new System.EventHandler(this.DomainCheckbox_CheckedChanged);
            // 
            // AutocorPanel
            // 
            this.AutocorPanel.Controls.Add(this.SgnCorrCheckbox);
            this.AutocorPanel.Controls.Add(this.DomainCheckbox);
            this.AutocorPanel.Controls.Add(this.DomainOutputGroupbox);
            this.AutocorPanel.Location = new System.Drawing.Point(12, 113);
            this.AutocorPanel.Name = "AutocorPanel";
            this.AutocorPanel.Size = new System.Drawing.Size(320, 176);
            this.AutocorPanel.TabIndex = 24;
            this.AutocorPanel.Visible = false;
            // 
            // FunctionTextbox
            // 
            this.FunctionTextbox.Location = new System.Drawing.Point(50, 3);
            this.FunctionTextbox.Name = "FunctionTextbox";
            this.FunctionTextbox.Size = new System.Drawing.Size(176, 27);
            this.FunctionTextbox.TabIndex = 19;
            // 
            // FunctionLabel
            // 
            this.FunctionLabel.AutoSize = true;
            this.FunctionLabel.Location = new System.Drawing.Point(3, 6);
            this.FunctionLabel.Name = "FunctionLabel";
            this.FunctionLabel.Size = new System.Drawing.Size(41, 20);
            this.FunctionLabel.TabIndex = 18;
            this.FunctionLabel.Text = "f(x)=";
            // 
            // FunctionPanel
            // 
            this.FunctionPanel.Controls.Add(this.FunctionLabel);
            this.FunctionPanel.Controls.Add(this.FunctionTextbox);
            this.FunctionPanel.Location = new System.Drawing.Point(163, 147);
            this.FunctionPanel.Name = "FunctionPanel";
            this.FunctionPanel.Size = new System.Drawing.Size(234, 35);
            this.FunctionPanel.TabIndex = 25;
            this.FunctionPanel.Visible = false;
            // 
            // DistribusionPanel
            // 
            this.DistribusionPanel.Controls.Add(this.FunctionCheckBox);
            this.DistribusionPanel.Controls.Add(this.FunctionPanel);
            this.DistribusionPanel.Controls.Add(this.DistribusionGroupBox);
            this.DistribusionPanel.Location = new System.Drawing.Point(12, 113);
            this.DistribusionPanel.Name = "DistribusionPanel";
            this.DistribusionPanel.Size = new System.Drawing.Size(409, 190);
            this.DistribusionPanel.TabIndex = 26;
            this.DistribusionPanel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 703);
            this.Controls.Add(this.DistribusionPanel);
            this.Controls.Add(this.AutocorPanel);
            this.Controls.Add(this.PlotButton);
            this.Controls.Add(this.PirsonGroupbox);
            this.Controls.Add(this.GenerateOutputButton);
            this.Controls.Add(this.InputTypeCombobox);
            this.Controls.Add(this.GenerateInputGroupbox);
            this.Controls.Add(this.InputValuesTextbox);
            this.Controls.Add(this.OutputValuesTextbox);
            this.Controls.Add(this.InputTypeLabel);
            this.Controls.Add(this.GenerationTypeLabel);
            this.Controls.Add(this.GenerationTypeBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DataMaker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DistribusionGroupBox.ResumeLayout(false);
            this.DistribusionGroupBox.PerformLayout();
            this.PirsonGroupbox.ResumeLayout(false);
            this.PirsonGroupbox.PerformLayout();
            this.GenerateInputGroupbox.ResumeLayout(false);
            this.GenerateInputGroupbox.PerformLayout();
            this.DomainOutputGroupbox.ResumeLayout(false);
            this.DomainOutputGroupbox.PerformLayout();
            this.AutocorPanel.ResumeLayout(false);
            this.AutocorPanel.PerformLayout();
            this.FunctionPanel.ResumeLayout(false);
            this.FunctionPanel.PerformLayout();
            this.DistribusionPanel.ResumeLayout(false);
            this.DistribusionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DistribusionTypeBox;
        private System.Windows.Forms.Label DistribusionTypeLabel;
        private System.Windows.Forms.Label Param1Label;
        private System.Windows.Forms.Label Param2Label;
        private System.Windows.Forms.TextBox Param1Textbox;
        private System.Windows.Forms.GroupBox DistribusionGroupBox;
        private System.Windows.Forms.TextBox Param2Textbox;
        private System.Windows.Forms.ComboBox GenerationTypeBox;
        private System.Windows.Forms.Label GenerationTypeLabel;
        private System.Windows.Forms.Label InputTypeLabel;
        private System.Windows.Forms.TextBox OutputValuesTextbox;
        private System.Windows.Forms.TextBox InputValuesTextbox;
        private System.Windows.Forms.GroupBox GenerateInputGroupbox;
        private System.Windows.Forms.Button GenerateInputButton;
        private System.Windows.Forms.Label InputStepLabel;
        private System.Windows.Forms.Label InputMaxLabel;
        private System.Windows.Forms.Label InputMinLabel;
        private System.Windows.Forms.TextBox InputStepTextBox;
        private System.Windows.Forms.TextBox InputMaxTextBox;
        private System.Windows.Forms.TextBox InputMinTextbox;
        private System.Windows.Forms.ComboBox InputTypeCombobox;
        private System.Windows.Forms.Button GenerateOutputButton;
        private System.Windows.Forms.GroupBox PirsonGroupbox;
        private System.Windows.Forms.TextBox PirsonTextbox;
        private System.Windows.Forms.Label PirsonLabel;
        private System.Windows.Forms.GroupBox DomainOutputGroupbox;
        private System.Windows.Forms.TextBox OutputMaxTextbox;
        private System.Windows.Forms.TextBox OutputMinTextbox;
        private System.Windows.Forms.Label OutputMaxLabel;
        private System.Windows.Forms.Label OutputMinLabel;
        private System.Windows.Forms.CheckBox FunctionCheckBox;
        private System.Windows.Forms.Button PlotButton;
        private System.Windows.Forms.CheckBox SgnCorrCheckbox;
        private System.Windows.Forms.CheckBox DomainCheckbox;
        private System.Windows.Forms.Panel AutocorPanel;
        private System.Windows.Forms.TextBox FunctionTextbox;
        private System.Windows.Forms.Label FunctionLabel;
        private System.Windows.Forms.Panel FunctionPanel;
        private System.Windows.Forms.Panel DistribusionPanel;
    }
}

