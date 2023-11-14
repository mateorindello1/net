using Entidades;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace WinFormsAcademia.Servicios
{
    public static class EspecialidadServicios
    {
        private static readonly string baseUrl = "https://localhost:7035/api/Especialidades";
        private static HttpClient httpClient = new HttpClient();
        public static async Task<Especialidad> GetOne(int idEspecialidad)
        {
            var response = await httpClient.GetAsync($"{baseUrl}/idEspecialidad={idEspecialidad}");
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var especialidad = JsonConvert.DeserializeObject<Especialidad>(responseContent);
                return especialidad;
            }
            else return null;
        }
        public static async Task<List<Especialidad>> Get()
        {
            var response = await httpClient.GetAsync($"{baseUrl}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var especialidades = JsonConvert.DeserializeObject<List<Especialidad>>(content);
                return especialidades;
            }
            else return null;
        }
        public static async Task<Especialidad> Create(Especialidad Especialidad)
        {
            var EspecialidadJson = JsonConvert.SerializeObject(Especialidad);
            var content = new StringContent(EspecialidadJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync($"{baseUrl}", content);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var addedEspecialidad = JsonConvert.DeserializeObject<Especialidad>(responseContent);
                return addedEspecialidad;
            }
            else return null;
        }
        public static async Task<Boolean> Update(Especialidad especialidad)
        {
            var especialidadJson = JsonConvert.SerializeObject(especialidad);
            var content = new StringContent(especialidadJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync($"{baseUrl}/idEspecialidad={especialidad.IdEspecialidad}", content);
            return response.IsSuccessStatusCode;
        }
        public static async Task<Boolean> Delete(int idEspecialidad)
        {
            var response = await httpClient.DeleteAsync($"{baseUrl}/idEspecialidad={idEspecialidad}");
            return response.IsSuccessStatusCode;
        }
    }
}
