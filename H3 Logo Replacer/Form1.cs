namespace H3_Logo_Replacer
{
    public partial class Form1 : Form
    {
        private byte[] firmware = [];
        public Form1()
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
            }
            bool loaded = firmware.Length > 0;
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

        private void LoadIM_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new()
            {
                Title = "Open picture file (128x60 pixels)",
                Filter = "Image Files|*.bmp;*.png;*.jpg|BMP Files|*.bmp|PNG Files|*.png|JPG Files|*.jpg|All Files|*.*"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                int start = (int)Offset.Value;
                Image? image;
                try { image = Image.FromFile(ofd.FileName); } catch { image = null; }
                if (image != null)
                {
                    Bitmap loaded = (Bitmap)image;
                    int byt = 0;
                    for (int y = 0; y < 60; y++)
                    {
                        for (int x = 0; x < 128; x++)
                        {
                            int mask = 1 << (7 - (x % 8));
                            Color c =
                                y < loaded.Height && x < loaded.Width ?
                                    loaded.GetPixel(x, y) :
                                    Color.Black;
                            int cc = c.R + c.G + c.B;
                            if (cc > 382) byt |= mask;
                            if (mask <= 1)
                            {
                                int addr = y * 16 + (x / 8) + start;
                                firmware[addr] = (byte)byt;
                                byt = 0;
                            }
                        }
                    }
                    DisplayFWImage();
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
            if(sfd.ShowDialog() == DialogResult.OK)
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
    }
}
