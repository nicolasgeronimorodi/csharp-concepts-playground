using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayground.Generics.Interfaces;
public interface ITrainingProducer<out T>
{
    T Produce();
}
