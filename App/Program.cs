using Mef.Import;

// 加载所有组件
var fac = new ServiceFac();

// 调用MEF某个组件
fac.Payment?.Handler();

// 调用MEF一组组件
foreach (var repo in fac.Repositories!)
{
    repo.Connection();
}

