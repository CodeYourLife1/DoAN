using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataPlayer;
namespace BusinessPlayer
{
   public class PhongBan
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();
        public tblPhongBan getItem(int id)
        {
            return db.tblPhongBans.FirstOrDefault(x => x.IDPhongBan == id);

        }
        public List<tblPhongBan> getList()
        {
            return db.tblPhongBans.ToList();
        }
        public tblPhongBan Add(tblPhongBan pb)
        {
            try
            {
                db.tblPhongBans.Add(pb);
                db.SaveChanges();
                return pb;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tblPhongBan Edit(tblPhongBan pb)
        {
            try
            {
                var _pb = db.tblPhongBans.FirstOrDefault(x => x.IDPhongBan == pb.IDPhongBan);
                _pb.TenPhongBan = pb.TenPhongBan;
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
                var _pb = db.tblPhongBans.FirstOrDefault(x => x.IDPhongBan == id);
                db.tblPhongBans.Remove(_pb);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
