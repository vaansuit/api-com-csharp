using Microsoft.AspNetCore.Mvc;
using RealData.Model;
using RealData.NewFolder;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private AnimalRepository repository;

        public AnimalController()
        {
            repository = new AnimalRepository();
        }


        [HttpGet]

        public List<Animal> Get()
        {/*
            Animal a1 = new Animal{Id = 1, Especie = "Cachurros", Peso = 10.2, Sexo = "Mas"};
            //return "Catchurros, o cachorro com gosto de churros";
            return a1;
            */

            //AnimalRepository animalRepository = new AnimalRepository();
            return repository.GetAll();

        }

        [HttpPost]
        public string Post(Animal model)
        {
            //AnimalRepository repo = new AnimalRepository();
           // Animal a1 = new Animal { Id = 1, Especie = "Elefante", Peso = 10.2, Sexo = "Masc" };
            return repository.Create(model);
        }
    }
}
