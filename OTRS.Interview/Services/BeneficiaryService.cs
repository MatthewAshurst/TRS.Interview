using OTRS.Interview.Entities;
using OTRS.Interview.Interfaces;

namespace OTRS.Interview.Services
{
    public class BeneficiaryService : IService<Beneficiary>
    {
        public void Add(Beneficiary entity)
        {
            using (var context = new TrsContext())
            {
                context.Beneficiary.Add(entity);
                context.SaveChanges();
            }
        }

        public void Remove(int beneficiaryId)
        {
            using (var context = new TrsContext())
            {
                var beneficiary = context.Beneficiary.Where(b => b.Id == beneficiaryId).FirstOrDefault();

                if (beneficiary != null) {
                    context.Beneficiary.Remove(beneficiary);
                    context.SaveChanges();
                }
            }
        }
    }
}
