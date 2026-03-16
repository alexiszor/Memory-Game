using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class Check
    {
        public bool Check1(Bitmap b1, Bitmap b2)
        {

            
            bool c = true;
            String image1;
            String image2;
            if (b1.Width == b2.Width && b1.Height == b2.Height)
            {
                for (int a = 0; a < b1.Width; a++) { 
                    for(int k = 0; k < b1.Height; k++)
                {
                        image1 = b1.GetPixel(a, k).ToString();
                        image2 = b2.GetPixel(a, k).ToString();
                        if (image1 != image2)
                        {
                            c = false;
                            break;
                        }
                 }
                }
                return c;
            }
            else
            {
                return false;
            }
            

           




        }
    }
}
