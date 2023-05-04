using Microsoft.AspNetCore.Mvc;
using RepoPattern.Models;
using RepoPattern.UnitOfWork;

namespace RepoPattern.Controllers
{
    public class StudentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public StudentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var student = _unitOfWork.StudentRepo.GetAll();
            return View(student);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.StudentRepo.Add(student);
                _unitOfWork.Commit();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }


        public IActionResult Edit(int id)
        {
            var customer = _unitOfWork.StudentRepo.GetById(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.StudentRepo.Update(student);
                _unitOfWork.Commit();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        public IActionResult Delete(int id)
        {
            var student = _unitOfWork.StudentRepo.GetById(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var student = _unitOfWork.StudentRepo.GetById(id);
            _unitOfWork.StudentRepo.Delete(student);
            _unitOfWork.Commit();
            return RedirectToAction(nameof(Index));
        }


    }
}
