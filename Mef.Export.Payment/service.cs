using System;
using System.ComponentModel.Composition;
using Mef.Contracts;

namespace Mef.Export.Payment;

[Export(typeof(IPayment))]
public class Unionpay : IPayment
{
    public void Handler()
    {
        Console.WriteLine("==> 支付处理成功");
    }
}