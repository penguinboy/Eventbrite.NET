using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace EventbriteNET.Xml
{
    public class BuilderBase
    {
        public string TryGetElementValue(string elementName, XmlDocument doc)
        {
            var nodeArray = doc.GetElementsByTagName(elementName);
            if (nodeArray.Count > 0)
            {
                return nodeArray[0].InnerText;
            }
            return null;
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
