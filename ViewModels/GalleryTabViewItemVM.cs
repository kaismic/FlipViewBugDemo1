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
            // CHANGE: set and adjust each ImageInfo.ImageFilePath accordingly
            //for (int i = 1; i <= 175; i++) {
            //    ImageInfo info = new() {
            //        ImageFilePath = Path.Combine(LOCAL_DIR, "images", "2823006", i.ToString("D3") + ".webp")
            //    };
            //    _imageInfos.Add(info);
            //}
            Debug.WriteLine(_imageInfos.Count);
            ImageCollectionPanelVMs = _imageInfos.Select(info => new ImageCollectionPanelVM() { ImageInfo = info }).ToList();
        }
    }
}
