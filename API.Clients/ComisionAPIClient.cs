using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using DTOs;

namespace API.Clients
{
    public class ComisionAPIClient : BaseApiClient
    {


        public static async Task<ComisionDTO> GetAsync(int id)
        {
            try
            {
                using var client = await CreateHttpClientAsync();

                HttpResponseMessage response = await client.GetAsync("comisiones/" + id);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<ComisionDTO>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener la comision con Id {id}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener la comision con Id {id}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener la comision con Id {id}: {ex.Message}", ex);
            }
        }

        public static async Task<IEnumerable<ComisionDTO>> GetAllAsync()
        {
            try
            {
                using var client = await CreateHttpClientAsync();

                HttpResponseMessage response = await client.GetAsync("comisiones");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<IEnumerable<ComisionDTO>>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener lista de comisiones. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener lista de comisiones: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener lista de comisiones: {ex.Message}", ex);
            }
        }

        public async static Task AddAsync(ComisionDTO comision)
        {
            try
            {
                using var client = await CreateHttpClientAsync();

                HttpResponseMessage response = await client.PostAsJsonAsync("comisiones", comision);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error. {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error. {ex.Message}", ex);
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

                HttpResponseMessage response = await client.DeleteAsync("comisiones/" + id);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al eliminar la comision con Id {id}: {ex.Message}", ex);
            }
        }

        public static async Task UpdateAsync(ComisionDTO comision)
        {
            try
            {
                using var client = await CreateHttpClientAsync();

                HttpResponseMessage response = await client.PutAsJsonAsync("comisiones", comision);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"{errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error. {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al actualizar la comision con Id {comision.Id}: {ex.Message}", ex);
            }
        }
    }
}
