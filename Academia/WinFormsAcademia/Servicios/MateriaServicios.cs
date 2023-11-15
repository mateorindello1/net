using Entidades;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace WinFormsAcademia.Servicios
{
    public static class MateriaServicios
    {
        private static readonly string baseUrl = "https://localhost:7035/api/Materias";
        private static HttpClient httpClient = new HttpClient();
        public static async Task<Materia> GetOne(int idMateria)
        {
            var response = await httpClient.GetAsync($"{baseUrl}/idMateria={idMateria}");
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var materia = JsonConvert.DeserializeObject<Materia>(responseContent);
                return materia;
            }
            else return null;
        }
        public static async Task<List<Materia>> Get(int? idPlan = null)
        {
            string requestUri = baseUrl;
            if (idPlan is not null) requestUri += $"?idPlan={idPlan}";
            var response = await httpClient.GetAsync($"{requestUri}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var materias = JsonConvert.DeserializeObject<List<Materia>>(content);
                return materias;
            }
            else return null;
        }
        public static async Task<Materia> Create(Materia materia)
        {
            var materiaJson = JsonConvert.SerializeObject(materia);
            var content = new StringContent(materiaJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync($"{baseUrl}", content);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var addedMateria = JsonConvert.DeserializeObject<Materia>(responseContent);
                return addedMateria;
            }
            else return null;
        }
        public static async Task<Boolean> Update(Materia materia)
        {
            var materiaJson = JsonConvert.SerializeObject(materia);
            var content = new StringContent(materiaJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync($"{baseUrl}/idMateria={materia.IdMateria}", content);
            return response.IsSuccessStatusCode;
        }
        public static async Task<Boolean> Delete(int idMateria)
        {
            var response = await httpClient.DeleteAsync($"{baseUrl}/idMateria={idMateria}");
            return response.IsSuccessStatusCode;
        }
    }
}
