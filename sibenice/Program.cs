using ReaLTaiizor.Colors;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;

namespace sibenice
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            // Nastavení barev motivu
            MaterialSkinManager material = MaterialSkinManager.Instance;
            material.Theme = MaterialSkinManager.Themes.LIGHT;
            material.ColorScheme = new MaterialColorScheme(
                MaterialPrimary.Blue700,
                MaterialPrimary.Blue900,
                MaterialPrimary.Blue500,
                MaterialAccent.LightBlue200,
                MaterialTextShade.WHITE
            );

            ApplicationConfiguration.Initialize();
            Application.Run(new MainMenu());
        }
    }
}