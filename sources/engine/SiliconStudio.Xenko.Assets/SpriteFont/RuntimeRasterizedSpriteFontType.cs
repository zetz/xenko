﻿// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.

using System.ComponentModel;
using SiliconStudio.Core;
using SiliconStudio.Xenko.Graphics.Font;

namespace SiliconStudio.Xenko.Assets.SpriteFont
{
    [DataContract("RuntimeRasterizedSpriteFontType")]
    [Display("Runtime Rasterized")]
    public class RuntimeRasterizedSpriteFontType : SpriteFontTypeBase
    {
        /// <inheritdoc/>
        [DataMember(30)]
        [DefaultValue(16.0f)]
        [Display("Default Size")]
        public override float Size { get; set; } = 16.0f;

        /// <inheritdoc/>
        [DataMember(110)]
        [DefaultValue(FontAntiAliasMode.Default)]
        [Display("Anti alias")]
        public override FontAntiAliasMode AntiAlias { get; set; } = FontAntiAliasMode.Default;
    }
}
