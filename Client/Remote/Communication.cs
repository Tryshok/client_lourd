using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace Client.Remote
{
    static class Communication
    {
        // send the user login request.
        public static async Task<Mapping.Token> SendUser(Mapping.User user)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                     //client.BaseAddress = new Uri(Properties.Settings.Default.WebServerTest);
                    client.BaseAddress = new Uri(Properties.Settings.Default.WebServerProd);


                    var myContent = JsonConvert.SerializeObject(user);
                    var buffer = Encoding.UTF8.GetBytes(myContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    //endPoint Matthieu

                    var response = await client.PostAsync("api/login_check", byteContent);

                    if (response.EnsureSuccessStatusCode().IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        var userToken = JsonConvert.DeserializeObject<Mapping.Token>(json);

                        return userToken;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Consuming the API to send the new clients when created.
        public static async Task<Mapping.Client> SendNewClient(Mapping.Client p_newClient)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    //client.BaseAddress = new Uri(Client.Properties.Settings.Default.WebServerTest);
                    client.BaseAddress = new Uri(Properties.Settings.Default.WebServerProd);

                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Business.Security.token);

                    var myContent = JsonConvert.SerializeObject(p_newClient);
                    var buffer = Encoding.UTF8.GetBytes(myContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    //endPoint Matthieu

                    var response = await client.PostAsync("api/client/new", byteContent);
                    response.EnsureSuccessStatusCode();
                    var json = await response.Content.ReadAsStringAsync();
                    var NewClients = JsonConvert.DeserializeObject<Mapping.Client>(json);

                    return NewClients;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal async static Task<List<Mapping.Client>> GetClients()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                     client.BaseAddress = new Uri(Properties.Settings.Default.WebServerProd);
                    //client.BaseAddress = new Uri(Client.Properties.Settings.Default.WebServerTest);
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Business.Security.token.ToString());

                    var response = await client.GetAsync("api/client/fetch");
                    var json = await response.Content.ReadAsStringAsync();
                    response.EnsureSuccessStatusCode();
                    var L_Clients = JsonConvert.DeserializeObject<List<Mapping.Client>>(json);

                    return L_Clients;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal async static Task<Mapping.Client> UpdateClients(Mapping.Client p_client)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    //client.BaseAddress = new Uri(Client.Properties.Settings.Default.WebServerTest);
                    client.BaseAddress = new Uri(Properties.Settings.Default.WebServerProd);

                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Business.Security.token);

                    var myContent = JsonConvert.SerializeObject(p_client);
                    var buffer = Encoding.UTF8.GetBytes(myContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    var response = await client.PostAsync("api/client/update", byteContent);
                    var json = await response.Content.ReadAsStringAsync();
                    response.EnsureSuccessStatusCode();
                    var L_Clients = JsonConvert.DeserializeObject<Mapping.Client>(json);

                    return L_Clients;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        internal static async Task<List<Mapping.Product>> GetProducts()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    //client.BaseAddress = new Uri(Client.Properties.Settings.Default.WebServerTest);
                    client.BaseAddress = new Uri(Properties.Settings.Default.WebServerProd);

                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Business.Security.token);

                    var response = await client.GetAsync("api/product/fetch");

                    var json = await response.Content.ReadAsStringAsync();

                    if (response.EnsureSuccessStatusCode().IsSuccessStatusCode)
                    {
                        var L_Products = JsonConvert.DeserializeObject<List<Mapping.Product>>(json);
                        return L_Products;
                    }
                    else
                    {
                        throw new Exception("C pas bon");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal static async Task<List<Mapping.Employee>> GetEmployees()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    //client.BaseAddress = new Uri(Client.Properties.Settings.Default.WebServerTest);
                    client.BaseAddress = new Uri(Properties.Settings.Default.WebServerProd);

                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Business.Security.token);

                    var response = await client.GetAsync("api/employee/fetch");
                    var json = await response.Content.ReadAsStringAsync();
                    var L_Clients = JsonConvert.DeserializeObject<List<Mapping.Employee>>(json);
                    response.EnsureSuccessStatusCode();

                    return L_Clients;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal async static Task<List<Mapping.Parts>> GetParts(int rowIndex)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    //client.BaseAddress = new Uri(Client.Properties.Settings.Default.WebServerTest);
                    client.BaseAddress = new Uri(Properties.Settings.Default.WebServerProd);

                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Business.Security.token);

                    var response = await client.GetAsync("api/product/parts/" + rowIndex);
                    var json = await response.Content.ReadAsStringAsync();
                    var L_Parts = JsonConvert.DeserializeObject<List<Mapping.Parts>>(json);
                    response.EnsureSuccessStatusCode();

                    return L_Parts;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Consuming the API to send the new clients when created.
        public static async Task<Mapping.Employee> SendNewEmployee(Mapping.Employee p_newEmployee)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    //client.BaseAddress = new Uri(Client.Properties.Settings.Default.WebServerTest);
                    client.BaseAddress = new Uri(Properties.Settings.Default.WebServerProd);

                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Business.Security.token);

                    var myContent = JsonConvert.SerializeObject(p_newEmployee);
                    var buffer = Encoding.UTF8.GetBytes(myContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    //endPoint Matthieu
                    var response = await client.PostAsync("api/employee/new", byteContent);
                    response.EnsureSuccessStatusCode();

                    var json = await response.Content.ReadAsStringAsync();
                    var NewEmployee = JsonConvert.DeserializeObject<Mapping.Employee>(json);
                    return NewEmployee;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal async static Task<Mapping.Employee> UpdateEmployee(Mapping.Employee p_employee)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    //client.BaseAddress = new Uri(Client.Properties.Settings.Default.WebServerTest);
                    client.BaseAddress = new Uri(Properties.Settings.Default.WebServerProd);

                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Business.Security.token);

                    var myContent = JsonConvert.SerializeObject(p_employee);
                    var buffer = Encoding.UTF8.GetBytes(myContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    var response = await client.PostAsync("api/employee/update", byteContent);
                    var json = await response.Content.ReadAsStringAsync();
                    response.EnsureSuccessStatusCode();
                    var L_newEmployee = JsonConvert.DeserializeObject<Mapping.Employee>(json);

                    return L_newEmployee;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
