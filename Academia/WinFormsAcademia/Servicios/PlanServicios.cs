using Entidades;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace WinFormsAcademia.Servicios
{
    public static class PlanServicios
    {
        private static readonly string baseUrl = "https://localhost:7035/api/Planes";
        private static HttpClient httpClient = new HttpClient();
        public static async Task<Plan> GetOne(int idPlan)
        {
            var response = await httpClient.GetAsync($"{baseUrl}/idPlan={idPlan}");
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var plan = JsonConvert.DeserializeObject<Plan>(responseContent);
                return plan;
            }
            else return null;
        }
        public static async Task<List<Plan>> Get()
        {
            var response = await httpClient.GetAsync($"{baseUrl}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var planes = JsonConvert.DeserializeObject<List<Plan>>(content);
                return planes;
            }
            else return null;
        }
        public static async Task<Plan> Create(Plan Plan)
        {
            var PlanJson = JsonConvert.SerializeObject(Plan);
            var content = new StringContent(PlanJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync($"{baseUrl}", content);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var addedPlan = JsonConvert.DeserializeObject<Plan>(responseContent);
                return addedPlan;
            }
            else return null;
        }
        public static async Task<Boolean> Update(Plan plan)
        {
            var planJson = JsonConvert.SerializeObject(plan);
            var content = new StringContent(planJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync($"{baseUrl}/idPlan={plan.IdPlan}", content);
            return response.IsSuccessStatusCode;
        }
        public static async Task<Boolean> Delete(int idPlan)
        {
            var response = await httpClient.DeleteAsync($"{baseUrl}/idPlan={idPlan}");
            return response.IsSuccessStatusCode;
        }
    }
}


