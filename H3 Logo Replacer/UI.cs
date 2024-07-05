using System.Diagnostics.Contracts;

namespace H3_Logo_Replacer
{
    public partial class UI : Form
    {
        private byte[] firmware = [];
        private Bitmap? newLogo = null;

        public UI()
        {
            InitializeComponent();
        }

        private void LoadFW_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new()
            {
                Title = "Open H3 Firmware Image Binary",
                Filter = "BIN Files|*.bin|All Files|*.*"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                byte[] temp;
                try
                {
                    temp = File.ReadAllBytes(ofd.FileName);
                }
                catch { temp = []; }
                if (temp.Length == 0)
                {
                    MessageBox.Show("Unable to load firmware, file system error.");
                }
                else
                {
                    if (temp.Length < 30000 || temp.Length > 65536)
                        MessageBox.Show("That file is not an appropriate size to be an H3 firmware file.");
                    else
                        firmware = temp;
                }
                newLogo = null;
                Contrast.Enabled = 
                Invert.Enabled = 
                Invert.Checked = false;
            }
            bool loaded = firmware.Length > 0;
            FreqPreview.Enabled =
            SaveFW.Enabled =
            LoadIM.Enabled =
            Offset.Enabled = loaded;
            if (loaded) DisplayFWImage();
        }

        private void Offset_ValueChanged(object sender, EventArgs e)
        {
            DisplayFWImage();
        }

        private void DisplayFWImage()
        {
            Bitmap bm = new(128, 60);
            int start = (int)Offset.Value;
            for (int line = 0; line < 60; line++)
            {
                for (int lineByte = 0; lineByte < 16; lineByte++)
                {
                    int addr = line * 16 + lineByte + start;
                    int dataByte = addr < firmware.Length ? firmware[addr] : 0;
                    for (int mask = 128, bit = 0; mask > 0; mask >>= 1, bit++)
                    {
                        int column = lineByte * 8 + bit;
                        bm.SetPixel(column, line, (dataByte & mask) != 0 ? Color.White : Color.Black);
                    }
                }
            }
            Preview.BackgroundImage = bm;
        }

        private void ApplyBitmap(Bitmap bm)
        {
            int start = (int)Offset.Value;
            int contrast = Contrast.Value;
            bool invert = Invert.Checked;
            int byt = 0;
            for (int y = 0; y < 60; y++)
            {
                for (int x = 0; x < 128; x++)
                {
                    int mask = 1 << (7 - (x % 8));
                    Color c =
                        y < bm.Height && x < bm.Width ?
                            bm.GetPixel(x, y) :
                            Color.Black;
                    int cc = c.R + c.G + c.B;
                    if ((invert && cc < contrast) || (!invert && cc > contrast))
                        byt |= mask;
                    if (mask <= 1)
                    {
                        int addr = y * 16 + (x / 8) + start;
                        if (addr < firmware.Length)
                            firmware[addr] = (byte)byt;
                        byt = 0;
                    }
                }
            }
            DisplayFWImage();
        }

        private void LoadIM_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new()
            {
                Title = "Open picture file (128x60 pixels)",
                Filter = "Image Files|*.bmp;*.png;*.jpg|BMP Files|*.bmp|PNG Files|*.png|JPG Files|*.jpg|All Files|*.*"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image? image;
                try { image = Image.FromFile(ofd.FileName); } catch { image = null; }
                if (image != null)
                {
                    newLogo = (Bitmap)image;
                    Contrast.Enabled = Invert.Enabled = true;
                    ApplyBitmap(newLogo);
                }
                else
                    MessageBox.Show("Cannot load that image. File system error or invalid format.");
            }
        }

        private void SaveFW_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new()
            {
                Title = "Save modified firmware binary",
                Filter = "BIN Files|*.bin"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllBytes(sfd.FileName, firmware);
                }
                catch
                {
                    MessageBox.Show("Cannot save firmware. File system error.");
                }
            }
        }

        private void Contrast_Scroll(object sender, EventArgs e)
        {
            if (newLogo != null)
                ApplyBitmap(newLogo);
        }

        private void Invert_Click(object sender, EventArgs e)
        {
            if (newLogo != null)
                ApplyBitmap(newLogo);
        }

        private void SaveCurrentImage()
        {
            if (Preview.BackgroundImage != null)
            {
                SaveFileDialog sfd = new()
                {
                    Title = "Save Current Image",
                    Filter = "PNG Files|*.png"
                };
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Preview.BackgroundImage.Save(sfd.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("Cannot save image. File system error.");
                    }
                }
            }
        }

        private void Preview_Click(object sender, EventArgs e)
        {
            SaveCurrentImage();
        }

        private void SaveImageMenu_Click(object sender, EventArgs e)
        {
            SaveCurrentImage();
        }

        private void FreqPreview_Click(object sender, EventArgs e)
        {
            if (firmware.Length > 0)
            {
                ColorDialog cdg = new();
                if (cdg.ShowDialog() == DialogResult.OK)
                {
                    FreqPreview.ForeColor = cdg.Color;
                    int r = cdg.Color.R >> 2;
                    int g = cdg.Color.G >> 3;
                    int b = cdg.Color.B >> 3;
                    int rgb = (r << 10) | (b << 5) | g;
                    byte ch = (byte)(rgb >> 8);
                    byte cl = (byte)(rgb & 0xff);
                    firmware[(int)ColorHighOffset.Value] = ch;
                    firmware[(int)ColorLowOffset.Value] = cl;
                    firmware[(int)WhiteNopOffset.Value] = 0;
                    firmware[(int)WhiteNopOffset.Value + 1] = 0;
                    firmware[(int)WhiteNopOffset.Value + 2] = 0;
                }
            }
        }
    }
}
