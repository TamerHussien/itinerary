﻿using Newtonsoft.Json;

namespace Itinerary.GoogleApiClient.Places.Autocomplete.Entities
{
  public class MatchedSubstring
  {
    [JsonProperty( propertyName: "length" )]
    public int Length { get; set; }

    [JsonProperty( propertyName: "offset" )]
    public int Offset { get; set; }
  }
}