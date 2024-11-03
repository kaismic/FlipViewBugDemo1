using FlipViewBugDemo1.ViewModels;
using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace FlipViewBugDemo1.Views.ViewPageViews {
    public sealed partial class ImageCollectionPanel : UserControl {
        public ImageCollectionPanelVM ViewModel { get; set; }

        public ImageCollectionPanel() {
            InitializeComponent();
        }
    }
}
