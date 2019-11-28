using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LimitesCredito.Models;

namespace LimitesCredito.Controllers
{
    public class LIMITES_CREDITO_LICController : Controller
    {
        private CreditoModel db = new CreditoModel();

        // GET: LIMITES_CREDITO_LIC
        public ActionResult Index()
        {
            return View(db.LIMITES_CREDITOS_LIC.ToList());
        }

        // GET: LIMITES_CREDITO_LIC/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LIMITES_CREDITOS_LIC lIMITES_CREDITOS_LIC = db.LIMITES_CREDITOS_LIC.Find(id);
            if (lIMITES_CREDITOS_LIC == null)
            {
                return HttpNotFound();
            }
            return View(lIMITES_CREDITOS_LIC);
        }

        // GET: LIMITES_CREDITO_LIC/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LIMITES_CREDITO_LIC/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDE_LIMITE_CREDITO,IDE_CONTRATO_TERCEIRO,DAT_EXPIRA_LIMITE,DES_OBSERVACAO,QTD_PARCELAS_APROVACAO,VLR_TOTAL_APROVACAO,PER_TAXA_OPERACAO,VLR_TARIFA_OPERACAO,VLR_TOTAL_DESCONTOS,VLR_LIQUIDO_APROVACAO,NUM_PARCELA_INICIAL,IDE_MOTIVO,LIS_SITUACAO,NOM_LOGIN_APROVACAO,DAT_APROVACAO,DES_APROVACAO,STS_LIMITE,DAT_INCLUSAO,NOM_LOGIN_INCLUSAO,NUM_IP_INCLUSAO,DAT_ALTERACAO,NOM_LOGIN_ALTERACAO")] LIMITES_CREDITOS_LIC lIMITES_CREDITOS_LIC)
        {
            if (ModelState.IsValid)
            {
                db.LIMITES_CREDITOS_LIC.Add(lIMITES_CREDITOS_LIC);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lIMITES_CREDITOS_LIC);
        }

        // GET: LIMITES_CREDITO_LIC/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LIMITES_CREDITOS_LIC lIMITES_CREDITOS_LIC = db.LIMITES_CREDITOS_LIC.Find(id);
            if (lIMITES_CREDITOS_LIC == null)
            {
                return HttpNotFound();
            }
            return View(lIMITES_CREDITOS_LIC);
        }

        // POST: LIMITES_CREDITO_LIC/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDE_LIMITE_CREDITO,IDE_CONTRATO_TERCEIRO,DAT_EXPIRA_LIMITE,DES_OBSERVACAO,QTD_PARCELAS_APROVACAO,VLR_TOTAL_APROVACAO,PER_TAXA_OPERACAO,VLR_TARIFA_OPERACAO,VLR_TOTAL_DESCONTOS,VLR_LIQUIDO_APROVACAO,NUM_PARCELA_INICIAL,IDE_MOTIVO,LIS_SITUACAO,NOM_LOGIN_APROVACAO,DAT_APROVACAO,DES_APROVACAO,STS_LIMITE,DAT_INCLUSAO,NOM_LOGIN_INCLUSAO,NUM_IP_INCLUSAO,DAT_ALTERACAO,NOM_LOGIN_ALTERACAO")] LIMITES_CREDITOS_LIC lIMITES_CREDITOS_LIC)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lIMITES_CREDITOS_LIC).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lIMITES_CREDITOS_LIC);
        }

        // GET: LIMITES_CREDITO_LIC/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LIMITES_CREDITOS_LIC lIMITES_CREDITOS_LIC = db.LIMITES_CREDITOS_LIC.Find(id);
            if (lIMITES_CREDITOS_LIC == null)
            {
                return HttpNotFound();
            }
            return View(lIMITES_CREDITOS_LIC);
        }

        // POST: LIMITES_CREDITO_LIC/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LIMITES_CREDITOS_LIC lIMITES_CREDITOS_LIC = db.LIMITES_CREDITOS_LIC.Find(id);
            db.LIMITES_CREDITOS_LIC.Remove(lIMITES_CREDITOS_LIC);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
