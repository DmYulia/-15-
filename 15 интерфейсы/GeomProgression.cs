using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_интерфейсы
{
    class GeomProgression : ISeries
    {
        public GeomProgression(int startValue, int delta)
        {
            setStart(startValue);
            Delta = delta;
            CurrentValue = startValue;
        }
        public int StartValue { get; set; }
        public int CurrentValue { get; set; }
        public int Delta { get; set; }
        public int getNext()
        {
            return CurrentValue *= Delta;
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
