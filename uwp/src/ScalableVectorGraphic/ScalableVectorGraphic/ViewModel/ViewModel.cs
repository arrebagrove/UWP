﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Mntone.SvgForXaml;
using Mntone.SvgForXaml.UI.Xaml;
using UwpConvertSimplifie.ViewModel;

namespace ScalableVectorGraphic.ViewModel
{
    public class ViewModel:NotifyProperty
    {
        public ViewModel()
        {
            Svgimage();
        }

        private void Svgimage()
        {
            string str = @"<?xml version=""1.0"" encoding=""utf-8""?>
<!-- Generator: Adobe Illustrator 16.0.0, SVG Export Plug-In . SVG Version: 6.00 Build 0)  -->
<!DOCTYPE svg PUBLIC ""-//W3C//DTD SVG 1.1//EN"" ""http://www.w3.org/Graphics/SVG/1.1/DTD/svg11.dtd"">
<svg version=""1.1"" id=""Layer_1"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" x=""0px"" y=""0px""
	 width=""64px"" height=""64px"" viewBox=""0 0 64 64"" enable-background=""new 0 0 64 64"" xml:space=""preserve"">
<g>
	<circle fill=""none"" stroke=""#000000"" stroke-width=""2"" stroke-miterlimit=""10"" cx=""32"" cy=""32"" r=""16""/>
	<line fill=""none"" stroke=""#000000"" stroke-width=""2"" stroke-miterlimit=""10"" x1=""32"" y1=""10"" x2=""32"" y2=""0""/>
	<line fill=""none"" stroke=""#000000"" stroke-width=""2"" stroke-miterlimit=""10"" x1=""32"" y1=""64"" x2=""32"" y2=""54""/>
	<line fill=""none"" stroke=""#000000"" stroke-width=""2"" stroke-miterlimit=""10"" x1=""54"" y1=""32"" x2=""64"" y2=""32""/>
	<line fill=""none"" stroke=""#000000"" stroke-width=""2"" stroke-miterlimit=""10"" x1=""0"" y1=""32"" x2=""10"" y2=""32""/>
	<line fill=""none"" stroke=""#000000"" stroke-width=""2"" stroke-miterlimit=""10"" x1=""48"" y1=""16"" x2=""53"" y2=""11""/>
	<line fill=""none"" stroke=""#000000"" stroke-width=""2"" stroke-miterlimit=""10"" x1=""11"" y1=""53"" x2=""16"" y2=""48""/>
	<line fill=""none"" stroke=""#000000"" stroke-width=""2"" stroke-miterlimit=""10"" x1=""48"" y1=""48"" x2=""53"" y2=""53""/>
	<line fill=""none"" stroke=""#000000"" stroke-width=""2"" stroke-miterlimit=""10"" x1=""11"" y1=""11"" x2=""16"" y2=""16""/>
</g>
</svg>
";
            Svg=SvgDocument.Parse(str);
          
        }

        public SvgDocument Svg
        {
            set
            {
                _svg = value;
                OnPropertyChanged();
            }
            get
            {
                return _svg;
            }
        }

        private SvgDocument _svg;
    }
}
