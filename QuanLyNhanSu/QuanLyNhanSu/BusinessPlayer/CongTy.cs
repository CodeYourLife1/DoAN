using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataPlayer;
namespace BusinessPlayer
{
   public class CongTy
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();
        public tblCongTy getItem(int id)
        {
            return db.tblCongTies.FirstOrDefault(x => x.IDCongTy == id);

        }
        public List<tblCongTy> getList()
        {
            return db.tblCongTies.ToList();
        }
        public tblCongTy Add(tblCongTy pb)
        {
            try
            {
                db.tblCongTies.Add(pb);
                db.SaveChanges();
                return pb;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tblCongTy Edit(tblCongTy pb)
        {
            try
            {
                var _ct = db.tblCongTies.FirstOrDefault(x => x.IDCongTy == pb.IDCongTy);
                _ct.TenCongTy = pb.TenCongTy;
                db.SaveChanges();
                return pb;
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
                var _ct = db.tblCongTies.FirstOrDefault(x => x.IDCongTy == id);
                db.tblCongTies.Remove(_ct);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
