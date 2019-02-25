using System;
using Newtonsoft.Json;

public class UserLocation
{
    [JsonProperty("userId")]
    public Guid UserId { get; set; }

    [JsonProperty("userType")]
    public UserType Type { get; set; }

    [JsonProperty("location")]
    public GPSLocation Location { get; set; }
}