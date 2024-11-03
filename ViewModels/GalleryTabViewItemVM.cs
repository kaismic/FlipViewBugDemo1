using FlipViewBugDemo1.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace FlipViewBugDemo1.ViewModels {
    public partial class GalleryTabViewItemVM {
        public static readonly string LOCAL_DIR = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        private readonly List<ImageInfo> _imageInfos = [];
        public List<ImageCollectionPanelVM> ImageCollectionPanelVMs { get; set; }

        public GalleryTabViewItemVM() {
            // CHANGE: set image paths accordingly
            for (int i = 1; i <= 175; i++) {
                ImageInfo info = new() {
                    ImageFilePath = Path.Combine(LOCAL_DIR, "images", "2823006", i.ToString("D3") + ".webp")
                };
                _imageInfos.Add(info);
            }
            UpdateImageCollectionPanelVMs();
        }

        public void UpdateImageCollectionPanelVMs() {
            int imagesPerPage = 2; // optional: change accordingly

            int vmsCount = (int)Math.Ceiling((double)_imageInfos.Count / imagesPerPage);
            ImageCollectionPanelVM[] imageCollectionPanelVMs = new ImageCollectionPanelVM[vmsCount];
            for (int i = 0; i < vmsCount; i++) {
                int start = i * imagesPerPage;
                int end = Math.Min((i + 1) * imagesPerPage, _imageInfos.Count);
                imageCollectionPanelVMs[i] = new() {
                    ImageInfos = [.. _imageInfos[start..end]]
                };
            }
            ImageCollectionPanelVMs = [.. imageCollectionPanelVMs];

        }
    }
}
