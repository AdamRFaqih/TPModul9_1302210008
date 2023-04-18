using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TPModul9_1302210008.Controllers
{
    [Route("api/[controller]")]
    public class MahasiswaController : Controller
    {
        public static List<Mahasiswa> kelompok1 = new List<Mahasiswa>
        {
            new Mahasiswa("ADAM RAFIF FAQIH","1302210008"),
            new Mahasiswa("MUHAMMAD ISA AL ANSHORI", "1302210014" ),
            new Mahasiswa("HABLI ZULVANA ATH THAARIQ", "1302210024"),
            new Mahasiswa("MAXIMUS BAYU PROUDIASTO", "1302210101"),
            new Mahasiswa("MUHAMAD ILHAM NASRULLAH", "1302210041")
        };
        // GET: api/values
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return kelompok1;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return kelompok1[id];
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Mahasiswa value)
        {
            kelompok1.Add(value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            kelompok1.RemoveAt(id);
        }
    }
}

