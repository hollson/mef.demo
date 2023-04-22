using System.ComponentModel.Composition;
using Mef.Contracts;


namespace Mef.Export.DB.Mysql;

[Export(typeof(IRepository))]
public class Mysql : IRepository
{
    public void Connection()
    {
        Console.WriteLine("==> Mysql连接成功");
    }
}