using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.Win
{
    public partial class AfficheForm : Form
    {
        public AfficheForm(MovieModel mov)
        {
            InitializeComponent();
            labelTitle.Text = mov.Title;
            labelDesc.Text = mov.Description;
            labelDate.Text = mov.Release_Date.ToString();
            labelCountry.Text = mov.Country;
            labelGenre.Text = mov.Genre;
            picturePoster.Image = mov.GetImage();

            AfficheModel affiche = DataAccess.LoadAfficheByMovie(mov.Id);
            labelPremierDate.Text = affiche.Premier_Date.ToShortDateString();
            labelTicketPrice.Text = affiche.Ticket_Price.ToString();
            labelRating.Text = affiche.Rating.ToString() + "/5";


            
            foreach(Label lbl in tableLayoutPanel1.Controls.OfType<Label>())
            {
                lbl.MouseEnter += (s, e) =>
                {
                    lbl.BackColor = Color.FromArgb(50, 25, 40);
                };

                lbl.MouseLeave += (s, e) =>
                {
                    lbl.BackColor = Color.FromArgb(40, 20, 30);
                };
            }
            

        }


    }
}
