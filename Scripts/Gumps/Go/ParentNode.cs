using System.Collections;
using System.Xml;

namespace Server.Gumps
{
    public class ParentNode
    {
        private ParentNode m_Parent;
        private object[] m_Children;

        private string m_Name;

        public ParentNode(XmlTextReader xml, ParentNode parent)
        {
            m_Parent = parent;

            Parse(xml);
        }

        private void Parse(XmlTextReader xml)
        {
            if (xml.MoveToAttribute("name"))
                m_Name = xml.Value;
            else
                m_Name = "empty";

            if (xml.IsEmptyElement)
            {
                m_Children = new object[0];
            }
            else
            {
                ArrayList children = new ArrayList();

                while (xml.Read() && (xml.NodeType == XmlNodeType.Element || xml.NodeType == XmlNodeType.Comment))
                {
                    if (xml.NodeType == XmlNodeType.Comment)
                        continue;

                    if (xml.Name == "child")
                    {
                        ChildNode n = new ChildNode(xml, this);

                        children.Add(n);
                    }
                    else
                    {
                        children.Add(new ParentNode(xml, this));
                    }
                }

                m_Children = children.ToArray();
            }
        }

        public ParentNode Parent
        {
            get
            {
                return m_Parent;
            }
        }

        public object[] Children
        {
            get
            {
                return m_Children;
            }
        }

        public string Name
        {
            get
            {
                return m_Name;
            }
        }
    }
}
