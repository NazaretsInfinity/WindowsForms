using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Clock
{
    public partial class FontChooser : Form
    {
        public Font ChosenFont {  get; private set; }
        public FontChooser()
        {
            InitializeComponent();
            LoadFonts();
        }

        void LoadFonts()
        {
            //1) get list of all files in the current directory and save this list in 'fonts' array
            string[] fonts = Directory.EnumerateFiles(Directory.GetCurrentDirectory(), "*.ttf").ToArray();
            //2) since list stores full ways to files, we erase those paths, so only file names stay.
            for (int i = 0; i < fonts.Length; ++i)
            {
                fonts[i] = fonts[i].Split('\\').Last();
            }
            //3) Load this array of files in combo box
            comboBox1.Items.AddRange(fonts);
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string fontfile = $"{Directory.GetCurrentDirectory()}\\{comboBox1.SelectedItem.ToString()}";
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(fontfile);
            Font font = new Font(pfc.Families[0], 20);
            //comboBox1.Font = font;
            labelExample.Font = font;

        }

        private void OKb_Click(object sender, EventArgs e)
        {
            ChosenFont = new Font(labelExample.Font.FontFamily, labelExample.Font.Size );            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
