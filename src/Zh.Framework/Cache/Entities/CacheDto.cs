using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using Zh.Framework.Tools.SerializeTool.Imp;
using System.Xml;

namespace Zh.Framework.Cache.Entities
{
    [Serializable]
    public class CacheDto : IXmlSerializable
    {
        public string Key { get; set; }
        public DateTime? Expire { get; set; }
        public object Value { get; set; }
        public Type Type { get; set; }

        public System.Xml.Schema.XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(System.Xml.XmlReader reader)
        {

            if (reader.IsEmptyElement) return;

            while (reader.Read())
            {
                if (reader.NodeType == System.Xml.XmlNodeType.Element)
                {
                    if (reader.Name == "Key")
                    {
                        this.Key = reader.ReadElementContentAsString();
                    }
                    if (reader.Name == "Expire")
                    {
                        var expire = reader.ReadElementContentAsString();
                        DateTime realExpire = DateTime.Now;
                        if (DateTime.TryParse(expire, out realExpire))
                        {
                            this.Expire = realExpire;
                        }
                    }
                    if (reader.Name == "Value")
                    {
                        var valueType = reader.GetAttribute("Type");
                        var type = Type.GetType(valueType);
                        var valueStr = string.Empty;
                        while (reader.Read())
                        {
                            if (reader.NodeType == System.Xml.XmlNodeType.CDATA)
                            {
                                valueStr = reader.Value;
                                break;
                            }
                        }
                        this.Value = XmlSerialize.DeserializeFromString(type, valueStr);
                    }
                }
            }
        }
        XmlSerializeToolImp _XmlSerializeToolImp = null;
        XmlSerializeToolImp XmlSerialize
        {
            get
            {
                if (_XmlSerializeToolImp == null) { _XmlSerializeToolImp = new XmlSerializeToolImp(); }
                return _XmlSerializeToolImp;
            }
        }
        public void WriteXml(System.Xml.XmlWriter writer)
        {
            writer.WriteElementString("Key", this.Key);
            writer.WriteElementString("Expire", this.Expire.HasValue ? this.Expire.Value.ToString("yyyy-MM-dd HH:mm:ss") : "");
            writer.WriteStartElement("Value");
            var valueType = Value.GetType();
            var assemblyName = valueType.Assembly.FullName.Split(',')[0];
            writer.WriteAttributeString("Type", string.Format("{0},{1}", valueType.FullName, assemblyName));
            writer.WriteCData(string.Format("{0}", XmlSerialize.SerializeToString(this.Value)));
            writer.WriteEndElement();
        }
    }
}
