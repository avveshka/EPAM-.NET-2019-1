using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AwardList : IAwardStorage
    {
        public BindingList<Award> ListAwards;

        public AwardList()
        {
            ListAwards = new BindingList<Award>();
        }

        public void Add(Award award)
        {
            ListAwards.Add(award);
        }

        public void Remove(Award award)
        {
            ListAwards.Remove(award);
        }

        public BindingList<Award> GetList()
        {
            return ListAwards;  
        }

        public void EditAward(Award award)
        {
            for (int i = 0; i < ListAwards.Count; i++)
            {
                if (ListAwards[i].ID == award.ID)
                {
                    ListAwards[i].Title = award.Title;
                    ListAwards[i].Description = award.Description;
                }
            }
        }
    }
}
