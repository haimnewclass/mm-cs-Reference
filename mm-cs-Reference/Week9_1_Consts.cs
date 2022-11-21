using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mm_cs_Reference
{
    public  class a
    {
        public a()
        {
            int a = 9;
        }
    }
    public static class Week9_1_Consts
    {
        public static a b = new a();
        public static void Run()
        {

        }
    }

    public class FlexLottoCard
    {
        public FlexLottoCard(byte MaxNumberInCard,int id)
        {
            ///////
            //
            CARD_SIZE = MaxNumberInCard;
            Card = new byte[CARD_SIZE];
            _id = id;
        }
        
        public readonly int a;
        public readonly byte CARD_SIZE;
        string BankName;

        private readonly int _id;
        public int Id
        {
            get { return _id; }
            //set { _id = value; }
        }


        byte[] Card ;
        public void LoadItems()
        {
            
            for (byte i = 0; i < CARD_SIZE; i++)
            {
                Card[i] = (byte)(i + 1);
            }
        }
    }

    public class LottoCard
    {
        public const byte CARD_SIZE = 45;
        string BankName;

        byte[] Card = new byte[CARD_SIZE];
        public void LoadItems()
        {
            for (byte i = 0; i < CARD_SIZE; i++)
            {
                Card[i] =(byte)(i+1);
            }
        }
    }
}
