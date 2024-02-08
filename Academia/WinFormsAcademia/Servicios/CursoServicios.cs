using Entidades;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace WinFormsAcademia.Servicios
{
    public static class CursoServicios
    {
        private static readonly string baseUrl = "https://localhost:7035/api/Cursos";
        private static HttpClient httpClient = new HttpClient();
        public static async Task<Curso> GetOne(int idComision, int idPlan, int idMateria, int anio)
        {
            string requestUri = $"{baseUrl}/idComision={idComision}&idPlan={idPlan}&idMateria={idMateria}&anio={anio}";
            //if ((bool)incluirDictados) requestUri += $"&incluirDictados{incluirDictados}";
            var response = await httpClient.GetAsync(requestUri);
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var curso = JsonConvert.DeserializeObject<Curso>(responseContent);
                return curso;
            }
            else return null;
        }
        public static async Task<List<Curso>> Get(int? idPlanFilter = null, int? idMateriaFilter = null, int? idComisionFilter = null)
        {
            string requestUri = baseUrl;
            if (idPlanFilter is not null) requestUri += $"?idPlanFilter={idPlanFilter}";
            if (idMateriaFilter is not null) requestUri += $"&idMateriaFilter={idMateriaFilter}";
            if (idComisionFilter is not null) requestUri += $"&idComisionFilter={idComisionFilter}";
            var response = await httpClient.GetAsync(requestUri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var cursos = JsonConvert.DeserializeObject<List<Curso>>(content);
                return cursos;
            }
            else return null;
        }
        public static async Task<Curso> Create(Curso Curso)
        {
            var CursoJson = JsonConvert.SerializeObject(Curso);
            var content = new StringContent(CursoJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync($"{baseUrl}", content);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var addedCurso = JsonConvert.DeserializeObject<Curso>(responseContent);
                return addedCurso;
            }
            else return null;
        }
        public static async Task<Boolean> Update(Curso curso)
        {
            var cursoJson = JsonConvert.SerializeObject(curso);
            var content = new StringContent(cursoJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync($"{baseUrl}/idComision={curso.IdComision}&idPlan={curso.IdPlan}&idMateria={curso.IdMateria}&anio={curso.Anio}", content);
            return response.IsSuccessStatusCode;
        }
        public static async Task<Boolean> Delete(int idComision, int idPlan, int idMateria, int anio)
        {
            var response = await httpClient.DeleteAsync($"{baseUrl}/idComision={idComision}&idPlan={idPlan}&idMateria={idMateria}&anio={anio}");
            return response.IsSuccessStatusCode;
        }
        public static async Task<List<Curso>> GetByDocente(int legajo)
        {
            string requestUri = baseUrl + $"/GetCursosByDocente?legajo={legajo}";
            var response = await httpClient.GetAsync($"{requestUri}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var cursos = JsonConvert.DeserializeObject<List<Curso>>(content);
                return cursos;
            }
            else return null;
        }
    }
}

