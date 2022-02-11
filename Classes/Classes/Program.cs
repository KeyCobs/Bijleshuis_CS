using System;

namespace Classes
{
    class Type
    {
        public string m_Type { get; set; }
        public int m_Bouwjaar { get; set; }

    }
    class Car
    {
        //Constructers
        #region hide
        public Car(Type t, int zetels, int deuren)
        {
            m_Type = t;
            m_AantalDeuren = deuren;
            m_AantalZetels = zetels;
        }





        private void BerekendPK()
        {
            //Code here;
        }
        public void PrintBouwJaar()
        {
            Console.WriteLine(m_Type.m_Bouwjaar);
        }
        public void PrintAlles()
        {
            Console.WriteLine(m_Type.m_Bouwjaar);
            Console.WriteLine(m_AantalZetels);
            Console.WriteLine(m_AantalDeuren);

        }
        public int BerekenMaxGewicht(int aantalPersonenInwagen)
        {

            return 0;
        }

        #endregion
        //              vraagt voor type int en noemt deze getal
        public void Voegtoe()
        {
            //_Lijftijd = getal;
        }
        
        private int m_AantalZetels{ get; set; }
        private int m_AantalDeuren { get; set; }

        public int _naam;
        public int _Lijftijd;
        public int _piano;
        public Type m_Type { get; private set; }
    }










    internal class Program
    {
        static void Main(string[] args)
        {
            #region Some extra code
            //Car audi = new Car();
            Type audi = new Type();
            audi.m_Bouwjaar = 1999;
            audi.m_Type = "Audi";
            #endregion

            //Car mijnAuto = new Car()
            //mijnauto._naam = "nnaam";
            Car mijnAuto = new Car(audi, 4, 5);
            mijnAuto.BerekenMaxGewicht(2);


            Console.WriteLine(mijnAuto._naam);


            Console.WriteLine(mijnAuto.m_Type);
            //mijnAuto.m_Type = audi;
        }
    }
}
