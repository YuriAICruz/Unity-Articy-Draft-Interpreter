﻿using System;
using System.Xml.Serialization;

namespace Graphene.ADInterpreter.ExportData{
    [Serializable] [XmlRoot(ElementName="ObjectCustomization", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
    public class ObjectCustomization {
        [XmlElement(ElementName="DisplayName", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string DisplayName;
        [XmlElement(ElementName="Color", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string Color;
        [XmlAttribute(AttributeName="Id")]
        public string Id;
    }
}