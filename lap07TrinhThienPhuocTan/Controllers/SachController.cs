using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using lap07TrinhThienPhuocTan.Models;

namespace lap07TrinhThienPhuocTan.Controllers
{
    public class SachController : ApiController
    {
        Sach[] sachs = new Sach[]
        {
        new Sach { Id = 1, Title = "Tôi thấy hoa vàng trên cỏ xanh", AuthorName =
        "Nguyễn Nhật Ánh", Price = 1, Content="Truyện kể về Tuổi thơ..." },
        new Sach { Id = 2, Title = "Pro ASP.NET MVC5", AuthorName = "Adam Freeman", Content="The ASP.NET MVC 5 Framework is the latest evolution of Microsoft’s ASP.NET web platform.", Price = 3.75M },
        new Sach { Id = 3, Title = "Thần thoại Hy Lạp", AuthorName =
        "Robert Alber", Price = 35, Content="Truyện kể về các phong tục hy lạp..." },
        };
        public IEnumerable<Sach> GetAll()
        {
            return sachs;
        }
        public IHttpActionResult GetSach(int id)
        {
            var sach = sachs.FirstOrDefault((p) => p.Id == id);
            if (sach == null)
            {
                return NotFound();
            }
            return Ok(sach);
        }
    }
}
