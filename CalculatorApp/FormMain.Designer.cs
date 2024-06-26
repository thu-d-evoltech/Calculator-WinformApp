﻿namespace CalculatorApp
{
    partial class Calculator
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonPercent = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonNegate = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.resultDisplay = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textDisplay = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMultiply.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiply.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonMultiply.Location = new System.Drawing.Point(330, 79);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(105, 70);
            this.buttonMultiply.TabIndex = 15;
            this.buttonMultiply.Text = "x";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(221, 79);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(103, 70);
            this.button9.TabIndex = 14;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDivide.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivide.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonDivide.Location = new System.Drawing.Point(330, 3);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(105, 70);
            this.buttonDivide.TabIndex = 16;
            this.buttonDivide.Text = "÷";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(112, 79);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(103, 70);
            this.button8.TabIndex = 13;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSubtract.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubtract.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonSubtract.Location = new System.Drawing.Point(330, 155);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(105, 70);
            this.buttonSubtract.TabIndex = 8;
            this.buttonSubtract.Text = "-";
            this.buttonSubtract.UseVisualStyleBackColor = true;
            this.buttonSubtract.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(3, 79);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 70);
            this.button7.TabIndex = 12;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(221, 155);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 70);
            this.button6.TabIndex = 9;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonPercent
            // 
            this.buttonPercent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPercent.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPercent.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonPercent.Location = new System.Drawing.Point(3, 3);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.Size = new System.Drawing.Size(103, 70);
            this.buttonPercent.TabIndex = 19;
            this.buttonPercent.Text = "%";
            this.buttonPercent.UseVisualStyleBackColor = true;
            this.buttonPercent.Click += new System.EventHandler(this.buttonPercent_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(112, 155);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 70);
            this.button5.TabIndex = 10;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(3, 155);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 70);
            this.button4.TabIndex = 11;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdd.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonAdd.Location = new System.Drawing.Point(330, 231);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(105, 70);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(221, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 70);
            this.button3.TabIndex = 6;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(112, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 70);
            this.button2.TabIndex = 5;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 70);
            this.button1.TabIndex = 4;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonEquals
            // 
            this.buttonEquals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonEquals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEquals.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEquals.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEquals.Location = new System.Drawing.Point(330, 307);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(105, 73);
            this.buttonEquals.TabIndex = 20;
            this.buttonEquals.Text = "＝";
            this.buttonEquals.UseVisualStyleBackColor = false;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // buttonNegate
            // 
            this.buttonNegate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNegate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNegate.Location = new System.Drawing.Point(3, 307);
            this.buttonNegate.Name = "buttonNegate";
            this.buttonNegate.Size = new System.Drawing.Size(103, 73);
            this.buttonNegate.TabIndex = 3;
            this.buttonNegate.Text = "+/-";
            this.buttonNegate.UseVisualStyleBackColor = true;
            this.buttonNegate.Click += new System.EventHandler(this.buttonNegate_Click);
            // 
            // button0
            // 
            this.button0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button0.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(112, 307);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(103, 73);
            this.button0.TabIndex = 2;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDot.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDot.Location = new System.Drawing.Point(221, 307);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(103, 73);
            this.buttonDot.TabIndex = 1;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // buttonC
            // 
            this.buttonC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonC.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonC.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonC.Location = new System.Drawing.Point(112, 3);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(103, 70);
            this.buttonC.TabIndex = 18;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonDel.Image = global::CalculatorApp.Properties.Resources.delete__3_;
            this.buttonDel.Location = new System.Drawing.Point(221, 3);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(103, 70);
            this.buttonDel.TabIndex = 17;
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // resultDisplay
            // 
            this.resultDisplay.AutoSize = true;
            this.resultDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.resultDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultDisplay.Font = new System.Drawing.Font("MS UI Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.resultDisplay.Location = new System.Drawing.Point(3, 66);
            this.resultDisplay.Name = "resultDisplay";
            this.resultDisplay.Size = new System.Drawing.Size(438, 66);
            this.resultDisplay.TabIndex = 0;
            this.resultDisplay.Text = "0";
            this.resultDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.textDisplay, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.resultDisplay, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.76596F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.76596F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.46809F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(444, 521);
            this.tableLayoutPanel1.TabIndex = 31;
            // 
            // textDisplay
            // 
            this.textDisplay.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textDisplay.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textDisplay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textDisplay.Location = new System.Drawing.Point(3, 3);
            this.textDisplay.MaxLength = 20;
            this.textDisplay.MinimumSize = new System.Drawing.Size(438, 60);
            this.textDisplay.Multiline = true;
            this.textDisplay.Name = "textDisplay";
            this.textDisplay.ReadOnly = true;
            this.textDisplay.Size = new System.Drawing.Size(438, 60);
            this.textDisplay.TabIndex = 0;
            this.textDisplay.TabStop = false;
            this.textDisplay.TextChanged += new System.EventHandler(this.textDisplay_TextChanged);
            this.textDisplay.Enter += new System.EventHandler(this.textDisplay_Enter);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.buttonDel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonEquals, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttonAdd, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.buttonDot, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.button0, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttonNegate, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttonSubtract, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.button3, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.buttonMultiply, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.button6, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.buttonDivide, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.button5, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.button9, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.button4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.button8, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonPercent, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonC, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 135);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(438, 383);
            this.tableLayoutPanel2.TabIndex = 31;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(467, 549);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(420, 518);
            this.Name = "Calculator";
            this.Text = "電卓";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonPercent;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonNegate;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Label resultDisplay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textDisplay;
    }
}

