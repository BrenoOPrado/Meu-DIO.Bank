using System;

namespace DIO.Bank
{
    public class Item
    {
        public string NomeItem {get; set;}
        public Item(string nomeitem)
        {
            NomeItem = nomeitem;
        }
        public override string ToString()
		{
            string retorno = "";
            retorno += this.NomeItem;
			return retorno;
		}
    }
}