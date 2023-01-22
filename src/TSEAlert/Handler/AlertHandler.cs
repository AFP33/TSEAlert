using System.Collections.Generic;
using System.Xml.Linq;
using TSEAlert.Models;
using System.Linq;
using System.Xml;
using System.IO;
using System;

namespace TSEAlert.Handler
{
    public class AlertHandler : IXmlHandler<Alert>
    {
        private readonly string xmlFile = "Alert.xml";
        private readonly string baseRoot = "Alerts";
        private readonly string subRoot = "Alert";

        public AlertHandler()
        {
            CreateXmlFile();
        }

        public int Add(Alert obj)
        {
            try
            {
                XDocument doc = XDocument.Load(xmlFile);
                XElement root = new XElement(subRoot);
                var id = GenerateId();
                root.Add(new XAttribute("Id", id));
                root.Add(new XElement("Name", obj.Name));
                root.Add(new XElement("Symbol", obj.Symbol));
                root.Add(new XElement("TseCode", obj.TseCode));
                root.Add(new XElement("AlertType", obj.AlertType.ToString()));
                root.Add(new XElement("Price", obj.Price.ToString()));
                root.Add(new XElement("Status", obj.Status.ToString()));
                doc.Element(baseRoot).Add(root);
                doc.Save(xmlFile);

                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(Alert obj)
        {
            try
            {
                XDocument doc = XDocument.Load(xmlFile);
                doc.Elements(baseRoot)
                    .Elements(subRoot)
                    .Where(x => x.Attributes("Id").FirstOrDefault().Value == obj.Id.ToString())
                    .Select(a =>
                    {
                        //a.Attributes("Id").FirstOrDefault()!.Value = newTemplate.Id.ToString();
                        a.Element("Name").Value = obj.Name;
                        a.Element("Symbol").Value = obj.Symbol;
                        a.Element("TseCode").Value = obj.TseCode.ToString();
                        a.Element("AlertType").Value = obj.AlertType.ToString();
                        a.Element("Price").Value = obj.Price.ToString();
                        a.Element("Status").Value = obj.Status.ToString();
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

        public List<Alert> Get()
        {
            try
            {
                XDocument doc = XDocument.Load(xmlFile);
                return doc.Elements(baseRoot).Elements(subRoot).Select(s => new Alert()
                {
                    Id = Convert.ToInt32(s.Attributes("Id").FirstOrDefault().Value),
                    Name = s.Element("Name").Value,
                    Symbol = s.Element("Symbol").Value,
                    TseCode = s.Element("TseCode").Value,
                    AlertType = (Models.AlertType?)Models.AlertType.Parse(typeof(Models.AlertType), s.Element("AlertType").Value),
                    Price = s.Element("Price").Value,
                    Status = s.Element("Status").Value == "True" ? true : false,
                }).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Alert Get(int id)
        {
            try
            {
                XDocument doc = XDocument.Load(xmlFile);
                return doc.Elements(baseRoot)
                    .Elements(subRoot)
                    .Where(x => x.Attributes("Id").FirstOrDefault().Value == id.ToString())
                    .Select(s => new Alert()
                    {
                        Id = Convert.ToInt32(s.Attributes("Id").FirstOrDefault().Value),
                        Name = s.Element("Name").Value,
                        Symbol = s.Element("Symbol").Value,
                        TseCode = s.Element("TseCode").Value,
                        AlertType = (Models.AlertType?)Models.AlertType.Parse(typeof(Models.AlertType), s.Element("AlertType").Value),
                        Price = s.Element("Price").Value,
                        Status = s.Element("Status").Value == "TRUE" ? true : false,
                    }).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Remove(Alert obj)
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

        public bool Remove(List<Alert> objs)
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
