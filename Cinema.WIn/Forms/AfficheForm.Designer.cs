namespace Cinema.Win
{
    partial class AfficheForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picturePoster = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPremierDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelRating = new System.Windows.Forms.Label();
            this.labelTicketPrice = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelShow = new System.Windows.Forms.Label();
            this.labelReviews = new System.Windows.Forms.Label();
            this.labelAdd = new System.Windows.Forms.Label();
            this.labelLeaveReview = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturePoster)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picturePoster
            // 
            this.picturePoster.BackColor = System.Drawing.Color.Transparent;
            this.picturePoster.Dock = System.Windows.Forms.DockStyle.Top;
            this.picturePoster.Location = new System.Drawing.Point(0, 0);
            this.picturePoster.Name = "picturePoster";
            this.picturePoster.Padding = new System.Windows.Forms.Padding(3);
            this.picturePoster.Size = new System.Drawing.Size(280, 256);
            this.picturePoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePoster.TabIndex = 0;
            this.picturePoster.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.labelPremierDate);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.labelCountry);
            this.panel4.Controls.Add(this.labelGenre);
            this.panel4.Controls.Add(this.labelRating);
            this.panel4.Controls.Add(this.labelTicketPrice);
            this.panel4.Controls.Add(this.labelDate);
            this.panel4.Controls.Add(this.picturePoster);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(280, 580);
            this.panel4.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 459);
            this.label10.Margin = new System.Windows.Forms.Padding(10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 18);
            this.label10.TabIndex = 5;
            this.label10.Text = "Оценка:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 421);
            this.label5.Margin = new System.Windows.Forms.Padding(10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Цена билета:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 383);
            this.label4.Margin = new System.Windows.Forms.Padding(10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Премьера:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 345);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Жанр:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPremierDate
            // 
            this.labelPremierDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelPremierDate.AutoSize = true;
            this.labelPremierDate.Location = new System.Drawing.Point(150, 383);
            this.labelPremierDate.Margin = new System.Windows.Forms.Padding(10);
            this.labelPremierDate.Name = "labelPremierDate";
            this.labelPremierDate.Size = new System.Drawing.Size(115, 18);
            this.labelPremierDate.TabIndex = 5;
            this.labelPremierDate.Text = "Premier Date";
            this.labelPremierDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 307);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Год выхода:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 269);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Страна:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCountry
            // 
            this.labelCountry.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(150, 269);
            this.labelCountry.Margin = new System.Windows.Forms.Padding(10);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(71, 18);
            this.labelCountry.TabIndex = 5;
            this.labelCountry.Text = "Country";
            this.labelCountry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGenre
            // 
            this.labelGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelGenre.AutoSize = true;
            this.labelGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(82)))), ((int)(((byte)(111)))));
            this.labelGenre.Location = new System.Drawing.Point(150, 345);
            this.labelGenre.Margin = new System.Windows.Forms.Padding(10);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(56, 18);
            this.labelGenre.TabIndex = 6;
            this.labelGenre.Text = "Genre";
            this.labelGenre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRating
            // 
            this.labelRating.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelRating.AutoSize = true;
            this.labelRating.Location = new System.Drawing.Point(150, 459);
            this.labelRating.Margin = new System.Windows.Forms.Padding(10);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(61, 18);
            this.labelRating.TabIndex = 5;
            this.labelRating.Text = "Rating";
            this.labelRating.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTicketPrice
            // 
            this.labelTicketPrice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelTicketPrice.AutoSize = true;
            this.labelTicketPrice.Location = new System.Drawing.Point(150, 421);
            this.labelTicketPrice.Margin = new System.Windows.Forms.Padding(10);
            this.labelTicketPrice.Name = "labelTicketPrice";
            this.labelTicketPrice.Size = new System.Drawing.Size(102, 18);
            this.labelTicketPrice.TabIndex = 5;
            this.labelTicketPrice.Text = "Ticket Price";
            this.labelTicketPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDate
            // 
            this.labelDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(150, 307);
            this.labelDate.Margin = new System.Windows.Forms.Padding(10);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(47, 18);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "Date";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDesc
            // 
            this.labelDesc.AutoEllipsis = true;
            this.labelDesc.AutoSize = true;
            this.labelDesc.BackColor = System.Drawing.Color.Transparent;
            this.labelDesc.Location = new System.Drawing.Point(3, 34);
            this.labelDesc.Margin = new System.Windows.Forms.Padding(3);
            this.labelDesc.MaximumSize = new System.Drawing.Size(525, 0);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(118, 18);
            this.labelDesc.TabIndex = 3;
            this.labelDesc.Text = "Description...";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.labelTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(750, 31);
            this.panel3.TabIndex = 8;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(3, 3);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(3);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(64, 25);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Title";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel5.Controls.Add(this.tableLayoutPanel1);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.labelDesc);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(280, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(750, 580);
            this.panel5.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelLeaveReview, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelAdd, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelReviews, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelShow, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 477);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(750, 103);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // labelShow
            // 
            this.labelShow.AutoSize = true;
            this.labelShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.labelShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelShow.Location = new System.Drawing.Point(3, 3);
            this.labelShow.Margin = new System.Windows.Forms.Padding(3);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(369, 45);
            this.labelShow.TabIndex = 0;
            this.labelShow.Text = "Посмотреть";
            this.labelShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelReviews
            // 
            this.labelReviews.AutoSize = true;
            this.labelReviews.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.labelReviews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelReviews.Location = new System.Drawing.Point(378, 3);
            this.labelReviews.Margin = new System.Windows.Forms.Padding(3);
            this.labelReviews.Name = "labelReviews";
            this.labelReviews.Size = new System.Drawing.Size(369, 45);
            this.labelReviews.TabIndex = 6;
            this.labelReviews.Text = "Отзывы";
            this.labelReviews.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.labelAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAdd.Location = new System.Drawing.Point(3, 54);
            this.labelAdd.Margin = new System.Windows.Forms.Padding(3);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(369, 46);
            this.labelAdd.TabIndex = 7;
            this.labelAdd.Text = "Добавить в каталог";
            this.labelAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLeaveReview
            // 
            this.labelLeaveReview.AutoSize = true;
            this.labelLeaveReview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.labelLeaveReview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLeaveReview.Location = new System.Drawing.Point(378, 54);
            this.labelLeaveReview.Margin = new System.Windows.Forms.Padding(3);
            this.labelLeaveReview.Name = "labelLeaveReview";
            this.labelLeaveReview.Size = new System.Drawing.Size(369, 46);
            this.labelLeaveReview.TabIndex = 11;
            this.labelLeaveReview.Text = "Оставить отзыв";
            this.labelLeaveReview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AfficheForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1030, 580);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AfficheForm";
            this.Text = "AfficheForm";
            ((System.ComponentModel.ISupportInitialize)(this.picturePoster)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picturePoster;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelPremierDate;
        private System.Windows.Forms.Label labelTicketPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelShow;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.Label labelLeaveReview;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.Label labelReviews;
    }
}