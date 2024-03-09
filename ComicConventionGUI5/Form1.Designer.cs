namespace ComicConventionGUI5
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
            if (disposing && (components != null))
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            bttnCalculate = new Button();
            bttnClear = new Button();
            lblCost = new Label();
            txtCostBox = new TextBox();
            rBttnConSup = new RadioButton();
            rBttnConAuto = new RadioButton();
            rBttnCon = new RadioButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1350, 313);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(397, 315);
            label1.Name = "label1";
            label1.Size = new Size(583, 54);
            label1.TabIndex = 1;
            label1.Text = "Comic Convention Registration ";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Coral;
            label2.Location = new Point(441, 421);
            label2.Name = "label2";
            label2.Size = new Size(145, 32);
            label2.TabIndex = 2;
            label2.Text = "Group Size:";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(629, 422);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // bttnCalculate
            // 
            bttnCalculate.BackColor = SystemColors.ActiveCaption;
            bttnCalculate.Location = new Point(285, 1010);
            bttnCalculate.Name = "bttnCalculate";
            bttnCalculate.Size = new Size(112, 34);
            bttnCalculate.TabIndex = 4;
            bttnCalculate.Text = "Calculate";
            bttnCalculate.UseVisualStyleBackColor = false;
            bttnCalculate.Click += bttnCalculate_Click;
            // 
            // bttnClear
            // 
            bttnClear.BackColor = SystemColors.ActiveCaption;
            bttnClear.Location = new Point(850, 1010);
            bttnClear.Name = "bttnClear";
            bttnClear.Size = new Size(112, 34);
            bttnClear.TabIndex = 5;
            bttnClear.Text = "Clear";
            bttnClear.UseVisualStyleBackColor = false;
            bttnClear.Click += bttnClear_Click;
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblCost.ForeColor = Color.Coral;
            lblCost.Location = new Point(325, 892);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(261, 41);
            lblCost.TabIndex = 6;
            lblCost.Text = "Registration Cost";
            // 
            // txtCostBox
            // 
            txtCostBox.Location = new Point(691, 902);
            txtCostBox.Name = "txtCostBox";
            txtCostBox.Size = new Size(150, 31);
            txtCostBox.TabIndex = 7;
            txtCostBox.TextChanged += txtCostBox_TextChanged;
            // 
            // rBttnConSup
            // 
            rBttnConSup.AutoSize = true;
            rBttnConSup.BackColor = Color.FromArgb(128, 255, 255);
            rBttnConSup.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rBttnConSup.ForeColor = Color.OrangeRed;
            rBttnConSup.Location = new Point(545, 576);
            rBttnConSup.Name = "rBttnConSup";
            rBttnConSup.Size = new Size(344, 29);
            rBttnConSup.TabIndex = 8;
            rBttnConSup.TabStop = true;
            rBttnConSup.Text = "Convention + Superhero Experience";
            rBttnConSup.UseVisualStyleBackColor = false;
            rBttnConSup.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rBttnConAuto
            // 
            rBttnConAuto.AutoSize = true;
            rBttnConAuto.BackColor = Color.FromArgb(128, 255, 255);
            rBttnConAuto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rBttnConAuto.ForeColor = Color.FromArgb(192, 64, 0);
            rBttnConAuto.Location = new Point(545, 611);
            rBttnConAuto.Name = "rBttnConAuto";
            rBttnConAuto.Size = new Size(247, 29);
            rBttnConAuto.TabIndex = 9;
            rBttnConAuto.TabStop = true;
            rBttnConAuto.Text = "Covention + Autographs";
            rBttnConAuto.UseVisualStyleBackColor = false;
            rBttnConAuto.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rBttnCon
            // 
            rBttnCon.AutoSize = true;
            rBttnCon.BackColor = Color.FromArgb(128, 255, 255);
            rBttnCon.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rBttnCon.ForeColor = Color.FromArgb(192, 64, 0);
            rBttnCon.Location = new Point(545, 646);
            rBttnCon.Name = "rBttnCon";
            rBttnCon.Size = new Size(135, 29);
            rBttnCon.TabIndex = 10;
            rBttnCon.TabStop = true;
            rBttnCon.Text = "Convention";
            rBttnCon.UseVisualStyleBackColor = false;
            rBttnCon.CheckedChanged += rBttnCon_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 1097);
            Controls.Add(rBttnCon);
            Controls.Add(rBttnConAuto);
            Controls.Add(rBttnConSup);
            Controls.Add(txtCostBox);
            Controls.Add(lblCost);
            Controls.Add(bttnClear);
            Controls.Add(bttnCalculate);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button bttnCalculate;
        private Button bttnClear;
        private Label lblCost;
        private TextBox txtCostBox;
        private RadioButton rBttnConSup;
        private RadioButton rBttnConAuto;
        private RadioButton rBttnCon;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
