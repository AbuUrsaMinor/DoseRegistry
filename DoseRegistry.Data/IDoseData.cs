using DoseRegistry.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoseRegistry.Data
{
    public interface IDoseData
    {
        IEnumerable<Dose> GetAll();
    }

    public class InMemoryDoseData : IDoseData
    {
        readonly List<Dose> doses;

        public InMemoryDoseData()
        {
            doses = new List<Dose>() {
                new Dose { Id = 1, Type = DoseType.External, Unit="mSv", Value=0.0001 },
                new Dose { Id = 2, Type = DoseType.Internal, Unit="mSv", Value=0.00015 },
                new Dose { Id = 3, Type = DoseType.Total, Unit="mSv", Value=0.00025 }
                };
        }

        public Dose get( int id) {
            return doses.SingleOrDefault(r => r.Id == id);
        }


        public IEnumerable<Dose> GetAll()
        {
            return from d in doses
                   orderby d.Id
                   select d;
        }
    }
}
