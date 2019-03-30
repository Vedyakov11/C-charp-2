﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3._2
{
    class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("Pupil.Study()");
        }

        public virtual void Read()
        {
            Console.WriteLine("Pupil.Read()");
        }

        public virtual void Write()
        {
            Console.WriteLine("Pupil.Write()");
        }

        public virtual void Relax()
        {
            Console.WriteLine("Pupil.Relax()");
        }
    }

    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("ExelentPupil.Study()");
        }

        public override void Read()
        {
            Console.WriteLine("ExelentPupil.Read()");
        }

        public override void Write()
        {
            Console.WriteLine("ExelentPupil.Write()");
        }

        public override void Relax()
        {
            Console.WriteLine("ExelentPupil.Relax()");
        }
    }

    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("GoodPupil.Study()");
        }

        public override void Read()
        {
            Console.WriteLine("GoodPupil.Read()");
        }

        public override void Write()
        {
            Console.WriteLine("GoodPupil.Write()");
        }

        public override void Relax()
        {
            Console.WriteLine("GoodPupil.Relax()");
        }
    }

    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("BadPupil.Study()");
        }

        public override void Read()
        {
            Console.WriteLine("BadPupil.Read()");
        }

        public override void Write()
        {
            Console.WriteLine("BadPupil.Write()");
        }

        public override void Relax()
        {
            Console.WriteLine("BadPupil.Relax()");
        }
    }
}
