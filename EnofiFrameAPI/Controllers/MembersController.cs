﻿using EnofiFrameAPI.Models;
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

        // GET: api/Members
        public IQueryable<Member> GetMembers()
        {
            return db.Members;
        }

        // GET: api/Members/5
        [ResponseType(typeof(Member))]
        public IHttpActionResult GetMember(int id)
        {
            Member member = db.Members.Find(id);
            if (member == null)
            {
                return NotFound();
            }

            return Ok(member);
        }

        // PUT: api/Members/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMember(int id, Member member)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != member.Id)
            {
                return BadRequest();
            }

            db.Entry(member).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MemberExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Members
        [ResponseType(typeof(Member))]
        public IHttpActionResult PostMember(Member member)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mem = db.Members.Where(m => m.Username == member.Username && m.Password == member.Password).FirstOrDefault();
            //db.SaveChanges();

            return Ok(mem);
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