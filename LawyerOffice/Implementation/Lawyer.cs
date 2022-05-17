using LawyerOffice.Contracts;
using LawyerOffice.Contracts.Delivery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerOffice.Implementation
{
    internal class Lawyer : Employee
    {
        public LawyerOffice lawyerOffice;
        


        public void OrdinaTraduzione(LANGUAGE lang, string text)
        {
            Console.WriteLine(lawyerOffice.OrdinaTraduzione(lang, text));

        }

        public Lawyer()
        {
            feedback = GetFeedback;
            lawyerOffice = new LawyerOffice();
        }
        public void OrdinaTaskUfficio(DOCUMENTO documento)
        {
            lawyerOffice.OrdinaTask(documento, feedback);
        }
        public void OrdinazioneCibo(FOOD food)
        {
            
            lawyerOffice.OrdinaFood(food , feedback);
        }
        
    }
}
