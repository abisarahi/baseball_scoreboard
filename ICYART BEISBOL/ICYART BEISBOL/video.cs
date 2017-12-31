using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICYART_BEISBOL
{
    public partial class video : Form
    {
        public video()
        {
            InitializeComponent();
        }

        public video(string video)
        {
            InitializeComponent();
            axWindowsMediaPlayer1.URL = video;
        }

        private void video_Load(object sender, EventArgs e)
        {

        }
    }
}
