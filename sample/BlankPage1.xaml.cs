using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.Toolkit.Uwp.UI.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace sample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
   
    public sealed partial class BlankPage1 : Page
    {
        public List<DetailLine> detailSource;
        public List<DetailLine> myList=new List<DetailLine>();
        public BlankPage1()
        {
            this.InitializeComponent();
        }

        private void addItemsToTable(object sender, RoutedEventArgs e)
        {
            if (pcText.Text != "" && posText.Text != "" && dpText.Text != "" && modText.Text != "" && ndcText.Text != "" && ndcqText.Text != "" && billAmtText.Text != "" && rpIDText.Text != "" && rNPIText.Text != "" && srNPIText.Text != "")
            {
                myList.Add(new DetailLine(sosDate.Date.ToString(), eosDate.Date.ToString(), pcText.Text, posText.Text, dpText.Text, modText.Text, ndcText.Text, ndcqText.Text, billAmtText.Text, rpIDText.Text, rNPIText.Text, srNPIText.Text));
                dataGrid.ItemsSource = null;
                dataGrid.ItemsSource=myList;
            }
        }
    }


    //backing data source in MyViewModel
    public class DetailLine
    {
        public String StartOfService { get; set; }
        public String EndOfService { get; set; }
        public String ProcedureCode { get; set; }
        public String PlaceOfService { get; set; }
        public String DiagnosisPointers { get; set; }
        public String Modifiers { get; set; }
        public String NDCCode { get; set; }
        public String NDCQuantity { get; set; }
        public String BilledAmount { get; set; }
        public String RenderingProviderID { get; set; }
        public String RenderingNPI { get; set; }
        public String SubmittedRenderingNPI { get; set; }

        public DetailLine(String startOfService, String endOfService, String procedureCode, String placeOfService, String diagnosisPointers, String modifiers, String ndcCode, String ndcQuantity, String billedAmount, String renderingProviderID, String renderingNPI, String submittedRenderingNPI)
        {
            this.StartOfService=startOfService;
            this.EndOfService=endOfService;
            this.ProcedureCode=procedureCode;
            this.PlaceOfService=placeOfService;
            this.DiagnosisPointers=diagnosisPointers;
            this.Modifiers=modifiers;
            this.NDCCode=ndcCode;
            this.NDCQuantity=ndcQuantity;
            this.BilledAmount=billedAmount;
            this.RenderingProviderID=renderingProviderID;
            this.RenderingNPI=renderingNPI;
            this.SubmittedRenderingNPI=submittedRenderingNPI;
        }

    }
}
