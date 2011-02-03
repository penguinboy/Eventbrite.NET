
# Eventbrite.NET

Eventbrite.NET is an API wrapper for the event management site [eventbrite.com](http://eventbrite.com).
Currently the focus of the project is around *fetching* data from Eventbrite and representing it in a suiteable class.
As of writing, there are class representations of Organisers, Events, Tickets, and Attendees. Not all classes
give a full representation of the object, but the most critical data is there.

Requests are made to Eventbrite's API via HTTP GET calls, using an API key supplied by the user.
The XML documents that Eventbrite returns are then parsed into coherant classes. 
The project utilises lazy-loading, ensuring there is minimal overhead for simple requests.

## Gettting Started

... Coming soon
