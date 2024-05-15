namespace CalculatorApp
{
    partial class 電卓
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(電卓));
            this.textDisplay = new System.Windows.Forms.TextBox();
            this.buttonMul = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.resultDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textDisplay
            // 
            this.textDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textDisplay.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDisplay.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textDisplay.Location = new System.Drawing.Point(15, 23);
            this.textDisplay.Multiline = true;
            this.textDisplay.Name = "textDisplay";
            this.textDisplay.ReadOnly = true;
            this.textDisplay.Size = new System.Drawing.Size(374, 90);
            this.textDisplay.TabIndex = 0;
            // 
            // buttonMul
            // 
            this.buttonMul.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMul.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonMul.Location = new System.Drawing.Point(303, 191);
            this.buttonMul.MaximumSize = new System.Drawing.Size(90, 61);
            this.buttonMul.MinimumSize = new System.Drawing.Size(90, 61);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(90, 61);
            this.buttonMul.TabIndex = 29;
            this.buttonMul.Text = "✕";
            this.buttonMul.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(207, 193);
            this.button9.MaximumSize = new System.Drawing.Size(90, 61);
            this.button9.MinimumSize = new System.Drawing.Size(90, 61);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(90, 61);
            this.button9.TabIndex = 27;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDiv.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonDiv.Location = new System.Drawing.Point(303, 126);
            this.buttonDiv.MaximumSize = new System.Drawing.Size(90, 61);
            this.buttonDiv.MinimumSize = new System.Drawing.Size(90, 61);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(90, 61);
            this.buttonDiv.TabIndex = 26;
            this.buttonDiv.Text = "÷";
            this.buttonDiv.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(111, 193);
            this.button8.MaximumSize = new System.Drawing.Size(90, 61);
            this.button8.MinimumSize = new System.Drawing.Size(90, 61);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(90, 61);
            this.button8.TabIndex = 23;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSub.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonSub.Location = new System.Drawing.Point(303, 257);
            this.buttonSub.MaximumSize = new System.Drawing.Size(90, 61);
            this.buttonSub.MinimumSize = new System.Drawing.Size(90, 61);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(90, 61);
            this.buttonSub.TabIndex = 24;
            this.buttonSub.Text = "－";
            this.buttonSub.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(15, 194);
            this.button7.MaximumSize = new System.Drawing.Size(90, 61);
            this.button7.MinimumSize = new System.Drawing.Size(90, 61);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(90, 61);
            this.button7.TabIndex = 20;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(207, 260);
            this.button6.MaximumSize = new System.Drawing.Size(90, 61);
            this.button6.MinimumSize = new System.Drawing.Size(90, 61);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 61);
            this.button6.TabIndex = 28;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCE.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonCE.Location = new System.Drawing.Point(15, 127);
            this.buttonCE.MaximumSize = new System.Drawing.Size(90, 61);
            this.buttonCE.MinimumSize = new System.Drawing.Size(90, 61);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(90, 61);
            this.buttonCE.TabIndex = 19;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(111, 260);
            this.button5.MaximumSize = new System.Drawing.Size(90, 61);
            this.button5.MinimumSize = new System.Drawing.Size(90, 61);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 61);
            this.button5.TabIndex = 21;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(15, 261);
            this.button4.MaximumSize = new System.Drawing.Size(90, 61);
            this.button4.MinimumSize = new System.Drawing.Size(90, 61);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 61);
            this.button4.TabIndex = 18;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonAdd.Location = new System.Drawing.Point(303, 327);
            this.buttonAdd.MaximumSize = new System.Drawing.Size(90, 61);
            this.buttonAdd.MinimumSize = new System.Drawing.Size(90, 61);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(90, 61);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(207, 327);
            this.button3.MaximumSize = new System.Drawing.Size(90, 61);
            this.button3.MinimumSize = new System.Drawing.Size(90, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 61);
            this.button3.TabIndex = 16;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(111, 327);
            this.button2.MaximumSize = new System.Drawing.Size(90, 61);
            this.button2.MinimumSize = new System.Drawing.Size(90, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 61);
            this.button2.TabIndex = 15;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(15, 327);
            this.button1.MaximumSize = new System.Drawing.Size(90, 61);
            this.button1.MinimumSize = new System.Drawing.Size(90, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 61);
            this.button1.TabIndex = 14;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonEquals
            // 
            this.buttonEquals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonEquals.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEquals.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEquals.Location = new System.Drawing.Point(303, 395);
            this.buttonEquals.MaximumSize = new System.Drawing.Size(90, 61);
            this.buttonEquals.MinimumSize = new System.Drawing.Size(90, 61);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(90, 61);
            this.buttonEquals.TabIndex = 13;
            this.buttonEquals.Text = "＝";
            this.buttonEquals.UseVisualStyleBackColor = false;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.Location = new System.Drawing.Point(15, 394);
            this.button.MaximumSize = new System.Drawing.Size(90, 61);
            this.button.MinimumSize = new System.Drawing.Size(90, 61);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(90, 61);
            this.button.TabIndex = 12;
            this.button.Text = "%";
            this.button.UseVisualStyleBackColor = true;
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(111, 394);
            this.button0.MaximumSize = new System.Drawing.Size(90, 61);
            this.button0.MinimumSize = new System.Drawing.Size(90, 61);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(90, 61);
            this.button0.TabIndex = 11;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDot.Location = new System.Drawing.Point(207, 394);
            this.buttonDot.MaximumSize = new System.Drawing.Size(90, 61);
            this.buttonDot.MinimumSize = new System.Drawing.Size(90, 61);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(90, 61);
            this.buttonDot.TabIndex = 10;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonC
            // 
            this.buttonC.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonC.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonC.Location = new System.Drawing.Point(111, 127);
            this.buttonC.MaximumSize = new System.Drawing.Size(90, 61);
            this.buttonC.MinimumSize = new System.Drawing.Size(90, 61);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(90, 61);
            this.buttonC.TabIndex = 26;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonDel.Image = global::CalculatorApp.Properties.Resources.delete__3_;
            this.buttonDel.Location = new System.Drawing.Point(207, 126);
            this.buttonDel.MaximumSize = new System.Drawing.Size(90, 61);
            this.buttonDel.MinimumSize = new System.Drawing.Size(90, 61);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(90, 61);
            this.buttonDel.TabIndex = 25;
            this.buttonDel.UseVisualStyleBackColor = true;
            // 
            // resultDisplay
            // 
            this.resultDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultDisplay.BackColor = System.Drawing.SystemColors.HighlightText;
            this.resultDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultDisplay.Enabled = false;
            this.resultDisplay.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.resultDisplay.Location = new System.Drawing.Point(21, 83);
            this.resultDisplay.Name = "resultDisplay";
            this.resultDisplay.ReadOnly = true;
            this.resultDisplay.Size = new System.Drawing.Size(362, 25);
            this.resultDisplay.TabIndex = 0;
            this.resultDisplay.Text = "0";
            this.resultDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // 電卓
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(406, 476);
            this.Controls.Add(this.buttonMul);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.button);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.resultDisplay);
            this.Controls.Add(this.textDisplay);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(428, 527);
            this.MinimumSize = new System.Drawing.Size(428, 527);
            this.Name = "電卓";
            this.Text = "電卓";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textDisplay;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.TextBox resultDisplay;
    }
}

