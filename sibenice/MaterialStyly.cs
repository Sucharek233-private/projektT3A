using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ReaLTaiizor.Colors;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;

namespace sibenice {
    internal class MaterialStyly {
        public MaterialSkinManager GreenTheme() {
            MaterialSkinManager material = MaterialSkinManager.Instance;
            material.ColorScheme = new MaterialColorScheme(
                MaterialPrimary.Green500,
                MaterialPrimary.Green700,
                MaterialPrimary.Green100,
                MaterialAccent.Green200,
                MaterialTextShade.WHITE
            );

            return material;
        }   
    }
}
