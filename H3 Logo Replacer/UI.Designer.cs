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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            tableLayoutPanel1 = new TableLayoutPanel();
            label3 = new Label();
            ColorLowOffset = new NumericUpDown();
            ColorHighOffset = new NumericUpDown();
            Preview = new PictureBox();
            PreviewMenu = new ContextMenuStrip(components);
            SaveImageMenu = new ToolStripMenuItem();
            Offset = new NumericUpDown();
            label1 = new Label();
            LoadFW = new Button();
            LoadIM = new Button();
            SaveFW = new Button();
            Contrast = new TrackBar();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            Invert = new CheckBox();
            label4 = new Label();
            WhiteNopOffset = new NumericUpDown();
            LogoColLow = new NumericUpDown();
            LogoColHigh = new NumericUpDown();
            tableLayoutPanel3 = new TableLayoutPanel();
            FreqPreview = new Label();
            FreqPreviewSmall = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ColorLowOffset).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ColorHighOffset).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Preview).BeginInit();
            PreviewMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Offset).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Contrast).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WhiteNopOffset).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoColLow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoColHigh).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(label3, 1, 6);
            tableLayoutPanel1.Controls.Add(ColorLowOffset, 1, 8);
            tableLayoutPanel1.Controls.Add(ColorHighOffset, 1, 7);
            tableLayoutPanel1.Controls.Add(Preview, 0, 0);
            tableLayoutPanel1.Controls.Add(Offset, 1, 4);
            tableLayoutPanel1.Controls.Add(label1, 1, 3);
            tableLayoutPanel1.Controls.Add(LoadFW, 1, 0);
            tableLayoutPanel1.Controls.Add(LoadIM, 1, 2);
            tableLayoutPanel1.Controls.Add(SaveFW, 1, 1);
            tableLayoutPanel1.Controls.Add(Contrast, 0, 5);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 5);
            tableLayoutPanel1.Controls.Add(label4, 1, 11);
            tableLayoutPanel1.Controls.Add(WhiteNopOffset, 1, 12);
            tableLayoutPanel1.Controls.Add(LogoColLow, 1, 9);
            tableLayoutPanel1.Controls.Add(LogoColHigh, 1, 10);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 13;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.805061F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.805061F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.805061F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.63715F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.63715F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.8504705F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.63715F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.63715F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.63715F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.63715F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.63715F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.63715F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.63715F));
            tableLayoutPanel1.Size = new Size(1098, 753);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Bottom;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(762, 415);
            label3.Margin = new Padding(30, 0, 10, 0);
            label3.Name = "label3";
            label3.Size = new Size(326, 32);
            label3.TabIndex = 11;
            label3.Text = "Colour Byte Offsets";
            // 
            // ColorLowOffset
            // 
            ColorLowOffset.Dock = DockStyle.Fill;
            ColorLowOffset.Enabled = false;
            ColorLowOffset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ColorLowOffset.Hexadecimal = true;
            ColorLowOffset.Location = new Point(762, 499);
            ColorLowOffset.Margin = new Padding(30, 3, 10, 3);
            ColorLowOffset.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            ColorLowOffset.Name = "ColorLowOffset";
            ColorLowOffset.Size = new Size(326, 39);
            ColorLowOffset.TabIndex = 10;
            ColorLowOffset.Value = new decimal(new int[] { 34462, 0, 0, 0 });
            // 
            // ColorHighOffset
            // 
            ColorHighOffset.Dock = DockStyle.Fill;
            ColorHighOffset.Enabled = false;
            ColorHighOffset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ColorHighOffset.Hexadecimal = true;
            ColorHighOffset.Location = new Point(762, 450);
            ColorHighOffset.Margin = new Padding(30, 3, 10, 3);
            ColorHighOffset.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            ColorHighOffset.Name = "ColorHighOffset";
            ColorHighOffset.Size = new Size(326, 39);
            ColorHighOffset.TabIndex = 9;
            ColorHighOffset.Value = new decimal(new int[] { 34459, 0, 0, 0 });
            // 
            // Preview
            // 
            Preview.BackColor = SystemColors.ButtonShadow;
            Preview.BackgroundImageLayout = ImageLayout.Zoom;
            Preview.ContextMenuStrip = PreviewMenu;
            Preview.Dock = DockStyle.Fill;
            Preview.Location = new Point(10, 10);
            Preview.Margin = new Padding(10);
            Preview.Name = "Preview";
            tableLayoutPanel1.SetRowSpan(Preview, 5);
            Preview.Size = new Size(712, 297);
            Preview.TabIndex = 0;
            Preview.TabStop = false;
            Preview.Click += Preview_Click;
            // 
            // PreviewMenu
            // 
            PreviewMenu.ImageScalingSize = new Size(24, 24);
            PreviewMenu.Items.AddRange(new ToolStripItem[] { SaveImageMenu });
            PreviewMenu.Name = "PreviewMenu";
            PreviewMenu.Size = new Size(177, 36);
            // 
            // SaveImageMenu
            // 
            SaveImageMenu.Name = "SaveImageMenu";
            SaveImageMenu.Size = new Size(176, 32);
            SaveImageMenu.Text = "Save Image";
            SaveImageMenu.Click += SaveImageMenu_Click;
            // 
            // Offset
            // 
            Offset.Dock = DockStyle.Fill;
            Offset.Enabled = false;
            Offset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Offset.Hexadecimal = true;
            Offset.Location = new Point(762, 271);
            Offset.Margin = new Padding(30, 3, 10, 3);
            Offset.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            Offset.Name = "Offset";
            Offset.Size = new Size(326, 39);
            Offset.TabIndex = 3;
            Offset.Value = new decimal(new int[] { 3310, 0, 0, 0 });
            Offset.ValueChanged += Offset_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(762, 236);
            label1.Margin = new Padding(30, 0, 10, 0);
            label1.Name = "label1";
            label1.Size = new Size(326, 32);
            label1.TabIndex = 4;
            label1.Text = "Image Byte Offset";
            // 
            // LoadFW
            // 
            LoadFW.Dock = DockStyle.Fill;
            LoadFW.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LoadFW.Location = new Point(762, 3);
            LoadFW.Margin = new Padding(30, 3, 10, 20);
            LoadFW.Name = "LoadFW";
            LoadFW.Size = new Size(326, 50);
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
            LoadIM.Location = new Point(762, 166);
            LoadIM.Margin = new Padding(30, 20, 10, 3);
            LoadIM.Name = "LoadIM";
            LoadIM.Size = new Size(326, 50);
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
            SaveFW.Location = new Point(762, 83);
            SaveFW.Margin = new Padding(30, 10, 10, 10);
            SaveFW.Name = "SaveFW";
            SaveFW.Size = new Size(326, 53);
            SaveFW.TabIndex = 2;
            SaveFW.Text = "Save Firmware";
            SaveFW.UseVisualStyleBackColor = true;
            SaveFW.Click += SaveFW_Click;
            // 
            // Contrast
            // 
            Contrast.Enabled = false;
            Contrast.Location = new Point(3, 320);
            Contrast.Maximum = 764;
            Contrast.Minimum = 1;
            Contrast.Name = "Contrast";
            Contrast.Size = new Size(726, 69);
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
            tableLayoutPanel2.Location = new Point(735, 320);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(360, 75);
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
            label2.Size = new Size(347, 32);
            label2.TabIndex = 5;
            label2.Text = "Contrast";
            // 
            // Invert
            // 
            Invert.AutoSize = true;
            Invert.CheckAlign = ContentAlignment.MiddleRight;
            Invert.Enabled = false;
            Invert.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Invert.Location = new Point(3, 40);
            Invert.Name = "Invert";
            Invert.Size = new Size(101, 32);
            Invert.TabIndex = 6;
            Invert.Text = "Invert";
            Invert.UseVisualStyleBackColor = true;
            Invert.Click += Invert_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Bottom;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(762, 660);
            label4.Margin = new Padding(30, 0, 10, 0);
            label4.Name = "label4";
            label4.Size = new Size(326, 32);
            label4.TabIndex = 11;
            label4.Text = "White NOPping Offset";
            // 
            // WhiteNopOffset
            // 
            WhiteNopOffset.Dock = DockStyle.Fill;
            WhiteNopOffset.Enabled = false;
            WhiteNopOffset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WhiteNopOffset.Hexadecimal = true;
            WhiteNopOffset.Location = new Point(762, 695);
            WhiteNopOffset.Margin = new Padding(30, 3, 10, 3);
            WhiteNopOffset.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            WhiteNopOffset.Name = "WhiteNopOffset";
            WhiteNopOffset.Size = new Size(326, 39);
            WhiteNopOffset.TabIndex = 12;
            WhiteNopOffset.Value = new decimal(new int[] { 34485, 0, 0, 0 });
            // 
            // LogoColLow
            // 
            LogoColLow.Dock = DockStyle.Fill;
            LogoColLow.Enabled = false;
            LogoColLow.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoColLow.Hexadecimal = true;
            LogoColLow.Location = new Point(762, 548);
            LogoColLow.Margin = new Padding(30, 3, 10, 3);
            LogoColLow.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            LogoColLow.Name = "LogoColLow";
            LogoColLow.Size = new Size(326, 39);
            LogoColLow.TabIndex = 10;
            LogoColLow.Value = new decimal(new int[] { 38386, 0, 0, 0 });
            // 
            // LogoColHigh
            // 
            LogoColHigh.Dock = DockStyle.Fill;
            LogoColHigh.Enabled = false;
            LogoColHigh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoColHigh.Hexadecimal = true;
            LogoColHigh.Location = new Point(762, 597);
            LogoColHigh.Margin = new Padding(30, 3, 10, 3);
            LogoColHigh.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            LogoColHigh.Name = "LogoColHigh";
            LogoColHigh.Size = new Size(326, 39);
            LogoColHigh.TabIndex = 10;
            LogoColHigh.Value = new decimal(new int[] { 38388, 0, 0, 0 });
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.Controls.Add(FreqPreview, 0, 0);
            tableLayoutPanel3.Controls.Add(FreqPreviewSmall, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 401);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel1.SetRowSpan(tableLayoutPanel3, 7);
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(726, 349);
            tableLayoutPanel3.TabIndex = 13;
            // 
            // FreqPreview
            // 
            FreqPreview.AutoSize = true;
            FreqPreview.BackColor = Color.Black;
            FreqPreview.Dock = DockStyle.Fill;
            FreqPreview.Enabled = false;
            FreqPreview.Font = new Font("Consolas", 56F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FreqPreview.ForeColor = Color.White;
            FreqPreview.Location = new Point(0, 0);
            FreqPreview.Margin = new Padding(0, 0, 0, 20);
            FreqPreview.Name = "FreqPreview";
            FreqPreview.Size = new Size(508, 329);
            FreqPreview.TabIndex = 7;
            FreqPreview.Text = "456.789";
            FreqPreview.TextAlign = ContentAlignment.MiddleRight;
            FreqPreview.Click += FreqPreview_Click;
            // 
            // FreqPreviewSmall
            // 
            FreqPreviewSmall.AutoSize = true;
            FreqPreviewSmall.BackColor = Color.Black;
            FreqPreviewSmall.Dock = DockStyle.Fill;
            FreqPreviewSmall.Enabled = false;
            FreqPreviewSmall.Font = new Font("Consolas", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FreqPreviewSmall.ForeColor = Color.White;
            FreqPreviewSmall.Location = new Point(508, 0);
            FreqPreviewSmall.Margin = new Padding(0, 0, 0, 20);
            FreqPreviewSmall.Name = "FreqPreviewSmall";
            FreqPreviewSmall.Size = new Size(218, 329);
            FreqPreviewSmall.TabIndex = 7;
            FreqPreviewSmall.Text = "00";
            FreqPreviewSmall.TextAlign = ContentAlignment.MiddleLeft;
            FreqPreviewSmall.Click += FreqPreview_Click;
            // 
            // UI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1098, 753);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UI";
            Text = "H3 Logo Changer v1.3";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ColorLowOffset).EndInit();
            ((System.ComponentModel.ISupportInitialize)ColorHighOffset).EndInit();
            ((System.ComponentModel.ISupportInitialize)Preview).EndInit();
            PreviewMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Offset).EndInit();
            ((System.ComponentModel.ISupportInitialize)Contrast).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)WhiteNopOffset).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoColLow).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoColHigh).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
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
        private ContextMenuStrip PreviewMenu;
        private ToolStripMenuItem SaveImageMenu;
        private Label FreqPreview;
        private Label label3;
        private NumericUpDown ColorLowOffset;
        private NumericUpDown ColorHighOffset;
        private NumericUpDown WhiteNopOffset;
        private Label label4;
        private NumericUpDown LogoColLow;
        private NumericUpDown LogoColHigh;
        private TableLayoutPanel tableLayoutPanel3;
        private Label FreqPreviewSmall;
    }
}
