using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuyNK
{
    using System.Xml.Serialization;
   public class champs
    {
        [XmlElement("Champion")]
        public string Champion { get; set; }

        [XmlElement("Filename")]
        public string Filename { get; set; }

        [XmlElement("Creator")]
        public string Creator { get; set; }

        [XmlElement("Status")]
        public string Status { get; set; }

        [XmlElement("Github")]
        public string Github { get; set; }

        [XmlElement("Install")]
        public string Install { get; set; }
    }
}
