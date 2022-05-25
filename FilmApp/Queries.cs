using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace FilmApp
{
    internal class Queries
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\University\Semester 6\Management of Software Projects\Project Assignment\System for Selecting a Film\FilmDatabase.accdb";
        OleDbConnection dbConnection = new OleDbConnection();
        string query;
        string[] messagesDB = { "Record submitted.", "Record updated.", "Record deleted." };

        public void OpenDbConnection()
        {
            dbConnection.ConnectionString = connectionString;
        }

        public void ExecuteQuery(string query, string message)
        {
            OpenDbConnection();
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            dbConnection.Open();
            dbCommand.CommandText = query;
            dbCommand.Connection = dbConnection;
            dbCommand.ExecuteNonQuery();
            MessageBox.Show(message);
            dbConnection.Close();
        }

        public void tableMovie(MovieModel movieModel, string selectedCommand)
        {
            string messageDB;
            if (selectedCommand == "Insert")
            {
                query = "INSERT INTO Movie(movie_name, movie_genre, movie_director, movie_actors, movie_year) " +
                    "VALUES('" + movieModel.movie_name + "', '" + movieModel.movie_genre + "', '" + movieModel.movie_director +
                    "', '" + movieModel.movie_actors + "', '" + movieModel.movie_year + "')";
                messageDB = messagesDB[0];
            }
            else if (selectedCommand == "Update")
            {
                query = "UPDATE Movie SET movie_name = '" + movieModel.movie_name + "', movie_genre='" + movieModel.movie_genre +
                "', movie_director='" + movieModel.movie_director + "', movie_actors='" + movieModel.movie_actors +
                "', movie_year='" + movieModel.movie_year + "'WHERE id_movie=" + movieModel.movie_id;
                messageDB = messagesDB[1];
            }
            else
            {
                query = "DELETE FROM Movie WHERE id_movie=" + movieModel.movie_id;
                messageDB = messagesDB[2];
            }
            ExecuteQuery(query, messageDB);
        }

        public string Query(string field,string selectedQuery)
        {
            if(selectedQuery == "Genre")
            {
                query = "SELECT movie_name, movie_genre, movie_year FROM MOVIE " +
                    "WHERE movie_genre LIKE '%" + field + "%'";
            }
            else if(selectedQuery == "Actor")
            {
                query = "SELECT movie_name, movie_genre, movie_year FROM MOVIE " +
                    "WHERE movie_actors LIKE '%" + field + "%'";
            }
            return query;
        }

        public void displayQuery(string query, DataGridView dataGridView)
        {
            dbConnection.ConnectionString = connectionString;
            dbConnection.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, dbConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView.DataSource = dt;
            dbConnection.Close();
        }
    }
}
