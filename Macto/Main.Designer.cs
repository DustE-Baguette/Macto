namespace Macto
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.macroBTN = new System.Windows.Forms.Button();
            this.macroSelectionTB = new System.Windows.Forms.TextBox();
            this.macroSelectionLBL = new System.Windows.Forms.Label();
            this.pressKeyLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // macroBTN
            // 
            this.macroBTN.BackColor = System.Drawing.Color.DimGray;
            this.macroBTN.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macroBTN.ForeColor = System.Drawing.Color.White;
            this.macroBTN.Location = new System.Drawing.Point(241, 360);
            this.macroBTN.Name = "macroBTN";
            this.macroBTN.Size = new System.Drawing.Size(80, 30);
            this.macroBTN.TabIndex = 0;
            this.macroBTN.Text = "Select";
            this.macroBTN.UseVisualStyleBackColor = false;
            this.macroBTN.Click += new System.EventHandler(this.macroBTN_Click);
            // 
            // macroSelectionTB
            // 
            this.macroSelectionTB.BackColor = System.Drawing.Color.Gray;
            this.macroSelectionTB.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macroSelectionTB.ForeColor = System.Drawing.Color.White;
            this.macroSelectionTB.Location = new System.Drawing.Point(197, 311);
            this.macroSelectionTB.Name = "macroSelectionTB";
            this.macroSelectionTB.ReadOnly = true;
            this.macroSelectionTB.Size = new System.Drawing.Size(173, 23);
            this.macroSelectionTB.TabIndex = 1;
            // 
            // macroSelectionLBL
            // 
            this.macroSelectionLBL.AutoSize = true;
            this.macroSelectionLBL.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macroSelectionLBL.Location = new System.Drawing.Point(217, 290);
            this.macroSelectionLBL.Name = "macroSelectionLBL";
            this.macroSelectionLBL.Size = new System.Drawing.Size(139, 18);
            this.macroSelectionLBL.TabIndex = 2;
            this.macroSelectionLBL.Text = "Selected Macro Key";
            // 
            // pressKeyLBL
            // 
            this.pressKeyLBL.AutoSize = true;
            this.pressKeyLBL.Font = new System.Drawing.Font("Bahnschrift", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressKeyLBL.Location = new System.Drawing.Point(392, 283);
            this.pressKeyLBL.Name = "pressKeyLBL";
            this.pressKeyLBL.Size = new System.Drawing.Size(480, 115);
            this.pressKeyLBL.TabIndex = 3;
            this.pressKeyLBL.Tag = "Overlay";
            this.pressKeyLBL.Text = "Press Key";
            this.pressKeyLBL.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pressKeyLBL);
            this.Controls.Add(this.macroSelectionLBL);
            this.Controls.Add(this.macroSelectionTB);
            this.Controls.Add(this.macroBTN);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button macroBTN;
        private System.Windows.Forms.TextBox macroSelectionTB;
        private System.Windows.Forms.Label macroSelectionLBL;
        private System.Windows.Forms.Label pressKeyLBL;
    }
}

