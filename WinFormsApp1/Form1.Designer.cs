namespace WinFormsApp1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Name1 = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.Fname = new System.Windows.Forms.TextBox();
            this.Country = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.Erro = new System.Windows.Forms.Label();
            this.Load = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AZE = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WinFormsApp1.Properties.Resources.Media_220525_191352;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::WinFormsApp1.Properties.Resources.Media_220525_191352;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(805, 399);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Name1
            // 
            this.Name1.Location = new System.Drawing.Point(251, 97);
            this.Name1.Multiline = true;
            this.Name1.Name = "Name1";
            this.Name1.PlaceholderText = "Name";
            this.Name1.Size = new System.Drawing.Size(144, 19);
            this.Name1.TabIndex = 0;
            this.Name1.Tag = "";
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(251, 122);
            this.surname.Multiline = true;
            this.surname.Name = "surname";
            this.surname.PlaceholderText = "Surname";
            this.surname.Size = new System.Drawing.Size(144, 19);
            this.surname.TabIndex = 1;
            // 
            // Fname
            // 
            this.Fname.Location = new System.Drawing.Point(251, 147);
            this.Fname.Multiline = true;
            this.Fname.Name = "Fname";
            this.Fname.PlaceholderText = "Father Name";
            this.Fname.Size = new System.Drawing.Size(144, 19);
            this.Fname.TabIndex = 2;
            // 
            // Country
            // 
            this.Country.Location = new System.Drawing.Point(251, 192);
            this.Country.Multiline = true;
            this.Country.Name = "Country";
            this.Country.PlaceholderText = "Country";
            this.Country.Size = new System.Drawing.Size(144, 19);
            this.Country.TabIndex = 3;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(251, 217);
            this.city.Multiline = true;
            this.city.Name = "city";
            this.city.PlaceholderText = "City";
            this.city.Size = new System.Drawing.Size(144, 19);
            this.city.TabIndex = 4;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(251, 242);
            this.phone.Multiline = true;
            this.phone.Name = "phone";
            this.phone.PlaceholderText = "Phone";
            this.phone.Size = new System.Drawing.Size(144, 19);
            this.phone.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dateTimePicker1.Location = new System.Drawing.Point(189, 276);
            this.dateTimePicker1.MaxDate = new System.DateTime(2022, 1, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1920, 1, 31, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(206, 23);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2022, 1, 31, 0, 0, 0, 0);
            // 
            // BTN_Save
            // 
            this.BTN_Save.AutoEllipsis = true;
            this.BTN_Save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTN_Save.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BTN_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Save.Location = new System.Drawing.Point(189, 347);
            this.BTN_Save.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(206, 29);
            this.BTN_Save.TabIndex = 1;
            this.BTN_Save.Text = "Save";
            this.BTN_Save.UseVisualStyleBackColor = false;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Checked = true;
            this.radioButton1.ForeColor = System.Drawing.Color.Cyan;
            this.radioButton1.Location = new System.Drawing.Point(221, 323);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 19);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.radioButton2.Location = new System.Drawing.Point(304, 323);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 19);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.Text = "Famale";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // Erro
            // 
            this.Erro.BackColor = System.Drawing.Color.Transparent;
            this.Erro.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Erro.ForeColor = System.Drawing.Color.Firebrick;
            this.Erro.Location = new System.Drawing.Point(191, 169);
            this.Erro.Name = "Erro";
            this.Erro.Size = new System.Drawing.Size(204, 20);
            this.Erro.TabIndex = 9;
            this.Erro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Load
            // 
            this.Load.AutoEllipsis = true;
            this.Load.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Load.BackColor = System.Drawing.Color.DarkViolet;
            this.Load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Load.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Load.ForeColor = System.Drawing.Color.PowderBlue;
            this.Load.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Load.Location = new System.Drawing.Point(318, 47);
            this.Load.Margin = new System.Windows.Forms.Padding(2);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(77, 24);
            this.Load.TabIndex = 10;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = false;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Load...";
            this.textBox1.Size = new System.Drawing.Size(124, 23);
            this.textBox1.TabIndex = 11;
            // 
            // AZE
            // 
            this.AZE.AutoSize = true;
            this.AZE.BackColor = System.Drawing.Color.Transparent;
            this.AZE.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AZE.ForeColor = System.Drawing.Color.Firebrick;
            this.AZE.Location = new System.Drawing.Point(251, 264);
            this.AZE.Name = "AZE";
            this.AZE.Size = new System.Drawing.Size(0, 11);
            this.AZE.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::WinFormsApp1.Properties.Resources.Media_220525_191352;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(803, 400);
            this.Controls.Add(this.AZE);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Erro);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.BTN_Save);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.city);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.Name1);
            this.Controls.Add(this.pictureBox1);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximumSize = new System.Drawing.Size(819, 439);
            this.MinimumSize = new System.Drawing.Size(819, 439);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private PictureBox pictureBox1;
        private TextBox Name1;
        private TextBox surname;
        private TextBox Fname;
        private TextBox Country;
        private TextBox city;
        private TextBox phone;
        private DateTimePicker dateTimePicker1;
        private Button BTN_Save;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label Erro;
        private Button Load;
        private TextBox textBox1;
        private Label AZE;
    }
}