using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parametrealmayan_geridegerdondürmeyen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void MaviRenk()// Geri değer döndürmeyen ve parametre almayan "MaviRenk" isimli metot
        {
            this.BackColor = Color.Blue;
        }
        void KirmiziRenk()
        {
            this.BackColor = Color.Red;
        }
        void SariRenk()
        {
            this.BackColor = Color.Yellow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbKirmizi.Checked)//"KirmiziRenk" isimli metot çağrıldı
            {
                KirmiziRenk();
            }
            else if (rbMavi.Checked)
            {
                MaviRenk();
            }
            else
            {
                SariRenk();
            }
        }
    }
}
