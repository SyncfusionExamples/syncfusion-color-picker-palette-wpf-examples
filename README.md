# WPF Color Picker Palette Demo
This sample demonstrates how to build a polished color selection experience in a WPF application using the Color Picker Palette control. It showcases drop-down and embedded palettes, a split-button workflow, theme/standard/recent color panels, and a “More Colors” dialog for precise RGB/HSV/Hex entry. Users can quickly pick theme colors, reuse recent choices, or open the dialog for exact values all within a themed, localizable, and RTL-ready UI.

## Features
- Drop-down and embedded (direct-selection) palette modes
- Split-button behavior: command button + palette drop-down
- Theme, Standard, and Recently Used color panels
- 10 built-in theme palettes with the current selection highlighted
- "More Colors" dialog with RGB, HSV, and Hex inputs
- Customizable header (icon/title/template)
- Built-in themes for consistent styling
- Right-to-left (RTL) layout support
- Localization for all static text

## Getting Started
1. Create a new WPF project in Visual Studio (e.g., ColorPickerPaletteDemo).
2. Install the NuGet package (for the Color Picker Palette control), for example: Syncfusion.Tools.WPF.
3. Add the XML namespace in XAML:
   - xmlns:syncfusion="http://schemas.syncfusion.com/wpf"
4. Place a Color Picker Palette in your Window/Page.
5. Configure panels and view mode:
   - Enable/disable Theme, Standard, and Recently Used panels
   - Choose the palette view mode (drop-down, standard, or split-button)
   - Set the header template/icon to match your scenario
6. Enable the "More Colors" dialog to allow RGB/HSV/Hex entry.
7. Apply a theme (e.g., VS2010) via syncfusion:SkinStorage.VisualStyle.

## Usage Tips
- Provide a clear entry point (icon/button) for the palette in drop-down/split-button modes.
- Keep the main palette fast: rely on the "More Colors" dialog for exact RGB/HSV/Hex entry.
- Persist recently used colors so users can quickly reuse prior selections.
- Offer multiple theme palettes and allow switching to fit different branding needs.
- Test both LTR and RTL layouts and verify localized strings.

## About the Sample
This sample provides a concise starting point for integrating a Color Picker Palette into WPF apps. It demonstrates common palette layouts (drop-down, standard, split-button), the Theme/Standard/Recently Used panels, and the "More Colors" dialog for precise selections. Extend it by wiring the selected color to brushes and styles, persisting user preferences, and tailoring templates and themes to your brand.