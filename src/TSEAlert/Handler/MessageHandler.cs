using System.Collections.Generic;
using System.Xml.Linq;
using TSEAlert.Models;
using System.Linq;
using System.Xml;
using System.IO;
using System;

namespace TSEAlert.Handler
{
    public class MessageHandler : IXmlHandler<Message>
    {
        private readonly string xmlFile = "Message.xml";
        private readonly string baseRoot = "Messages";
        private readonly string subRoot = "Message";

        public MessageHandler()
        {
            CreateXmlFile();
        }

        public int Add(Message obj)
        {
            try
            {
                XDocument doc = XDocument.Load(xmlFile);
                XElement root = new XElement(subRoot);
                var id = GenerateId();
                root.Add(new XAttribute("Id", id));
                root.Add(new XElement("Content", obj.Content));
                root.Add(new XElement("Date", obj.Date));
                doc.Element(baseRoot).Add(root);
                doc.Save(xmlFile);

                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(Message obj)
        {
            try
            {
                XDocument doc = XDocument.Load(xmlFile);
                doc.Elements(baseRoot)
                    .Elements(subRoot)
                    .Where(x => x.Attributes("Id").FirstOrDefault().Value == obj.Id.ToString())
                    .Select(a =>
                    {
                        a.Element("Content").Value = obj.Content;
                        a.Element("Date").Value = obj.Date.ToString();
                        return a;
                    }).ToList();
                doc.Save(xmlFile);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Message> Get()
        {
            try
            {
                XDocument doc = XDocument.Load(xmlFile);
                return doc.Elements(baseRoot).Elements(subRoot).Select(s => new Message()
                {
                    Id = Convert.ToInt32(s.Attributes("Id").FirstOrDefault().Value),
                    Content = s.Element("Content").Value,
                    Date = DateTime.Parse(s.Element("Date").Value),
                }).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Message Get(int id)
        {
            try
            {
                XDocument doc = XDocument.Load(xmlFile);
                return doc.Elements(baseRoot)
                    .Elements(subRoot)
                    .Where(x => x.Attributes("Id").FirstOrDefault().Value == id.ToString())
                    .Select(s => new Message()
                    {
                        Id = Convert.ToInt32(s.Attributes("Id").FirstOrDefault().Value),
                        Content = s.Element("Content").Value,
                        Date = DateTime.Parse(s.Element("Symbol").Value),
                    }).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Remove(Message obj)
        {
            try
            {
                XDocument doc = XDocument.Load(xmlFile);
                doc.Elements(baseRoot)
                    .Elements(subRoot)
                    .Where(x => x.Attributes("Id").FirstOrDefault().Value == obj.Id.ToString()).Remove();
                doc.Save(xmlFile);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Remove(List<Message> objs)
        {
            try
            {
                foreach (var alert in objs)
                {
                    Remove(alert);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool RemoveAll()
        {
            try
            {
                return Remove(Get());

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CreateXmlFile()
        {
            if (!File.Exists(xmlFile))
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.IndentChars = "    "; //  "\t";
                settings.OmitXmlDeclaration = false;
                settings.Encoding = System.Text.Encoding.UTF8;

                using (XmlWriter writer = XmlWriter.Create(xmlFile, settings))
                {

                    writer.WriteStartDocument();
                    writer.WriteStartElement(baseRoot);
                    writer.WriteAttributeString("xmlns", "xsi", null, "http://www.w3.org/2001/XMLSchema-instance");
                    writer.WriteAttributeString("xmlns", "xsd", null, "http://www.w3.org/2001/XMLSchema");

                    writer.WriteEndElement();

                    writer.Flush();
                    writer.Close();
                }
            }
        }

        private int GenerateId()
        {
            var temps = Get();
            int selectedId = 1;
            if (temps.Count() != 0)
                selectedId = temps.Last().Id + 1;

            // 
            while (true)
            {
                if (temps.Where(x => x.Id == selectedId).Count() > 0)
                {
                    selectedId += 1;
                    continue;
                }
                break;
            }
            return selectedId;
        }
    }
}
