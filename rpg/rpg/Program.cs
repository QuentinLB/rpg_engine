using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace rpg
{
    class Program
    {
        static void Main(string[] args)
        {

            // serialisation
            //Story story = new Story();
            //for (int i = 0; i < 50; i++)
            //{
            //    story.add_link(new NodeLink(new StoryNode(), new StoryNode(), new Fight()));
            //}
            //FileStream fs = new FileStream("test.xml", FileMode.OpenOrCreate);
            //XmlSerializer s = new XmlSerializer(typeof(Story), new Type[]{typeof(NodeLink), typeof(StoryNode), typeof(Fight)});
            //s.Serialize(fs, story);

            // deserialisation
            XmlSerializer sss = new XmlSerializer(typeof(Story), new Type[]{typeof(NodeLink), typeof(StoryNode), typeof(Fight)});
            StreamReader reader = new StreamReader("test.xml");
            Story s2;

            s2 = (Story)sss.Deserialize(reader);
            reader.Close();


        }
    }
}
