using Syncfusion.SfSkinManager;
using Syncfusion.Windows.Shared;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Themes
{
    class ViewModel : NotificationObject
    {
        private Color selectedColor = Colors.YellowGreen;
        private FlowDirection flowDirection;
        private ObservableCollection<string> themes = new ObservableCollection<string>();
        private DelegateCommand<object> selectionChangedCommand;

        public ICommand SelectionChangedCommand
        {
            get
            {
                return selectionChangedCommand;
            }
        }

        public ObservableCollection<string> Themes
        {
            get
            {
                return themes;
            }
            set
            {
                themes = value;
                this.RaisePropertyChanged("Themes");
            }
        }

        public Color SelectedColor
        {
            get { return selectedColor; }
            set
            {
                selectedColor = value;
                this.RaisePropertyChanged("SelectedColor");
            }
        }
        public FlowDirection FlowDirection
        {
            get { return flowDirection; }
            set
            {
                flowDirection = value;
                this.RaisePropertyChanged("FlowDirection");
            }
        }
        public ViewModel()
        {
            //Theme list  added in the collection
            Themes.Add("Blend");
            Themes.Add("Lime");
            Themes.Add("MaterialDark");
            Themes.Add("MaterialDarkBlue");
            Themes.Add("MaterialLight");
            Themes.Add("MaterialLightBlue");
            Themes.Add("Metro");
            Themes.Add("Office2010Black");
            Themes.Add("Office2010Blue");
            Themes.Add("Office2010Silver");
            Themes.Add("Office2013DarkGray");
            Themes.Add("Office2013LightGray");
            Themes.Add("Office2013White");
            Themes.Add("Office2016Colorful");
            Themes.Add("Office2016DarkGray");
            Themes.Add("Office2016White");
            Themes.Add("Office2019Black");
            Themes.Add("Office2019Colorful");
            Themes.Add("Office365");
            Themes.Add("Saffron");
            Themes.Add("VisualStudio2013");
            Themes.Add("VisualStudio2015");

            selectionChangedCommand = new DelegateCommand<object>(selectionChanged);
        }

        public void selectionChanged(object parameter)
        {
            WindowCollection windows = Application.Current.Windows;
            if (windows.Count > 0)
            {
                Window samplewindow = windows[0];
                ComboBox combo = parameter as System.Windows.Controls.ComboBox;
                if (combo != null)
                {
                    if (combo.SelectedItem != null)
                    {
                        string themename = combo.SelectedValue.ToString();
                        SfSkinManager.SetVisualStyle(samplewindow, (VisualStyles)Enum.Parse(typeof(VisualStyles), themename));
                    }
                }
            }
        }
    }
}
