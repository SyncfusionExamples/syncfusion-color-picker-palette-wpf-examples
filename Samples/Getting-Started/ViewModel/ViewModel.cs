using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools.Controls;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media;

namespace PropertyGrid_WPF
{
    public class ViewModel : NotificationObject
    {
        private Visibility automaticColorVisibility;
        private Visibility themePanelVisibility;
        private Visibility standardPanelVisibility;
        private BlackWhiteVisible blackWhiteVisibility;
        private Visibility recentlyUsedPanelVisibility;
        private Visibility moreColorOptionVisibility;
        private Visibility isCustomTabVisible;
        private Visibility isStandardTabVisible;
        private bool generateThemeVariants = true;
        private bool generateStandardVariants;
        private PickerMode pickerMode = PickerMode.Split;
        private Color selectedColor =Colors.Red;
        private ObservableCollection<PaletteTheme> paletteThemes;
        private PaletteTheme paletteTheme;

        public PaletteTheme PaletteTheme
        {
            get
            {
                return paletteTheme;
            }
            set
            {
                paletteTheme = value;
                this.RaisePropertyChanged("PaletteTheme");
            }
        }
        public ObservableCollection<PaletteTheme> PaletteThemes
        {
            get
            {
                return paletteThemes;
            }
            set
            {
                paletteThemes = value;
                this.RaisePropertyChanged("PaletteThemes");
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

        public Visibility AutomaticColorVisibility
        {
            get { return automaticColorVisibility; }
            set
            {
                automaticColorVisibility = value;
                this.RaisePropertyChanged(nameof(AutomaticColorVisibility));
            }
        }

        public Visibility ThemePanelVisibility
        {
            get { return themePanelVisibility; }
            set
            {
                themePanelVisibility = value;
                this.RaisePropertyChanged(nameof(ThemePanelVisibility));
            }
        }

        public Visibility StandardPanelVisibility
        {
            get { return standardPanelVisibility; }
            set
            {
                standardPanelVisibility = value;
                this.RaisePropertyChanged(nameof(StandardPanelVisibility));
            }
        }
        public BlackWhiteVisible BlackWhiteVisibility
        {
            get { return blackWhiteVisibility; }
            set
            {
                blackWhiteVisibility = value;
                this.RaisePropertyChanged(nameof(BlackWhiteVisibility));
            }
        } 
        public Visibility RecentlyUsedPanelVisibility
        {
            get { return recentlyUsedPanelVisibility; }
            set
            {
                recentlyUsedPanelVisibility = value;
                this.RaisePropertyChanged(nameof(RecentlyUsedPanelVisibility));
            }
        } 
        public Visibility MoreColorOptionVisibility
        {
            get { return moreColorOptionVisibility; }
            set
            {
                moreColorOptionVisibility = value;
                this.RaisePropertyChanged(nameof(MoreColorOptionVisibility));
            }
        }
        public Visibility IsCustomTabVisible
        {
            get { return isCustomTabVisible; }
            set
            {
                isCustomTabVisible = value;
                this.RaisePropertyChanged(nameof(IsCustomTabVisible));
            }
        } 
        public Visibility IsStandardTabVisible
        {
            get { return isStandardTabVisible; }
            set
            {
                isStandardTabVisible = value;
                this.RaisePropertyChanged(nameof(IsStandardTabVisible));
            }
        }

        public PickerMode PickerMode
        {
            get { return pickerMode; }
            set
            {
                pickerMode = value;
                this.RaisePropertyChanged(nameof(PickerMode));
            }
        }

        public bool GenerateStandardVariants
        {
            get { return generateStandardVariants; }
            set
            {
                generateStandardVariants = value;
                this.RaisePropertyChanged(nameof(GenerateStandardVariants));
            }
        } 
        
        public bool GenerateThemeVariants
        {
            get { return generateThemeVariants; }
            set
            {
                generateThemeVariants = value;
                this.RaisePropertyChanged(nameof(GenerateThemeVariants));
            }
        }

        public ViewModel()
        {
            PaletteThemes = new ObservableCollection<PaletteTheme>();
            PaletteThemes.Add(PaletteTheme.Apex);
            PaletteThemes.Add(PaletteTheme.Aspect);
            PaletteThemes.Add(PaletteTheme.Civic);
            PaletteThemes.Add(PaletteTheme.Equity);
            PaletteThemes.Add(PaletteTheme.Flow);
            PaletteThemes.Add(PaletteTheme.Foundary);
            PaletteThemes.Add(PaletteTheme.Grayscale);
            PaletteThemes.Add(PaletteTheme.Median);
            PaletteThemes.Add(PaletteTheme.Metro);
            PaletteThemes.Add(PaletteTheme.Office);
        }
    }   
}