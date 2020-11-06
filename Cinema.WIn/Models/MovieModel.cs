using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Win
{
    /// <summary>
    /// Класс для хранения информации о фильме
    /// </summary>
    public class MovieModel
    {
        //Идентификатор фильма
        public int Id { get; set; }
        //Название фильма
        public string Title { get; set; }
        //Страна
        public string Country { get; set; }
        //Жанр
        public string Genre { get; set; }
        //Режиссер
        public string Director { get; set; }
        //Дата релиза
        public int Release_Date { get; set; }
        //Продолжительность
        public int Length { get; set; }

        public string Description { get; set; }
        public byte[] Poster { get; set; }

        /// <summary>
        /// Конвертирует массив байтов в Изображение
        /// </summary>
        /// <returns>Изображение</returns>
        public Bitmap GetImage()
        {
            Bitmap bmp;
            using (var ms = new MemoryStream(Poster))
            {
                bmp = new Bitmap(ms);
            }


            return bmp;
        }

    }

}
