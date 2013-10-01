using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grade
{
    public class Grade
    {
        public int grade(int score)
        {
            if (score < 0) throw new UnderFlow();
            if (score >= 80 && score <= 100) return 4;
            if (score >= 70 && score < 80) return 3;
            if (score >= 60 && score < 70) return 2;
            if (score >= 50 && score < 60) return 1;
            if (score >= 0 && score < 50) return 0;
            return 0;
        }
    }

    public class UnderFlow : FormatException
    { 
    
    }
}
