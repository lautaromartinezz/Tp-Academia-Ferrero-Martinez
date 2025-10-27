using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using DTOs;

namespace API.Clients
{
    public class PersonaAPIClient:BaseApiClient
    {


        public static async Task<PersonaDTO> GetAsync(int id)
        {
            try
            {
                using var client = await CreateHttpClientAsync();

                HttpResponseMessage response = await client.GetAsync("personas/" + id);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<PersonaDTO>();
                }
                else
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
        public static async Task<IEnumerable<PersonaDTO>> GetAllAsync()
        {
            try
            {
                using var client = await CreateHttpClientAsync();

                HttpResponseMessage response = await client.GetAsync("personas");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<IEnumerable<PersonaDTO>>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener lista de personas. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener lista de personas: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener lista de personas: {ex.Message}", ex);
            }
        }
    }
}
