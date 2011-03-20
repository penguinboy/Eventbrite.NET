// Venue.cs
using System;
using System.Xml.Serialization;
public class venue
{
    [XmlElement("Lat-Long")] 
    public string Lat_Long { get; set; }
    public string address { get; set; }
    public string address_2 { get; set; }
    public string city { get; set; }
    public string country { get; set; }
    public string country_code { get; set; }
    public string latitude { get; set; }
    public string longitude { get; set; }

    public string name { get; set; }
    public string postal_code { get; set; }

    public string region { get; set; }


}