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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.macroBTN = new System.Windows.Forms.Button();
            this.macroSelectionTB = new System.Windows.Forms.TextBox();
            this.macroSelectionLBL = new System.Windows.Forms.Label();
            this.pressKeyLBL = new System.Windows.Forms.Label();
            this.emulatingKeyLBL = new System.Windows.Forms.Label();
            this.emulatingSelectionTB = new System.Windows.Forms.TextBox();
            this.emulateBTN = new System.Windows.Forms.Button();
            this.repeatTimeUD = new System.Windows.Forms.NumericUpDown();
            this.repeatTimeLBL = new System.Windows.Forms.Label();
            this.beginBTN = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.repeatTimeUD)).BeginInit();
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
            this.macroSelectionLBL.Location = new System.Drawing.Point(213, 290);
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
            // emulatingKeyLBL
            // 
            this.emulatingKeyLBL.AutoSize = true;
            this.emulatingKeyLBL.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emulatingKeyLBL.Location = new System.Drawing.Point(550, 290);
            this.emulatingKeyLBL.Name = "emulatingKeyLBL";
            this.emulatingKeyLBL.Size = new System.Drawing.Size(165, 18);
            this.emulatingKeyLBL.TabIndex = 6;
            this.emulatingKeyLBL.Text = "Selected Emulating Key";
            // 
            // emulatingSelectionTB
            // 
            this.emulatingSelectionTB.BackColor = System.Drawing.Color.Gray;
            this.emulatingSelectionTB.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emulatingSelectionTB.ForeColor = System.Drawing.Color.White;
            this.emulatingSelectionTB.Location = new System.Drawing.Point(546, 311);
            this.emulatingSelectionTB.Name = "emulatingSelectionTB";
            this.emulatingSelectionTB.ReadOnly = true;
            this.emulatingSelectionTB.Size = new System.Drawing.Size(173, 23);
            this.emulatingSelectionTB.TabIndex = 5;
            // 
            // emulateBTN
            // 
            this.emulateBTN.BackColor = System.Drawing.Color.DimGray;
            this.emulateBTN.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emulateBTN.ForeColor = System.Drawing.Color.White;
            this.emulateBTN.Location = new System.Drawing.Point(590, 360);
            this.emulateBTN.Name = "emulateBTN";
            this.emulateBTN.Size = new System.Drawing.Size(80, 30);
            this.emulateBTN.TabIndex = 4;
            this.emulateBTN.Text = "Select";
            this.emulateBTN.UseVisualStyleBackColor = false;
            this.emulateBTN.Click += new System.EventHandler(this.emulateBTN_Click);
            // 
            // repeatTimeUD
            // 
            this.repeatTimeUD.BackColor = System.Drawing.Color.Gray;
            this.repeatTimeUD.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeatTimeUD.ForeColor = System.Drawing.Color.White;
            this.repeatTimeUD.Location = new System.Drawing.Point(939, 312);
            this.repeatTimeUD.Name = "repeatTimeUD";
            this.repeatTimeUD.Size = new System.Drawing.Size(120, 23);
            this.repeatTimeUD.TabIndex = 7;
            // 
            // repeatTimeLBL
            // 
            this.repeatTimeLBL.AutoSize = true;
            this.repeatTimeLBL.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeatTimeLBL.Location = new System.Drawing.Point(936, 290);
            this.repeatTimeLBL.Name = "repeatTimeLBL";
            this.repeatTimeLBL.Size = new System.Drawing.Size(126, 18);
            this.repeatTimeLBL.TabIndex = 8;
            this.repeatTimeLBL.Text = "Repeat Time (ms)";
            // 
            // beginBTN
            // 
            this.beginBTN.BackColor = System.Drawing.Color.DimGray;
            this.beginBTN.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginBTN.ForeColor = System.Drawing.Color.White;
            this.beginBTN.Location = new System.Drawing.Point(582, 550);
            this.beginBTN.Name = "beginBTN";
            this.beginBTN.Size = new System.Drawing.Size(100, 40);
            this.beginBTN.TabIndex = 9;
            this.beginBTN.Text = "Begin";
            this.beginBTN.UseVisualStyleBackColor = false;
            this.beginBTN.Click += new System.EventHandler(this.beginBTN_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Macto (Running)";
            this.notifyIcon1.Visible = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.beginBTN);
            this.Controls.Add(this.repeatTimeLBL);
            this.Controls.Add(this.repeatTimeUD);
            this.Controls.Add(this.emulatingKeyLBL);
            this.Controls.Add(this.emulatingSelectionTB);
            this.Controls.Add(this.emulateBTN);
            this.Controls.Add(this.pressKeyLBL);
            this.Controls.Add(this.macroSelectionLBL);
            this.Controls.Add(this.macroSelectionTB);
            this.Controls.Add(this.macroBTN);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.repeatTimeUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button macroBTN;
        private System.Windows.Forms.TextBox macroSelectionTB;
        private System.Windows.Forms.Label macroSelectionLBL;
        private System.Windows.Forms.Label pressKeyLBL;
        private System.Windows.Forms.Label emulatingKeyLBL;
        private System.Windows.Forms.TextBox emulatingSelectionTB;
        private System.Windows.Forms.Button emulateBTN;
        private System.Windows.Forms.NumericUpDown repeatTimeUD;
        private System.Windows.Forms.Label repeatTimeLBL;
        private System.Windows.Forms.Button beginBTN;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

