using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TravelClient.Models
{
  public class Place
  {
    public int PlaceId { get; set; }
    public string Landmark { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string Review { get; set; }
    public DateTime Date { get; set; }
    public int Rating { get; set; }


    public static List<Place> GetPlaces()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Place> placeList = JsonConvert.DeserializeObject<List<Place>>(jsonResponse.ToString());

      return placeList;
    }
  }
}