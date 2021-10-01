using Proy1.Shared.Entity;
using System.Collections.Generic;
using System;

namespace Proy1.Client.Services
{
    public class ServiceMovie:IServiceMovie
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>(){
                new Movie(){ Name="Movie1",Sinopsis="Descripcion Movie1", Image="/Images/movies/movie1.jpg", Category="Action", Score=100,    Premier= new DateTime(2021,09,24)},
                new Movie(){Name="Movie2", Sinopsis="Descripcion Movie2", Image="/Images/movies/movie2.jpg", Category="Action", Score=100, Premier= new DateTime(2021,09,24)},
                new Movie(){Name="Movie3", Sinopsis="Descripcion Movie3", Image="/Images/movies/movie3.jpg", Category="Action", Score=100, Premier= new DateTime(2021,09,24)},
                new Movie(){Name="Movie4", Sinopsis="Descripcion Movie4", Image="/Images/movies/movie4.jpg", Category="Action",    Score=100, Premier= new DateTime(2021,09,24)},
                new Movie(){Name="Movie5", Sinopsis="Descripcion Movie5", Image="/Images/movies/movie5.jpg", Category="Action",    Score=100, Premier= new DateTime(2021,09,24)},
                new Movie(){Name="Movie6", Sinopsis="Descripcion Movie6", Image="/Images/movies/movie6.jpg", Category="Action",    Score=100, Premier= new DateTime(2021,09,24)},
                new Movie(){Name="Movie7", Sinopsis="Descripcion Movie7", Image="/Images/movies/movie7.jpg", Category="Action",    Score=100, Premier= new DateTime(2021,09,24)},
                new Movie(){Name="Movie8", Sinopsis="Descripcion Movie8", Image="/Images/movies/movie8.jpg", Category="Action",    Score=100, Premier= new DateTime(2021,09,24)},
                new Movie(){Name="Movie9", Sinopsis="Descripcion Movie9", Image="/Images/movies/movie9.jpg", Category="Action",    Score=100, Premier= new DateTime(2021,09,24)},
                new Movie(){Name="Movie10",Sinopsis="Descripcion Movie10",Image="/Images/movies/movie10.jpg", Category="Action",    Score=100, Premier= new DateTime(2021,09,24)}
            };
        }
    }
}