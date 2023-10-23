using Newtonsoft.Json; //Para manejar las respuestas
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using WebApi.Models; //Modelos de la API

namespace WinFormsABM.Services
{
    public static class AlumnoService
    {
        private static readonly string baseUrl= "https://localhost:7001/api/Alumnos";
        private static HttpClient httpClient = new HttpClient();
        public static async Task<Alumno> GetOne(int legajo) //traer por legajo
        {
            var response = await httpClient.GetAsync($"{baseUrl}/{legajo}");
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var Alumno = JsonConvert.DeserializeObject<Alumno>(responseContent);
                return Alumno;
            }
            else return null;
        }
        public static async Task<List<Alumno>> Get(string? apellidoFilter = "") //traer todos, filtro por apellido opcional
        {
            string requestUri = baseUrl;
            if (!string.IsNullOrEmpty(apellidoFilter))
            {
                // Añade el filtro a la URL de la solicitud GET
                requestUri += $"?apellidoFilter={apellidoFilter}";
            }
            var response = await httpClient.GetAsync($"{requestUri}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var Alumnos = JsonConvert.DeserializeObject<List<Alumno>>(content);
                return Alumnos;
            }
            else return null;
        }
        public static async Task<Alumno> Create(Alumno Alumno) //insertar
        {
            var AlumnoJson = JsonConvert.SerializeObject(Alumno);
            var content = new StringContent(AlumnoJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync($"{baseUrl}", content);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var addedAlumno = JsonConvert.DeserializeObject<Alumno>(responseContent);
                return addedAlumno;
            }
            else return null;
        }
        public static async Task<int> Update(Alumno Alumno) //actualizar
        {
            var AlumnoJson = JsonConvert.SerializeObject(Alumno);
            var content = new StringContent(AlumnoJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync($"{baseUrl}/{Alumno.Legajo}", content);
            return response.IsSuccessStatusCode ? Alumno.Legajo : 0;
        }
        public static async Task<int> Delete(int legajo) //eliminar
        {
            var response = await httpClient.DeleteAsync($"{baseUrl}/{legajo}");
            return response.IsSuccessStatusCode ? legajo : 0;
        }
    }
}

