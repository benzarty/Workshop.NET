using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
    //sealed pour bloquer l heritages
    public  abstract class Concept
    {
        public abstract void getDetails();
    }
}
