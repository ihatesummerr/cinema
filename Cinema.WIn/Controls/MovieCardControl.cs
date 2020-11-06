using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.Win
{
    public partial class MovieCardControl : UserControl
    {

        private MovieModel movie;

        public MovieCardControl(MovieModel mov)
        {
            InitializeComponent();
            movie = mov;
            labelTitle.Text = mov.Title;
            labelDesc.Text = mov.Description;
            labelDate.Text = mov.Release_Date.ToString();
            labelCountry.Text = mov.Country;
            labelGenre.Text = mov.Genre;
            picturePoster.Image = mov.GetImage();
            Dock = DockStyle.Fill;
        }

        private void MovieCardControl_MouseEnter(object sender, EventArgs e)
        {
            labelTitle.ForeColor = Color.FromArgb(234, 82, 111);
        }

        private void MovieCardControl_MouseLeave(object sender, EventArgs e)
        {
            labelTitle.ForeColor = Color.FromArgb(234, 224, 213);
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new AfficheForm(movie));
        }
    }
}
