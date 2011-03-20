using RestSharp;
using System.Collections.Generic;

// TwilioApi.cs

public class EventBriteApi
{
    const string BaseUrl = "https://www.eventbrite.com";

    
    readonly string _appKey;

    public EventBriteApi()
    {
        _appKey = "YjZjZTg2OGJmMTll";
    }

    public T Execute<T>(RestRequest request) where T : new()
    {
        var client = new RestClient();
        client.BaseUrl = BaseUrl;
        //client.Authenticator = new HttpBasicAuthenticator(_accountSid, _secretKey);
        request.AddParameter("app_key", _appKey); // used on every request - , ParameterType.UrlSegment
        var response = client.Execute<T>(request);
        return response.Data;
    }

    // EventBriteApi.cs, method of EventBrite class
    public @event GetEvent(int eventId)
    {
        var request = new RestRequest();
        request.Resource = "xml/event_get";
        //request.RootElement = "event";

        request.AddParameter("id", eventId);

        return Execute <@event>(request);
        
    }


    // EventBriteApi.cs, method of EventBrite class
    public List<@event> GetEvents(string category)
    {
        var request = new RestRequest();
        var client = new RestClient();

        //client.Authenticator = new HttpBasicAuthenticator(_accountSid, _secretKey);
        client.BaseUrl = BaseUrl;
        //request.RootElement = "events";
        request.Resource = "xml/event_search";
        request.AddParameter("category", category);

     
        return Execute <List<@event>>(request);

    }

}