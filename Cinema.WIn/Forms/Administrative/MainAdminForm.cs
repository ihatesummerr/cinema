using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.Win
{
    public partial class MainAdminForm : Form
    {
        private bool connected = false;
        BindingSource bsMovies = new BindingSource();
        BindingSource bsAffiches = new BindingSource();
        
        public MainAdminForm()
        {
            InitializeComponent();
        }

        private void MainAdminForm_Load(object sender, EventArgs e)
        {
            

        }

        /// <summary>
        /// Установка стилей для сетки данных
        /// </summary>
        private void StyleDataGridView(DataGridView dg)
        {
            dg.BorderStyle = BorderStyle.None;
            dg.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dg.DefaultCellStyle.SelectionBackColor = Color.FromArgb(234, 82, 111);
            dg.DefaultCellStyle.SelectionForeColor = Color.FromArgb(234, 224, 213);
            dg.DefaultCellStyle.Font = new Font("Segoe UI", 14);
            dg.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dg.BackgroundColor = Color.FromArgb(30, 20, 20);
            dg.DefaultCellStyle.BackColor = Color.FromArgb(40, 20, 30);
            dg.DefaultCellStyle.ForeColor = Color.FromArgb(234, 224, 213);
            dg.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dg.EnableHeadersVisualStyles = false;
            dg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dg.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 16);
            dg.ColumnHeadersDefaultCellStyle.Padding = new Padding(10);
            dg.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 20, 20);
            dg.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void SetUpTabPageMovies()
        {
            StyleDataGridView(dataGridView1);
            bsMovies.DataSource = DataAccess.LoadMovies();
            dataGridView1.DataSource = bsMovies;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Description"].Visible = false;
            dataGridView1.Columns["Poster"].Visible = false;

            dataGridView1.Columns["Title"].HeaderText = "Название";
            dataGridView1.Columns["Country"].HeaderText = "Страна";
            dataGridView1.Columns["Genre"].HeaderText = "Жанр";
            dataGridView1.Columns["Director"].HeaderText = "Режиссер";
            dataGridView1.Columns["Release_Date"].HeaderText = "Дата Выхода";
            dataGridView1.Columns["Length"].HeaderText = "Хронометраж";
        }

        private void SetUpTabPageAffiches()
        {
            StyleDataGridView(dataGridView2);
            bsAffiches.DataSource = DataAccess.LoadAffiches();
            dataGridView2.DataSource = bsAffiches;
            dataGridView2.Columns["Id"].Visible = false;
            dataGridView2.Columns["Movie_Id"].Visible = false;
            dataGridView2.Columns["Rating"].Visible = false;


            dataGridView2.Columns["Title"].HeaderText = "Название";
            dataGridView2.Columns["Premier_Date"].HeaderText = "Дата премьеры";
            dataGridView2.Columns["Ticket_Price"].HeaderText = "Цена билета";
            dataGridView2.Columns["End_Date"].HeaderText = "Конец проката";
        }

        private Action Disconnect()
        {
            return new Action(() => 
            {

                


            });
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!connected)
            {
                button1.Enabled = false;
                try
                {
                    SetUpTabPageMovies();
                    SetUpTabPageAffiches();

                    connected = true;


                }
                catch (Exception)
                {

                    throw;
                }
                button1.Enabled = true;
                button1.Text = "Отключиться";
            }
            else
            {
                button1.Enabled = false;
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                button1.Enabled = true;
                connected = false;
                button1.Text = "Подключиться";
            }

            
        }
    }
}
