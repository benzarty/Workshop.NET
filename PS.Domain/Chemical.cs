using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
    public class Chemical : Product


    {
      


        public string LabName { get; set; }

        public virtual Adresse Adresse { get; set; }
        public override void GetMyType()
 //tenajem tena7ihom ovveride wel virtual 
        {
            base.GetMyType();  // pour hériter console.write du parentk.

            Console.WriteLine(" chemical");  //yafichi meta3 base wel jedida 
        }
    }
}
