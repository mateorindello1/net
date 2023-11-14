using Entidades;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace WinFormsAcademia.Servicios
{
    public static class InscripcionServicios
    {
        private static readonly string baseUrl = "https://localhost:7035/api/Inscripciones";
        private static HttpClient httpClient = new HttpClient();
        public static async Task<Inscripcion> GetOne(int idAlumno, int idComision, int idPlan, int idMateria, int anio)
        {
            var response = await httpClient.GetAsync($"{baseUrl}/idAlumno={idAlumno}&idComision={idComision}&idPlan={idPlan}&idMateria={idMateria}&anio={anio}");
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var inscripcion = JsonConvert.DeserializeObject<Inscripcion>(responseContent);
                return inscripcion;
            }
            else return null;
        }
        public static async Task<List<Inscripcion>> Get()
        {
            var response = await httpClient.GetAsync($"{baseUrl}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var inscripciones = JsonConvert.DeserializeObject<List<Inscripcion>>(content);
                return inscripciones;
            }
            else return null;
        }
        public static async Task<Inscripcion> Create(Inscripcion Inscripcion)
        {
            var InscripcionJson = JsonConvert.SerializeObject(Inscripcion);
            var content = new StringContent(InscripcionJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync($"{baseUrl}", content);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var addedInscripcion = JsonConvert.DeserializeObject<Inscripcion>(responseContent);
                return addedInscripcion;
            }
            else return null;
        }
        public static async Task<Boolean> Update(Inscripcion inscripcion)
        {
            var inscripcionJson = JsonConvert.SerializeObject(inscripcion);
            var content = new StringContent(inscripcionJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync($"{baseUrl}/idAlumno={inscripcion.IdAlumno}&idComision={inscripcion.IdComision}&idPlan={inscripcion.IdPlan}&idMateria={inscripcion.IdMateria}&anio={inscripcion.Anio}", content);
            return response.IsSuccessStatusCode;
        }
        public static async Task<Boolean> Delete(int idAlumno, int idComision, int idPlan, int idMateria, int anio)
        {
            var response = await httpClient.DeleteAsync($"{baseUrl}/idAlumno={idAlumno}&idComision={idComision}&idPlan={idPlan}&idMateria={idMateria}&anio={anio}");
            return response.IsSuccessStatusCode;
        }
    }
}