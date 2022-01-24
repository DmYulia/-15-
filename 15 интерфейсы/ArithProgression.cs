using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_интерфейсы
{
    class ArithProgression : ISeries
    {
        public ArithProgression(int startValue, int k)
        {
            setStart(startValue);
            K = k;
            CurrentValue = startValue;
        }
        public int StartValue { get; set; }
        public int CurrentValue { get; set; }
        public int K { get; set; }
        public int getNext()
        {
            return CurrentValue += K;
        }
        public void reset()
        {
            CurrentValue = StartValue;
        }
        public void setStart(int x)
        {
            StartValue = x;
        }
    }
}
