using Microsoft.Data.SqlClient;
using System.Data;

namespace MVCAuthor.Models
{
    public class MovieDbRepository
    {
        public static List<Movie> GetMovieList()
        {
            List<Movie> movielist = new List<Movie>();
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand selectmoviecmd = cn.CreateCommand();
                String selectAllMovies = "Select * from movietbl";
                selectmoviecmd.CommandText = selectAllMovies;
                SqlDataReader moviedr = selectmoviecmd.ExecuteReader();
                while (moviedr.Read())
                {
                    Movie movie = new Movie
                    {
                        ID = moviedr.GetInt32(0),
                        Title = moviedr.GetString(1),
                        Language = moviedr.GetString(2),
                        Hero = moviedr.GetString(3),
                        Director = moviedr.GetString(4),
                        MusicDirector = moviedr.GetString(5),
                        ReleaseDate = new DateOnly (moviedr.GetDateTime(6).Year, moviedr.GetDateTime(6).Month, moviedr.GetDateTime(6).Day),
                        Cost = moviedr.GetDecimal(7),
                        Collection = moviedr.GetDecimal(8),
                        Review = moviedr.GetInt32(9),
                    };
                    movielist.Add(movie);
                }
            }
            return movielist;
        }
        public static Movie GetMovieById(int id)
        {

            Movie movielist = new Movie();
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand selectmoviecmd = cn.CreateCommand();
                String selectMovie = "Select * from movietbl where ID = @id";
                //selectempcmd.Parameters.AddWithValue("@id", id);
                selectmoviecmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                selectmoviecmd.CommandText = selectMovie;
                SqlDataReader moviedr = selectmoviecmd.ExecuteReader();
                moviedr.Read();
                movielist.ID = moviedr.GetInt32(0);
                movielist.Title = moviedr.GetString(1);
                movielist.Language = moviedr.GetString(2);
                movielist.Hero = moviedr.GetString(3);
                movielist.Director = moviedr.GetString(4);
                movielist.MusicDirector = moviedr.GetString(5);
                movielist.ReleaseDate = new DateOnly(moviedr.GetDateTime(6).Year, moviedr.GetDateTime(6).Month, moviedr.GetDateTime(6).Day);
                movielist.Cost = moviedr.GetDecimal(7);
                movielist.Collection = moviedr.GetDecimal(8);
                movielist.Review = moviedr.GetInt32(9);
            }
            return movielist;
        }
        public static int AddNewMovie(Movie newmovie)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand insertMoviecmd = cn.CreateCommand();
                String insertNewMovieQuery = "insert into movietbl values( @ID,@Title,@Language,@Hero,@Director,@MusicDirector,@ReleaseDate,@Cost,@Collection ,@Review )";
                insertMoviecmd.Parameters.Add("@ID", SqlDbType.Int).Value = newmovie.ID;
                insertMoviecmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = newmovie.Title;
                insertMoviecmd.Parameters.Add("@Language", SqlDbType.NVarChar).Value = newmovie.Language;
                insertMoviecmd.Parameters.Add("@Hero", SqlDbType.NVarChar).Value = newmovie.Hero;
                insertMoviecmd.Parameters.Add("@Director", SqlDbType.NVarChar).Value = newmovie.Director;
                insertMoviecmd.Parameters.Add("@MusicDirector", SqlDbType.NVarChar).Value = newmovie.MusicDirector;
                insertMoviecmd.Parameters.Add("@ReleaseDate", SqlDbType.Date).Value = newmovie.ReleaseDate;
                insertMoviecmd.Parameters.Add("@Cost", SqlDbType.Decimal).Value = newmovie.Cost;
                insertMoviecmd.Parameters.Add("@Collection", SqlDbType.Decimal).Value = newmovie.Collection;
                insertMoviecmd.Parameters.Add("@Review", SqlDbType.Int).Value = newmovie.Review;
                insertMoviecmd.CommandText = insertNewMovieQuery;
                query_result = insertMoviecmd.ExecuteNonQuery();
            }
            return query_result;
        }
        public static int UpdateMovie(Movie modifiedMovie)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand updateMoviecmd = cn.CreateCommand();
                String updateMovieQuery = "Update movietbl set ID = @ID,Title = @Title,Language = @Language,Hero = @Hero,Director = @Director,MusicDirector = @MusicDirector,ReleaseDate = @ReleaseDate,Cost = @Cost,Collection = @Collection ,Review = @Review where ID=@ID";
                updateMoviecmd.Parameters.Add("@ID", SqlDbType.Int).Value = modifiedMovie.ID;
                updateMoviecmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = modifiedMovie.Title;
                updateMoviecmd.Parameters.Add("@Language", SqlDbType.NVarChar).Value = modifiedMovie.Language;
                updateMoviecmd.Parameters.Add("@Hero", SqlDbType.NVarChar).Value = modifiedMovie.Hero;
                updateMoviecmd.Parameters.Add("@Director", SqlDbType.NVarChar).Value = modifiedMovie.Director;
                updateMoviecmd.Parameters.Add("@MusicDirector", SqlDbType.NVarChar).Value = modifiedMovie.MusicDirector;
                updateMoviecmd.Parameters.Add("@ReleaseDate", SqlDbType.Date).Value = modifiedMovie.ReleaseDate;
                updateMoviecmd.Parameters.Add("@Cost", SqlDbType.Decimal).Value = modifiedMovie.Cost;
                updateMoviecmd.Parameters.Add("@Collection", SqlDbType.Decimal).Value = modifiedMovie.Collection;
                updateMoviecmd.Parameters.Add("@Review", SqlDbType.Int).Value = modifiedMovie.Review;
                updateMoviecmd.CommandText = updateMovieQuery;
                query_result = updateMoviecmd.ExecuteNonQuery();
            }
            return query_result;
        }
        public static int DeleteMovie(int id)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand deleteMoviecmd = cn.CreateCommand();
                String deleteMovieQuery = "Delete from movietbl where ID=@id";
                deleteMoviecmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                deleteMoviecmd.CommandText = deleteMovieQuery;
                query_result = deleteMoviecmd.ExecuteNonQuery();
            }
            return query_result;
        }
    }
}
