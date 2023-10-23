using Newtonsoft.Json; //Para manejar las respuestas
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using WebApi.Models; //Modelos de la API

namespace WinFormsABM.Services
{
    public static class UsuarioService
    {
        private static readonly string baseUrl= "https://localhost:7054/api/Usuarios";
        private static HttpClient httpClient = new HttpClient();
        public static async Task<Usuario> GetOne(string username) //traer por clave primaria
        {
            var response = await httpClient.GetAsync($"{baseUrl}/{username}");
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var usuario = JsonConvert.DeserializeObject<Usuario>(responseContent);
                return usuario;
            }
            else return null;
        }
        public static async Task<List<Usuario>> Get(string? userFilter = "") //traer todos
        {
            string requestUri = baseUrl;
            if (!string.IsNullOrEmpty(userFilter))
            {
                // Añade el filtro a la URL de la solicitud GET
                requestUri += $"?userFilter={userFilter}";
            }
            var response = await httpClient.GetAsync($"{requestUri}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var usuarios = JsonConvert.DeserializeObject<List<Usuario>>(content);
                return usuarios;
            }
            else return null;
        }
        public static async Task<Usuario> Create(Usuario usuario) //insertar
        {
            var usuarioJson = JsonConvert.SerializeObject(usuario);
            var content = new StringContent(usuarioJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync($"{baseUrl}", content);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var addedUsuario = JsonConvert.DeserializeObject<Usuario>(responseContent);
                return addedUsuario;
            }
            else return null;
        }
        public static async Task<Boolean> Update(Usuario usuario) //actualizar
        {
            var usuarioJson = JsonConvert.SerializeObject(usuario);
            var content = new StringContent(usuarioJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync($"{baseUrl}/{usuario.NombreUsuario}", content);
            return response.IsSuccessStatusCode;
        }
        public static async Task<Boolean> Delete(string id) //eliminar
        {
            var response = await httpClient.DeleteAsync($"{baseUrl}/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
