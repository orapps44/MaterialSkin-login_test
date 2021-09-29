
namespace MaterialSkinExample
{
    partial class Form1
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
            this.materialButtonOk = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonCancel = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialButtonOk
            // 
            this.materialButtonOk.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.materialButtonOk.AutoSize = false;
            this.materialButtonOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonOk.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonOk.Depth = 0;
            this.materialButtonOk.HighEmphasis = true;
            this.materialButtonOk.Icon = null;
            this.materialButtonOk.Location = new System.Drawing.Point(365, 253);
            this.materialButtonOk.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonOk.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonOk.Name = "materialButtonOk";
            this.materialButtonOk.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.materialButtonOk.Size = new System.Drawing.Size(75, 36);
            this.materialButtonOk.TabIndex = 0;
            this.materialButtonOk.Text = "OK";
            this.materialButtonOk.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonOk.UseAccentColor = false;
            this.materialButtonOk.UseVisualStyleBackColor = true;
            this.materialButtonOk.Click += new System.EventHandler(this.materialButtonOk_Click);
            // 
            // materialButtonCancel
            // 
            this.materialButtonCancel.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.materialButtonCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonCancel.Depth = 0;
            this.materialButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.materialButtonCancel.HighEmphasis = true;
            this.materialButtonCancel.Icon = null;
            this.materialButtonCancel.Location = new System.Drawing.Point(280, 253);
            this.materialButtonCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonCancel.Name = "materialButtonCancel";
            this.materialButtonCancel.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.materialButtonCancel.Size = new System.Drawing.Size(77, 36);
            this.materialButtonCancel.TabIndex = 1;
            this.materialButtonCancel.Text = "Cancel";
            this.materialButtonCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonCancel.UseAccentColor = false;
            this.materialButtonCancel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.materialButtonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.materialButtonCancel;
            this.ClientSize = new System.Drawing.Size(447, 298);
            this.Controls.Add(this.materialButtonCancel);
            this.Controls.Add(this.materialButtonOk);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButtonOk;
        private MaterialSkin.Controls.MaterialButton materialButtonCancel;
    }
}