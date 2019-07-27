namespace Assignment4_Juneyeong
{
    partial class BMICalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ImperialTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.MetricTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.KiloTextBox = new System.Windows.Forms.TextBox();
            this.MeterTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BMILabel = new System.Windows.Forms.Label();
            this.BMITextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.MultiLineTextBox = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ImperialTableLayoutPanel.SuspendLayout();
            this.MetricTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImperialTableLayoutPanel
            // 
            this.ImperialTableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.ImperialTableLayoutPanel.ColumnCount = 2;
            this.ImperialTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.13383F));
            this.ImperialTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.86617F));
            this.ImperialTableLayoutPanel.Controls.Add(this.WeightTextBox, 1, 1);
            this.ImperialTableLayoutPanel.Controls.Add(this.WeightLabel, 0, 1);
            this.ImperialTableLayoutPanel.Controls.Add(this.HeightTextBox, 1, 0);
            this.ImperialTableLayoutPanel.Controls.Add(this.HeightLabel, 0, 0);
            this.ImperialTableLayoutPanel.Location = new System.Drawing.Point(13, 84);
            this.ImperialTableLayoutPanel.Name = "ImperialTableLayoutPanel";
            this.ImperialTableLayoutPanel.RowCount = 2;
            this.ImperialTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ImperialTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ImperialTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ImperialTableLayoutPanel.Size = new System.Drawing.Size(269, 132);
            this.ImperialTableLayoutPanel.TabIndex = 0;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightTextBox.Location = new System.Drawing.Point(154, 69);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(112, 69);
            this.WeightTextBox.TabIndex = 5;
            this.WeightTextBox.Text = "pound";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(3, 66);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(115, 66);
            this.WeightLabel.TabIndex = 3;
            this.WeightLabel.Text = "My Weight";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightTextBox.Location = new System.Drawing.Point(154, 3);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(112, 69);
            this.HeightTextBox.TabIndex = 4;
            this.HeightTextBox.Text = "inch";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(3, 0);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(139, 66);
            this.HeightLabel.TabIndex = 2;
            this.HeightLabel.Text = "My Height";
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Checked = true;
            this.ImperialRadioButton.Location = new System.Drawing.Point(12, 40);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(254, 58);
            this.ImperialRadioButton.TabIndex = 0;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            this.ImperialRadioButton.CheckedChanged += new System.EventHandler(this.ImperialRadioButton_CheckedChanged);
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Location = new System.Drawing.Point(167, 40);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(208, 58);
            this.MetricRadioButton.TabIndex = 1;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            this.MetricRadioButton.CheckedChanged += new System.EventHandler(this.MetricRadioButton_CheckedChanged);
            // 
            // MetricTableLayoutPanel
            // 
            this.MetricTableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.MetricTableLayoutPanel.ColumnCount = 2;
            this.MetricTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.13383F));
            this.MetricTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.86617F));
            this.MetricTableLayoutPanel.Controls.Add(this.KiloTextBox, 1, 1);
            this.MetricTableLayoutPanel.Controls.Add(this.MeterTextBox, 1, 0);
            this.MetricTableLayoutPanel.Controls.Add(this.label1, 0, 1);
            this.MetricTableLayoutPanel.Controls.Add(this.label2, 0, 0);
            this.MetricTableLayoutPanel.Location = new System.Drawing.Point(13, 84);
            this.MetricTableLayoutPanel.Name = "MetricTableLayoutPanel";
            this.MetricTableLayoutPanel.RowCount = 2;
            this.MetricTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.MetricTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.MetricTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MetricTableLayoutPanel.Size = new System.Drawing.Size(269, 132);
            this.MetricTableLayoutPanel.TabIndex = 2;
            this.MetricTableLayoutPanel.Visible = false;
            // 
            // KiloTextBox
            // 
            this.KiloTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KiloTextBox.Location = new System.Drawing.Point(154, 69);
            this.KiloTextBox.Name = "KiloTextBox";
            this.KiloTextBox.Size = new System.Drawing.Size(112, 69);
            this.KiloTextBox.TabIndex = 5;
            this.KiloTextBox.Text = "kilogram";
            // 
            // MeterTextBox
            // 
            this.MeterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MeterTextBox.Location = new System.Drawing.Point(154, 3);
            this.MeterTextBox.Name = "MeterTextBox";
            this.MeterTextBox.Size = new System.Drawing.Size(112, 69);
            this.MeterTextBox.TabIndex = 4;
            this.MeterTextBox.Text = "meter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 66);
            this.label1.TabIndex = 3;
            this.label1.Text = "My Weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 66);
            this.label2.TabIndex = 2;
            this.label2.Text = "My Height";
            // 
            // BMILabel
            // 
            this.BMILabel.AutoSize = true;
            this.BMILabel.BackColor = System.Drawing.Color.PapayaWhip;
            this.BMILabel.Location = new System.Drawing.Point(56, 6);
            this.BMILabel.Name = "BMILabel";
            this.BMILabel.Size = new System.Drawing.Size(392, 54);
            this.BMILabel.TabIndex = 3;
            this.BMILabel.Text = "BMI Calculator";
            // 
            // BMITextBox
            // 
            this.BMITextBox.BackColor = System.Drawing.Color.Beige;
            this.BMITextBox.Location = new System.Drawing.Point(65, 290);
            this.BMITextBox.Name = "BMITextBox";
            this.BMITextBox.ReadOnly = true;
            this.BMITextBox.Size = new System.Drawing.Size(179, 69);
            this.BMITextBox.TabIndex = 4;
            this.BMITextBox.Text = "0";
            this.BMITextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BMITextBox.Visible = false;
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.CalculateButton.Location = new System.Drawing.Point(42, 243);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(214, 39);
            this.CalculateButton.TabIndex = 5;
            this.CalculateButton.Text = "Claculate";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // MultiLineTextBox
            // 
            this.MultiLineTextBox.Location = new System.Drawing.Point(25, 338);
            this.MultiLineTextBox.Multiline = true;
            this.MultiLineTextBox.Name = "MultiLineTextBox";
            this.MultiLineTextBox.Size = new System.Drawing.Size(241, 62);
            this.MultiLineTextBox.TabIndex = 6;
            this.MultiLineTextBox.Visible = false;
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.ResetButton.Location = new System.Drawing.Point(79, 200);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(146, 38);
            this.ResetButton.TabIndex = 7;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(31F, 53F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(294, 409);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.MultiLineTextBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.BMITextBox);
            this.Controls.Add(this.BMILabel);
            this.Controls.Add(this.MetricTableLayoutPanel);
            this.Controls.Add(this.ImperialTableLayoutPanel);
            this.Controls.Add(this.ImperialRadioButton);
            this.Controls.Add(this.MetricRadioButton);
            this.Font = new System.Drawing.Font("Gulim", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BMICalculatorForm_FormClosing);
            this.ImperialTableLayoutPanel.ResumeLayout(false);
            this.ImperialTableLayoutPanel.PerformLayout();
            this.MetricTableLayoutPanel.ResumeLayout(false);
            this.MetricTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ImperialTableLayoutPanel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.TableLayoutPanel MetricTableLayoutPanel;
        private System.Windows.Forms.TextBox KiloTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MeterTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label BMILabel;
        private System.Windows.Forms.TextBox BMITextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox MultiLineTextBox;
        private System.Windows.Forms.Button ResetButton;
    }
}

