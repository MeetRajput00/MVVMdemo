using BasicMvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample.Models
{
    public class TableModel:BindableBase
    {
		private int ndcCode;

		public int NdcCode
		{
			get { return ndcCode; }
			set 
			{ 
				if(ndcCode!=value)
				{ 
					ndcCode = value; 
					OnPropertyChanged("NdcCode"); 
				} 
			}
		}

		private int ndcQuantity;

		public int NdcQuantity
		{
			get { return ndcQuantity; }
			set 
			{ 
				if (ndcQuantity != value) 
				{ 
					ndcQuantity = value; 
					OnPropertyChanged("NdcQuantity"); 
				} 
			}
		}

		private int amount;

		public int Amount
		{
			get { return amount; }
			set 
			{ 
				if (amount != value) 
				{ 
					amount = value; 
					OnPropertyChanged("Amount"); 
				} 
			}
		}
		public TableModel()
		{

		}
		public TableModel(int ndcCode, int ndcQuantity, int amount)
		{
			NdcCode = ndcCode;
			NdcQuantity = ndcQuantity;
			Amount = amount;
		}
	}
}
