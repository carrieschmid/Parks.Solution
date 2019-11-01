using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;


namespace ParksApp.Models
{
    public class Park
    {
        public int ParkId { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        [StringLength(20)]
        public string State { get; set; }
        
        public int Miles { get; set; }
       
        
    public static List<Park> GetParks()
        {
            var apiCallTask = ApiHelper.ApiCall();
            var result = apiCallTask.Result;

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            Console.WriteLine(jsonResponse);
            List<Park> parksList = JsonConvert.DeserializeObject<List<Park>>(jsonResponse.ToString());

            return parksList;
        }
    }
}