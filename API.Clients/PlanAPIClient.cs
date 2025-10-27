using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace API.Clients
{
    public class PlanAPIClient : BaseApiClient
    {



        public static async Task<PlanDTO> GetAsync(int id)
        {
            try
            {
                using var client = await CreateHttpClientAsync();

                HttpResponseMessage response = await client.GetAsync("planes/" + id);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<PlanDTO>();
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

        public static async Task<IEnumerable<PlanDTO>> GetAllAsync()
        {
            try
            {
                using var client = await CreateHttpClientAsync();

                HttpResponseMessage response = await client.GetAsync("planes");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<IEnumerable<PlanDTO>>();
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

        public async static Task AddAsync(PlanDTO plan)
        {
            try
            {
                using var client = await CreateHttpClientAsync();

                HttpResponseMessage response = await client.PostAsJsonAsync("planes", plan);

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
                HttpResponseMessage response = await client.DeleteAsync("planes/" + id);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error:{errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error:{ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"{ex.Message}", ex);
            }
        }

        public static async Task UpdateAsync(PlanDTO plan)
        {
            try
            {
                using var client = await CreateHttpClientAsync();
                HttpResponseMessage response = await client.PutAsJsonAsync("planes", plan);

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
