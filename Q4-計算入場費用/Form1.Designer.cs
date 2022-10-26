namespace Q4_計算入場費用
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.txtPersonInsert = new System.Windows.Forms.TextBox();
			this.txtCarInsert = new System.Windows.Forms.TextBox();
			this.btnCal = new System.Windows.Forms.Button();
			this.txtResult = new System.Windows.Forms.TextBox();
			this.lblPersonNumber = new System.Windows.Forms.Label();
			this.lblCarNumber = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtPersonInsert
			// 
			this.txtPersonInsert.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtPersonInsert.Location = new System.Drawing.Point(102, 32);
			this.txtPersonInsert.Name = "txtPersonInsert";
			this.txtPersonInsert.Size = new System.Drawing.Size(100, 30);
			this.txtPersonInsert.TabIndex = 1;
			// 
			// txtCarInsert
			// 
			this.txtCarInsert.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtCarInsert.Location = new System.Drawing.Point(102, 70);
			this.txtCarInsert.Name = "txtCarInsert";
			this.txtCarInsert.Size = new System.Drawing.Size(100, 30);
			this.txtCarInsert.TabIndex = 1;
			// 
			// btnCal
			// 
			this.btnCal.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnCal.Location = new System.Drawing.Point(255, 35);
			this.btnCal.Name = "btnCal";
			this.btnCal.Size = new System.Drawing.Size(126, 43);
			this.btnCal.TabIndex = 2;
			this.btnCal.Text = "計算結果";
			this.btnCal.UseVisualStyleBackColor = true;
			this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
			// 
			// txtResult
			// 
			this.txtResult.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtResult.Location = new System.Drawing.Point(44, 127);
			this.txtResult.Multiline = true;
			this.txtResult.Name = "txtResult";
			this.txtResult.ReadOnly = true;
			this.txtResult.Size = new System.Drawing.Size(367, 187);
			this.txtResult.TabIndex = 1;
			// 
			// lblPersonNumber
			// 
			this.lblPersonNumber.AutoSize = true;
			this.lblPersonNumber.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblPersonNumber.Location = new System.Drawing.Point(48, 35);
			this.lblPersonNumber.Name = "lblPersonNumber";
			this.lblPersonNumber.Size = new System.Drawing.Size(48, 22);
			this.lblPersonNumber.TabIndex = 3;
			this.lblPersonNumber.Text = "人數:";
			// 
			// lblCarNumber
			// 
			this.lblCarNumber.AutoSize = true;
			this.lblCarNumber.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblCarNumber.Location = new System.Drawing.Point(48, 73);
			this.lblCarNumber.Name = "lblCarNumber";
			this.lblCarNumber.Size = new System.Drawing.Size(48, 22);
			this.lblCarNumber.TabIndex = 3;
			this.lblCarNumber.Text = "車數:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(460, 350);
			this.Controls.Add(this.lblCarNumber);
			this.Controls.Add(this.lblPersonNumber);
			this.Controls.Add(this.btnCal);
			this.Controls.Add(this.txtResult);
			this.Controls.Add(this.txtCarInsert);
			this.Controls.Add(this.txtPersonInsert);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "計算入場費用";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtPersonInsert;
		private System.Windows.Forms.TextBox txtCarInsert;
		private System.Windows.Forms.Button btnCal;
		private System.Windows.Forms.TextBox txtResult;
		private System.Windows.Forms.Label lblPersonNumber;
		private System.Windows.Forms.Label lblCarNumber;
	}
}

