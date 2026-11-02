using System;
using System.Globalization;
using System.Linq;
using Janus.Windows.EditControls;

internal static class OriginalSchoolYears
{
    internal static void Select(UIComboBox combo, string year)
    {
        if (!int.TryParse(year, NumberStyles.Integer, CultureInfo.InvariantCulture, out int selected) || selected < 1300 || selected > 1600)
            throw new InvalidOperationException("سال تعلیمی باید بین ۱۳۰۰ و ۱۶۰۰ باشد.");
        // Match the same supported range as SchoolService.SetYear. Install the
        // complete selection atomically; handlers must never see an empty year.
        combo.SetItems(Enumerable.Range(1300,301).Reverse().Select(value => new UIComboBoxItem
        {
            Text = value.ToString(CultureInfo.InvariantCulture),
            Value = value.ToString(CultureInfo.InvariantCulture)
        }),year);
    }
}
