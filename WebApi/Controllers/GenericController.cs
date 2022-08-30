using Microsoft.AspNetCore.Mvc;
using RealData.Model;
using RealData.NewFolder;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenerciController<T, R> : ControllerBase where T : BaseModel where R : BaseRepository<T>
    {
        private R repository;

        public GenerciController(R repository)
        {
            this.repository = repository;
        }

        [HttpGet]

        public List<T> Get()
        {/*
            Animal a1 = new Animal{Id = 1, Especie = "Cachurros", Peso = 10.2, Sexo = "Mas"};
            //return "Catchurros, o cachorro com gosto de churros";
            return a1;
            */

            //AnimalRepository animalRepository = new AnimalRepository();
            return repository.GetAll();

        }

        [HttpGet("{id}")]

        public T GetById(int id)
        {
            return repository.GetById(id);
        }

        [HttpPost]
        public string Post(T model)
        {
            //AnimalRepository repo = new AnimalRepository();
            // Animal a1 = new Animal { Id = 1, Especie = "Elefante", Peso = 10.2, Sexo = "Masc" };
            return repository.Create(model);
        }

        [HttpPut]

        public string Put(T model)
        {
            //AnimalRepository repo = new AnimalRepository();
            // Animal a1 = new Animal { Id = 1, Especie = "Elefante", Peso = 10.2, Sexo = "Masc" };
            return repository.Create(model);
        }

        [HttpDelete("{id}")]

        public string Delete(int id)
        {
            //AnimalRepository repo = new AnimalRepository();
            // Animal a1 = new Animal { Id = 1, Especie = "Elefante", Peso = 10.2, Sexo = "Masc" };
            return repository.Delete(id);
        }
    }
}
