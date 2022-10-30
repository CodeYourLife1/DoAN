using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataPlayer;
namespace BusinessPlayer
{
   public class TrinhDo
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();
        public tblTrinhDo getItem(int id)
        {
            return db.tblTrinhDoes.FirstOrDefault(x => x.IDTrinhDo == id);

        }
        public List<tblTrinhDo> getList()
        {
            return db.tblTrinhDoes.ToList();
        }
        public tblTrinhDo Add(tblTrinhDo td)
        {
            try
            {
                db.tblTrinhDoes.Add(td);
                db.SaveChanges();
                return td;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tblTrinhDo Edit(tblTrinhDo td)
        {
            try
            {
                var _td = db.tblTrinhDoes.FirstOrDefault(x => x.IDTrinhDo == td.IDTrinhDo);
                _td.TenTrinhDo = td.TenTrinhDo;
                db.SaveChanges();
                return td;
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
                var _td = db.tblTrinhDoes.FirstOrDefault(x => x.IDTrinhDo == id);
                db.tblTrinhDoes.Remove(_td);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
