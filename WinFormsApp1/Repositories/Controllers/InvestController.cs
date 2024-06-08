using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Repositories.Models;

namespace WinFormsApp1.Repositories.Controllers
{
    internal class InvestController
    {
        InvEntities entity = new InvEntities();

        public List<Invest> GetAllInvests()
        {
            try
            {
                var allInvests = entity.Invests.ToList();
                return allInvests;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        public Invest GetInvestBySerial(int serial)
        {
            try
            {
                var allInvests = entity.Invests.ToList();
                var invest = allInvests.SingleOrDefault(x => x.Serial == serial);
                return invest;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        public void AddInvest(Invest newInvest)
        {
            try
            {
                var invest = GetInvestBySerial(newInvest.Serial);
                if(invest == null)
                {
                    entity.Invests.Add(newInvest);
                    entity.SaveChanges();
                } else
                {
                    throw new Exception("Invest Already Exists!");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return;
            }
        }

        public void RemoveInvest(int serial)
        {
            try
            {
                var invest = GetInvestBySerial(serial);
                if (invest != null)
                {
                    entity.Invests.Remove(invest);
                    entity.SaveChanges();
                }
                else
                {
                    throw new Exception("Invest Does Not Exist!");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return;
            }
        }

        public void UpdateInvest(Invest investToUpdate)
        {
            try
            {
                var invest = GetInvestBySerial(investToUpdate.Serial);
                if (invest != null)
                {
                    entity.Invests.Update(invest);
                    invest.Resume = investToUpdate.Resume;
                    invest.Rem = investToUpdate.Rem;
                    invest.Dfile = investToUpdate.Dfile;
                    invest.Dmahdar = investToUpdate.Dmahdar;
                    invest.Madbout = investToUpdate.Madbout;
                    entity.SaveChanges();
                }
                else
                {
                    throw new Exception("Invest Does Not Exist!");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return;
            }
        }
    }
}
