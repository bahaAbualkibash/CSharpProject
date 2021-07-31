
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoreLinq.Extensions;


namespace WindowsFormsApp1
{
    internal class RenderMovies
    {
        private List<Movie> _retreviedList = new List<Movie>();
        private int _page = 1;

        public async Task<Welcome>  LoadMovies( string genere)
        {
         var url = "https://yts.mx/api/v2/list_movies.json?sort_by=download_count&minimum_rating=5&limit=50&page="  + _page++;
            if (genere.Length > 0)
            { 
                url = "https://yts.mx/api/v2/list_movies.json?sort_by=download_count&minimum_rating=5&limit=50&page=" + _page++ + "&genre=" + genere;

            }

            using (var response = await  ApiHelper.ApiClient.GetAsync(url))
            {
                    if (response.IsSuccessStatusCode)
                    {
                        
                        var movies = await response.Content.ReadAsStringAsync();

                    var welcome = Welcome.FromJson(movies);
                    // _page = 1;

                    return welcome;
                    }
                    throw new Exception(response.ReasonPhrase);

            }

            
        }

        private async Task<List<Movie>> ReadyList(string genere)
        {
            var list = await LoadMovies(genere);
            return list.Data.Movies.ToList();
        }

        

        public async Task<List<Movie>> GetNewList(string genere)
        {   
            
            _retreviedList = new List<Movie>();
            var numberOfPages = 3;
            for (var i = 0; i < numberOfPages; i++)
            {
                var list = await ReadyList(genere);
                _retreviedList.AddRange(list);
            }

            RemoveRedundantMoviesInTheList();
            return _retreviedList;

        }
        public async Task<List<Movie>> GetNewList(int pages)
        {

            _retreviedList = new List<Movie>();
            
            for (var i = 0; i < pages; i++)
            {
                var list = await ReadyList("");
                _retreviedList.AddRange(list);
            }

            RemoveRedundantMoviesInTheList();
            return _retreviedList;

        }


        private void RemoveRedundantMoviesInTheList()
        {
            _retreviedList = _retreviedList.DistinctBy(movie => movie.TitleLong).ToList();

        }


        public void setPage(int page)
        {
            _page = page;
        }

    }
}
