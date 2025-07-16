namespace PH
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
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            dg1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            gp_cp = new GroupBox();
            button3 = new Button();
            label1 = new Label();
            txt_cp = new TextBox();
            cmb_cp = new ComboBox();
            rt_cr = new RichTextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg1).BeginInit();
            groupBox3.SuspendLayout();
            gp_cp.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(939, 139);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prompt";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(901, 108);
            textBox1.TabIndex = 0;
            textBox1.Text = "#Profile#and create Course objective for AWS Cloud Practitioner";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dg1);
            groupBox2.Location = new Point(12, 157);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(939, 186);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Contents";
            // 
            // dg1
            // 
            dg1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dg1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dg1.Location = new Point(17, 22);
            dg1.Name = "dg1";
            dg1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dg1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg1.Size = new Size(901, 139);
            dg1.TabIndex = 6;
            dg1.CellContentClick += dg1_CellContentClick;
            // 
            // Column1
            // 
            Column1.FillWeight = 200F;
            Column1.HeaderText = "Annotation ";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            Column1.Width = 572;
            // 
            // Column2
            // 
            Column2.HeaderText = "Value";
            Column2.Name = "Column2";
            Column2.Width = 286;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox2);
            groupBox3.Location = new Point(29, 349);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(922, 178);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Created Prompt";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(15, 22);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(886, 138);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(983, 76);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Generate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(983, 232);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Generate";
            button2.UseVisualStyleBackColor = true;
            // 
            // gp_cp
            // 
            gp_cp.Controls.Add(rt_cr);
            gp_cp.Controls.Add(button3);
            gp_cp.Controls.Add(label1);
            gp_cp.Controls.Add(txt_cp);
            gp_cp.Controls.Add(cmb_cp);
            gp_cp.Location = new Point(526, 42);
            gp_cp.Name = "gp_cp";
            gp_cp.Size = new Size(476, 433);
            gp_cp.TabIndex = 5;
            gp_cp.TabStop = false;
            gp_cp.Text = "Content From Respository";
            // 
            // button3
            // 
            button3.Location = new Point(227, 392);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Submit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 49);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 2;
            label1.Text = "Annotator";
            label1.Click += label1_Click;
            // 
            // txt_cp
            // 
            txt_cp.Location = new Point(21, 98);
            txt_cp.Multiline = true;
            txt_cp.Name = "txt_cp";
            txt_cp.Size = new Size(425, 51);
            txt_cp.TabIndex = 1;
            // 
            // cmb_cp
            // 
            cmb_cp.FormattingEnabled = true;
            cmb_cp.Location = new Point(148, 46);
            cmb_cp.Name = "cmb_cp";
            cmb_cp.Size = new Size(289, 23);
            cmb_cp.TabIndex = 0;
            cmb_cp.SelectedIndexChanged += cmb_cp_SelectedIndexChanged;
            // 
            // rt_cr
            // 
            rt_cr.Location = new Point(30, 171);
            rt_cr.Name = "rt_cr";
            rt_cr.Size = new Size(416, 215);
            rt_cr.TabIndex = 4;
            rt_cr.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 539);
            Controls.Add(gp_cp);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dg1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            gp_cp.ResumeLayout(false);
            gp_cp.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private DataGridView dg1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private GroupBox groupBox3;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private GroupBox gp_cp;
        private Label label1;
        private TextBox txt_cp;
        private ComboBox cmb_cp;
        private Button button3;
        private RichTextBox rt_cr;
    }
}
