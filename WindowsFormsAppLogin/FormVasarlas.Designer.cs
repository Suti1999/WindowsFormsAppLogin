namespace WindowsFormsAppLogin
{
    partial class FormVasarlas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVasarlas));
            this.listBox_Termekek = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_termeknev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_termekid = new System.Windows.Forms.TextBox();
            this.button_vasarlas = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_raktarKeszlet = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_ar = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_vasaroltDarab = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_raktarKeszlet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_vasaroltDarab)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Termekek
            // 
            this.listBox_Termekek.BackColor = System.Drawing.Color.LightGray;
            this.listBox_Termekek.FormattingEnabled = true;
            this.listBox_Termekek.Location = new System.Drawing.Point(12, 25);
            this.listBox_Termekek.Name = "listBox_Termekek";
            this.listBox_Termekek.Size = new System.Drawing.Size(186, 407);
            this.listBox_Termekek.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Termékek:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown_vasaroltDarab);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numericUpDown_ar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDown_raktarKeszlet);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_termekid);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_termeknev);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(233, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 231);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Megvásárlás";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Termék neve:";
            // 
            // textBox_termeknev
            // 
            this.textBox_termeknev.Location = new System.Drawing.Point(86, 17);
            this.textBox_termeknev.Name = "textBox_termeknev";
            this.textBox_termeknev.Size = new System.Drawing.Size(100, 20);
            this.textBox_termeknev.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Termék id:";
            // 
            // textBox_termekid
            // 
            this.textBox_termekid.Location = new System.Drawing.Point(86, 48);
            this.textBox_termekid.Name = "textBox_termekid";
            this.textBox_termekid.Size = new System.Drawing.Size(28, 20);
            this.textBox_termekid.TabIndex = 3;
            // 
            // button_vasarlas
            // 
            this.button_vasarlas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_vasarlas.Location = new System.Drawing.Point(233, 396);
            this.button_vasarlas.Name = "button_vasarlas";
            this.button_vasarlas.Size = new System.Drawing.Size(289, 36);
            this.button_vasarlas.TabIndex = 6;
            this.button_vasarlas.Text = "VÁSÁRLÁS";
            this.button_vasarlas.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Raktáron:";
            // 
            // numericUpDown_raktarKeszlet
            // 
            this.numericUpDown_raktarKeszlet.Location = new System.Drawing.Point(83, 88);
            this.numericUpDown_raktarKeszlet.Name = "numericUpDown_raktarKeszlet";
            this.numericUpDown_raktarKeszlet.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_raktarKeszlet.TabIndex = 4;
            this.numericUpDown_raktarKeszlet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ár:";
            // 
            // numericUpDown_ar
            // 
            this.numericUpDown_ar.Location = new System.Drawing.Point(83, 126);
            this.numericUpDown_ar.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_ar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_ar.Name = "numericUpDown_ar";
            this.numericUpDown_ar.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_ar.TabIndex = 6;
            this.numericUpDown_ar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_ar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Darabszam:";
            // 
            // numericUpDown_vasaroltDarab
            // 
            this.numericUpDown_vasaroltDarab.Location = new System.Drawing.Point(83, 161);
            this.numericUpDown_vasaroltDarab.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_vasaroltDarab.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_vasaroltDarab.Name = "numericUpDown_vasaroltDarab";
            this.numericUpDown_vasaroltDarab.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_vasaroltDarab.TabIndex = 8;
            this.numericUpDown_vasaroltDarab.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_vasaroltDarab.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormVasarlas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(546, 450);
            this.Controls.Add(this.button_vasarlas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Termekek);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVasarlas";
            this.Text = "Vásárlás";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_raktarKeszlet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_vasaroltDarab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Termekek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_termeknev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_termekid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_raktarKeszlet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_vasarlas;
        private System.Windows.Forms.NumericUpDown numericUpDown_vasaroltDarab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_ar;
        private System.Windows.Forms.Label label5;
    }
}