namespace Dmytro_Geras_Lab07_Sec001
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resultFactorial = new System.Windows.Forms.Label();
            this.tbFactorial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.radioChars = new System.Windows.Forms.RadioButton();
            this.tbLowIndex = new System.Windows.Forms.TextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbHighIndex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioDoubles = new System.Windows.Forms.RadioButton();
            this.radioIntegers = new System.Windows.Forms.RadioButton();
            this.listBoxGenerated = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resultEvenOdd = new System.Windows.Forms.Label();
            this.tbEvenOdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEvenOdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resultFactorial);
            this.groupBox1.Controls.Add(this.tbFactorial);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnFactorial);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 360);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "(1) Calculate Asynchronously";
            // 
            // resultFactorial
            // 
            this.resultFactorial.AutoSize = true;
            this.resultFactorial.Location = new System.Drawing.Point(42, 314);
            this.resultFactorial.MinimumSize = new System.Drawing.Size(650, 0);
            this.resultFactorial.Name = "resultFactorial";
            this.resultFactorial.Size = new System.Drawing.Size(650, 32);
            this.resultFactorial.TabIndex = 3;
            // 
            // tbFactorial
            // 
            this.tbFactorial.Location = new System.Drawing.Point(369, 76);
            this.tbFactorial.Multiline = true;
            this.tbFactorial.Name = "tbFactorial";
            this.tbFactorial.Size = new System.Drawing.Size(288, 64);
            this.tbFactorial.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Get factorial of:";
            // 
            // btnFactorial
            // 
            this.btnFactorial.Location = new System.Drawing.Point(58, 236);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(201, 64);
            this.btnFactorial.TabIndex = 0;
            this.btnFactorial.Text = "Calculate";
            this.btnFactorial.UseVisualStyleBackColor = true;
            this.btnFactorial.Click += new System.EventHandler(this.btnFactorial_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbDisplay);
            this.groupBox3.Controls.Add(this.btnGenerate);
            this.groupBox3.Controls.Add(this.radioChars);
            this.groupBox3.Controls.Add(this.tbLowIndex);
            this.groupBox3.Controls.Add(this.btnDisplay);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbHighIndex);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tbSearch);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.radioDoubles);
            this.groupBox3.Controls.Add(this.radioIntegers);
            this.groupBox3.Controls.Add(this.listBoxGenerated);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(816, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1159, 778);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "(3) Display List of Values and Search";
            // 
            // tbDisplay
            // 
            this.tbDisplay.Location = new System.Drawing.Point(291, 624);
            this.tbDisplay.Multiline = true;
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.Size = new System.Drawing.Size(790, 99);
            this.tbDisplay.TabIndex = 5;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(728, 37);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(370, 73);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate Values";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // radioChars
            // 
            this.radioChars.AutoSize = true;
            this.radioChars.Location = new System.Drawing.Point(525, 75);
            this.radioChars.Name = "radioChars";
            this.radioChars.Size = new System.Drawing.Size(132, 36);
            this.radioChars.TabIndex = 3;
            this.radioChars.Text = "Chars";
            this.radioChars.UseVisualStyleBackColor = true;
            // 
            // tbLowIndex
            // 
            this.tbLowIndex.Location = new System.Drawing.Point(629, 323);
            this.tbLowIndex.Multiline = true;
            this.tbLowIndex.Name = "tbLowIndex";
            this.tbLowIndex.Size = new System.Drawing.Size(218, 64);
            this.tbLowIndex.TabIndex = 2;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(897, 384);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(201, 64);
            this.btnDisplay.TabIndex = 0;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(897, 195);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(201, 64);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Input low index:";
            // 
            // tbHighIndex
            // 
            this.tbHighIndex.Location = new System.Drawing.Point(629, 438);
            this.tbHighIndex.Multiline = true;
            this.tbHighIndex.Name = "tbHighIndex";
            this.tbHighIndex.Size = new System.Drawing.Size(218, 64);
            this.tbHighIndex.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Input high index:";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(629, 195);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(218, 64);
            this.tbSearch.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input value for search:";
            // 
            // radioDoubles
            // 
            this.radioDoubles.AutoSize = true;
            this.radioDoubles.Location = new System.Drawing.Point(291, 75);
            this.radioDoubles.Name = "radioDoubles";
            this.radioDoubles.Size = new System.Drawing.Size(164, 36);
            this.radioDoubles.TabIndex = 2;
            this.radioDoubles.Text = "Doubles";
            this.radioDoubles.UseVisualStyleBackColor = true;
            // 
            // radioIntegers
            // 
            this.radioIntegers.AutoSize = true;
            this.radioIntegers.Checked = true;
            this.radioIntegers.Location = new System.Drawing.Point(57, 76);
            this.radioIntegers.Name = "radioIntegers";
            this.radioIntegers.Size = new System.Drawing.Size(162, 36);
            this.radioIntegers.TabIndex = 1;
            this.radioIntegers.TabStop = true;
            this.radioIntegers.Text = "Integers";
            this.radioIntegers.UseVisualStyleBackColor = true;
            // 
            // listBoxGenerated
            // 
            this.listBoxGenerated.FormattingEnabled = true;
            this.listBoxGenerated.ItemHeight = 31;
            this.listBoxGenerated.Location = new System.Drawing.Point(31, 162);
            this.listBoxGenerated.Name = "listBoxGenerated";
            this.listBoxGenerated.Size = new System.Drawing.Size(189, 562);
            this.listBoxGenerated.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resultEvenOdd);
            this.groupBox2.Controls.Add(this.tbEvenOdd);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnEvenOdd);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(39, 456);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(704, 360);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "(2) Check for Even/Odd";
            // 
            // resultEvenOdd
            // 
            this.resultEvenOdd.AutoSize = true;
            this.resultEvenOdd.Location = new System.Drawing.Point(52, 288);
            this.resultEvenOdd.Name = "resultEvenOdd";
            this.resultEvenOdd.Size = new System.Drawing.Size(0, 32);
            this.resultEvenOdd.TabIndex = 3;
            // 
            // tbEvenOdd
            // 
            this.tbEvenOdd.Location = new System.Drawing.Point(369, 76);
            this.tbEvenOdd.Multiline = true;
            this.tbEvenOdd.Name = "tbEvenOdd";
            this.tbEvenOdd.Size = new System.Drawing.Size(288, 64);
            this.tbEvenOdd.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Input Number:";
            // 
            // btnEvenOdd
            // 
            this.btnEvenOdd.Location = new System.Drawing.Point(162, 179);
            this.btnEvenOdd.Name = "btnEvenOdd";
            this.btnEvenOdd.Size = new System.Drawing.Size(495, 64);
            this.btnEvenOdd.TabIndex = 0;
            this.btnEvenOdd.Text = "Check for Even or Odd";
            this.btnEvenOdd.UseVisualStyleBackColor = true;
            this.btnEvenOdd.Click += new System.EventHandler(this.btnEvenOdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 568);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(563, 32);
            this.label6.TabIndex = 6;
            this.label6.Text = "Output of values between Low and High:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2018, 860);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(2050, 948);
            this.MinimumSize = new System.Drawing.Size(2050, 948);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asyncgronous programming";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label resultFactorial;
        private System.Windows.Forms.TextBox tbFactorial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label resultEvenOdd;
        private System.Windows.Forms.TextBox tbEvenOdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEvenOdd;
        private System.Windows.Forms.RadioButton radioChars;
        private System.Windows.Forms.RadioButton radioDoubles;
        private System.Windows.Forms.RadioButton radioIntegers;
        private System.Windows.Forms.ListBox listBoxGenerated;
        private System.Windows.Forms.TextBox tbLowIndex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbHighIndex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label6;
    }
}

