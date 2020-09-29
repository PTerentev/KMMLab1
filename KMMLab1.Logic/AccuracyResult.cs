using System;
using System.Collections.Generic;
using System.Text;

namespace KMMLab1.Infrastructure
{
    public class AccuracyResult
    {
        internal AccuracyResult()
        {
        }

        public double[] Epsilons { get; internal set; }

        public double[] BValues { get; internal set; }
    }
}
