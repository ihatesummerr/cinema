using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.Win
{
    public partial class MoviesForm : Form
    {
        //Список фильмов
        public List<MovieModel> Movies { get; set; }
        // Список отысканных фильмов
        private List<MovieModel> SearchMovies { get; set; }
        // Номер страницы
        private int _page = 0;
        // Текущий жанр
        private string _genre;


        public MoviesForm(string genre)
        {
            InitializeComponent();

            _genre = genre;

            //Получаем список фильмов
            Movies = DataAccess.LoadMoviesByGenre(genre);

            //Для каждого фильма создаем новую карточку и добавляем её в контейнер
            CreateMovieCards(Movies);

        }

        public MoviesForm()
        {
            InitializeComponent();

            Movies = DataAccess.LoadMoviesForToday();
            CreateMovieCards(Movies);

            labelSearch.Text = "Доступные фильмы в прокате";

            textBoxSearch.Visible = false;
            buttonSearch.Visible = false;
        }

        /// <summary>
        /// Обновление списка фильмов после совершения поиска
        /// </summary>
        private void UpdateMovieList(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxSearch.Text))
            {
                CreateMovieCards(Movies);
                return;
            }

            //Производим поиск фильмов по заголовку через sql запрос
            SearchMovies = DataAccess.LoadMovies(textBoxSearch.Text + "%");
            CreateMovieCards(SearchMovies);
        }

        /// <summary>
        /// Создание карточек по списку фильмов
        /// </summary>
        /// <param name="movies">Список фильмов</param>
        private void CreateMovieCards(List<MovieModel> movies)
        {
            flowMoviesContainer.Controls.Clear();
            movies.ForEach(movie =>
            {
                flowMoviesContainer.Controls.Add(new MovieCardControl(movie));
                flowMoviesContainer.RowCount++;
            });

            MoreButtonInit();
        }

        private void MoreButtonInit()
        {

            // Стиль кнопки "Еще"
            Label more = new Label()
            {
                Text = "Еще ",
                Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))),
                ForeColor = Color.FromArgb(234, 224, 213),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.TopCenter
            };


            #region Эффект при наведении мыши
            more.MouseEnter += (s, e) =>
            {
                more.ForeColor = Color.FromArgb(234, 82, 111);
            };

            more.MouseLeave += (s, e) =>
            {
                more.ForeColor = Color.FromArgb(234, 224, 213);
            };
            #endregion

            // Действие по нажатию
            more.Click += (s, e) =>
            {
                _page += 10;
                int i = flowMoviesContainer.Controls.Count;
                flowMoviesContainer.Controls.RemoveAt(i - 1);
                DataAccess.LoadMoviesLimit(_page, 10, _genre).ForEach(movie =>
                {
                    Movies.Add(movie);
                    flowMoviesContainer.Controls.Add(new MovieCardControl(movie));
                });

                flowMoviesContainer.Controls.Add(s as Label);
                flowMoviesContainer.RowCount++;
            };
            flowMoviesContainer.Controls.Add(more);
        }



    }
}
