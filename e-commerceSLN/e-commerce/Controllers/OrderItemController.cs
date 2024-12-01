using e_commerce.Models;
using e_commerce.Repositories;
using e_commerce.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace e_commerce.Controllers
{
    public class OrderItemController : Controller
    {
        private readonly OrderItemRepository _orderitemrepository;
        public OrderItemController(OrderItemRepository orderItemRepository)
        {
            _orderitemrepository = orderItemRepository;
        }
        public IActionResult Index()
        {
            var orderitems= _orderitemrepository.GetAll();
            return View(orderitems);
        }
        // add order item
        public IActionResult Add()
        {
            return View();
        }
        //details ordedr item
        public IActionResult Details(int id)
        {
            var orderItem = _orderitemrepository.GetById(id);
            if (orderItem == null)
            {
                return NotFound();
            }
            return View(orderItem);
        }
       
        //delete
        public IActionResult Delete(int id)
        {
            var orderItem = _orderitemrepository.GetById(id);
            if (orderItem == null)
            {
                return NotFound();
            }
            return View(orderItem);
        }
        //get by id 
        public IActionResult ByProductId(int id)
        {
            var orderItem = _orderitemrepository.GetByProductId(id);
            if (orderItem == null)
            {
                return NotFound();
            }
            return View(orderItem);
        }
        // edit
        public IActionResult Edit(int id, OrderItem orderItem)
        {
            if (id != orderItem.OrderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                orderItem.TotalPrice = (orderItem.Quantity * orderItem.UnitPrice) ?? 0;
               _orderitemrepository.Update(orderItem);
                _orderitemrepository.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(orderItem);
        }
    }
}
