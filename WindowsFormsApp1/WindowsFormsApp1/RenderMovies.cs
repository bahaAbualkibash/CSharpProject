
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class RenderMovies
    {
        public async Task  LoadMovies()
        {
          
                string url = "https://yts.mx/api/v2/list_movies.json";
                using (HttpResponseMessage response = await  ApiHelper.ApiClient.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        
                    }

                }
            
        }
    }
}
