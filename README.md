
# Eventbrite.NET

Eventbrite.NET is an API wrapper for the event management site [eventbrite.com](http://eventbrite.com).
Currently the focus of the project is around *fetching* data from Eventbrite and representing it in a suiteable class.
As of writing, there are class representations of Organisers, Events, Tickets, and Attendees. Not all classes
give a full representation of the object, but the most critical data is there.

Requests are made to Eventbrite's API via HTTP GET calls, using an API key supplied by the user.
The XML documents that Eventbrite returns are then parsed into coherant classes. 
The project utilises lazy-loading, ensuring there is minimal overhead for simple requests.

## Gettting Started

1. Download/Fork/Clone Eventbrite.NET code OR you can get the [NuGet](http://nuget.codeplex.com) package `eventbriteNET`
2. Input your Eventbrite App\_key and User\_key (optional) into your App.config. Below is a sample App.config:
        <?xml version="1.0" encoding="utf-8" ?>
        <configuration>
		  <appSettings>
		    <add key="EventbriteAppKey" value="FWQINIQWOINIFIOQWFNIQWOFIWQN"/>
		    <add key="EventbriteUserKey" value="OIQWEFNIOQWNFIFOWQINQIWOFNWQ"/>
		  </appSettings>
		</configuration>
3. Add a reference to the EventbriteNET project. Add a "using EventbriteNET" statement at the top of your application.
4. Explore! Entities are represented in the EventbriteNET.Entities namespace, refer to the examples below if you need help!


## Examples

### Exploring Organiser Events
	// Instantiate Organiser entity with the desired organisation ID
	var organiser = new Organiser(ORGANISER_ID_HERE);

	// Get all the events that the organiser has created
	var events = organiser.Events;

	// Get the first event in the collection
	var firstEvent = events.First().Value;

	// All the attendees in that event
	var attendees = firstEvent.Attendees;

	// All the tickets in that event
	var tickets = firstEvent.Tickets;

There are plenty of properties available in each of these objects. Again, exploring is the best way to learn!


## Caveats
Eventbrite.NET uses lazy-loading to ensure there is minimal overhead for simple requests. 
It's important you are aware of this, as some calls may hang the thread while data is fetched from Eventbrite.

Secondly, Eventbrite does _not_ expose ALL entity properties to everyone. Some entity properties are nullable types,
you should be aware that sometimes they _will_ be null. You will get the most data from Eventbrite by fetching from
the organisation that your user\_key is associated with.