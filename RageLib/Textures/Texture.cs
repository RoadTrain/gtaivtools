﻿/**********************************************************************\

 RageLib - Textures
 Copyright (C) 2008  Arushan/Aru <oneforaru at gmail.com>

 This program is free software: you can redistribute it and/or modify
 it under the terms of the GNU General Public License as published by
 the Free Software Foundation, either version 3 of the License, or
 (at your option) any later version.

 This program is distributed in the hope that it will be useful,
 but WITHOUT ANY WARRANTY; without even the implied warranty of
 MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 GNU General Public License for more details.

 You should have received a copy of the GNU General Public License
 along with this program.  If not, see <http://www.gnu.org/licenses/>.

\**********************************************************************/

using System;
using System.Drawing;
using RageLib.Textures.Decoder;
using RageLib.Textures.Resource;

namespace RageLib.Textures
{
    public class Texture
    {
        public const int ThumbnailSize = 32;
        private Image _thumbnailCache;
        internal Texture(TextureInfo info)
        {
            Name = info.Name;
            Width = info.Width;
            Height = info.Height;

            switch (info.Format)
            {
                case D3DFormat.DXT1:
                    TextureType = TextureType.DXT1;
                    break;
                case D3DFormat.DXT3:
                    TextureType = TextureType.DXT3;
                    break;
                case D3DFormat.DXT5:
                    TextureType = TextureType.DXT5;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            TextureData = info.TextureData;
            Levels = info.Levels;
            Info = info;
        }

        internal TextureInfo Info { get; set; }

        public uint Width { get; private set; }
        public uint Height { get; private set; }
        public TextureType TextureType { get; private set; }
        public byte[] TextureData { get; private set; }
        public string Name { get; private set; }
        public int Levels { get; private set; }


        public string TitleName
        { 
            get
            {
                string name = Name;
                if (name.StartsWith("pack:/"))
                {
                    name = Name.Substring(6);
                }
                if (name.EndsWith(".dds"))
                {
                    name = name.Substring(0, name.Length - 4);
                }                
                return name;
            }
        }

        public Image DecodeAsThumbnail()
        {
            if (_thumbnailCache == null)
            {
                Image image = Decode();

                int thumbWidth = ThumbnailSize;
                int thumbHeight = ThumbnailSize;
                if (Width > Height)
                {
                    thumbHeight = (int) (((float) Height/Width)*ThumbnailSize);
                }
                else if (Height > Width)
                {
                    thumbWidth = (int) (((float) Width/Height)*ThumbnailSize);
                }

                _thumbnailCache = image.GetThumbnailImage(thumbWidth, thumbHeight, () => false, IntPtr.Zero);
            }

            return _thumbnailCache;
        }

        public Image Decode()
        {
            return Decode(0);
        }

        public Image Decode(int level)
        {
            return TextureDecoder.Decode(this, level);
        }

        public override string ToString()
        {
            string format;
            switch (TextureType)
            {
                case TextureType.DXT1:
                    format = "DXT1";
                    break;
                case TextureType.DXT3:
                    format = "DXT3";
                    break;
                case TextureType.DXT5:
                    format = "DXT5";
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            return string.Format("{0} ({1}x{2} {3})", Name.Substring(6), Width, Height, format);
        }

        public uint GetTextureDataSize(int level)
        {
            var width = GetWidth(level);
            var height = GetHeight(level);
            var blockSize = TextureType == TextureType.DXT1 ? 8 : 16;
            return (uint)((width/4)*(height/4)*blockSize);
        }

        public uint GetWidth(int level)
        {
            return Width/(uint)Math.Pow(2, level);
        }

        public uint GetHeight(int level)
        {
            return Height / (uint)Math.Pow(2, level);
        }

        public byte[] GetTextureData(int level)
        {
            byte[] data;
            if (level == 0)
            {
                data = TextureData;
            }
            else
            {
                uint offset = 0;
                for(int i=0; i<level; i++)
                {
                    offset += GetTextureDataSize(i);
                }
                uint size = GetTextureDataSize(level);

                data = new byte[size];
                Array.Copy(TextureData, offset, data, 0, size);
            }
            return data;
        }
    }
}