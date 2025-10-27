using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DTOs;

namespace API.Clients
{
    public class ModuloAPIClient : BaseApiClient
    {

        public static async Task<IEnumerable<ModuloDTO>> GetAllAsync()
        {
            try
            {
                using var client = await CreateHttpClientAsync();

                HttpResponseMessage response = await client.GetAsync("modulos");

                if (!response.IsSuccessStatusCode)
                {
                    string message = await response.Content.ReadAsStringAsync();
                    throw new ArgumentException(message);
                } else
                {
                    IEnumerable<ModuloDTO> dtos = await response.Content.ReadAsAsync<IEnumerable<ModuloDTO>>();

                    return dtos;
                }

                    

            } catch (Exception ex)
            {
                throw new Exception("Error al hacer la peticion de los datos");
            }
                
        }

        public static async Task<ModuloDTO> GetOneAsync(int id)
        {
            try
            {
                using var client = await CreateHttpClientAsync();

                HttpResponseMessage response = await client.GetAsync("modulos/" + id);

                if (!response.IsSuccessStatusCode)
                {
                    string message = await response.Content.ReadAsStringAsync();

                    throw new Exception(message);
                } else
                {
                    ModuloDTO dto = await response.Content.ReadAsAsync<ModuloDTO>();

                    return dto;           
                }     
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static async Task PostAsync(ModuloDTO dto)
        {
            try
            {
                using var client = await CreateHttpClientAsync();

                HttpResponseMessage response = await client.PostAsJsonAsync("modulos", dto);

                if (!response.IsSuccessStatusCode)
                {
                    string message = await response.Content.ReadAsStringAsync();

                    throw new Exception(message);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static async Task PutAsync(ModuloDTO dto)
        {
            try
            {
                using var client = await CreateHttpClientAsync();

                HttpResponseMessage response = await client.PutAsJsonAsync("modulos", dto);

                if (!response.IsSuccessStatusCode)
                {
                    string message = await response.Content.ReadAsStringAsync();

                    throw new Exception(message);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static async Task DeleteAsync(int id)
        {
            try
            {
                using var client = await CreateHttpClientAsync();

                HttpResponseMessage response = await client.DeleteAsync("modulos/" + id);

                if (!response.IsSuccessStatusCode)
                {
                    string message = await response.Content.ReadAsStringAsync();

                    throw new Exception(message);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
