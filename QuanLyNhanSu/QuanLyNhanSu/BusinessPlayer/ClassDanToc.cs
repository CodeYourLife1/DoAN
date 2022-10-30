using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataPlayer;
namespace BusinessPlayer
{
    public class ClassDanToc
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();
        public tblDanToc getItem(int id)
        {
            return db.tblDanTocs.FirstOrDefault(x => x.ID == id);

        }
        public List<tblDanToc> getList()
        {
            return db.tblDanTocs.ToList();
        }
        public tblDanToc Add(tblDanToc dt)
        {
            try
            {
                db.tblDanTocs.Add(dt);
                db.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tblDanToc Edit(tblDanToc dt)
        {
            try
            {
                var _dt = db.tblDanTocs.FirstOrDefault(x => x.ID == dt.ID);
                _dt.TenDanToc = dt.TenDanToc;
                db.SaveChanges();
                return dt;
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
                var _dt = db.tblDanTocs.FirstOrDefault(x => x.ID == id);
                db.tblDanTocs.Remove(_dt);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
