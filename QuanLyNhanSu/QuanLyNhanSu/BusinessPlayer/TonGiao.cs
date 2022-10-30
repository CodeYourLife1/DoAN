using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataPlayer;

namespace BusinessPlayer
{
   public class TonGiao
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();
        public tblTonGiao getItem(int id)
        {
            return db.tblTonGiaos.FirstOrDefault(x => x.ID == id);

        }
        public List<tblTonGiao> getList()
        {
            return db.tblTonGiaos.ToList();
        }
        public tblTonGiao Add(tblTonGiao tg)
        {
            try
            {
                db.tblTonGiaos.Add(tg);
                db.SaveChanges();
                return tg;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tblTonGiao Edit(tblTonGiao tg)
        {
            try
            {
                var _dt = db.tblTonGiaos.FirstOrDefault(x => x.ID == tg.ID);
                _dt.TenTonGiao = tg.TenTonGiao;
                db.SaveChanges();
                return tg;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void Delete(int id)
        {
            try
            {
                var _tg = db.tblTonGiaos.FirstOrDefault(x => x.ID == id);
                db.tblTonGiaos.Remove(_tg);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
