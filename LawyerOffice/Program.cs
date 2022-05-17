using LawyerOffice.Implementation;
using System;

namespace LawyerOffice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lawyer lawyer = new Lawyer();
            lawyer.OrdinaTraduzione(LANGUAGE.ENG, "HI");
            lawyer.OrdinazioneCibo(FOOD.PIZZA);
            //lawyer.OrdinaTaskUfficio(DOCUMENTO.MODULO);


        }
    }

    public enum LANGUAGE
    {
        ENG,
        GERMAN,
        SPANISH

    }
    public enum RESTAURANTTYPE
    { 
        BREAKFAST,
        LUNCH,
        DINNER

        

    }
    public enum FOOD
    {
        CAFFE,
        PANINO,
        PIZZA
    }

    public enum DOCUMENTO
    {
        MODULO,
        PRATICA
    }
    public enum TASKTYPE
    {
        LEGALE,
        FISCALE
    }


}
