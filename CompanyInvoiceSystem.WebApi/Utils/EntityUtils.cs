using CompanyInvoiceSystem.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CompanyInvoiceSystem.WebApi.Utils
{
    public static class EntityUtils
    {

        public static bool Update<TEntity>(this ApplicationContext _context, TEntity item) where TEntity : BaseEntity
        {
            try
            {
                var collection = _context.Set<TEntity>();
                var entity = collection.Find(item.Id);
                if (entity == null)
                {
                    return false;
                }
                _context.Entry(entity).CurrentValues.SetValues(item);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
