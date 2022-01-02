using Lab2_SOLIDPattern.Repositories;
using Lab2_SOLIDPattern.Services;

IOrderService orderService = OrderFactory.CreateOrderService();

IOrderRepo slowOrder = new NormalOrderRepo
{
    ID = Guid.NewGuid(),
    Email = "slowEmail@example.com",
    TotalPrce = 100,
};

IOrderRepo urgentOrder = new LightningSpeedOrderRepo
{
    ID = Guid.NewGuid(),
    Email = "urgentEmail@test.com",
    TotalPrce = 150,
};

orderService.OrderProcess(slowOrder);
Console.WriteLine();
orderService.OrderProcess(urgentOrder);
