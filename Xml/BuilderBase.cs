using System;
using System.Xml;

namespace EventbriteNET.Xml
{
    class BuilderBase
    {
        protected EventbriteContext Context;
        public BuilderBase(EventbriteContext context)
        {
            this.Context = context;
        }

        protected void Validate(string xmlString)
        {
            var doc = new XmlDocument();
            doc.LoadXml(xmlString);

            if (doc.GetElementsByTagName("error").Count > 0)
            {
                throw new InvalidOperationException("Response contained an error: " + doc.GetElementsByTagName("error")[0].InnerText);
            }
        }

        public string TryGetElementValue(string elementName, XmlDocument doc)
        {
            var nodeArray = doc.GetElementsByTagName(elementName);
            if (nodeArray.Count > 0)
            {
                return nodeArray[0].InnerText;
            }
            return null;
        }

        public long TryGetElementLongValue(string elementName, XmlDocument doc)
        {
            return long.Parse(TryGetElementValue(elementName, doc));
        }

        public long? TryGetElementNullableLongValue(string elementName, XmlDocument doc)
        {
            var value = TryGetElementValue(elementName, doc);
            if (value == null)
            {
                return null;
            }
            return long.Parse(value);
        }

        public int TryGetElementIntValue(string elementName, XmlDocument doc)
        {
            return Int32.Parse(TryGetElementValue(elementName, doc));
        }

        public int? TryGetElementNullableIntValue(string elementName, XmlDocument doc)
        {
            var value = TryGetElementValue(elementName, doc);
            if (value == null)
            {
                return null;
            }
            return Int32.Parse(value);
        }

        public DateTime? TryGetElementDateTimeValue(string elementName, XmlDocument doc)
        {
            var value = TryGetElementValue(elementName, doc);
            if (value == null)
            {
                return null;
            }
            return DateTime.Parse(value);
        }

        public float? TryGetElementNullableFloatValue(string elementName, XmlDocument doc)
        {
            var value = TryGetElementValue(elementName, doc);
            if (value == null)
            {
                return null;
            }
            return float.Parse(value);
        }
    }
}
