using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;
using Mef.Contracts;

namespace Mef.Import;


/// <summary>
/// MEF Service Factory
/// </summary>
public class ServiceFac
{
    //导出所有协议
    [Import(typeof(IPayment))] public IPayment? Payment { get; set; }
    [ImportMany(typeof(IRepository))] public IEnumerable<IRepository>? Repositories { get; set; }

    public ServiceFac()
    {
        // 【Hosting】聚合目录,一个聚合目录可以承载N个ComposablePartDefinition
        var aggCat = new AggregateCatalog();

        // 获取当前目录的程序集
        var dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        if (dir == null) throw new ApplicationException();

        //【Hosting】文件目录
        using var dirCat = new DirectoryCatalog(dir);
        
        //【Hosting】复合容器
        using var container = new CompositionContainer(aggCat);
        aggCat.Catalogs.Add(dirCat);
        container.ComposeParts(this); //组合/组装部件
    }
}