using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Clarifai2.Dto.Model {
    partial class ClusterModel {
        public override global::Clarifai2.Dto.Model.Output_info.OutputInfo OutputInfo() {
            return ClusterOutputInfo();
        }
    }
    partial class ColorModel
    {
        public override global::Clarifai2.Dto.Model.Output_info.OutputInfo OutputInfo()
        {
            return ColorOutputInfo();
        }
    }
    partial class UnknownModel
    {
        public override global::Clarifai2.Dto.Model.Output_info.OutputInfo OutputInfo()
        {
            return UnknownOutputInfo();
        }
    }
    partial class LogoModel
    {
        public override global::Clarifai2.Dto.Model.Output_info.OutputInfo OutputInfo()
        {
            return LogoOutputInfo();
        }
    }
    partial class FocusModel
    {
        public override global::Clarifai2.Dto.Model.Output_info.OutputInfo OutputInfo()
        {
            return FocusOutputInfo();
        }
    }
    partial class FaceDetectionModel
    {
        public override global::Clarifai2.Dto.Model.Output_info.OutputInfo OutputInfo()
        {
            return FaceDetectionOutputInfo();
        }
    }
    partial class EmbeddingModel {
        public override global::Clarifai2.Dto.Model.Output_info.OutputInfo OutputInfo() {
            return EmbeddingOutputInfo();
        }
    }
}