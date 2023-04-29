using ImdbTopMovies.Models;
using System.Collections;
using System.Net;

namespace ImdbTopMovies
{
    public partial class FormMovies : Form
    {

        List<Movie> movies = new List<Movie>();
        public FormMovies()
        {
            InitializeComponent();
        }

        private void FormMovies_Load(object sender, EventArgs e)
        {
            WebClient client = new WebClient();


            string result = String.Empty;
            try
            {

                result = client.DownloadString("https://www.imdb.com/chart/top/");

            }
            catch (Exception)
            {

                MessageBox.Show("İntrernet bağlantısı kurulamadı.");
            }




            List<string> content = result.Replace("</tr>", "").Split("<tr>").ToList();

            if (content.Count>2)
            {
                content.RemoveRange(0, 2);

            }
            else
            {
                content = new List<string>() ;   
            }



            foreach (string item in content)
            {
                item.Replace("<tr>", "").Replace("</tr>", "");

                Movie movie = new Movie();

                string nameRaw = item;
                string yearRaw = item;
                string ratingRaw = item;

                if (item.Contains("<a"))
                {
                    int start = item.IndexOf("<a href=");
                    int end = item.IndexOf("</a>");
                    string newName = item.Substring(start, end - start + 4);
                    int newIndex = newName.IndexOf("alt=");
                    newName = newName.Substring(newIndex).Replace("</a>", "").Replace("/", "").Replace("\\\"", "").Replace("<", "").Replace(">", "").Replace("alt=", "").Replace("\n", "").Replace("\"", "");
                    movie.Name = newName;

                }
                if (item.Contains("class=\"secondaryInfo\">"))
                {
                    int start = item.IndexOf("class=\"secondaryInfo\">(");
                    int newYear = Convert.ToInt32(item.Substring(start + 23, 4));
                    movie.Year = newYear;

                }
                if (item.Contains("user ratings\">"))
                {
                    int start = item.IndexOf("user ratings\">");
                    int end = item.IndexOf("</strong>");
                    double newRating = Convert.ToDouble(item.Substring(start + 14, 3));
                    movie.Rating = newRating;
                }



                movies.Add(movie);

                labelResult.Text = SetLabel(movies);

            }


            client.Dispose();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = movies.ToList();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {


        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

            string input = textSearch.Text.ToLower();
            List<Movie> searchedMovies = new List<Movie>();

            foreach (var item in movies)
            {
                if (item.Name.ToLower().Contains(input))
                {
                    searchedMovies.Add(item);
                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = searchedMovies;
            labelResult.Text = SetLabel(searchedMovies);
        }

        public static string SetLabel(List<Movie> movies)
        {

            return movies.Count.ToString() + " adet kitap var.";
        }
    }
}