// Event.cs
using System;
using System.Collections.Generic;

public class @event
{
    public long id { get; set; }
    public string background_color { get; set; }
    public string box_background_color { get; set; }
    public string box_border_color { get; set; }
    public string box_header_background_color { get; set; }
    public string box_header_text_color { get; set; }
    public string box_text_color { get; set; }
    public string capacity { get; set; }
    public string category { get; set; }
    public DateTime created { get; set; }
    public string description { get; set; }
    public string distance { get; set; }
    public DateTime end_date { get; set; }
    public string link_color { get; set; }
    public string logo { get; set; }
    public string logo_ssl { get; set; }
    public DateTime modified { get; set; }
    public string num_attendee_rows { get; set; }

    public List<organizer> organizer { get; set; }

    public string privacy { get; set; }
    public string repeats { get; set; }
    public DateTime start_date { get; set; }
    public string status { get; set; }
    public string tags { get; set; }

    public List<tickets> tickets { get; set; }

    public string timezone { get; set; }
    public string title { get; set;}
    public string title_text_color { get; set; }
    public string url { get; set; }

    public venue venue { get; set; }

    //not part of xml response. used to pass through with watch
    public string opentok_sessionid { get; set; }
   


    
}




//<?xml version="1.0" encoding="utf-8" ?>
//<search>
//    <summary>
//        <filters>
//            <city>New York</city>
//            <country>US</country>
//        </filters>
//        <first_event>908163459</first_event>
//        <last_event>702165483</last_event>
//        <total_items>10</total_items>
//    </summary>
//    <event>
//        <id>908163459</id>
//        <title>Best NYC New Year's Party</title>
//        <description>Come spend New Year's Eve with us!</description>
//        <category>conferences</category>
//        <tags>new year, party</tags>
//        <start_date>2008-12-31 20:00:00</start_date>
//        <end_date>2009-01-01 06:00:00</end_date>
//        <timezone>US/Eastern</timezone>
//        <created>2007-11-03 12:47:06</created>
//        <modified>2008-01-09 10:12:15</modified>
//        <privacy>1</privacy>
//        <url>http://nycparty.eventbrite.com</url>
//        <logo>http://images.eventbrite.com/logos/908163459.jpg</url>
//        <logo_ssl>https://www.eventbrite.com/php/logo.php?id=908163459.jpg</url>
//        <venue>
//            <id>1</id>
//            <name>Madison Square Garden</name>
//            <address>4 Penn Plaza</address>
//            <address_2></address_2>
//            <city>New York</city>
//            <region>NY</region>
//            <postal_code>10001</postal_code>
//            <country>United States</country>
//            <country_code>US</country_code>
//            <Lat-Long>47.123 / 3.34</Lat-Long>
//        </venue>
//        <organizer>
//            <id>65739440</id>
//            <name>New Year's NYC Team</name>
//            <description>We organizer the best parties in town!</description>
//            <url>http://www.eventbrite.com/org/65739440</url>
//        </organizer>
//        <tickets>
//            <ticket>
//                <id>45264859</id>
//                <name>VIP Registration</name>
//                <description>Access to VIP Rooms</description>
//                <type>0</type>
//                <currency>USD</currency>
//                <price>199.99</price>
//                <start_date>2008-10-24 00:00:00</start_date>
//                <end_date>2008-12-30 23:00:00</end_date>
//                <quantity_available>100</quantity_available>
//                <quantity_sold>0</quantity_sold>
//            </ticket>
//        </tickets>
//    </event>
//</search>
