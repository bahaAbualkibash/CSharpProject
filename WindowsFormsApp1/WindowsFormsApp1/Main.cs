using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Guna.UI.WinForms;
using Guna.UI2.WinForms;
using MoreLinq;
using MoreLinq.Extensions;
using PictureBox = Guna.UI2.WinForms.Suite.PictureBox;

namespace WindowsFormsApp1
{

    [System.Runtime.InteropServices.Guid("BBCF181D-F563-4E7A-A550-A04727DE2BD0")]
    public partial class Main : Form
    {
        private  List<Movie> listMoveis = new List<Movie>();

        private RenderMovies render = new RenderMovies();

        public Main()
        {
            InitializeComponent();
            isReady();
            Text = "Popcorn Movies";
        }

        private async void isReady()
        {
            var list  = await render.LoadMovies("");
            ShowMovies(list.Data.Movies);
            listMoveis = MoreEnumerable.DistinctBy(listMoveis, movie => movie.TitleLong).ToList();
            foreach (var movie in listMoveis)
            {
                var imageUri = (movie.MediumCoverImage.AbsoluteUri);
                var pictureBox = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                pictureBox.LoadAsync(imageUri);
                pictureBox.Margin = new Padding(20);
                pictureBox.Size = new System.Drawing.Size(380, 470);
                flowLayoutPanel1.Controls.Add(pictureBox);

            }
        }

      

        private void clearPanel()
        {
            flowLayoutPanel1.Controls.Clear();

        }
        private void ShowMovies(List<Movie> listMoveis)
        {
            foreach (var movie in listMoveis)
            {
                var imageUri = (movie.MediumCoverImage.AbsoluteUri);
                var pictureBox = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                pictureBox.LoadAsync(imageUri);
                pictureBox.Margin = new Padding(20);
                pictureBox.Size = new System.Drawing.Size(380, 470);
                flowLayoutPanel1.Controls.Add(pictureBox);

            }
        }

        private async void ButtonClick(string type= "")
        {
            List<Movie> list = new List<Movie>();
            if (type.Equals("new"))
            {
                
                    list = await render.GetNewList(10);
                    list = MoreEnumerable.DistinctBy(list, (movie => movie.Year > DateTime.Now.Year - 1)).ToList();

                

            }
            else
            {
                render.setPage(1);
                list = await render.GetNewList(type);

            }
            clearPanel();
            ShowMovies(list);
        }


        private void feelsGoodButtom_Click(object sender, EventArgs e)
        {
            ButtonClick("Adventure");
        }

        private void comedyButton_Click(object sender, EventArgs e)
        {
            ButtonClick("Comedy");
        }

        private void classicsButton_Click(object sender, EventArgs e)
        {
            ButtonClick("Horror");

        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            ButtonClick("Action");

        }

        private void oscarFilmsButton_Click_1(object sender, EventArgs e)
        {

            ButtonClick("Sci-Fi");
        }

        private void MainButton_Click(object sender, EventArgs e)
        {
            ButtonClick();

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            ButtonClick("new");


        }
    }


}
