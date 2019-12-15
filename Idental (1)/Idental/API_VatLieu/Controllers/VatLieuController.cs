using Data_iDental.DAO;
using Data_iDental.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_VatLieu.Controllers
{
    public class VatLieuController : ApiController
    {
        VatLieuDAO dao = new VatLieuDAO();
        public IHttpActionResult GetVatLieu()//int employeeID
        {
            List<VatLieu> list = dao.GetVatLieu();
            if (list.Count == 0)
            {
                return NotFound();
            }

            return Ok(list);
        }
        public IHttpActionResult PostVatLieu([FromBody] ThemVatLieu dv)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            if (dao.PostVatLieu(dv) == false)
            {
                return BadRequest("Not a valid model");
            }

            return Ok();
        }
        public IHttpActionResult PutVatLieu([FromBody] SuaVatLieu dv)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            if (!dao.PutVatLieu(dv))
            {
                return BadRequest("Not a valid model");
            }

            return Ok();
        }
        public IHttpActionResult DeleteVatLieu(XoaVatLieu ServiceID)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            if (!dao.DeleteVatLieu(ServiceID))
            {
                return BadRequest("Not a valid model");
            }

            return Ok();
        }
    }
}
