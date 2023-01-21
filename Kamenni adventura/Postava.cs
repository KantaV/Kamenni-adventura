using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Kamenni_adventura
{
    internal class Postava
    {
        public bool zije { get; set; }
        public SystemSound hlaska { get; }
        public Image vzhled { get; }

        public Image vzhled2 { get; }

        public Postava(bool zije)
        {
            this.zije = zije;
        }

        public Postava(bool zije, SystemSound hlaska, Image vzhled)
        {
            this.zije = zije;
            this.hlaska = hlaska;
            this.vzhled = vzhled;
        }

        public Postava(bool zije, SystemSound hlaska, Image vzhled, Image vzhled2)
        {
            this.zije = zije;
            this.hlaska = hlaska;
            this.vzhled = vzhled;
            this.vzhled2 = vzhled2;
        }
    }
}
