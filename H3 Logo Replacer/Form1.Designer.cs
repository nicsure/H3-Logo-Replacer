﻿namespace H3_Logo_Replacer
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
            tableLayoutPanel1 = new TableLayoutPanel();
            Preview = new PictureBox();
            Offset = new NumericUpDown();
            label1 = new Label();
            LoadFW = new Button();
            LoadIM = new Button();
            SaveFW = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Preview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Offset).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(Preview, 0, 0);
            tableLayoutPanel1.Controls.Add(Offset, 1, 4);
            tableLayoutPanel1.Controls.Add(label1, 1, 3);
            tableLayoutPanel1.Controls.Add(LoadFW, 1, 0);
            tableLayoutPanel1.Controls.Add(LoadIM, 1, 2);
            tableLayoutPanel1.Controls.Add(SaveFW, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(1176, 420);
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
            Preview.Size = new Size(764, 400);
            Preview.TabIndex = 0;
            Preview.TabStop = false;
            // 
            // Offset
            // 
            Offset.Dock = DockStyle.Fill;
            Offset.Enabled = false;
            Offset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Offset.Location = new Point(814, 339);
            Offset.Margin = new Padding(30, 3, 3, 3);
            Offset.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            Offset.Name = "Offset";
            Offset.Size = new Size(359, 39);
            Offset.TabIndex = 3;
            Offset.Value = new decimal(new int[] { 3310, 0, 0, 0 });
            Offset.ValueChanged += Offset_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(814, 272);
            label1.Margin = new Padding(30, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(359, 64);
            label1.TabIndex = 4;
            label1.Text = "Image Byte Offset\r\n(Firmware 240606 is 3310)";
            // 
            // LoadFW
            // 
            LoadFW.Dock = DockStyle.Fill;
            LoadFW.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LoadFW.Location = new Point(814, 3);
            LoadFW.Margin = new Padding(30, 3, 3, 30);
            LoadFW.Name = "LoadFW";
            LoadFW.Size = new Size(359, 51);
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
            LoadIM.Location = new Point(814, 198);
            LoadIM.Margin = new Padding(30, 30, 3, 3);
            LoadIM.Name = "LoadIM";
            LoadIM.Size = new Size(359, 51);
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
            SaveFW.Location = new Point(814, 99);
            SaveFW.Margin = new Padding(30, 15, 3, 15);
            SaveFW.Name = "SaveFW";
            SaveFW.Size = new Size(359, 54);
            SaveFW.TabIndex = 2;
            SaveFW.Text = "Save Firmware";
            SaveFW.UseVisualStyleBackColor = true;
            SaveFW.Click += SaveFW_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1176, 420);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "H3 Logo Changer";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Preview).EndInit();
            ((System.ComponentModel.ISupportInitialize)Offset).EndInit();
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
    }
}