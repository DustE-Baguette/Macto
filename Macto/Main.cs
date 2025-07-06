using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;

namespace Macto
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private IKeyboardMouseEvents globalHook;


        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            globalHook.Dispose();
            base.OnFormClosed(e);
        }

        private void macroBTN_Click(object sender, EventArgs e)
        {
            // Show "Press Key" overlay
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Visible = ctrl.Tag?.ToString() == "Overlay";
            }

            globalHook = Hook.GlobalEvents();

            // Listen for keyboard clicks
            globalHook.KeyDown += (s, keyEvent) =>
            {
                macroSelectionTB.Text = keyEvent.KeyCode.ToString();
                FinishInput();
            };

            // Listen for mouse clicks
            globalHook.MouseDown += (s, mouseEvent) =>
            {
                macroSelectionTB.Text = mouseEvent.Button.ToString();
                FinishInput();
            };

            // Dispose of hook and hide "Press Key" overlay
            void FinishInput()
            {
                globalHook.Dispose();
                globalHook = null;

                foreach (Control ctrl in this.Controls)
                {
                    ctrl.Visible = ctrl.Tag?.ToString() != "Overlay";
                }
            }
        }
    }
}
