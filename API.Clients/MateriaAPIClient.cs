using DTOs;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace API.Clients
{
    public class MateriaAPIClient : BaseApiClient
    {

        public static async Task<MateriaDTO> GetAsync(int id)
        {
            try
            {
                using var client = await CreateHttpClientAsync();

                HttpResponseMessage response = await client.GetAsync("materias/" + id);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<MateriaDTO>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener la materia con Id {id}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener la materia con Id {id}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener la materia con Id {id}: {ex.Message}", ex);
            }
        }

        public static async Task<IEnumerable<MateriaDTO>> GetAllAsync()
        {
            try
            {
                using var client = await CreateHttpClientAsync();

                HttpResponseMessage response = await client.GetAsync("materias");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<IEnumerable<MateriaDTO>>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener lista de materias. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener lista de materias: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener lista de materias: {ex.Message}", ex);
            }
        }

        public async static Task AddAsync(MateriaDTO materia)
        {
            try
            {
                using var client = await CreateHttpClientAsync();

                HttpResponseMessage response = await client.PostAsJsonAsync("materias", materia);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"{ex.Message}", ex);
            }
        }

        public static async Task DeleteAsync(int id)
        {
            try
            {
                using var client = await CreateHttpClientAsync();

                HttpResponseMessage response = await client.DeleteAsync("materias/" + id);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"{ex.Message}", ex);
            }
        }

        public static async Task UpdateAsync(MateriaDTO materia)
        {
            try
            {
                using var client = await CreateHttpClientAsync();

                HttpResponseMessage response = await client.PutAsJsonAsync("materias", materia);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"{ex.Message}", ex);
            }
        }
    }
}
