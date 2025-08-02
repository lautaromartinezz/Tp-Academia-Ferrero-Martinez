using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using DTOs;
namespace WindowsForms
{
    public class MateriaAPIClient
    {
        private static HttpClient client = new HttpClient();
        static MateriaAPIClient()
        {
            client.BaseAddress = new Uri("http://localhost:5183/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public static async Task<MateriaDTO> GetAsync(int id)
        {
            MateriaDTO materia = null;
            HttpResponseMessage response = await client.GetAsync("materias/" + id);
            if (response.IsSuccessStatusCode)
            {
                materia = await response.Content.ReadAsAsync<MateriaDTO>();
            }
            return materia;
        }

        public static async Task<IEnumerable<MateriaDTO>> GetAllAsync()
        {
            IEnumerable<MateriaDTO> materias = null;
            HttpResponseMessage response = await client.GetAsync("materias");
            if (response.IsSuccessStatusCode)
            {
                materias = await response.Content.ReadAsAsync<IEnumerable<MateriaDTO>>();
            }
            return materias;
        }

        public async static Task AddAsync(MateriaDTO materia)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("materias", materia);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("materias/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(MateriaDTO materia)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("materias", materia);
            response.EnsureSuccessStatusCode();
        }
    }
}

