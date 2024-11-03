using FlipViewBugDemo1.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace FlipViewBugDemo1.ViewModels {
    public partial class GalleryTabViewItemVM {
        public static readonly string LOCAL_DIR = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        private readonly List<ImageInfo> _imageInfos = [];
        public List<ImageCollectionPanelVM> ImageCollectionPanelVMs { get; set; }

        public GalleryTabViewItemVM() {
            for (int i = 1; i <= 7; i++) {
                ImageInfo info = new() {
                    ImageFilePath = Path.Combine(LOCAL_DIR, i.ToString() + ".jpeg")
                };
                _imageInfos.Add(info);
            }
            Debug.WriteLine(_imageInfos.Count);
            ImageCollectionPanelVMs = _imageInfos.Select(info => new ImageCollectionPanelVM() { ImageInfo = info }).ToList();
        }
    }
}
