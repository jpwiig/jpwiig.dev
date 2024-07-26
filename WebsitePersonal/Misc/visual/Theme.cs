using MudBlazor;

namespace BlazorApp1;

public class Theme
{
    private MudTheme? myTheme { get; set; }

    public MudTheme getTheme()
    {
        return myTheme = new MudTheme()
        {
            
            PaletteLight = new PaletteLight()
            {
                Primary = "#3D4552",
                Secondary = "#3A3B3C",
                Tertiary = "#222B33",
                Background = "#FFFFFF",
            },
            PaletteDark = new PaletteDark()
            {
                Primary = "#3D4552",
                Secondary = "#3A3B3C",
                Tertiary = "#222B33",
               // Background = "#172125",
            },
            Typography = new Typography()
            {
                Default = new Default()
                {
                    FontFamily = new[]
                    {
                      "Poppins", "Sans Serif"
                    },
                    
                }
            }
        };
    }
}