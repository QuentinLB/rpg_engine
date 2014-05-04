using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

[Serializable]
[XmlRoot("Story")]
public class Story
{
    [XmlArray("NodeLinkList"), XmlArrayItem(typeof(NodeLink), ElementName = "NodeLink")]
    public List<NodeLink> links { get; set; }

    public Story()
    {
        links = new List<NodeLink>();
    }

    public void add_link(NodeLink n){
        links.Add(n);
    }
}
