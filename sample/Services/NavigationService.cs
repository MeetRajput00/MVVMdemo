using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace sample.Services
{
    public class NavigationService
    {
        private readonly static Lazy<NavigationService> lazyInstance = new Lazy<NavigationService>(() => new NavigationService(), true);

        public static NavigationService CurrentInstance
        {
            get
            {
                return lazyInstance.Value;
            }
        }

        private NavigationService() { }

        public Frame NavigationFrame { get; set; }
        private Dictionary<string, Type> pages = new Dictionary<string, Type>();

        public void GoBack()
        {
            if (NavigationFrame.CanGoBack)
            {
                NavigationFrame.GoBack();
            }
        }

        public void NavigateTo(string pageKey)
        {
            this.NavigateTo(pageKey, (object)null);
        }

        public void NavigateTo(string pageKey, object parameter)
        {
            Dictionary<string, Type> pagesByKey = this.pages;
            bool lockTaken = false;
            try
            {
                Monitor.Enter((object)pagesByKey, ref lockTaken);
                Configure(pageKey);
                NavigationFrame.Navigate(this.pages[pageKey], parameter);
            }
            finally
            {
                if (lockTaken)
                    Monitor.Exit((object)pagesByKey);
            }
        }
        private void Configure(string pageName)
        {
            Dictionary<string, Type> pagesByKey = this.pages;
            if (string.IsNullOrEmpty(pageName))
                throw new ArgumentException("The page key cannot be empty: ");
            if (!this.pages.ContainsKey(pageName))
            {
                try
                {
                    StringBuilder name = new StringBuilder();
                    name.Append("sample" + ".");//All your pages should be in the same namespace
                    name.Append(pageName);
                    Assembly currentAssm = this.GetType().GetTypeInfo().Assembly;
                    Type pageType = currentAssm.GetType(name.ToString());
                    this.pages.Add(pageName, pageType);
                }
                catch
                {
                    throw new ArgumentException(string.Format("Can not map {0} page name to actual type", pageName), "pageName");
                }
            }
        }

    }
}
