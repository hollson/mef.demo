namespace Mef.Contracts;

/// <summary>
/// 数据仓储
/// </summary>
public interface IRepository
{
    /// <summary>
    /// 创建数据库链接
    /// </summary>
    void Connection();
}