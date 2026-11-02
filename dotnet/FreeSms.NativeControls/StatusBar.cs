using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FreeSms.NativeControls
{
    public enum StatusBarPanelAutoSize { None, Contents, Spring }
    public class StatusBarPanel : ToolStripStatusLabel
    {
        public new StatusBarPanelAutoSize AutoSize
        {
            get => Spring ? StatusBarPanelAutoSize.Spring : base.AutoSize ? StatusBarPanelAutoSize.Contents : StatusBarPanelAutoSize.None;
            set { Spring = value == StatusBarPanelAutoSize.Spring; base.AutoSize = value == StatusBarPanelAutoSize.Contents; }
        }
    }
    public class StatusBar : StatusStrip
    {
        public sealed class PanelCollection : IEnumerable<StatusBarPanel>
        {
            private readonly StatusBar owner;
            internal PanelCollection(StatusBar owner) { this.owner = owner; }
            public StatusBarPanel this[int index] => (StatusBarPanel)owner.Items[index];
            public int Add(StatusBarPanel panel) => owner.Items.Add(panel);
            public IEnumerator<StatusBarPanel> GetEnumerator() { foreach (StatusBarPanel item in owner.Items) yield return item; }
            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
        public PanelCollection Panels { get; }
        public bool ShowPanels { get => Visible; set => Visible = value; }
        public StatusBar() { Panels = new PanelCollection(this); SizingGrip = false; }
    }
}
