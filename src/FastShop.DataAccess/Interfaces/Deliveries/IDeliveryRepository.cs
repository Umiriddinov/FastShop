using FastShop.DataAccess.Common.Interfaces;
using FastShop.DataAccess.ViewModels.Deliveries;
using FastShop.Domain.Entities.Deliveries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastShop.DataAccess.Interfaces.Deliveries;

public interface IDeliveryRepository : IRepository<Deliver, Deliver>,
    IGetAll<DeliverViewModel>
{
    public Task<DeliverViewModel> GetDeliverAsync(long id);
}
