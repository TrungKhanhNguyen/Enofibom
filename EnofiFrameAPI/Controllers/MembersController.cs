using EnofiFrameAPI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace EnofiFrameAPI.Controllers
{
    public class MembersController : ApiController
    {
        private MapOfflineEntities db = new MapOfflineEntities();

        // GET: api/Members/GetMembers
        [ActionName("GetAllMembers")]
        public IQueryable<Member> GetAllMembers()
        {
            return db.Members;
        }

        // POST: api/Members/PostMember
        [ResponseType(typeof(Member))]
        [ActionName("GetMember")]
        public IHttpActionResult PostMember(Member member)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mem = db.Members.Where(m => m.Username == member.Username && m.Password == member.Password).FirstOrDefault();
          
            return Ok(mem);
        }
        [ActionName("AddMember")]
        public void AddMember(Member _mem)
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            db.Members.Add(_mem);
            db.SaveChanges();
        }

        // PUT: api/Members/5
        [ResponseType(typeof(void))]
        [ActionName("UpdateMember")]
        public IHttpActionResult UpdateMember(Member _mem)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var member = db.Members.Where(m => m.Id == _mem.Id).FirstOrDefault();
                db.Entry(member).State = EntityState.Modified;
                member.Active = _mem.Active;
                member.IsAdmin = _mem.IsAdmin;
                db.SaveChanges();
            }
            catch
            {
                return NotFound();
            }
            return StatusCode(HttpStatusCode.NoContent);
        }

      

        // DELETE: api/Members/5
        [ResponseType(typeof(Member))]
        public IHttpActionResult DeleteMember(int id)
        {
            Member member = db.Members.Find(id);
            if (member == null)
            {
                return NotFound();
            }

            db.Members.Remove(member);
            db.SaveChanges();

            return Ok(member);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MemberExists(int id)
        {
            return db.Members.Count(e => e.Id == id) > 0;
        }
    }
}