using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataPlayer;
namespace BusinessPlayer
{
   public class BoPhan
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();
        public tblBoPhan getItem(int id)
        {
            return db.tblBoPhans.FirstOrDefault(x => x.IDBoPhan == id);

        }
        public List<tblBoPhan> getList()
        {
            return db.tblBoPhans.ToList();
        }
        public tblBoPhan Add(tblBoPhan bp)
        {
            try
            {
                db.tblBoPhans.Add(bp);
                db.SaveChanges();
                return bp;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tblBoPhan Edit(tblBoPhan bp)
        {
            try
            {
                var _bp = db.tblBoPhans.FirstOrDefault(x => x.IDBoPhan == bp.IDBoPhan);
                _bp.TenBoPhan = bp.TenBoPhan;
                db.SaveChanges();
                return bp;
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
                var _bp = db.tblBoPhans.FirstOrDefault(x => x.IDBoPhan == id);
                db.tblBoPhans.Remove(_bp);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
