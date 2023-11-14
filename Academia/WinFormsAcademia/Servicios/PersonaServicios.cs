using Entidades;
using Newtonsoft.Json;
using System.Text;

namespace WinFormsAcademia.Servicios
{
    public static class PersonaServicios
    {
        private static readonly string baseUrl = "https://localhost:7035/api/Personas";
        private static HttpClient httpClient = new HttpClient();
        public static async Task<Persona> GetOne(int id, int? rol)
        {
            var response = await httpClient.GetAsync($"{baseUrl}/legajo={id}");
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var persona = JsonConvert.DeserializeObject<Persona>(responseContent);
                return persona;
            }
            else return null;
        }
        public static async Task<List<Persona>> Get(int? rol)
        {
            string requestUri = baseUrl;
            if (rol is not null) requestUri += $"?rol={rol}";
            var response = await httpClient.GetAsync($"{requestUri}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var personas = JsonConvert.DeserializeObject<List<Persona>>(content);
                return personas;
            }
            else return null;
        }
        public static async Task<Persona> Create(Persona persona)
        {
            var personaJson = JsonConvert.SerializeObject(persona);
            var content = new StringContent(personaJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync($"{baseUrl}", content);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var addedpersona = JsonConvert.DeserializeObject<Persona>(responseContent);
                return addedpersona;
            }
            else return null;
        }
        public static async Task<Boolean> Update(Persona persona)
        {
            var personaJson = JsonConvert.SerializeObject(persona);
            var content = new StringContent(personaJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync($"{baseUrl}/legajo={persona.Legajo}", content);
            return response.IsSuccessStatusCode;
        }
        public static async Task<Boolean> Delete(int legajo)
        {
            var response = await httpClient.DeleteAsync($"{baseUrl}/legajo={legajo}");
            return response.IsSuccessStatusCode;
        }

        public static async Task<Persona> Login(Credenciales credenciales)
        {
            var credencialesJson = JsonConvert.SerializeObject(credenciales);
            var content = new StringContent(credencialesJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync($"{baseUrl}/autenticar", content);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var persona = JsonConvert.DeserializeObject<Persona>(responseContent);
                return persona;
            }
            else return null;
        }

        public static bool UsuarioDisponible(string nombreUsuario)
        {
            var nombreUsuarioJson = JsonConvert.SerializeObject(nombreUsuario);
            var content = new StringContent(nombreUsuarioJson, Encoding.UTF8, "application/json");
            var response = httpClient.PostAsync($"{baseUrl}/usuariodisponible", content).Result;
            return (response.IsSuccessStatusCode);
        }
    }
}

