using CSharpPlayground.Generics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayground.Generics.Interfaces;
public interface ITrainingConsumer<in T>
{
    void Enroll(Training training);
}
