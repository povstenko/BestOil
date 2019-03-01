namespace BestOil
{
	partial class fCheck
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
			this.tbxCheck = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// tbxCheck
			// 
			this.tbxCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbxCheck.BackColor = System.Drawing.SystemColors.Window;
			this.tbxCheck.Enabled = false;
			this.tbxCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbxCheck.Location = new System.Drawing.Point(-1, -1);
			this.tbxCheck.Multiline = true;
			this.tbxCheck.Name = "tbxCheck";
			this.tbxCheck.ReadOnly = true;
			this.tbxCheck.Size = new System.Drawing.Size(297, 379);
			this.tbxCheck.TabIndex = 0;
			this.tbxCheck.Text = "                    CheckOil                      ";
			// 
			// fCheck
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(294, 375);
			this.Controls.Add(this.tbxCheck);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "fCheck";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Check";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbxCheck;
	}
}