namespace windowsform
{
    partial class tagdij
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
            this.listBox_Klubtagok = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_insert = new System.Windows.Forms.Button();
            this.numericUpDown_szulev = new System.Windows.Forms.NumericUpDown();
            this.textBox_orszag = new System.Windows.Forms.TextBox();
            this.numericUpDown_iranyitoszam = new System.Windows.Forms.NumericUpDown();
            this.Text_Box_Nev = new System.Windows.Forms.TextBox();
            this.Text_Box_Azon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_szulev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_iranyitoszam)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Klubtagok
            // 
            this.listBox_Klubtagok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_Klubtagok.FormattingEnabled = true;
            this.listBox_Klubtagok.Location = new System.Drawing.Point(0, 0);
            this.listBox_Klubtagok.Name = "listBox_Klubtagok";
            this.listBox_Klubtagok.Size = new System.Drawing.Size(246, 450);
            this.listBox_Klubtagok.TabIndex = 0;
            this.listBox_Klubtagok.SelectedIndexChanged += new System.EventHandler(this.listBox_Klubtagok_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Delete);
            this.groupBox1.Controls.Add(this.button_Update);
            this.groupBox1.Controls.Add(this.button_insert);
            this.groupBox1.Controls.Add(this.numericUpDown_szulev);
            this.groupBox1.Controls.Add(this.textBox_orszag);
            this.groupBox1.Controls.Add(this.numericUpDown_iranyitoszam);
            this.groupBox1.Controls.Add(this.Text_Box_Nev);
            this.groupBox1.Controls.Add(this.Text_Box_Azon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(246, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 450);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiválaszott tagok adatai";
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(127, 211);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(217, 56);
            this.button_Delete.TabIndex = 13;
            this.button_Delete.Text = "Töröl";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(127, 273);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(217, 56);
            this.button_Update.TabIndex = 12;
            this.button_Update.Text = "Módosít";
            this.button_Update.UseVisualStyleBackColor = true;
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(127, 335);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(217, 62);
            this.button_insert.TabIndex = 11;
            this.button_insert.Text = "Új tag";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // numericUpDown_szulev
            // 
            this.numericUpDown_szulev.Location = new System.Drawing.Point(132, 70);
            this.numericUpDown_szulev.Maximum = new decimal(new int[] {
            2090,
            0,
            0,
            0});
            this.numericUpDown_szulev.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDown_szulev.Name = "numericUpDown_szulev";
            this.numericUpDown_szulev.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_szulev.TabIndex = 10;
            this.numericUpDown_szulev.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // textBox_orszag
            // 
            this.textBox_orszag.Location = new System.Drawing.Point(132, 134);
            this.textBox_orszag.Name = "textBox_orszag";
            this.textBox_orszag.Size = new System.Drawing.Size(100, 20);
            this.textBox_orszag.TabIndex = 9;
            // 
            // numericUpDown_iranyitoszam
            // 
            this.numericUpDown_iranyitoszam.Location = new System.Drawing.Point(132, 97);
            this.numericUpDown_iranyitoszam.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown_iranyitoszam.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_iranyitoszam.Name = "numericUpDown_iranyitoszam";
            this.numericUpDown_iranyitoszam.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_iranyitoszam.TabIndex = 8;
            this.numericUpDown_iranyitoszam.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // Text_Box_Nev
            // 
            this.Text_Box_Nev.Location = new System.Drawing.Point(132, 43);
            this.Text_Box_Nev.Name = "Text_Box_Nev";
            this.Text_Box_Nev.Size = new System.Drawing.Size(100, 20);
            this.Text_Box_Nev.TabIndex = 6;
            // 
            // Text_Box_Azon
            // 
            this.Text_Box_Azon.Location = new System.Drawing.Point(132, 16);
            this.Text_Box_Azon.Name = "Text_Box_Azon";
            this.Text_Box_Azon.Size = new System.Drawing.Size(100, 20);
            this.Text_Box_Azon.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ország";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Irányítószám";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Születési év";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Név";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Azonosító";
            // 
            // tagdij
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox_Klubtagok);
            this.Name = "tagdij";
            this.Text = "Beregszászi Klub";
            this.Load += new System.EventHandler(this.tagdij_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_szulev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_iranyitoszam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Klubtagok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Text_Box_Nev;
        private System.Windows.Forms.TextBox Text_Box_Azon;
        private System.Windows.Forms.TextBox textBox_orszag;
        private System.Windows.Forms.NumericUpDown numericUpDown_iranyitoszam;
        private System.Windows.Forms.NumericUpDown numericUpDown_szulev;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Delete;
    }
}

