using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http.Filters;

namespace RefereeTest.DAL
{
    class Listado
    {
        private Uri uri = new Uri("http://referee.mbarrera.ciclo.iesnervion.es/trivial/regla");
        /// <summary>
        ///  Metodo que recoge todas las personas, con o sin parametros de busqueda
        /// </summary>
        /// <returns></returns>
        public async Task<Trivial> gettrivial()
        {
            Trivial trivial = new Trivial();
            //HttpBaseProtocolFilter filtro = new HttpBaseProtocolFilter();
            //filtro.CacheControl.ReadBehavior = HttpCacheReadBehavior.MostRecent;
            //filtro.CacheControl.WriteBehavior = HttpCacheWriteBehavior.NoCache;
            HttpClient mihttpClient = new HttpClient();

            try
            {
                string respuesta = await mihttpClient.GetStringAsync(uri);
                mihttpClient.Dispose();
                trivial = JsonConvert.DeserializeObject<Trivial>(respuesta);

            }
            catch (Exception)
            {

            }

            return trivial;
        }
    }
}
