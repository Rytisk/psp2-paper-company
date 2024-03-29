﻿using PaperCompany.Entities.SalesApi;
using PaperCompany.Facade.OrderFacadeApi;
using PaperCompany.UI.Api.Views;
using System.Collections.Generic;
using PaperCompany.UI.Api.Controllers;

namespace PaperCompany.UI.Console.Controllers
{
    public class SalesmanController : ISalesmanController
    {
        private IOrderFacade _orderFacade;
        private ISalesmanView _view;

        public SalesmanController(IOrderFacade orderFacade, ISalesmanView view)
        {
            _orderFacade = orderFacade;
            _view = view;
            _view.AddController(this);
        }

        public void CreateOrder(List<string> productIds, decimal unitPrice, string salesmanId)
        {
            IOrder order = _orderFacade.CreateOrder(productIds, unitPrice, salesmanId);
            _view.ShowOrderInfo(order.OrderId, order.GetQuantity(), order.GetTotalPrice());
        }

        public void LoadView()
        {
            _view.ShowMenu();
        }
    }
}
