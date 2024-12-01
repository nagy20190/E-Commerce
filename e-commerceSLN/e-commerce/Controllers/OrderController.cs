using e_commerce.Models;
using e_commerce.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace e_commerce.Controllers
{
    public class OrderController : Controller
    {
        private readonly OrderRepository _orderRepository;
        public OrderController(OrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public IActionResult Index()
        {
            var orders = _orderRepository.GetAll();
            return View();
        }
        //add order 
        public IActionResult Add()
        {
            return View();
        }
        //edit order by id
        public IActionResult Edit(int id) 
        {
            var order = _orderRepository.GetById(id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }
        //get by status
        public IActionResult ByStatus (OrderStatus status)
        {
            var order =_orderRepository.GetByStatus(status);
            return View(order);
        }
        //delete order by id 
        public IActionResult Delete(int id)
        { 
         var order= _orderRepository.GetById(id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }
        //details by id
        public IActionResult Detail(int id)
        {
            var order = _orderRepository.GetById(id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);

        }


    }
}
