using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Win
{
    /// <summary>
    /// Статический класс.
    /// Описывает взаимодействие с БД
    /// </summary>
    public static class DataAccess
    {

        /// <summary>
        /// Получение полной информации о фильмах из БД
        /// </summary>
        /// <returns>Список Фильмов</returns>
        public static List<MovieModel> LoadMovies(string title = null)
        {


            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {

                DynamicParameters p = new DynamicParameters();

                string sql = @"SELECT m.Id,
	                                m.Title,
	                                c.Name Country,
	                                m.Release_Date,
	                                g.Name Genre,
	                                d.FirstName || ' ' || d.LastName Director,
	                                m.Length,
	                                m.Poster,
	                                m.Description
                                FROM movies m
                                JOIN countries c ON (m.Country_Id = c.Id)
                                JOIN genres g ON (m.Genre_Id = g.Id)
                                JOIN directors d ON (m.Director_Id = d.Id)";

                if (title != null)
                {
                    sql += " WHERE m.Title Like @Title";
                    p.Add("title", title);
                }

                var output = cnn.Query<MovieModel>(sql, new {Title = title });
                return output.ToList();
            }
        }

        public static List<MovieModel> LoadMoviesForToday()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"SELECT m.Id,
	                                m.Title,
	                                c.Name Country,
	                                m.Release_Date,
	                                g.Name Genre,
	                                d.FirstName || ' ' || d.LastName Director,
	                                m.Length,
	                                m.Poster,
	                                m.Description
                                FROM movies m
                                JOIN countries c ON (m.Country_Id = c.Id)
                                JOIN genres g ON (m.Genre_Id = g.Id)
                                JOIN directors d ON (m.Director_Id = d.Id)
                                JOIN affiches a ON (m.Id = a.Movie_Id)
                                WHERE Date('now') BETWEEN a.Premier_Date AND End_Date";

                var output = cnn.Query<MovieModel>(sql);
                return output.ToList();
            }

            
        }

        public static List<MovieModel> LoadMoviesByGenre(string genre)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {

                DynamicParameters p = new DynamicParameters();

                string sql = @"SELECT m.Id,
	                                m.Title,
	                                c.Name Country,
	                                m.Release_Date,
	                                g.Name Genre,
	                                d.FirstName || d.LastName Director,
	                                m.Length,
	                                m.Poster,
	                                m.Description
                                FROM movies m
                                JOIN countries c ON (m.Country_Id = c.Id)
                                JOIN genres g ON (m.Genre_Id = g.Id)
                                JOIN directors d ON (m.Director_Id = d.Id)
                                WHERE g.Name = @Genre";
                

                var output = cnn.Query<MovieModel>(sql, new { Genre = genre });
                return output.ToList();
            }
        }

        public static List<string> LoadGenres()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {

                string sql = @"SELECT Name FROM genres ORDER BY Name DESC";

                var output = cnn.Query<string>(sql);
                return output.ToList();
            }
        }

        public static List<MovieModel> LoadMoviesLimit(int limit, int to, string genre)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {

                DynamicParameters p = new DynamicParameters();

                p.Add("Limit", limit);
                p.Add("To", to);

                

                string sql = @"SELECT m.Id,
	                                m.Title,
	                                c.Name Country,
	                                m.Release_Date,
	                                g.Name Genre,
	                                d.FirstName || d.LastName Director,
	                                m.Length,
	                                m.Poster,
	                                m.Description
                                FROM movies m
                                JOIN countries c ON (m.Country_Id = c.Id)
                                JOIN genres g ON (m.Genre_Id = g.Id)
                                JOIN directors d ON (m.Director_Id = d.Id)";

                if (!string.IsNullOrWhiteSpace(genre))
                {
                    sql += " WHERE g.Name = '@Genre'";
                    p.Add("Genre", genre);
                }

                sql += " Limit @Limit, @To";

                var output = cnn.Query<MovieModel>(sql, p);
                return output.ToList();
            }
        }

        public static List<AfficheModel> LoadAffiches()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"SELECT a.Id, a.Movie_Id, m.Title as Title, a.Premier_Date, a.Ticket_Price, a.End_Date 
                            FROM affiches a
                            JOIN movies m ON (a.Movie_Id = m.Id)";

                var output = cnn.Query<AfficheModel>(sql);
                return output.ToList();
            }
        }

        public static AfficheModel LoadAfficheByMovie(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"SELECT
                                a.Id,
                                a.Movie_Id,
                                a.Premier_Date,
                                a.Ticket_Price,
                                a.End_Date,
                                AVG(r.Rating) as Rating
                                FROM affiches a
                                LEFT JOIN reviews r ON (a.Movie_Id = r.Movie_Id)
                                WHERE a.Movie_Id = @Id
                                GROUP BY Id, a.Movie_Id, a.Premier_Date, a.Ticket_Price, a.End_Date";

                var output = cnn.Query<AfficheModel>(sql, new { Id = id.ToString() });
                return output.First();
            }
        }

        public static bool FindUser(string login)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"SELECT * FROM users WHERE Username = @Login";

                var output = cnn.Query<UserModel>(sql, new { Login = login });
                return output.ToList().Count == 1 ? true : false;

            }
        }

        


        
        /// <summary>
        /// Загрузка строки подключения к БД
        /// </summary>
        /// <param name="id">Идентификатор строки из конфигурации приложения</param>
        /// <returns>Строка подключения</returns>
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
