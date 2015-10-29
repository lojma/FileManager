using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FileManager
{
    public class FileUtilites
    {
        private XElement _xElem;
        private TreeNode _Node;
        private List<XElement> _xElemList;
        public TreeNode NodeOfTree
        {
            get { return _Node; }
            set { _Node = value; }
        }

        public XElement XElem
        {
            get { return _xElem; }
            set { _xElem = value; }
        }

        public List<XElement> XElemList
        {
            get
            {
                return _xElemList;
            }

            set
            {
                _xElemList = value;
            }
        }
    }
}
