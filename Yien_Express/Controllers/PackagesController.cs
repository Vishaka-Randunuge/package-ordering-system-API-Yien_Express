using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yien_Express.Data;
using Yien_Express.DTO;
using Yien_Express.Model;

namespace Yien_Express.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackagesController : ControllerBase
    {
        public IPackageRepo packageRepo;
        public IMapper mapper;

        public PackagesController(IPackageRepo pRepo, IMapper pMapper)
        {
            packageRepo = pRepo;
            mapper = pMapper;
        }
        [HttpGet]
        public ActionResult<IEnumerable<PackageReadDTO>> GetPackage()
        {
          var packages = packageRepo.GetPackages(); 
          return Ok(mapper.Map<IEnumerable<PackageReadDTO>>(packages));
        }
        [HttpGet("{code}",Name ="GetPackage")]
        public ActionResult<PackageReadDTO> GetPackage(int code)
        {
            var package = packageRepo.GetPackage(code);
            if (package != null)
                return Ok(mapper.Map<PackageReadDTO>(package));
            else
                return NotFound();
        }
        [HttpPost]
        public ActionResult<PackageCreateDTO> CreatePackage(PackageCreateDTO package)
        {
            var modelPackage = mapper.Map<Package>(package);
            packageRepo.CreatePackage(modelPackage);
            packageRepo.Save();
            var newPackage = mapper.Map<PackageReadDTO>(modelPackage);
            return CreatedAtRoute(nameof(GetPackage),
                new { code = newPackage.ID }, newPackage);
        }
        [HttpPut("{code}")]
        public ActionResult Update(int code,PackageCreateDTO package)
        {
            var packageToUpdate = mapper.Map<Package>(package);
            packageToUpdate.ID = code;
            if (packageRepo.Update(packageToUpdate))
                return Ok();
            else
                return NotFound();
        }
        [HttpDelete("{code}")]
        public ActionResult Delete(int code)
        {
            var packageToDelete = packageRepo.GetPackage(code);
            
            if (packageToDelete != null)
            {
                packageRepo.Delete(packageToDelete);
                return Ok();
            }
                
            else
                return NotFound();
        }
    }
}
