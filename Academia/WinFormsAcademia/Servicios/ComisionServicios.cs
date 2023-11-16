using Entidades;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace WinFormsAcademia.Servicios
{
    public static class ComisionServicios
    {
        private static readonly string baseUrl = "https://localhost:7035/api/Comisiones";
        private static HttpClient httpClient = new HttpClient();
        public static async Task<Comision> GetOne(int idComision, int idPlan, int idMateria)
        {
            var response = await httpClient.GetAsync($"{baseUrl}/idComision={idComision}&idPlan={idPlan}&idMateria={idMateria}");
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var comision = JsonConvert.DeserializeObject<Comision>(responseContent);
                return comision;
            }
            else return null;
        }
        public static async Task<List<Comision>> Get(int? idPlanFilter=null,int? idMateriaFilter=null)
        {
            string requestUri = baseUrl;
            if (idPlanFilter is not null) requestUri += $"?idPlanFilter={idPlanFilter}";
            if (idMateriaFilter is not null) requestUri += $"&idMateriaFilter={idMateriaFilter}";
            var response = await httpClient.GetAsync($"{requestUri}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var comisiones = JsonConvert.DeserializeObject<List<Comision>>(content);
                return comisiones;
            }
            else return null;
        }
        public static async Task<Comision> Create(Comision Comision)
        {
            var ComisionJson = JsonConvert.SerializeObject(Comision);
            var content = new StringContent(ComisionJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync($"{baseUrl}", content);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var addedComision = JsonConvert.DeserializeObject<Comision>(responseContent);
                return addedComision;
            }
            else return null;
        }
        public static async Task<Boolean> Update(Comision comision)
        {
            var comisionJson = JsonConvert.SerializeObject(comision);
            var content = new StringContent(comisionJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync($"{baseUrl}/idComision={comision.IdComision}&idPlan={comision.IdPlan}&idMateria={comision.IdMateria}", content);
            return response.IsSuccessStatusCode;
        }
        public static async Task<Boolean> Delete(int idComision, int idPlan, int idMateria)
        {
            var response = await httpClient.DeleteAsync($"{baseUrl}/idComision={idComision}&idPlan={idPlan}&idMateria={idMateria}");
            return response.IsSuccessStatusCode;
        }
    }
}

