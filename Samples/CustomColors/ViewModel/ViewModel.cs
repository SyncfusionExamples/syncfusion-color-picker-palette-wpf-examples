using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace CustomColors
{
    public class ViewModel : NotificationObject
    {
        private ObservableCollection<CustomColor> ownColorCollection;
        private Visibility customHeaderVisibility;
        private Color selectedColor=Colors.YellowGreen;

        public Visibility CustomHeaderVisibility
        {
            get
            {
                return customHeaderVisibility;
            }
            set
            {
                customHeaderVisibility = value;
                this.RaisePropertyChanged("CustomHeaderVisibility");
            }
        }
        
        public Color SelectedColor
        {
            get
            {
                return selectedColor;
            }
            set
            {
                selectedColor = value;
                this.RaisePropertyChanged("SelectedColor");
            }
        }
        public ObservableCollection<CustomColor> OwnColorCollection
        {
            get
            {
                return ownColorCollection;
            }
            set
            {
                ownColorCollection = value;
                this.RaisePropertyChanged("OwnColorCollection");
            }
        }
        public ViewModel()
        {
            OwnColorCollection = new ObservableCollection<CustomColor>();
        }
    }
}
