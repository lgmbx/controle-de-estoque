using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estoque.DAL {
    class DataContextFactory {


        private static estoqueDataContext dataContext;

        estoqueDataContext DataContext{
            get {
                if (dataContext == null) {
                    dataContext = new estoqueDataContext();
                }
                return dataContext;
            }
        }

    }
}
