using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodInterfaces
{
    public interface ICallInfo : IComparable<ICallInfo>
    {
        string MemberName { get; }
        string SourceFilePath { get; }
        int LineNumber { get; }
    }
}
