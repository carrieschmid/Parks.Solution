using System.Threading.Tasks;
using RestSharp;

namespace ParksApp.Models
{
  class ApiHelper
  {
    public static async Task<string> ApiCall()
    {
      RestClient client = new RestClient("http://localhost:5000/api/park/");
      //this is the table name in our travel schema
      RestRequest request = new RestRequest(Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}