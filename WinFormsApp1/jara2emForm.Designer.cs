namespace ConProj
{
    partial class jara2emForm
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
            this.jara2emdataGridView1 = new System.Windows.Forms.DataGridView();
            this.jara2emHazefbutton = new System.Windows.Forms.Button();
            this.jara2emcheckedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.jara2emSerialtextBox1 = new System.Windows.Forms.TextBox();
            this.jara2emSerialLabel = new System.Windows.Forms.Label();
            this.jara2empictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.jara2emdataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jara2empictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // jara2emdataGridView1
            // 
            this.jara2emdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jara2emdataGridView1.Location = new System.Drawing.Point(753, 56);
            this.jara2emdataGridView1.Name = "jara2emdataGridView1";
            this.jara2emdataGridView1.RowHeadersWidth = 51;
            this.jara2emdataGridView1.RowTemplate.Height = 24;
            this.jara2emdataGridView1.Size = new System.Drawing.Size(478, 335);
            this.jara2emdataGridView1.TabIndex = 0;
            // 
            // jara2emHazefbutton
            // 
            this.jara2emHazefbutton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jara2emHazefbutton.Location = new System.Drawing.Point(917, 453);
            this.jara2emHazefbutton.Name = "jara2emHazefbutton";
            this.jara2emHazefbutton.Size = new System.Drawing.Size(230, 67);
            this.jara2emHazefbutton.TabIndex = 1;
            this.jara2emHazefbutton.Text = "حذف";
            this.jara2emHazefbutton.UseVisualStyleBackColor = true;
            // 
            // jara2emcheckedListBox1
            // 
            this.jara2emcheckedListBox1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jara2emcheckedListBox1.FormattingEnabled = true;
            this.jara2emcheckedListBox1.Items.AddRange(new object[] {
            "رشوة",
            "سرقة",
            "سلب",
            "نهب",
            "ارهاب",
            "اقامة غير مشروعة",
            "احتكار ",
            "اقتناء اسلحة",
            "تبادل اطلاق نار"});
            this.jara2emcheckedListBox1.Location = new System.Drawing.Point(43, 137);
            this.jara2emcheckedListBox1.Name = "jara2emcheckedListBox1";
            this.jara2emcheckedListBox1.Size = new System.Drawing.Size(261, 344);
            this.jara2emcheckedListBox1.TabIndex = 2;
            this.jara2emcheckedListBox1.SelectedIndexChanged += new System.EventHandler(this.jara2emcheckedListBox1_SelectedIndexChanged);
            // 
            // jara2emSerialtextBox1
            // 
            this.jara2emSerialtextBox1.Location = new System.Drawing.Point(84, 73);
            this.jara2emSerialtextBox1.Name = "jara2emSerialtextBox1";
            this.jara2emSerialtextBox1.Size = new System.Drawing.Size(173, 22);
            this.jara2emSerialtextBox1.TabIndex = 3;
            this.jara2emSerialtextBox1.WordWrap = false;
            // 
            // jara2emSerialLabel
            // 
            this.jara2emSerialLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jara2emSerialLabel.Location = new System.Drawing.Point(121, 27);
            this.jara2emSerialLabel.Name = "jara2emSerialLabel";
            this.jara2emSerialLabel.Size = new System.Drawing.Size(122, 30);
            this.jara2emSerialLabel.TabIndex = 4;
            this.jara2emSerialLabel.Text = "المتسلسل";
            this.jara2emSerialLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // jara2empictureBox1
            // 
            this.jara2empictureBox1.Location = new System.Drawing.Point(378, 66);
            this.jara2empictureBox1.Name = "jara2empictureBox1";
            this.jara2empictureBox1.Size = new System.Drawing.Size(304, 325);
            this.jara2empictureBox1.TabIndex = 5;
            this.jara2empictureBox1.TabStop = false;
            // 
            // jara2emForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 594);
            this.Controls.Add(this.jara2empictureBox1);
            this.Controls.Add(this.jara2emSerialLabel);
            this.Controls.Add(this.jara2emSerialtextBox1);
            this.Controls.Add(this.jara2emcheckedListBox1);
            this.Controls.Add(this.jara2emHazefbutton);
            this.Controls.Add(this.jara2emdataGridView1);
            this.Name = "jara2emForm";
            this.Text = "jara2emForm";
            ((System.ComponentModel.ISupportInitialize)(this.jara2emdataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jara2empictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView jara2emdataGridView1;
        private System.Windows.Forms.Button jara2emHazefbutton;
        private System.Windows.Forms.CheckedListBox jara2emcheckedListBox1;
        private System.Windows.Forms.TextBox jara2emSerialtextBox1;
        private System.Windows.Forms.Label jara2emSerialLabel;
        private System.Windows.Forms.PictureBox jara2empictureBox1;
    }
}