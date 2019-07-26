using Gomes.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GomesMVC.ViewModels;
using AutoMapper;
using Gomes.Domain.Entity;
using Gomes.Domain.Interfaces.Service;
using Gomes.Application.Interface;

namespace GomesMVC.Controllers
{
    public class ClientesController : Controller
    {

        private readonly IClienteApplicationService _service;
        public ClientesController(IClienteApplicationService service)
        {
            _service = service;
        }
        // GET: Clientes
        public ActionResult Index()
        {
            var clienteViewModel = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_service.GetAll());
            return View(clienteViewModel);
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            var cliente = _service.GetById(id);
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(cliente);

            return View(clienteViewModel);
            
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteViewModel cliente)
        {
            if (ModelState.IsValid)
            {
                var clienteDomain = Mapper.Map<ClienteViewModel, Cliente>(cliente);
                _service.Add(clienteDomain);
                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            var cliente = _service.GetById(id);
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(cliente);

            return View(clienteViewModel);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ClienteViewModel cliente)
        {

            if (ModelState.IsValid)
            {
                var clienteDomain = Mapper.Map<ClienteViewModel, Cliente>(cliente);
                _service.Update(clienteDomain);
                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            var cliente = _service.GetById(id);
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(cliente);

            return View(clienteViewModel);
        }

        // POST: Clientes/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var cliente = _service.GetById(id);
            _service.Remove(cliente);

            return RedirectToAction("Index");
        }
    }
}
