using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmApp
{
    public partial class AddMovie : Form
    {
        public AddMovie()
        {
            InitializeComponent();
        }

        Queries queries = new Queries();
        MovieModel movieModel = new MovieModel();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            movieModel.movie_name = txtMovieName.Text;
            movieModel.movie_genre = txtMovieGenre.Text;
            movieModel.movie_director = txtMovieDirector.Text;
            movieModel.movie_actors = txtMovieActors.Text;
            movieModel.movie_year = txtMovieYear.Text;
            queries.tableMovie(movieModel, "Insert");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            movieModel.movie_id = txtMovieId.Text;
            movieModel.movie_name = txtMovieName.Text;
            movieModel.movie_genre = txtMovieGenre.Text;
            movieModel.movie_director = txtMovieDirector.Text;
            movieModel.movie_actors = txtMovieActors.Text;
            movieModel.movie_year = txtMovieYear.Text;
            queries.tableMovie(movieModel, "Update");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            movieModel.movie_id = txtMovieId.Text;
            queries.tableMovie(movieModel, "Delete");
        }

        private void AddMovie_Load(object sender, EventArgs e)
        {

        }
    }
}
