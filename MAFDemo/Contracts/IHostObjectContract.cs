using System;
using System.AddIn.Contract;
using System.AddIn.Pipeline;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    /// <summary>
    /// 报告对象接口,由于不是插件实现的所以不需要AddInContract
    /// </summary>
    
    public interface IHostObjectContract:IContract
    {
        void ReportProgress(float progressspercent);
    }
}
