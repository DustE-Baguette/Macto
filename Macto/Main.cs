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
using WindowsInput;
using WindowsInput.Native;

namespace Macto
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private IKeyboardMouseEvents globalHook;
        private readonly InputSimulator sim = new InputSimulator();

        private Keys selectedMacroKey;
        private Keys selectedEmulationKey;
        private MouseButtons selectedMacroMouseKey;
        private MouseButtons selectedEmulationMouseKey;

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            globalHook.Dispose();
            base.OnFormClosed(e);
        }

        //private void 

        private void SetKeyHookListen(TextBox selectedTB, bool macroSender)
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
                selectedTB.Text = keyEvent.KeyCode.ToString();

                // Set selected key into variable
                if (macroSender)
                {
                    selectedMacroKey = keyEvent.KeyCode;
                    selectedMacroMouseKey = MouseButtons.None;
                }
                else
                {
                    selectedEmulationKey = keyEvent.KeyCode;
                    selectedEmulationMouseKey = MouseButtons.None;
                }

                FinishInput();
            };

            // Listen for mouse clicks
            globalHook.MouseDown += (s, mouseEvent) =>
            {
                selectedTB.Text = mouseEvent.Button.ToString();

                // Set selected key into variable
                if (macroSender)
                {
                    selectedMacroMouseKey = mouseEvent.Button;
                    selectedMacroKey = Keys.None;
                }
                else
                {
                    selectedEmulationMouseKey = mouseEvent.Button;
                    selectedEmulationKey = Keys.None;
                }

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

        private void HookListen()
        {

        }

        private void macroBTN_Click(object sender, EventArgs e)
        {
            SetKeyHookListen(macroSelectionTB, true);
        }

        private void emulateBTN_Click(object sender, EventArgs e)
        {
            SetKeyHookListen(emulatingSelectionTB, false);
        }

        private void beginBTN_Click(object sender, EventArgs e)
        {
            if (selectedMacroKey == Keys.None) // If mouse key is emulated
            {
                
            }
            else // If keyboard key is emulated
            {
                VirtualKeyCode vkc = (VirtualKeyCode)selectedEmulationKey;

                Timer macroTimer = new Timer();
                macroTimer.Interval = 1000 / (int)repeatTimeUD.Value;
                macroTimer.Tick += (s, es) =>
                {
                    sim.Keyboard.KeyPress(vkc);
                };
                macroTimer.Start();
            }
        }
    }
}
