using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DrawingDemo
{
    interface IWritable
    {
        void Write(TextWriter writer);
    }
}
