namespace H3_Logo_Replacer
{
    partial class UI
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
            tableLayoutPanel1 = new TableLayoutPanel();
            Preview = new PictureBox();
            Offset = new NumericUpDown();
            label1 = new Label();
            LoadFW = new Button();
            LoadIM = new Button();
            SaveFW = new Button();
            Contrast = new TrackBar();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            Invert = new CheckBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Preview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Offset).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Contrast).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(Preview, 0, 0);
            tableLayoutPanel1.Controls.Add(Offset, 1, 4);
            tableLayoutPanel1.Controls.Add(label1, 1, 3);
            tableLayoutPanel1.Controls.Add(LoadFW, 1, 0);
            tableLayoutPanel1.Controls.Add(LoadIM, 1, 2);
            tableLayoutPanel1.Controls.Add(SaveFW, 1, 1);
            tableLayoutPanel1.Controls.Add(Contrast, 0, 5);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1201, 483);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Preview
            // 
            Preview.BackColor = SystemColors.ButtonShadow;
            Preview.BackgroundImageLayout = ImageLayout.Zoom;
            Preview.Dock = DockStyle.Fill;
            Preview.Location = new Point(10, 10);
            Preview.Margin = new Padding(10);
            Preview.Name = "Preview";
            tableLayoutPanel1.SetRowSpan(Preview, 5);
            Preview.Size = new Size(780, 380);
            Preview.TabIndex = 0;
            Preview.TabStop = false;
            // 
            // Offset
            // 
            Offset.Dock = DockStyle.Fill;
            Offset.Enabled = false;
            Offset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Offset.Location = new Point(830, 323);
            Offset.Margin = new Padding(30, 3, 10, 3);
            Offset.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            Offset.Name = "Offset";
            Offset.Size = new Size(361, 39);
            Offset.TabIndex = 3;
            Offset.Value = new decimal(new int[] { 3310, 0, 0, 0 });
            Offset.ValueChanged += Offset_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(830, 288);
            label1.Margin = new Padding(30, 0, 10, 0);
            label1.Name = "label1";
            label1.Size = new Size(361, 32);
            label1.TabIndex = 4;
            label1.Text = "Image Byte Offset";
            // 
            // LoadFW
            // 
            LoadFW.Dock = DockStyle.Fill;
            LoadFW.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LoadFW.Location = new Point(830, 3);
            LoadFW.Margin = new Padding(30, 3, 10, 30);
            LoadFW.Name = "LoadFW";
            LoadFW.Size = new Size(361, 47);
            LoadFW.TabIndex = 2;
            LoadFW.Text = "Load Firmware";
            LoadFW.UseVisualStyleBackColor = true;
            LoadFW.Click += LoadFW_Click;
            // 
            // LoadIM
            // 
            LoadIM.Dock = DockStyle.Fill;
            LoadIM.Enabled = false;
            LoadIM.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LoadIM.Location = new Point(830, 190);
            LoadIM.Margin = new Padding(30, 30, 10, 3);
            LoadIM.Name = "LoadIM";
            LoadIM.Size = new Size(361, 47);
            LoadIM.TabIndex = 2;
            LoadIM.Text = "Load Image";
            LoadIM.UseVisualStyleBackColor = true;
            LoadIM.Click += LoadIM_Click;
            // 
            // SaveFW
            // 
            SaveFW.Dock = DockStyle.Fill;
            SaveFW.Enabled = false;
            SaveFW.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            SaveFW.Location = new Point(830, 95);
            SaveFW.Margin = new Padding(30, 15, 10, 15);
            SaveFW.Name = "SaveFW";
            SaveFW.Size = new Size(361, 50);
            SaveFW.TabIndex = 2;
            SaveFW.Text = "Save Firmware";
            SaveFW.UseVisualStyleBackColor = true;
            SaveFW.Click += SaveFW_Click;
            // 
            // Contrast
            // 
            Contrast.Enabled = false;
            Contrast.Location = new Point(3, 403);
            Contrast.Maximum = 764;
            Contrast.Minimum = 1;
            Contrast.Name = "Contrast";
            Contrast.Size = new Size(781, 69);
            Contrast.TabIndex = 5;
            Contrast.Value = 382;
            Contrast.Scroll += Contrast_Scroll;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(Invert, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(803, 403);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(395, 77);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Margin = new Padding(3, 0, 10, 0);
            label2.Name = "label2";
            label2.Size = new Size(382, 32);
            label2.TabIndex = 5;
            label2.Text = "Contrast";
            // 
            // Invert
            // 
            Invert.AutoSize = true;
            Invert.CheckAlign = ContentAlignment.MiddleRight;
            Invert.Enabled = false;
            Invert.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Invert.Location = new Point(3, 41);
            Invert.Name = "Invert";
            Invert.Size = new Size(101, 33);
            Invert.TabIndex = 6;
            Invert.Text = "Invert";
            Invert.UseVisualStyleBackColor = true;
            Invert.Click += Invert_Click;
            // 
            // UI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1201, 483);
            Controls.Add(tableLayoutPanel1);
            Name = "UI";
            Text = "H3 Logo Changer v1.1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Preview).EndInit();
            ((System.ComponentModel.ISupportInitialize)Offset).EndInit();
            ((System.ComponentModel.ISupportInitialize)Contrast).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox Preview;
        private Button LoadFW;
        private Button LoadIM;
        private NumericUpDown Offset;
        private Label label1;
        private Button SaveFW;
        private TrackBar Contrast;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private CheckBox Invert;
    }
}
