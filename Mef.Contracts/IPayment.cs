namespace Mef.Contracts;

/// <summary>
/// 支付接口
/// </summary>
public interface IPayment
{
    /// <summary>
    /// 支付处理
    /// </summary>
    void Handler();
}