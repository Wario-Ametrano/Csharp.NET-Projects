using LawyerOffice.Contracts.Delivery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerOffice
{
    internal class LawyerOffice
    {
        public string codiceDocumento;
        ManagerOffice manager = new ManagerOffice();
      

        public void OrdinaFood(FOOD ordine , Feedback feedbackLawyer)
        {
            manager.StartOrdine(ordine , feedbackLawyer);
        }
      


        
        public string OrdinaTraduzione(LANGUAGE lang, string text)
        {
            return manager.StartTranslation(lang, text);
        }

        //public void OrdinaFood(ORDINI ordine)
        //{
        //    Console.WriteLine(manager.StartOrdine(ordine));
        //}
        public void  OrdinaTask(DOCUMENTO documento, Feedback feedbackTaskLawyer)
        {
            manager.StartOrdineTask(documento, feedbackTaskLawyer);
        }


    }
}
