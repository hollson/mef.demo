using System.ComponentModel.Composition;
using Mef.Contracts;

namespace Mef.Export.DB.SqlServer;

[Export(typeof(IRepository))]
public class SqlServer : IRepository
{
    public void Connection()
    {
        Console.WriteLine("==> SqlServer连接成功");
    }
}