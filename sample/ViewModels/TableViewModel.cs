using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using BasicMvvm;
using BasicMvvm.Commands;
using sample.Models;
namespace sample.ViewModels
{
    public class TableViewModel:BindableBase
    {
		private TableModel tableModel=new TableModel();

		private ObservableCollection<TableModel> dataList;

		public ObservableCollection<TableModel> DataList
		{
			get { return dataList; }
			set { dataList = value; OnPropertyChanged("DataList"); }
		}

		public ICommand submitButton => new DelegateCommand(submitButtonCommand);

		public TableModel TableModel
		{
			get { return tableModel; }
			set { tableModel = value; OnPropertyChanged("TableModel"); }
		}

		public TableViewModel()
		{
            dataList = new ObservableCollection<TableModel>();
        }
		public void submitButtonCommand()
		{
			if (tableModel.Amount != 0 && tableModel.NdcQuantity != 0 && tableModel.NdcCode != 0)
			{
				dataList.Add(new TableModel(tableModel.NdcCode, tableModel.NdcQuantity, tableModel.Amount));
				//Add data to table
			}
		}

	}
}
