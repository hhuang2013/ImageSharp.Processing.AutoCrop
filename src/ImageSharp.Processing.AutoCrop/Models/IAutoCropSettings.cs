﻿namespace ImageSharp.Processing.AutoCrop.Models
{
    public interface IAutoCropSettings
    {
        int PadX { get; }
        int PadY { get; }
        int ColorThreshold { get; }
        float BucketThreshold { get; set; }
    }
}
