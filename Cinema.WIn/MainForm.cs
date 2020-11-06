using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.Win
{
    public partial class MainForm : Form
    {
        //Активная дочерняя форма, по умолчанию = Null
        private Form _activeChildForm = null;
        //Активный дочерная панель, по умолчанию = Null
        private Control _activeChildBar = null;
        //Публичный экземпляр главной формы
        public static MainForm Instance;
        //Список жанров
        private List<string> Genres;
        public MainForm()
        {
            InitializeComponent();
            panelMoviesSubMenu.Visible = false;
            Instance = this;
            OpenChildForm(new MoviesForm());
            InitMovieMenu();


            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

        }


        #region Кастомный TitleBar
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion




        /// <summary>
        /// Создание отдельной кнопки для каждого жанра
        /// </summary>
        private void InitMovieMenu()
        {
            Genres = DataAccess.LoadGenres();
            Genres.ForEach(genre =>
            {
                Button subMenuBtn = new Button()
                {
                    BackColor = Color.FromArgb(40, 20, 30),
                    Dock = DockStyle.Top,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))),
                    Padding = new Padding(40, 0, 0, 0),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Size = new Size(250, 35),
                    Text = genre
                };

                subMenuBtn.FlatAppearance.BorderSize = 0;

                subMenuBtn.Click += (s, e) =>
                {
                    OpenChildForm(new MoviesForm(genre));
                    //HideSubMenu();
                };

                panelMoviesSubMenu.Controls.Add(subMenuBtn);
            });
        }

        /// <summary>
        /// Скрывает все открытые под. меню.
        /// </summary>
        private void HideSubMenu()
        {
            panelMoviesSubMenu.Visible = panelMoviesSubMenu.Visible ? false : true;
        }

        /// <summary>
        /// Показывает под. меню.
        /// </summary>
        /// <param name="subMenu">Под. меню</param>
        private void ShowSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        /// <summary>
        /// Открытие дочерней формы внутри главной
        /// </summary>
        /// <param name="childForm">Дочерняя форма</param>
        public void OpenChildForm(Form childForm)
        {
            if (_activeChildForm != null) _activeChildForm.Close();

            _activeChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.ShowInTaskbar = false;
            panelChildFrom.Controls.Add(childForm);
            panelChildFrom.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }

        public void OpenChildBar(Control childBar)
        {
            if (_activeChildBar != null) panelBar.Controls.Clear();

            _activeChildBar = childBar;
            childBar.Dock = DockStyle.Fill;

            panelBar.Controls.Add(childBar);
        }

        /// <summary>
        /// Показать меню фильмы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMovies_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelMoviesSubMenu);
            
        }

        private void ReturnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MoviesForm());
        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureExit_MouseEnter(object sender, EventArgs e)
        {
            pictureExit.Image = Resource.exit_hover;
        }

        private void pictureExit_MouseLeave(object sender, EventArgs e)
        {
            pictureExit.Image = Resource.exit;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            new MainAdminForm().Show();
        }
    }
}
