namespace ConProj
{
    partial class ed5alForm
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
            dataGridView1 = new DataGridView();
            mloa5ascheckBox = new CheckBox();
            MadbotatCheckBox = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            tare5aled5al = new DateTimePicker();
            tare5lmo3amaleh = new DateTimePicker();
            label3 = new Label();
            aljoromcomboBox = new ComboBox();
            label4 = new Label();
            mawdo3elmo3amale = new TextBox();
            button8 = new Button();
            ash5asButton = new Button();
            el8a2Button = new Button();
            tahdethButton = new Button();
            HazefButton = new Button();
            button5 = new Button();
            syaratButton = new Button();
            tasnefButton = new Button();
            mola5asButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(601, 55);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(842, 682);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // mloa5ascheckBox
            // 
            mloa5ascheckBox.AutoSize = true;
            mloa5ascheckBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mloa5ascheckBox.Location = new Point(1038, 15);
            mloa5ascheckBox.Margin = new Padding(3, 4, 3, 4);
            mloa5ascheckBox.Name = "mloa5ascheckBox";
            mloa5ascheckBox.RightToLeft = RightToLeft.Yes;
            mloa5ascheckBox.Size = new Size(138, 26);
            mloa5ascheckBox.TabIndex = 1;
            mloa5ascheckBox.Text = "هل يوجد ملخص";
            mloa5ascheckBox.TextAlign = ContentAlignment.TopLeft;
            mloa5ascheckBox.UseVisualStyleBackColor = true;
            mloa5ascheckBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // MadbotatCheckBox
            // 
            MadbotatCheckBox.AutoSize = true;
            MadbotatCheckBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MadbotatCheckBox.Location = new Point(740, 15);
            MadbotatCheckBox.Margin = new Padding(3, 4, 3, 4);
            MadbotatCheckBox.Name = "MadbotatCheckBox";
            MadbotatCheckBox.RightToLeft = RightToLeft.Yes;
            MadbotatCheckBox.Size = new Size(163, 26);
            MadbotatCheckBox.TabIndex = 2;
            MadbotatCheckBox.Text = "هل يوجد مضبوطات";
            MadbotatCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(466, 55);
            label1.Name = "label1";
            label1.Size = new Size(95, 23);
            label1.TabIndex = 3;
            label1.Text = "تاريخ الادخال";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(461, 136);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 4;
            label2.Text = "تاريخ المعاملة";
            // 
            // tare5aled5al
            // 
            tare5aled5al.Location = new Point(302, 105);
            tare5aled5al.Margin = new Padding(3, 4, 3, 4);
            tare5aled5al.Name = "tare5aled5al";
            tare5aled5al.Size = new Size(293, 27);
            tare5aled5al.TabIndex = 5;
            // 
            // tare5lmo3amaleh
            // 
            tare5lmo3amaleh.Location = new Point(302, 194);
            tare5lmo3amaleh.Margin = new Padding(3, 4, 3, 4);
            tare5lmo3amaleh.Name = "tare5lmo3amaleh";
            tare5lmo3amaleh.Size = new Size(293, 27);
            tare5lmo3amaleh.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(528, 258);
            label3.Name = "label3";
            label3.Size = new Size(45, 23);
            label3.TabIndex = 7;
            label3.Text = "الجرم";
            // 
            // aljoromcomboBox
            // 
            aljoromcomboBox.FormattingEnabled = true;
            aljoromcomboBox.Items.AddRange(new object[] { "رشوة", "سرقة", "سلب", "نهب", "ارهاب", "اقامة غير مشروعة", "احتكار ", "اقتناء اسلحة", "تبادل اطلاق نار" });
            aljoromcomboBox.Location = new Point(302, 260);
            aljoromcomboBox.Margin = new Padding(3, 4, 3, 4);
            aljoromcomboBox.Name = "aljoromcomboBox";
            aljoromcomboBox.Size = new Size(202, 28);
            aljoromcomboBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(461, 309);
            label4.Name = "label4";
            label4.Size = new Size(117, 23);
            label4.TabIndex = 9;
            label4.Text = "موضوع المعاملة";
            // 
            // mawdo3elmo3amale
            // 
            mawdo3elmo3amale.Location = new Point(316, 341);
            mawdo3elmo3amale.Margin = new Padding(3, 4, 3, 4);
            mawdo3elmo3amale.Multiline = true;
            mawdo3elmo3amale.Name = "mawdo3elmo3amale";
            mawdo3elmo3amale.Size = new Size(279, 395);
            mawdo3elmo3amale.TabIndex = 10;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.ForeColor = SystemColors.ActiveCaptionText;
            button8.Location = new Point(1316, 745);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(127, 69);
            button8.TabIndex = 11;
            button8.Text = "ادخال";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // ash5asButton
            // 
            ash5asButton.BackColor = Color.White;
            ash5asButton.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ash5asButton.ForeColor = SystemColors.ActiveCaptionText;
            ash5asButton.Location = new Point(695, 745);
            ash5asButton.Margin = new Padding(3, 4, 3, 4);
            ash5asButton.Name = "ash5asButton";
            ash5asButton.Size = new Size(114, 69);
            ash5asButton.TabIndex = 12;
            ash5asButton.Text = "اشخاص";
            ash5asButton.UseVisualStyleBackColor = false;
            ash5asButton.Click += ash5asButton_Click;
            // 
            // el8a2Button
            // 
            el8a2Button.BackColor = Color.White;
            el8a2Button.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            el8a2Button.ForeColor = SystemColors.ActiveCaptionText;
            el8a2Button.Location = new Point(815, 745);
            el8a2Button.Margin = new Padding(3, 4, 3, 4);
            el8a2Button.Name = "el8a2Button";
            el8a2Button.Size = new Size(115, 69);
            el8a2Button.TabIndex = 13;
            el8a2Button.Text = "الغاء";
            el8a2Button.UseVisualStyleBackColor = false;
            // 
            // tahdethButton
            // 
            tahdethButton.BackColor = Color.White;
            tahdethButton.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tahdethButton.ForeColor = SystemColors.ActiveCaptionText;
            tahdethButton.Location = new Point(936, 745);
            tahdethButton.Margin = new Padding(3, 4, 3, 4);
            tahdethButton.Name = "tahdethButton";
            tahdethButton.Size = new Size(113, 69);
            tahdethButton.TabIndex = 14;
            tahdethButton.Text = "تحديث";
            tahdethButton.UseVisualStyleBackColor = false;
            tahdethButton.Click += tahdethButton_Click;
            // 
            // HazefButton
            // 
            HazefButton.BackColor = Color.White;
            HazefButton.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HazefButton.ForeColor = SystemColors.ActiveCaptionText;
            HazefButton.Location = new Point(1055, 745);
            HazefButton.Margin = new Padding(3, 4, 3, 4);
            HazefButton.Name = "HazefButton";
            HazefButton.Size = new Size(126, 69);
            HazefButton.TabIndex = 15;
            HazefButton.Text = "حذف";
            HazefButton.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(1187, 745);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(123, 69);
            button5.TabIndex = 16;
            button5.Text = "تعديل";
            button5.UseVisualStyleBackColor = false;
            // 
            // syaratButton
            // 
            syaratButton.BackColor = Color.White;
            syaratButton.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            syaratButton.ForeColor = SystemColors.ActiveCaptionText;
            syaratButton.Location = new Point(446, 745);
            syaratButton.Margin = new Padding(3, 4, 3, 4);
            syaratButton.Name = "syaratButton";
            syaratButton.Size = new Size(124, 69);
            syaratButton.TabIndex = 17;
            syaratButton.Text = "سيارات";
            syaratButton.UseVisualStyleBackColor = false;
            syaratButton.Click += syaratButton_Click;
            // 
            // tasnefButton
            // 
            tasnefButton.BackColor = Color.White;
            tasnefButton.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tasnefButton.ForeColor = SystemColors.ActiveCaptionText;
            tasnefButton.Location = new Point(576, 745);
            tasnefButton.Margin = new Padding(3, 4, 3, 4);
            tasnefButton.Name = "tasnefButton";
            tasnefButton.Size = new Size(113, 69);
            tasnefButton.TabIndex = 18;
            tasnefButton.Text = "تصنيف";
            tasnefButton.UseVisualStyleBackColor = false;
            // 
            // mola5asButton
            // 
            mola5asButton.BackColor = Color.White;
            mola5asButton.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mola5asButton.ForeColor = SystemColors.ActiveCaptionText;
            mola5asButton.Location = new Point(316, 745);
            mola5asButton.Margin = new Padding(3, 4, 3, 4);
            mola5asButton.Name = "mola5asButton";
            mola5asButton.Size = new Size(124, 69);
            mola5asButton.TabIndex = 19;
            mola5asButton.Text = "ملخص";
            mola5asButton.UseVisualStyleBackColor = false;
            // 
            // ed5alForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1458, 915);
            Controls.Add(mola5asButton);
            Controls.Add(tasnefButton);
            Controls.Add(syaratButton);
            Controls.Add(button5);
            Controls.Add(HazefButton);
            Controls.Add(tahdethButton);
            Controls.Add(el8a2Button);
            Controls.Add(ash5asButton);
            Controls.Add(button8);
            Controls.Add(mawdo3elmo3amale);
            Controls.Add(label4);
            Controls.Add(aljoromcomboBox);
            Controls.Add(label3);
            Controls.Add(tare5lmo3amaleh);
            Controls.Add(tare5aled5al);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MadbotatCheckBox);
            Controls.Add(mloa5ascheckBox);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ed5alForm";
            Text = "ed5alForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox mloa5ascheckBox;
        private System.Windows.Forms.CheckBox MadbotatCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker tare5aled5al;
        private System.Windows.Forms.DateTimePicker tare5lmo3amaleh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox aljoromcomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mawdo3elmo3amale;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button ash5asButton;
        private System.Windows.Forms.Button el8a2Button;
        private System.Windows.Forms.Button tahdethButton;
        private System.Windows.Forms.Button HazefButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button syaratButton;
        private System.Windows.Forms.Button tasnefButton;
        private System.Windows.Forms.Button mola5asButton;
    }
}