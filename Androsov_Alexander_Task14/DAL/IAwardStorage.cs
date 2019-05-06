using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IAwardStorage
    {
        void Add(Award award);

        void Remove(Award award);

        BindingList<Award> GetList();

        void EditAward(Award award);
    }
}
