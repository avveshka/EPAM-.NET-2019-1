using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AwardList : IStorage
    {
        public BindingList<Award> ListAwards;

        public AwardList()
        {
            ListAwards = new BindingList<Award>();
        }
    }
}
