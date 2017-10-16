using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using System.Data.SqlClient;
using DapperExtensions;
using E = Dapper.Contrib.Extensions;

namespace ProjetoModeloDDD.Infra.Data.Dapper.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected SqlConnection Context
        {
            get
            {
                var cn = new SqlConnection("data source=SERVIDOR-22;initial catalog=CRM_FORMS;User ID=CRM; Password=t4lism4!;MultipleActiveResultSets=True;App=CrmForms");
                cn.Open();
                return cn;
            }
        }

         public void Add(TEntity obj)
        {
            using (var db = Context)
            {
                db.Insert(obj);
            }
        }

        public TEntity GetById(int id)
        {
            TEntity returnValue = null;

            using (var db = Context)
            {
                returnValue = db.Get<TEntity>(id);
            }

            return returnValue;
        }

        public IEnumerable<TEntity> GetAll()
        {
            IEnumerable<TEntity> returnValue = null;

            using (var db = Context)
            {
                returnValue = db.GetList<TEntity>().ToList();
            }

            return returnValue;
        }

        public void Update(TEntity obj)
        {
            using (var db = Context)
            {
                db.Update(obj);
            }
        }

        public void Remove(TEntity obj)
        {
            using (var db = Context)
            {
                db.Delete(obj);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
