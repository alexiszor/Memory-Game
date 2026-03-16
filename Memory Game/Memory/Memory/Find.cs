using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    class Find
    {
        public List<PictureBox> find1(int t1, int t2, List<PictureBox> p)
        {
            List<PictureBox> findP = new List<PictureBox>();
            for (int i = 0; i < p.Count; i++)
            {
                if (p[i].Name == t1.ToString())
                {
                    findP.Add(p[i]);
                }
                if (p[i].Name ==  t2.ToString())
                {
                    findP.Add(p[i]);

                }
                if (findP.Count == 2)
                {
                    break;
                }

            }
            return findP;
        }

        public PictureBox find2(int t1, List<PictureBox> p)
        {
            PictureBox p2 = new PictureBox();
            List<PictureBox> findP = new List<PictureBox>();
            for (int i = 0; i < p.Count; i++)
            {
                if (p[i].Name == t1.ToString())
                {
                    p2=p[i];
                    break;
                }
               
                

            }
            return p2;
        }
    }
}
