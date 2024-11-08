using FlipViewBugDemo1.Entities;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace FlipViewBugDemo1.Views.ViewPageViews {
    public sealed partial class ImageCollectionPanel : Grid {

        public static readonly DependencyProperty ImageInfoProperty = DependencyProperty.Register(
            nameof(ImageInfo),
            typeof(ImageInfo),
            typeof(ImageCollectionPanel),
            null
        );

        public ImageInfo ImageInfo {
            get => (ImageInfo)GetValue(ImageInfoProperty);
            set => SetValue(ImageInfoProperty, value);
        }

        //public ImageInfo ImageInfo { get; set; }

        public ImageCollectionPanel() {
            InitializeComponent();
        }
    }
}
