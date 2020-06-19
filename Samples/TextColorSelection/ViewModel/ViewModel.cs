using System.Windows.Input;
using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools.Controls;
using System.Windows.Controls;
using System.Windows.Documents;

namespace TextColorSelection
{
    public class ViewModel : NotificationObject
    {
        private ICommand selectionChangedCommand;
        private ICommand loadedChangedCommand;
        private RichTextBox TextBox;

        public ICommand SelectionChangedCommand
        {
            get
            {
                return selectionChangedCommand;
            }
        }

        public ICommand LoadedChangedCommand
        {
            get
            {
                return loadedChangedCommand;
            }
        }

        public void Loadedmethod(object param)
        {
            TextBox = param as RichTextBox;
        }
        public void PropertyChangedHandler(object param)
        {
            if (param != null && TextBox != null)
            {
                ColorSelectedCommandArgs groupItem = param as ColorSelectedCommandArgs;
                TextRange range = new TextRange(TextBox.Selection.Start, TextBox.Selection.End);
                range.ApplyPropertyValue(FlowDocument.ForegroundProperty, groupItem.Brush);
            }
        }
        public ViewModel()
        {
            selectionChangedCommand = new DelegateCommand<object>(PropertyChangedHandler);
            loadedChangedCommand = new DelegateCommand<object>(Loadedmethod);
        }
    }
}
