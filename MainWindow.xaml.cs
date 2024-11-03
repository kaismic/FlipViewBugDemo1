using FlipViewBugDemo1.ViewModels;
using Microsoft.UI.Xaml;

namespace FlipViewBugDemo1 {
    public partial class MainWindow : Window {
        public GalleryTabViewItemVM GalleryTabViewItemVM { get; private set; }
        public MainWindow() {
            GalleryTabViewItemVM = new();
            InitializeComponent();
        }
    }
}
