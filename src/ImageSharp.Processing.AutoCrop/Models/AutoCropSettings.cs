﻿namespace ImageSharp.Processing.AutoCrop.Models
{
    public class AutoCropSettings : IAutoCropSettings
    {
        public int PadX { get; set; }
        public int PadY { get; set; }
        public int ColorThreshold { get; set; } = 35;
        public float BucketThreshold { get; set; } = 0.945f;
    }
}
